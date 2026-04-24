namespace Maple.WzSchema;

/// <summary>
/// WZ property descriptors for Skill.wz/MobSkill.img mob skill level data.
/// Nested classes mirror the WZ node hierarchy:
/// MobSkill.img/{skillId}/level/{level}/
/// </summary>
public static class MobSkillKeys
{
    // Image name within Skill.wz
    public const string Img = "MobSkill.img";

    // Sub-node names for navigation
    public const string LevelNode = "level";

    /// <summary>
    /// Properties under MobSkill.img/{skillId}/level/{levelIndex}/.
    /// Corresponds to MOBSKILLLEVELDATA in game_types.h.
    /// </summary>
    public static class Level
    {
        // ── Activation condition ──────────────────────────────────
        /// <summary>
        /// HP% threshold — skill activates when mob HP ≤ this value.
        /// WZ key confirmed as <c>"hp"</c> (PDB SP 0x7D2, C++ field <c>nHPBelow</c>).
        /// Earlier references incorrectly used <c>"hpBelow"</c>.
        /// </summary>
        public static readonly WzProperty<int> HpBelow = new("hp", WzDefaults.MobSkillHpBelowDefault);

        // ── Cost / timing ─────────────────────────────────────────
        public static readonly WzProperty<int> ConMP = new("conMP", 0);
        public static readonly WzProperty<int> Interval = new("interval", 0);

        /// <summary>
        /// Effect duration in ms (WZ value in seconds × 1000 by loader).
        /// WZ key confirmed as <c>"time"</c> (PDB SP 0x963, C++ field <c>tDuration</c>).
        /// Earlier references incorrectly used <c>"duration"</c>.
        /// </summary>
        public static readonly WzProperty<int> Duration = new("time", 0);

        // ── Targeting ─────────────────────────────────────────────
        public static readonly WzProperty<int> Prop = new("prop", 100);
        public static readonly WzProperty<int> X = new("x", 0);
        public static readonly WzProperty<int> Y = new("y", 0);

        /// <summary>
        /// Max targets; −1 = unlimited (schema-confirmed default).
        /// </summary>
        public static readonly WzProperty<int> Count = new("count", WzDefaults.MobSkillUnlimitedTargets);

        /// <summary>
        /// Random target selection flag.
        /// WZ key confirmed as <c>"randomtarget"</c> (PDB literal <c>aRandomtarget</c>,
        /// <c>game_pseudocode.c:658517</c>). Earlier references incorrectly used <c>"random"</c>.
        /// </summary>
        public static readonly WzProperty<int> Random = new("randomtarget", 0);
        public static readonly WzProperty<int> Dir = new("dir", 0);

        // ── Effect / attribute ────────────────────────────────────
        public static readonly WzProperty<int> ElemAttr = new("elemAttr", 0);

        /// <summary>
        /// Integer effect type code. WZ key confirmed as <c>"nEffect"</c> (SP 0xB1E,
        /// <c>CSkillInfo::LoadMobSkillLevelData</c>). C++ field <c>nEffect</c>.
        /// </summary>
        public static readonly WzProperty<int> NEffect = new("nEffect", 0);
        public static readonly WzProperty<int> Limit = new("limit", 0);

        // ── Area of effect (vector nodes lt / rb) ─────────────────
        public const string Lt = "lt";
        public const string Rb = "rb";

        // ── UOL references (animation nodes) ─────────────────────
        public const string Effect = "effect";
        public const string Hit = "hit";
        public const string Mob = "mob";
        public const string Affected = "affected";
        public const string Tile = "tile";

        // ── Summon list ───────────────────────────────────────────
        /// <summary>
        /// Integer-indexed child node containing mob template IDs to summon.
        /// E.g. summon/0 = 100100, summon/1 = 100101
        /// </summary>
        public const string Summon = "summon";
    }
}
