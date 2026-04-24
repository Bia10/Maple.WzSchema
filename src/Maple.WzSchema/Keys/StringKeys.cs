namespace Maple.WzSchema;

/// <summary>
/// WZ node key strings for the String.wz central text-table archive.
/// Contains image node names for each domain section and common per-entry property names.
/// </summary>
public static class StringKeys
{
    // ── Archive root ──────────────────────────────────────────────────────────
    public const string Root = "String";

    // ── Image node names within String.wz ────────────────────────────────────
    // NB: Several of these are also declared in the respective domain key files
    // (e.g. ItemKeys.EqpImg, NpcKeys.RootImg). Both references are valid;
    // StringKeys is the canonical single-file view of the String.wz layout.
    public const string EqpImg = "Eqp.img";
    public const string ConsumeImg = "Consume.img";
    public const string InsImg = "Ins.img";
    public const string EtcImg = "Etc.img";
    public const string CashImg = "Cash.img";
    public const string PetImg = "Pet.img";
    public const string SpecialImg = "Special.img";
    public const string NpcImg = "Npc.img";
    public const string MobImg = "Mob.img";
    public const string MapImg = "Map.img";
    public const string SkillImg = "Skill.img";
    public const string JobImg = "Job.img";
    public const string MonsterBookImg = "Monster Book.img";
    public const string MonsterBookImgAlt = "MonsterBook";
    public const string StoryImg = "Story.img";
    public const string Story = "Story";
    public const string FamiliarImg = "Familiar.img";

    // ── Common per-entry properties (shared across image sections) ────────────

    public const string Detail = "detail";
    public const string Catch = "catch";
    public const string Autodesc = "autodesc";

    // ── NPC-specific string properties (String.wz/Npc.img/{npcId}/) ──────────
    public const string Func = "func";
    public const string D0 = "d0";
    public const string D1 = "d1";
    public const string Dialogue = "dialogue";

    // ── Skill-specific string property (skill hint, stored as "h") ────────────
    public const string SkillHint = "h";
}
