namespace Maple.WzSchema;

/// <summary>
/// WZ property descriptors for Mob.wz/{id:D7}.img/ nodes.
/// Nested classes mirror the WZ node hierarchy.
/// </summary>
public static class MobKeys
{
    // Root node names for Mob archive navigation
    public const string Root = "Mob";
    public const string RootImg = "Mob.img";

    // Etc.wz node names for mob supplementary data
    public const string MobLocation = "MobLocation";
    public const string RewardItem = "RewardItem";

    // Sprite action fallback sequence
    public static readonly string[] ActionFallbacks =
    [
        "stand",
        "stand1",
        "stand2",
        "move",
        "move1",
        "move2",
        "fly",
        "hit1",
        "die1",
        "attack1",
        "chase",
        "regen",
    ];

    public const string ActionMove = "move";
    public const string ActionFly = "fly";
    public const string ActionJump = "jump";

    /// <summary>
    /// Standard mob animation action keys as a nested class.
    /// Mirrors the root-level <c>ActionXxx</c> constants for client loader compatibility.
    /// </summary>
    public static class Actions
    {
        public const string Stand = "stand";
        public const string Move = "move";
        public const string Attack1 = "attack1";
        public const string Attack2 = "attack2";
        public const string Hit1 = "hit1";
        public const string Hit2 = "hit2";
        public const string Die1 = "die1";
        public const string Die2 = "die2";
        public const string Jump = "jump";
        public const string Fly = "fly";
        public const string Regen = "regen";
        public const string Chase = "chase";
        public const string Skill0 = "skill0";
        public const string Skill1 = "skill1";
    }

    /// <summary>
    /// Top-level action node whose presence enables chase behavior.
    /// Not an <c>info/</c> key; do not read it with <c>WzPresenceFlag</c>.
    /// </summary>
    public const string ActionChase = "chase";

    /// <summary>
    /// Top-level action node whose presence enables the regen action.
    /// Not an <c>info/</c> key; do not read it with <c>WzPresenceFlag</c>.
    /// </summary>
    public const string ActionRegen = "regen";
    public const string SkillPrefix = "skill";

    /// <summary>Properties under Mob.wz/{id}.img/info/</summary>
    public static class Info
    {
        // ── Core Stats ────────────────────────────────────────────
        public static readonly WzProperty<int> Level = new("level", WzDefaults.MobDefaultLevel);
        public static readonly WzProperty<int> MaxHP = new("maxHP", 0);
        public static readonly WzProperty<int> MaxMP = new("maxMP", 0);
        public static readonly WzProperty<int> PADamage = new("PADamage", 0);
        public static readonly WzProperty<int> MADamage = new("MADamage", 0);
        public static readonly WzProperty<int> PDRate = new("PDRate", 0);
        public static readonly WzProperty<int> MDRate = new("MDRate", 0);
        public static readonly WzProperty<int> Acc = new("acc", 0);
        public static readonly WzProperty<int> Eva = new("eva", 0);
        public static readonly WzProperty<int> Exp = new("exp", 0);
        public static readonly WzProperty<int> Speed = new("speed", 0);
        public static readonly WzProperty<int> FlySpeed = new("flySpeed", 0);

        // ── Boolean Flags (all WzPresenceFlag: nonzero = true) ───
        public static readonly WzPresenceFlag Boss = new("boss");
        public static readonly WzPresenceFlag Undead = new("undead");
        public static readonly WzPresenceFlag BodyAttack = new("bodyAttack");
        public static readonly WzPresenceFlag FirstAttack = new("firstAttack");
        public static readonly WzPresenceFlag Invincible = new("invincible");
        public static readonly WzPresenceFlag NotAttack = new("notAttack");
        public static readonly WzPresenceFlag SelfDestruction = new("selfDestruction");
        public static readonly WzPresenceFlag FirstSelfDestruction = new("firstSelfDestruction");
        public static readonly WzPresenceFlag Disable = new("disable");
        public static readonly WzPresenceFlag NoFlip = new("noFlip");

        /// <summary>Nonzero means the mob can pick up drops.</summary>
        public static readonly WzPresenceFlag PickUpDrop = new("publicReward");
        public static readonly WzPresenceFlag HideHP = new("hideHP");
        public static readonly WzPresenceFlag HideName = new("hideName");
        public static readonly WzPresenceFlag HideLevel = new("hideLevel");
        public static readonly WzPresenceFlag AngerGauge = new("angerGauge");

