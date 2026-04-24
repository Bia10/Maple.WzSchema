namespace Maple.WzSchema;

/// <summary>
/// Describes a typed WZ node property: its key string, CLR type, and default value.
/// Instances are static readonly singletons defined in domain Keys classes.
/// </summary>
/// <remarks>
/// <para><strong>Two resolution APIs — pick one per consumer:</strong></para>
/// <list type="bullet">
///   <item>
///     <term>Typed (admin panel / data-layer consumers)</term>
///     <description>
///       Use <see cref="WzPropertyExtensions"/> extension methods:
///       <c>node.Resolve(MobKeys.Info.Level)</c> returns <c>int</c> and applies
///       the descriptor's <see cref="Default"/> when the node is absent.
///     </description>
///   </item>
///   <item>
///     <term>Nullable (client / Duey DataExtensions consumers)</term>
///     <description>
///       Duey's own <c>DataExtensions.ResolveInt(string path)</c> accepts any
///       <see cref="WzProperty{T}"/> via its implicit <c>string</c> conversion,
///       but returns <c>int?</c> — the caller must supply the fallback inline
///       (<c>node.ResolveInt(MobKeys.Info.Level) ?? 1</c>).
///       The descriptor's <see cref="Default"/> is <em>not</em> applied in this path.
///     </description>
///   </item>
/// </list>
/// <para>
/// Keys classes in this package mix <see cref="WzProperty{T}"/> descriptors (for value-bearing
/// properties with known defaults) and plain <c>const string</c> (for navigation waypoints
/// and structural node names that carry no scalar default). Both forms work with both APIs.
/// </para>
/// </remarks>
public readonly record struct WzProperty<T>(string Key, T Default)
{
    /// <summary>Implicit conversion to key string — allows passing a descriptor wherever a raw key string is accepted.</summary>
    public static implicit operator string(WzProperty<T> prop) => prop.Key;

    public override string ToString() => $"{Key} ({typeof(T).Name}, default={Default})";
}
