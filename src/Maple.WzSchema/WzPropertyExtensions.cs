using Duey.Abstractions;

namespace Maple.WzSchema;

/// <summary>
/// Extension methods that resolve WZ properties using typed descriptors.
/// Bridges <see cref="WzProperty{T}"/> and <see cref="WzPresenceFlag"/>
/// with the existing <see cref="WzNodeNavigator"/> infrastructure.
/// </summary>
public static class WzPropertyExtensions
{
    // ── IDataNode direct resolution ──────────────────────────────────────

    /// <summary>Resolves an int property, returning the descriptor's default when absent.</summary>
    public static int Resolve(this IDataNode parent, WzProperty<int> prop) =>
        WzNodeNavigator.GetChild(parent, prop.Key)?.ResolveInt() ?? prop.Default;

    /// <summary>Resolves a string property, returning the descriptor's default when absent.</summary>
    public static string? Resolve(this IDataNode parent, WzProperty<string?> prop) =>
        WzNodeNavigator.TryResolveString(WzNodeNavigator.GetChild(parent, prop.Key)) ?? prop.Default;

    /// <summary>Resolves a float property, returning the descriptor's default when absent.</summary>
    public static float Resolve(this IDataNode parent, WzProperty<float> prop)
    {
        var node = WzNodeNavigator.GetChild(parent, prop.Key);
        if (node is null)
            return prop.Default;
        return (float)(node.ResolveDouble() ?? node.ResolveInt() ?? prop.Default);
    }

    /// <summary>Resolves a boolean presence flag (non-zero = true, absent = false).</summary>
    public static bool Resolve(this IDataNode parent, WzPresenceFlag flag) =>
        (WzNodeNavigator.GetChild(parent, flag.Key)?.ResolveInt() ?? 0) != 0;

    /// <summary>
    /// Returns the non-zero integer value or null.
    /// Treats zero the same as absent — use this for optional fields where 0 means "not set".
    /// For a true presence check (zero is a valid value), use <see cref="ResolveIfPresent(IDataNode,WzProperty{int})"/>.
    /// </summary>
    public static int? ResolveNonZero(this IDataNode parent, WzProperty<int> prop)
    {
        int val = parent.Resolve(prop);
        return val != 0 ? val : null;
    }

    /// <summary>
    /// Returns the non-zero float value or null.
    /// Treats zero the same as absent — use this for optional fields where 0.0 means "not set".
    /// For a true presence check (0.0 is a valid value), use <see cref="ResolveIfPresent(IDataNode,WzProperty{float})"/>.
    /// </summary>
    public static float? ResolveNonZero(this IDataNode parent, WzProperty<float> prop)
    {
        float val = parent.Resolve(prop);
        return val != 0f ? val : null;
    }

    /// <summary>
    /// Returns the value if the node is present in WZ, otherwise null.
    /// Correctly distinguishes "absent" from "present with value 0".
    /// Use this when 0 is a semantically meaningful value (e.g. Category 0 = generic mob).
    /// </summary>
    public static int? ResolveIfPresent(this IDataNode parent, WzProperty<int> prop)
    {
        var node = WzNodeNavigator.GetChild(parent, prop.Key);
        return node?.ResolveInt();
    }

    /// <summary>
    /// Returns the float value if the node is present in WZ, otherwise null.
    /// Correctly distinguishes "absent" from "present with value 0.0" (e.g. frictionless fs=0).
    /// </summary>
    public static float? ResolveIfPresent(this IDataNode parent, WzProperty<float> prop)
    {
        var node = WzNodeNavigator.GetChild(parent, prop.Key);
        if (node is null)
            return null;
        return (float?)(node.ResolveDouble() ?? node.ResolveInt());
    }

    // ── IDataNode short resolution ────────────────────────────────────────

    /// <summary>Resolves an int property as a clamped short, returning the descriptor's default when absent.</summary>
    public static short ResolveShort(this IDataNode parent, WzProperty<int> prop)
    {
        int? value = WzNodeNavigator.GetChild(parent, prop.Key)?.ResolveInt();
        if (!value.HasValue)
            return (short)Math.Clamp(prop.Default, short.MinValue, short.MaxValue);
        return (short)Math.Clamp(value.Value, short.MinValue, short.MaxValue);
    }

