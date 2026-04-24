namespace Maple.WzSchema;

/// <summary>
/// A WZ property that represents an integer boolean flag: node absent-or-zero = false, nonzero = true.
/// Semantically distinct from WzProperty&lt;int&gt; — the consumer wants bool, not int.
/// </summary>
/// <remarks>
/// This type covers WZ integer boolean fields (e.g., boss, undead) that store 0 or 1.
/// Resolved as: <c>GetChild(key)?.ResolveInt() != 0</c> — absent or zero both become false.
/// <para>
/// For pure presence checks where the node's mere existence means true (e.g., a container
/// node with no int value), use <c>GetChild(key) is not null</c> directly instead of this type.
/// </para>
/// </remarks>
public readonly record struct WzPresenceFlag(string Key)
{
    public static implicit operator string(WzPresenceFlag flag) => flag.Key;

    public override string ToString() => $"{Key} (bool)";
}
