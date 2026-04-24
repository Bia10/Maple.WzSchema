using System.Collections.Concurrent;
using Duey.Abstractions;
using Microsoft.Extensions.Logging;

namespace Maple.WzSchema;

/// <summary>
/// Static helpers for navigating Duey IDataNode trees. Shared by all sprite services.
/// </summary>
public static class WzNodeNavigator
{
    private static readonly int s_imgSuffixLength = CommonKeys.ImgSuffix.Length;

    /// <summary>
    /// Checks if a node name matches an ID, with or without a ".img" suffix.
    /// Eliminates string concatenation (id + ".img") on hot paths.
    /// </summary>
    public static bool MatchesNodeName(ReadOnlySpan<char> nodeName, ReadOnlySpan<char> id) =>
        nodeName.Equals(id, StringComparison.OrdinalIgnoreCase)
        || (
            nodeName.Length == id.Length + s_imgSuffixLength
            && nodeName.EndsWith(CommonKeys.ImgSuffix, StringComparison.OrdinalIgnoreCase)
            && nodeName[..^s_imgSuffixLength].Equals(id, StringComparison.OrdinalIgnoreCase)
        );

    /// <summary>
    /// Strips the <c>.img</c> suffix from <paramref name="nodeName"/> if present; otherwise returns the original string.
    /// </summary>
    public static string TrimImgSuffix(string nodeName) =>
        nodeName.EndsWith(CommonKeys.ImgSuffix, StringComparison.OrdinalIgnoreCase)
            ? nodeName[..^s_imgSuffixLength]
            : nodeName;

    /// <summary>
    /// Finds a child node matching the given ID (with or without ".img" suffix).
    /// Avoids allocating id + ".img" strings.
    /// </summary>
    public static IDataNode? FindChildByIds(IDataNode root, string id)
    {
        foreach (var child in root.Children)
        {
            if (MatchesNodeName(child.Name, id))
                return child;
        }
        return null;
    }

    /// <summary>
    /// Finds a child node matching any of the given IDs (with or without ".img" suffix).
    /// Avoids allocating id + ".img" strings.
    /// </summary>
    public static IDataNode? FindChildByIds(IDataNode root, ReadOnlySpan<string> ids)
    {
        foreach (var child in root.Children)
        {
            ReadOnlySpan<char> name = child.Name;
            foreach (var id in ids)
            {
                if (MatchesNodeName(name, id))
                    return child;
            }
        }
        return null;
    }

    // Overloads avoid params array allocation and lambda closure allocation on hot paths.
    // All use explicit foreach (not LINQ) to match the params ReadOnlySpan<string> overload.

