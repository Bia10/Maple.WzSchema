namespace Maple.WzSchema;

/// <summary>
/// WZ node key strings for the Skill domain (String.wz / Skill.wz).
/// Covers archive roots, info props, level data, flags, and child node names.
/// </summary>
public static class SkillKeys
{
    // ── Archive roots ─────────────────────────────────────────────────────────
    public const string Root = "Skill";
    public const string SkillStringImg = "Skill.img";
    public const string JobStringImg = "Job";
    public static readonly string[] RootNodes = [Root, SkillStringImg];

    // ── String.wz per-skill props ─────────────────────────────────────────────

    public const string Hint = "h";
    public const string Job = "job";
    public const string JobName = "jobName";

    // ── Info node props ───────────────────────────────────────────────────────
    public const string MaxLevel = "maxLevel";
    public const string MasterLevel = "masterLevel";
    public const string ReqLevel = "reqLevel";
    public const string PsdSkill = "psdSkill";

    /// <summary>
    /// Nonzero indicates per-level stat lookups use the level-data system rather than inline
    /// formula evaluation.
    /// </summary>
    public static readonly WzProperty<int> SkillLvData = new("skillLVData", 0);

    // skillType and type are both used — pick with ResolveIntNullable fallback
    public const string SkillType = "skillType";
    public const string SkillTypeAlt = "type";

    // Element code strings. WZ stores a single character: F/I/L/S/H/D/U/"0".
    // AttackElemAttr on the model is derived from this string value.
    public const string ElemAttr = "elemAttr";
    public const string Element = "element";

    public const string Weapon = "weapon";
    public const string SubWeapon = "subWeapon";
    public const string PrepareAction = "prepareAction";

    /// <summary>
    /// WZ sub-node name at skill root. Contains the prepare action name and its <c>time</c> sub-key.
    /// Do not read it as a flat info key.
    /// </summary>
    public const string PrepareNode = "prepare";

    /// <summary>WZ key <c>"time"</c> within the <c>prepare/</c> sub-node.</summary>
    public const string PrepareTimeKey = "time";

    /// <summary>
    /// WZ sub-node name at skill root. Contains the projectile timing data, including <c>delay</c>.
    /// Do not read it as a flat info key.
    /// </summary>
    public const string BallNode = "ball";

    /// <summary>Default master level key. Note the truncated spelling: <c>defaultMasterLev</c>.</summary>
    public const string DefaultMasterLevel = "defaultMasterLev";

    /// <summary>WZ key for the referenced mob template code.</summary>
    public const string MobCode = "mob";

    /// <summary>Frame delay key. Default is <c>-1</c>.</summary>
    public const string DelayFrame = "delay";

    /// <summary>Frame hold key. Default is <c>-1</c>.</summary>
    public const string HoldFrame = "hold";
    public const string Speed = "speed";
    public const string ItemConsume = "itemConsume";
    public const string ItemConsumeCount = "itemConsumeCount";
    public const string MoneyCon = "moneyCon";
    public const string HpCon = "hpCon";
    public const string MpCon = "mpCon";

    // ── Boolean presence flags ────────────────────────────────────────────────
    // Psd and Ball are used as child-node NAME checks (container nodes with no int value),
    // so they remain const string — WzPresenceFlag.Resolve would return false for container nodes.
    public const string Psd = "psd";
    public const string Ball = "ball";
    public static readonly WzPresenceFlag Invisible = new("invisible");
    public static readonly WzPresenceFlag UpButtonDisabled = new("upButtonDisabled");
    public static readonly WzPresenceFlag CombatOrders = new("combatOrders");
    public static readonly WzPresenceFlag TimeLimited = new("timeLimited");
    public static readonly WzPresenceFlag Hyper = new("hyper");
    public static readonly WzPresenceFlag PvpDisable = new("pvpDisable");
    public static readonly WzPresenceFlag KeydownEnd = new("keydownEnd");
    public static readonly WzPresenceFlag Summon = new("summon");
    public static readonly WzPresenceFlag NotRemoved = new("notRemoved");
    public static readonly WzPresenceFlag ContinuousEffect = new("continuousEffect");

    // ── Level data child nodes ────────────────────────────────────────────────
    // Four variants appear across different WZ versions — use GetChildNode with all four.
    public const string LevelNode = "level";
    public const string LevelNodeAlt = "Level";
    public const string LevelDataNode = "levelData";
    public const string LevelDataNodeAlt = "LevelData";

    /// <summary>Short alias for <see cref="LevelNode"/> (client loader compatibility).</summary>
    public const string Level = LevelNode;

    // ── Common formula node ───────────────────────────────────────────────
    /// <summary>
    /// WZ sub-node containing formula strings evaluated per level (for example <c>"x*5+100"</c>).
    /// Each child name matches a per-level stat field.
    /// </summary>
    public const string CommonNode = "common";

    /// <summary>Short alias for <see cref="CommonNode"/> (client loader compatibility).</summary>
    public const string Common = CommonNode;