        /// <summary>Nonzero hides the HP gauge.</summary>
        public static readonly WzPresenceFlag HPGaugeHide = new("HPgaugeHide");
        public static readonly WzPresenceFlag OnlyNormalAttack = new("onlyNormalAttack");
        public static readonly WzPresenceFlag CantPassByTeleport = new("cantPassByTeleport");
        public static readonly WzPresenceFlag CannotEvade = new("cannotEvade");
        public static readonly WzPresenceFlag UpperMostLayer = new("upperMostLayer");

        // ── Recovery / Fixed damage ──────────────────────────────
        public static readonly WzProperty<int> HPRecovery = new("hpRecovery", 0);
        public static readonly WzProperty<int> MPRecovery = new("mpRecovery", 0);
        public static readonly WzProperty<int> FixedDamage = new("fixedDamage", 0);

        // ── Metadata (nullable-int: non-zero = present) ──────────
        /// <summary>Overrides the Monster Book entry ID.</summary>
        public static readonly WzProperty<int> MonsterBook = new("mbookID", 0);
        public static readonly WzProperty<int> Category = new("category", 0);

        /// <summary>
        /// Nonzero marks the template as an escort-type mob.
        /// Move ability is derived from action-node presence at runtime.
        /// </summary>
        public static readonly WzProperty<int> Escort = new("escort", 0);
        public static readonly WzProperty<int> ChaseSpeed = new("chaseSpeed", 0);

        /// <summary>Knockback force. Default is <c>1</c>.</summary>
        public static readonly WzProperty<int> PushedDamage = new("pushed", 1);
        public static readonly WzProperty<int> Weapon = new("weapon", 0);

        /// <summary>
        /// Traction / friction coefficient.
        /// Typed as <c>float</c> because WZ stores floating-point values here.
        /// </summary>
        public static readonly WzProperty<float> Fs = new("fs", 0f);
        public static readonly WzProperty<int> HpTagColor = new("hpTagColor", 0);

        /// <summary>
        /// HP tag background ARGB color.
        /// Note the lowercase <c>c</c> in the WZ key.
        /// </summary>
        public static readonly WzProperty<int> HpTagBgColor = new("hpTagBgcolor", 0);
        public static readonly WzProperty<int> ChargeCount = new("chargeCount", 0);
        public static readonly WzProperty<int> DropItemPeriod = new("dropItemPeriod", 0);

        /// <summary>Ban behavior after the mob kills a player.</summary>
        public static readonly WzProperty<int> BanType = new("ban", 0);
        public static readonly WzProperty<int> HitCount = new("hitCount", 0);
        public static readonly WzProperty<int> DieCount = new("dieCount", 0);
        public static readonly WzProperty<int> EscortType = new("escortType", 0);
        public static readonly WzProperty<int> ChatBalloon = new("chatBalloon", 0);
        public static readonly WzProperty<int> Type = new("type", 0);

        // ── String properties ────────────────────────────────────
        public static readonly WzProperty<string?> ElemAttr = new("elemAttr", null);

        /// <summary>
        /// Species string stored in WZ (for example <c>"beast"</c> or <c>"dragon"</c>).
        /// Default is <c>"etc"</c>.
        /// </summary>
        public static readonly WzProperty<string?> Species = new("species", "etc");

        // ── Child node names (for list-valued children) ──────────
        public const string ElemBonus = "elemBonus";
        public const string Revive = "revive";

        public static readonly WzPresenceFlag NoRegen = new("noregen");
        public static readonly WzProperty<int> FixedBodyAttackDamR = new("fixedBodyAttackDamR", 0);

        /// <summary>Child node listing mob IDs that can damage this mob.</summary>
        public const string DamagedBySelectedMob = "damagedByMob";

        /// <summary>Child node listing skill IDs that can damage this mob.</summary>
        public const string DamagedBySelectedSkill = "damagedBySkill";
    }

    /// <summary>Properties under Mob.wz/{id}.img/attack{N}/info/</summary>
    public static class Attack
    {
        public static readonly WzProperty<int> PADamage = new("PADamage", 0);
        public static readonly WzProperty<int> ConMP = new("conMP", 0);
        public static readonly WzProperty<int> ElemAttr = new("elemAttr", 0);
        public static readonly WzProperty<int> MPBurn = new("mpBurn", 0);
        public static readonly WzProperty<int> Type = new("type", 0);
        public static readonly WzProperty<int> BulletNumber = new("bulletNumber", 0);
        public static readonly WzProperty<int> BulletSpeed = new("bulletSpeed", 0);
        public static readonly WzProperty<int> EffectAfter = new("effectAfter", 0);
        public static readonly WzProperty<int> AttackAfter = new("attackAfter", 0);
        public static readonly WzProperty<int> RandDelayAttack = new("randDelayAttack", 0);
        public static readonly WzPresenceFlag Magic = new("magic");
        public static readonly WzPresenceFlag Deadly = new("deadly");
        public static readonly WzPresenceFlag KnockBack = new("knockBack");
        public static readonly WzPresenceFlag Tremble = new("tremble");
        public static readonly WzPresenceFlag DoFirst = new("doFirst");
        public static readonly WzPresenceFlag Rush = new("rush");

