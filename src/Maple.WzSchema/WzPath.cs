using Maple.StrongId;

namespace Maple.WzSchema;

/// <summary>
/// Static methods that produce WZ path segments. Eliminates ad-hoc
/// string formatting like $"{mobId:D7}.img" scattered across loaders.
/// </summary>
public static class WzPath
{
    /// <summary>Returns the WZ image filename for the given mob template (e.g. <c>"0100100.img"</c>).</summary>
    public static string MobImg(MobTemplateId mobId) => $"{mobId.Value:D7}.img";

    /// <summary>Returns the WZ image filename for the given NPC template (e.g. <c>"9201000.img"</c>).</summary>
    public static string NpcImg(NpcTemplateId npcId) => $"{npcId.Value:D7}.img";

    /// <summary>Returns the WZ image filename for the given item template (e.g. <c>"01002000.img"</c>).</summary>
    public static string ItemImg(ItemTemplateId id) => $"{id.Value:D8}.img";

    /// <summary>Returns the WZ image filename for the given job's skill archive (e.g. <c>"100.img"</c>).</summary>
    public static string SkillJobImg(JobId jobId) => $"{jobId.Value}.img";

    /// <summary>Returns the WZ group folder name for the given map (e.g. <c>"Map0"</c>, <c>"Map1"</c>).</summary>
    public static string MapGroup(FieldTemplateId mapId) => mapId.WzGroupName;

    /// <summary>Returns the WZ image filename for the given map (e.g. <c>"000000000.img"</c>).</summary>
    public static string MapImg(FieldTemplateId mapId) => $"{mapId.Value:D9}.img";

    /// <summary>Returns the WZ image filename for the given reactor template (e.g. <c>"9201000.img"</c>).</summary>
    public static string ReactorImg(ReactorTemplateId reactorId) => $"{reactorId.Value:D7}.img";
}