    // ── Dictionary-indexed resolution (O(1) via BuildChildIndex) ─────────

    /// <summary>Resolves an int property from a pre-built child index, returning the descriptor's default when absent.</summary>
    public static int Resolve(this IReadOnlyDictionary<string, IDataNode> idx, WzProperty<int> prop) =>
        idx.GetValueOrDefault(prop.Key)?.ResolveInt() ?? prop.Default;

    /// <summary>Resolves an int property as a clamped short from a pre-built child index.</summary>
    public static short ResolveShort(this IReadOnlyDictionary<string, IDataNode> idx, WzProperty<int> prop)
    {
        int? value = idx.GetValueOrDefault(prop.Key)?.ResolveInt();
        if (!value.HasValue)
            return (short)Math.Clamp(prop.Default, short.MinValue, short.MaxValue);
        return (short)Math.Clamp(value.Value, short.MinValue, short.MaxValue);
    }

    /// <summary>Resolves a boolean presence flag from a pre-built child index.</summary>
    public static bool Resolve(this IReadOnlyDictionary<string, IDataNode> idx, WzPresenceFlag flag) =>
        (idx.GetValueOrDefault(flag.Key)?.ResolveInt() ?? 0) != 0;

    /// <summary>Resolves a string property from a pre-built child index, returning the descriptor's default when absent.</summary>
    public static string? Resolve(this IReadOnlyDictionary<string, IDataNode> idx, WzProperty<string?> prop) =>
        WzNodeNavigator.TryResolveString(idx.GetValueOrDefault(prop.Key)) ?? prop.Default;

    /// <summary>Resolves a float property from a pre-built child index, returning the descriptor's default when absent.</summary>
    public static float Resolve(this IReadOnlyDictionary<string, IDataNode> idx, WzProperty<float> prop)
    {
        var node = idx.GetValueOrDefault(prop.Key);
        if (node is null)
            return prop.Default;
        return (float)(node.ResolveDouble() ?? node.ResolveInt() ?? prop.Default);
    }

    /// <summary>
    /// Returns the non-zero integer value or null from a pre-built child index.
    /// Treats zero the same as absent. Use <see cref="ResolveIfPresent(IReadOnlyDictionary{string,IDataNode},WzProperty{int})"/> when 0 is a valid value.
    /// </summary>
    public static int? ResolveNonZero(this IReadOnlyDictionary<string, IDataNode> idx, WzProperty<int> prop)
    {
        int val = idx.Resolve(prop);
        return val != 0 ? val : null;
    }

    /// <summary>
    /// Returns the non-zero float value or null from a pre-built child index.
    /// Treats zero the same as absent. Use <see cref="ResolveIfPresent(IReadOnlyDictionary{string,IDataNode},WzProperty{float})"/> when 0.0 is a valid value.
    /// </summary>
    public static float? ResolveNonZero(this IReadOnlyDictionary<string, IDataNode> idx, WzProperty<float> prop)
    {
        float val = idx.Resolve(prop);
        return val != 0f ? val : null;
    }

    /// <summary>
    /// Returns the integer value if the key is present in the index, otherwise null.
    /// Correctly distinguishes "absent" from "present with value 0".
    /// </summary>
    public static int? ResolveIfPresent(this IReadOnlyDictionary<string, IDataNode> idx, WzProperty<int> prop) =>
        idx.GetValueOrDefault(prop.Key)?.ResolveInt();

    /// <summary>
    /// Returns the float value if the key is present in the index, otherwise null.
    /// Correctly distinguishes "absent" from "present with value 0.0".
    /// </summary>
    public static float? ResolveIfPresent(this IReadOnlyDictionary<string, IDataNode> idx, WzProperty<float> prop)
    {
        var node = idx.GetValueOrDefault(prop.Key);
        if (node is null)
            return null;
        return (float?)(node.ResolveDouble() ?? node.ResolveInt());
    }
}