    /// <summary>
    /// Returns the first child of <paramref name="root"/> whose name matches <paramref name="name"/> (case-insensitive).
    /// </summary>
    public static IDataNode? GetChild(IDataNode root, string name)
    {
        foreach (var child in root.Children)
        {
            if (child.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                return child;
        }
        return null;
    }

    /// <summary>
    /// Returns the first child of <paramref name="root"/> whose name matches either
    /// <paramref name="name1"/> or <paramref name="name2"/> (case-insensitive OR match).
    /// Use this to resolve WZ nodes that may appear under alternative spellings.
    /// </summary>
    public static IDataNode? GetChild(IDataNode root, string name1, string name2)
    {
        foreach (var child in root.Children)
        {
            if (
                child.Name.Equals(name1, StringComparison.OrdinalIgnoreCase)
                || child.Name.Equals(name2, StringComparison.OrdinalIgnoreCase)
            )
                return child;
        }
        return null;
    }

    /// <summary>
    /// Returns the first child of <paramref name="root"/> whose name matches any of
    /// <paramref name="name1"/>, <paramref name="name2"/>, or <paramref name="name3"/> (case-insensitive OR match).
    /// Use this to resolve WZ nodes that may appear under alternative spellings.
    /// </summary>
    public static IDataNode? GetChild(IDataNode root, string name1, string name2, string name3)
    {
        foreach (var child in root.Children)
        {
            if (
                child.Name.Equals(name1, StringComparison.OrdinalIgnoreCase)
                || child.Name.Equals(name2, StringComparison.OrdinalIgnoreCase)
                || child.Name.Equals(name3, StringComparison.OrdinalIgnoreCase)
            )
                return child;
        }
        return null;
    }

    /// <summary>
    /// Returns the first child of <paramref name="root"/> whose name matches any of the given
    /// <paramref name="names"/> (case-insensitive OR match). Use this for dynamic alternative-name
    /// lookups; prefer the fixed-arity overloads on hot paths to avoid span allocation.
    /// </summary>
    public static IDataNode? GetChild(IDataNode root, params ReadOnlySpan<string> names)
    {
        foreach (var child in root.Children)
        {
            foreach (var name in names)
            {
                if (child.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                    return child;
            }
        }
        return null;
    }

    /// <summary>
    /// Returns the child of <paramref name="package"/> named <paramref name="childName"/>,
    /// or <paramref name="package"/> itself when no matching child is found.
    /// </summary>
    /// <remarks>
    /// This method never returns <see langword="null"/>; callers must not assume the result
    /// is the requested child — it may be the original root package when the child is absent.
    /// </remarks>
    public static IDataNode? GetWzRoot(IDataNode? package, string childName)
    {
        if (package is null)
            return null;
        return FindChildByIds(package, childName) ?? package;
    }

    /// <summary>
    /// Enumerates children of a node defensively, collecting as many as possible before
    /// any WZ string block error aborts the enumerator.
    /// </summary>
    public static IReadOnlyList<IDataNode> SafeEnumerateChildren(IDataNode node, ILogger logger) =>
        SafeEnumerateChildrenCounted(node, logger).Nodes;

    /// <summary>
    /// Like <see cref="SafeEnumerateChildren"/> but also signals whether enumeration was
    /// aborted early due to a WZ error (i.e. the result may be incomplete).
    /// Callers that care about completeness should log a warning when <c>Aborted</c> is true.
    /// </summary>
    public static (IReadOnlyList<IDataNode> Nodes, bool Aborted) SafeEnumerateChildrenCounted(
        IDataNode node,
        ILogger logger
    )
    {
        var result = new List<IDataNode>();
        IEnumerator<IDataNode>? enumerator;
        try
        {
            enumerator = node.Children.GetEnumerator();
        }
        catch (Exception ex)
        {
            logger.LogDebug(ex, "Cannot enumerate children of node '{NodeName}'", node.Name);
            return (result, true);
        }

        try
        {
            while (true)
            {
                bool moved;
                try
                {
                    moved = enumerator.MoveNext();
                }
                catch (Exception ex)
                {
                    logger.LogDebug(
                        ex,
                        "Error mid-enumeration of '{NodeName}', collected {Count} partial children",
                        node.Name,
                        result.Count
                    );
                    return (result, true);
                }
                if (!moved)
                    break;
                result.Add(enumerator.Current);
            }
        }
        finally
        {
            enumerator.Dispose();
        }

        return (result, false);
    }

    /// <summary>
    /// Parses the numeric map ID from a node name, stripping any trailing <c>.img</c> suffix first.
    /// Returns <see langword="false"/> when the name (after stripping) is not a valid integer.
    /// </summary>
    public static bool TryGetMapId(string name, out int id)
    {
        ReadOnlySpan<char> span = name.AsSpan();
        if (span.EndsWith(CommonKeys.ImgSuffix, StringComparison.OrdinalIgnoreCase))
            span = span[..^s_imgSuffixLength];
        return int.TryParse(span, System.Globalization.NumberStyles.Integer, null, out id);
    }

    /// <summary>
    /// Searches <paramref name="categoryNode"/>'s children for an item node matching <paramref name="id"/>,
    /// trying both the bare integer and the zero-padded D8 format (with or without <c>.img</c> suffix).
    /// </summary>
    public static IDataNode? FindItemNode(IDataNode categoryNode, int id)
    {
        Span<char> buf1 = stackalloc char[12];
        id.TryFormat(buf1, out int len1);
        Span<char> buf2 = stackalloc char[12];
        id.TryFormat(buf2, out int len2, "D8");
        foreach (var child in categoryNode.Children)
        {
            ReadOnlySpan<char> name = child.Name;
            if (MatchesNodeName(name, buf1[..len1]) || MatchesNodeName(name, buf2[..len2]))
                return child;
        }
        return null;
    }

    /// <summary>
    /// Looks up an item node by <paramref name="id"/> using a caller-owned <paramref name="cache"/>,
    /// building the category index on first access via <see cref="BuildItemLookup"/>.
    /// Callers are responsible for supplying (and sharing) the <paramref name="cache"/> dictionary across calls
    /// so that each category is indexed only once.
    /// </summary>
    public static IDataNode? GetItemNodeCached(
        ConcurrentDictionary<string, Lazy<Dictionary<string, IDataNode>>> cache,
        IDataNode categoryNode,
        string categoryName,
        int id
    )
    {
        var map = cache
            .GetOrAdd(
                categoryName,
                _ => new Lazy<Dictionary<string, IDataNode>>(
                    () => BuildItemLookupDictionary(categoryNode),
                    LazyThreadSafetyMode.ExecutionAndPublication
                )
            )
            .Value;

        var altLookup = map.GetAlternateLookup<ReadOnlySpan<char>>();
        Span<char> buf1 = stackalloc char[12];
        id.TryFormat(buf1, out int len1);
        if (altLookup.TryGetValue(buf1[..len1], out var node))
            return node;
        Span<char> buf2 = stackalloc char[12];
        id.TryFormat(buf2, out int len2, "D8");
        if (altLookup.TryGetValue(buf2[..len2], out node))
            return node;
        return null;
    }

    /// <summary>
    /// Builds a normalized lookup stripping ".img" suffixes from keys,
    /// so callers never need to concatenate id + ".img" for lookups.
    /// </summary>
    public static IReadOnlyDictionary<string, IDataNode> BuildItemLookup(IDataNode categoryNode) =>
        BuildItemLookupDictionary(categoryNode);

    private static Dictionary<string, IDataNode> BuildItemLookupDictionary(IDataNode categoryNode)
    {
        var map = new Dictionary<string, IDataNode>(StringComparer.OrdinalIgnoreCase);
        foreach (var child in categoryNode.Children)
        {
            string key = TrimImgSuffix(child.Name);
            map.TryAdd(key, child);
        }
        return map;
    }

    /// <summary>
    /// Root namespace of the NX provider library. Used by <see cref="IsNxNode"/> to
    /// detect when a node originates from NX rather than WZ data.
    /// If the Duey.Provider.NX package is renamed, update this constant.
    /// </summary>
    internal const string NxProviderNamespace = "Duey.Provider.NX";

    private static readonly ConcurrentDictionary<Type, bool> s_nxNodeCache = new();

    /// <summary>
    /// Returns true when <paramref name="node"/> originates from the NX provider
    /// (see <see cref="NxProviderNamespace"/>). Used to skip NX nodes in lookup paths
    /// that only support WZ data.
    /// </summary>
    public static bool IsNxNode(IDataNode node) =>
        s_nxNodeCache.GetOrAdd(
            node.GetType(),
            static t => t.Namespace?.StartsWith(NxProviderNamespace, StringComparison.Ordinal) ?? false
        );

    /// <summary>
    /// Searches <paramref name="npcRoot"/>'s children for the NPC image node matching <paramref name="npcId"/>,
    /// trying both the bare integer and the zero-padded D7 format (with or without <c>.img</c> suffix).
    /// </summary>
    public static IDataNode? FindNpcImgNode(IDataNode npcRoot, int npcId) => FindImgNodeByD7Id(npcRoot, npcId);

    /// <summary>
    /// Searches <paramref name="mobRoot"/>'s children for the mob image node matching <paramref name="mobId"/>,
    /// trying both the bare integer and the zero-padded D7 format (with or without <c>.img</c> suffix).
    /// </summary>
    public static IDataNode? FindMobImgNode(IDataNode mobRoot, int mobId) => FindImgNodeByD7Id(mobRoot, mobId);

    private static IDataNode? FindImgNodeByD7Id(IDataNode root, int id)
    {
        Span<char> buf1 = stackalloc char[12];
        id.TryFormat(buf1, out int len1);
        Span<char> buf2 = stackalloc char[12];
        id.TryFormat(buf2, out int len2, "D7");
        foreach (var child in root.Children)
        {
            ReadOnlySpan<char> name = child.Name;
            if (MatchesNodeName(name, buf1[..len1]) || MatchesNodeName(name, buf2[..len2]))
                return child;
        }
        return null;
    }

    /// <summary>
    /// Follows info/link chains up to 10 levels deep, returning the terminal node.
    /// Used by both sprite loading and info parsing so that linked NPCs resolve correctly.
    /// </summary>
    public static IDataNode ResolveNpcLink(IDataNode npcRoot, IDataNode npcNode)
    {
        var current = npcNode;
        for (int depth = 0; depth < 10; depth++)
        {
            var infoNode = GetChild(current, CommonKeys.Info);
            if (infoNode is null)
                break;

            var linkNode = GetChild(infoNode, CommonKeys.Link);
            if (linkNode is null)
                break;

            int? linkVal = ResolveLinkValue(linkNode);
            if (!linkVal.HasValue)
                break;

            var linkedNode = FindNpcImgNode(npcRoot, linkVal.Value);
            if (linkedNode is null)
                break;

            current = linkedNode;
        }

        return current;
    }

    /// <summary>
    /// Follows info/link chains for a mob node up to 10 levels deep.
    /// Searches <paramref name="allMobRoots"/> when a linked mob is not found in <paramref name="primaryRoot"/>.
    /// Used by both sprite loading and info parsing.
    /// </summary>
    public static IDataNode ResolveMobLink(
        IDataNode primaryRoot,
        IDataNode mobNode,
        IReadOnlyList<IDataNode> allMobRoots
    )
    {
        var current = mobNode;
        for (int depth = 0; depth < 10; depth++)
        {
            var infoNode = GetChild(current, CommonKeys.Info);
            if (infoNode is null)
                break;

            var linkNode = GetChild(infoNode, CommonKeys.Link);
            if (linkNode is null)
                break;

            int? linkVal = ResolveLinkValue(linkNode);
            if (!linkVal.HasValue)
                break;

            IDataNode? resolved = FindMobImgNode(primaryRoot, linkVal.Value);
            if (resolved is null)
            {
                foreach (var root in allMobRoots)
                {
                    if (ReferenceEquals(root, primaryRoot))
                        continue;
                    resolved = FindMobImgNode(root, linkVal.Value);
                    if (resolved is not null)
                        break;
                }
            }

            if (resolved is null)
                break;
            current = resolved;
        }

        return current;
    }

    // ── Pure node-value helpers (no logger needed) ────────────────────────

    /// <summary>
    /// Safely reads a string value from <paramref name="node"/>, returning <see langword="null"/>
    /// on any exception (e.g. corrupt WZ data where the node is not a string type).
    /// </summary>
    public static string? TryResolveString(IDataNode? node)
    {
        if (node is null)
            return null;
        try
        {
            return node.ResolveString();
        }
        catch (Exception ex) when (ex is not OutOfMemoryException)
        {
            return null;
        } // Expected: corrupt WZ data — node may not be a string type
    }

    /// <summary>
    /// Reads a numeric link value from <paramref name="linkNode"/>, accepting both
    /// integer-typed nodes and string-typed nodes whose content parses as an integer.
    /// Returns <see langword="null"/> when neither form is present or parseable.
    /// </summary>
    public static int? ResolveLinkValue(IDataNode linkNode)
    {
        int? linkVal = linkNode.ResolveInt();
        if (linkVal.HasValue)
            return linkVal;

        var linkStr = linkNode.ResolveString();
        if (
            linkStr is not null
            && int.TryParse(
                linkStr,
                System.Globalization.NumberStyles.Integer,
                System.Globalization.CultureInfo.InvariantCulture,
                out int parsed
            )
        )
            return parsed;

        return null;
    }

    /// <summary>
    /// Reads a 2D point from <paramref name="node"/>: first attempts a native vector resolve,
    /// then falls back to reading child nodes named <c>"x"</c> and <c>"y"</c>.
    /// Returns <see langword="false"/> when neither form yields a complete point.
    /// </summary>
    public static bool TryResolveVector(IDataNode node, out int x, out int y)
    {
        x = 0;
        y = 0;

        var vector = node.ResolveVector();
        if (vector.HasValue)
        {
            x = vector.Value.Item1;
            y = vector.Value.Item2;
            return true;
        }

        var xNode = GetChild(node, CommonKeys.X);
        var yNode = GetChild(node, CommonKeys.Y);
        var rx = xNode?.ResolveInt();
        var ry = yNode?.ResolveInt();
        if (rx.HasValue && ry.HasValue)
        {
            x = rx.Value;
            y = ry.Value;
            return true;
        }

        return false;
    }
}