    // ── Action child nodes ────────────────────────────────────────────────
    public const string ActionNode = "action";

    /// <summary>
    /// WZ node name for the final-attack dispatch table under skill/{id}/finalAttack/.
    /// Note: the C++ struct field is named <c>aFinalAttack</c>, but the WZ node is <c>finalAttack</c>.
    /// </summary>
    public const string FinalAttackNode = "finalAttack";
    public const string SkillListNode = "skillList";

    /// <summary>
    /// Intermediate grouping node inside a job .img (e.g. Skill.wz/9100.img/skill/{skillId}/).
    /// Used by guild skill and some job skill layouts to group skills under a "skill" sub-node.
    /// </summary>
    public const string SkillGroupNode = "skill";
    public const string SkillGroupNodeAlt = "Skill";
    public static readonly string[] SkillGroupNodes = [SkillGroupNode, SkillGroupNodeAlt];

    /// <summary>Short alias for <see cref="SkillGroupNode"/> (client loader compatibility).</summary>
    public const string SkillNode = SkillGroupNode;

    // ── Requirement child nodes ───────────────────────────────────────────────
    public const string ReqNode = "req";
    public const string ReqSkillNode = "reqSkill";

    // Req entry child keys
    public static class ReqEntry
    {
        public const string Id = "id";
        public const string Level = "level";
    }

    // ── Passive stat offset sub-nodes ────────────────────────────────────────
    public static class AdditionPsd
    {
        public const string Cr = "cr";
        public const string CdMin = "cdMin";
        public const string Ar = "ar";
        public const string DipR = "dipR";
        public const string PDamR = "pDamR";
        public const string MDamR = "mDamR";
        public const string ImpR = "impR";
    }

    // ── Animation sub-nodes ─────────────────────────────────────────────────
    public static class Animation
    {
        public const string Effect = "effect";
        public const string ScreenEffect = "screen";
        public const string Affected = "affected";
        public const string Affected0 = "affected0";
        public const string SpecialAffected = "specialAffected";
        public const string Prepare = "prepare";
        public const string KeyDown = "keydown";
        public const string KeyDownEnd = "keydownend";
        public const string Hit = "hit";
        public const string Ball = "ball";
        public const string FlipBall = "flipBall";
        public const string Mob = "mob";
        public const string Tile = "tile";
        public const string Afterimage = "afterimage";
        public const string Special = "special";
        public const string Summoned = "summoned";
        public const string Finish = "finish";
    }

    public static readonly string[] IconNodeCandidates =
    [
        CommonKeys.Icon,
        CommonKeys.IconMouseOver,
        CommonKeys.IconDisabled,
        CommonKeys.IconRaw,
        CommonKeys.IconDisabledRaw,
    ];

    // ── Icon nested class (client loader compatibility) ───────────────────────
    /// <summary>Icon canvas variants within a skill info node.</summary>
    public static class Icon
    {
        public const string Standard = "icon";
        public const string MouseOver = "iconMouseOver";
        public const string Disabled = "iconDisabled";
    }

    // ── Formula field names ──────────────────────────────────────────────────
    /// <summary>
    /// Field names inside <c>common/</c> (formula strings) and <c>level/{N}/</c> (evaluated values).
    /// </summary>
    public static class Formula
    {
        // Resource costs
        public const string HpCon = "hpCon";
        public const string MpCon = "mpCon";
        public const string MoneyCon = "moneyCon";
        public const string ItemCon = "itemCon";
        public const string ItemConNo = "itemConNo";

        // Damage
        public const string Damage = "damage";
        public const string FixDamage = "fixdamage";

        // Duration / probability
        public const string Time = "time";
        public const string SubTime = "subTime";
        public const string Prop = "prop";
        public const string SubProp = "subProp";

        // Attack parameters
        public const string AttackCount = "attackCount";
        public const string BulletCount = "bulletCount";
        public const string BulletConsume = "bulletConsume";
        public const string Mastery = "mastery";
        public const string MobCount = "mobCount";

        // Combat stats
        public const string Hp = "hp";
        public const string Mp = "mp";
        public const string Pad = "pad";
        public const string Pdd = "pdd";
        public const string Mad = "mad";
        public const string Mdd = "mdd";
        public const string Acc = "acc";
        public const string Eva = "eva";
        public const string Speed = "speed";
        public const string Jump = "jump";

        // Generic parameters
        public const string X = "x";
        public const string Y = "y";
        public const string Z = "z";

        // Range / cooldown
        public const string Range = "range";
        public const string Cooltime = "cooltime";

        // DoT
        public const string Dot = "dot";
        public const string DotInterval = "dotInterval";
        public const string DotTime = "dotTime";

        // Affected area rectangle
        public const string LtX = "lt/x";
        public const string LtY = "lt/y";
        public const string RbX = "rb/x";
        public const string RbY = "rb/y";
    }
}
