using Duey.Abstractions;

namespace Maple.WzSchema;

/// <summary>
/// Instance-based abstraction over <see cref="WzNodeNavigator"/> static helpers.
/// Inject this interface into services that need WZ node traversal so they can be
/// unit-tested without live WZ archives.
/// </summary>
public interface IWzNodeNavigator
{
    // ── Child traversal ───────────────────────────────────────────────────────
    IDataNode? GetChild(IDataNode root, string name);
    IDataNode? GetChild(IDataNode root, string name1, string name2);
    IDataNode? GetChild(IDataNode root, string name1, string name2, string name3);
    IDataNode? FindChildByIds(IDataNode root, string id);
    IDataNode? GetWzRoot(IDataNode? package, string childName);

    // ── Domain-specific item/NPC/mob node finders ─────────────────────────────
    IDataNode? FindItemNode(IDataNode categoryNode, int id);
    IDataNode? FindNpcImgNode(IDataNode npcRoot, int npcId);
    IDataNode? FindMobImgNode(IDataNode mobRoot, int mobId);
    IReadOnlyDictionary<string, IDataNode> BuildItemLookup(IDataNode categoryNode);

    // ── Link resolution ───────────────────────────────────────────────────────
    IDataNode ResolveNpcLink(IDataNode npcRoot, IDataNode npcNode);
    IDataNode ResolveMobLink(IDataNode primaryRoot, IDataNode mobNode, IReadOnlyList<IDataNode> allMobRoots);

    // ── Utilities ─────────────────────────────────────────────────────────────
    bool TryGetMapId(string name, out int id);
    string TrimImgSuffix(string nodeName);
    bool IsNxNode(IDataNode node);

    // ── Fault-tolerant enumeration ────────────────────────────────────────────
    IReadOnlyList<IDataNode> SafeEnumerateChildren(IDataNode node);
    (IReadOnlyList<IDataNode> Nodes, bool Aborted) SafeEnumerateChildrenCounted(IDataNode node);
}
