namespace Maple.WzSchema;

/// <summary>
/// WZ node key strings for the NPC domain (String.wz / Npc.wz).
/// Covers archive roots, catalogue location index names, string props, and sprite action fallbacks.
/// </summary>
public static class NpcKeys
{
    // ── Archive roots ─────────────────────────────────────────────────────────
    public const string Root = "Npc";
    public const string RootImg = "Npc.img";

    // Etc.wz location index name
    public const string NpcLocation = "NpcLocation";

    // ── String.wz per-NPC props ───────────────────────────────────────────────
    public const string NpcName = "npcName";
    public const string Func = "func";

    // ── Common node names ───────────────────────────────────────────────────
    public const string InfoNode = CommonKeys.Info;
    public const string LinkNode = CommonKeys.Link;
    public const string MoveNode = ActionMove;
    public const string ShopNode = "shop";
    public const string SayNode = ActionSay;
    public const string SpeakNode = "speak";
    public const string ConditionPrefix = "condition";
    public const string DcRangeNode = "dcRange";
    public const string DcLeft = "dcLeft";
    public const string DcTop = "dcTop";
    public const string DcRight = "dcRight";
    public const string DcBottom = "dcBottom";
    public const string DialogueNode = StringKeys.Dialogue;
    public const string D0 = StringKeys.D0;
    public const string D1 = StringKeys.D1;

    // ── Info node (nested class for client loader compatibility) ──────────────
    /// <summary>Keys under <c>{npcId:D7}.img/info/</c> as a nested class.</summary>
    public static class Info
    {
        /// <summary>
        /// Redirect key — when present, all data should be read from <c>{link}.img</c> instead.
        /// </summary>
        public const string Link = "link";
    }

    // ── Frame sub-node keys ───────────────────────────────────────────────────
    /// <summary>Per-frame sub-node fields inside each numbered animation frame.</summary>
    public static class Frame
    {
        /// <summary>Frame duration in milliseconds (NPC default: 180 ms).</summary>
        public static readonly WzProperty<int> Delay = new("delay", WzDefaults.DefaultNpcFrameDelay);

        /// <summary>Anchor-point vector for sprite positioning.</summary>
        public const string Origin = "origin";
    }

    // ── Info node props ───────────────────────────────────────────────────────
    public static readonly WzPresenceFlag Float = new("float");
    public static readonly WzPresenceFlag Hide = new("hide");
    public static readonly WzPresenceFlag HideName = new("hideName");
    public static readonly WzPresenceFlag Cash = new("cash");
    public static readonly WzPresenceFlag TalkMouseOnly = new("talkMouseOnly");
    public static readonly WzPresenceFlag DcMark = new("dcMark");
    public static readonly WzPresenceFlag StoreBank = new("storeBank");
    public static readonly WzPresenceFlag MapleTv = new("MapleTV");
    public static readonly WzPresenceFlag ViewToLocalUser = new("viewToLocalUser");
    public const string Speed = "speed";
    public const string Script = "script";

    public const string TrunkGet = "trunkGet";
    public const string TrunkPut = "trunkPut";
    public const string MapleTvMsgX = "MapleTVmsgX";
    public const string MapleTvMsgY = "MapleTVmsgY";
    public const string MapleTvAdX = "MapleTVadX";
    public const string MapleTvAdY = "MapleTVadY";
    public const string Imitate = "imitate";
    public const string SpecialAct = "specialAct";

    public static class Shop
    {
        public const string ItemId = "item";
        public const string Price = "price";
        public const string Period = "period";
        public const string TokenItemId = "tokenItemID";
        public const string TokenPrice = "tokenPrice";
        public const string LimitPerDay = "limitPerDay";
        public const string MaxPerSlot = "maxPerSlot";
        public const string Stock = "stock";
        public const string RunOut = "nRunOut";
        public const string TamingMob = "tamingMob";
    }

    public static class ScriptInfo
    {
        public const string StartDate = "startDate";
        public const string EndDate = "endDate";
    }

    public static class SpeakCondition
    {
        public const string JobCategory = "jobCategory";
        public const string Job = "job";
        public const string QuestId = "q";
        public const string Gender = "gender";
    }

    // ── Sprite action node names ──────────────────────────────────────────────

    /// <summary>
    /// Nested action key class for client-loader compatibility
    /// (mirrors the naming convention used in <see cref="CharacterKeys.Actions"/>).
    /// </summary>
    public static class Actions
    {
        /// <summary>Primary stand animation node (WZ key: <c>stand</c>).</summary>
        public const string Stand = "stand";

        /// <summary>Alternate stand animation node used by some WZ revisions (WZ key: <c>stand1</c>).</summary>
        public const string Stand1 = "stand1";
    }

    public const string ActionDefault = "default";
    public const string ActionMove = "move";
    public const string ActionSay = "say";
    public const string ActionFinger = "finger";
    public const string ActionWink = "wink";
    public const string ActionHeart = "heart";
    public const string ActionShine = "shine";

    // ── Sprite action fallback sequence ──────────────────────────────────────
    /// <summary>
    /// Ordered list of action node names tried when looking up an NPC sprite frame.
    /// Matches <c>NpcSpriteService.NpcActionFallbacks</c> array.
    /// </summary>
    public static readonly string[] ActionFallbacks =
    [
        Actions.Stand,
        ActionDefault,
        ActionMove,
        ActionSay,
        ActionFinger,
        ActionWink,
        ActionHeart,
        ActionShine,
    ];
}