        /// <summary>Intentional WZ typo preserved: <c>"speicalAttack"</c>.</summary>
        public static readonly WzPresenceFlag SpeicalAttack = new("speicalAttack");
        public static readonly WzPresenceFlag Inactive = new("inactive");
        public static readonly WzPresenceFlag JumpAttack = new("jumpAttack");

        // Range sub-node
        public const string Range = "range";
        public const string Lt = "lt";
        public const string Rb = "rb";

        // UOL animation paths (string children on attack{N}/info/)
        public const string EffectUol = "effect";
        public const string BallUol = "ball";

        /// <summary>Area-warning effect UOL played before the attack fires to signal the danger zone.</summary>
        public const string AreaWarningUol = "areaWarning";

        // Hit sub-node (hit/hitAttach and hit/facingAttatch are read from the hit/ child)
        public const string Hit = "hit";
        public static readonly WzPresenceFlag HitAttach = new("hitAttach");

        /// <summary>Intentional WZ typo preserved: <c>"facingAttatch"</c>.</summary>
        public static readonly WzPresenceFlag FacingAttatch = new("facingAttatch");
    }

    /// <summary>Properties under Mob.wz/{id}.img/skill{N}/</summary>
    public static class Skill
    {
        public static readonly WzProperty<int> SkillId = new("skill", 0);
        public static readonly WzProperty<int> Level = new("level", 1);
        public static readonly WzProperty<int> EffectAfter = new("effectAfter", 0);
        public static readonly WzProperty<int> CoolTime = new("cooltime", 0);
    }

    /// <summary>Properties under Mob.wz/{id}.img/speak/{N}/</summary>
    public static class Speak
    {
        public const string NodeName = "speak";
        public const string ConditionNode = "condition";
        public const string QuestNode = "quest";
        public const string StateNode = "state";
        public const string PetNode = "pet";

        public static readonly WzProperty<int> Action = new("action", 0);

        /// <summary>HP% threshold to trigger this speak entry. Default is <c>50</c>.</summary>
        public static readonly WzProperty<int> Hp = new("hp", WzDefaults.MobSpeakHpDefault);

        /// <summary>MP threshold to trigger this speak entry. Default is <c>0</c>.</summary>
        public static readonly WzProperty<int> Mp = new("mp", WzDefaults.MobSpeakMpDefault);
        public static readonly WzProperty<int> Prob = new("prob", WzDefaults.DefaultPercent);

        /// <summary>Chat balloon width in pixels. Default is <c>150</c>.</summary>
        public static readonly WzProperty<int> Width = new("width", 150);
    }

    /// <summary>Named child keys within a mob animation frame node.</summary>
    public static class Frame
    {
        /// <summary>Sound-effect node (maps to <c>Sound.wz</c> path).</summary>
        public const string Sfx = "sSfx";

        /// <summary>Body collision rectangle sub-node.</summary>
        public const string Body = "body";

        /// <summary>Head attachment point (for HP bar placement).</summary>
        public const string Head = "head";

        /// <summary>Frame delay in milliseconds (default: 120).</summary>
        public static readonly WzProperty<int> Delay = new("delay", WzDefaults.DefaultMobFrameDelay);

        /// <summary>
        /// Explicit left-top corner of the body rect.
        /// When absent, fall back to canvas origin + dimensions.
        /// </summary>
        public const string Lt = "lt";

        /// <summary>
        /// Explicit right-bottom corner of the body rect.
        /// When absent, fall back to canvas origin + dimensions.
        /// </summary>
        public const string Rb = "rb";
    }

    /// <summary>Drop table properties under Etc.wz/RewardItem.img/{mobId}/{N}/</summary>
    public static class Drop
    {
        public static readonly WzProperty<int> Item = new("item", 0);
        public static readonly WzProperty<int> Min = new("min", 1);
        public static readonly WzProperty<int> Max = new("max", 1);
        public static readonly WzProperty<int> Prop = new("prop", 0);
    }
}
