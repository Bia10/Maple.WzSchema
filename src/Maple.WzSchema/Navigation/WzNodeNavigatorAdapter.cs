using Duey.Abstractions;
using Microsoft.Extensions.Logging;

namespace Maple.WzSchema;

/// <summary>
/// Production implementation of <see cref="IWzNodeNavigator"/> that delegates to the
/// existing <see cref="WzNodeNavigator"/> static helpers.
/// Uses an injected <see cref="ILogger"/> for fault-tolerant enumeration log messages.
/// </summary>
public sealed class WzNodeNavigatorAdapter(ILogger<WzNodeNavigatorAdapter> logger) : IWzNodeNavigator
{
    // ── Child traversal ───────────────────────────────────────────────────────

    public IDataNode? GetChild(IDataNode root, string name) => WzNodeNavigator.GetChild(root, name);

    public IDataNode? GetChild(IDataNode root, string name1, string name2) =>
        WzNodeNavigator.GetChild(root, name1, name2);

    public IDataNode? GetChild(IDataNode root, string name1, string name2, string name3) =>
        WzNodeNavigator.GetChild(root, name1, name2, name3);

    public IDataNode? FindChildByIds(IDataNode root, string id) => WzNodeNavigator.FindChildByIds(root, id);

    public IDataNode? GetWzRoot(IDataNode? package, string childName) => WzNodeNavigator.GetWzRoot(package, childName);

    // ── Domain-specific node finders ─────────────────────────────────────────

    public IDataNode? FindItemNode(IDataNode categoryNode, int id) => WzNodeNavigator.FindItemNode(categoryNode, id);

    public IDataNode? FindNpcImgNode(IDataNode npcRoot, int npcId) => WzNodeNavigator.FindNpcImgNode(npcRoot, npcId);

    public IDataNode? FindMobImgNode(IDataNode mobRoot, int mobId) => WzNodeNavigator.FindMobImgNode(mobRoot, mobId);

    public IReadOnlyDictionary<string, IDataNode> BuildItemLookup(IDataNode categoryNode) =>
        WzNodeNavigator.BuildItemLookup(categoryNode);

    // ── Link resolution ─────────────────────────────────────────────────────

    public IDataNode ResolveNpcLink(IDataNode npcRoot, IDataNode npcNode) =>
        WzNodeNavigator.ResolveNpcLink(npcRoot, npcNode);

    public IDataNode ResolveMobLink(IDataNode primaryRoot, IDataNode mobNode, IReadOnlyList<IDataNode> allMobRoots) =>
        WzNodeNavigator.ResolveMobLink(primaryRoot, mobNode, allMobRoots);

    // ── Utilities ─────────────────────────────────────────────────────────────

    public bool TryGetMapId(string name, out int id) => WzNodeNavigator.TryGetMapId(name, out id);

    public string TrimImgSuffix(string nodeName) => WzNodeNavigator.TrimImgSuffix(nodeName);

    public bool IsNxNode(IDataNode node) => WzNodeNavigator.IsNxNode(node);

    // ── Fault-tolerant enumeration ────────────────────────────────────────────

    public IReadOnlyList<IDataNode> SafeEnumerateChildren(IDataNode node) =>
        WzNodeNavigator.SafeEnumerateChildren(node, logger);

    public (IReadOnlyList<IDataNode> Nodes, bool Aborted) SafeEnumerateChildrenCounted(IDataNode node) =>
        WzNodeNavigator.SafeEnumerateChildrenCounted(node, logger);
}
