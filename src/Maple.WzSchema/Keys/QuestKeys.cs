namespace Maple.WzSchema;

/// <summary>
/// WZ node key strings for the Quest domain (String.wz / Quest.wz).
/// This is the single quest-schema authority for loaders and parsers.
/// </summary>
public static class QuestKeys
{
    // ── Archive roots ─────────────────────────────────────────────────────────
    public const string Root = "Quest";
    public const string CheckImg = "Check.img";
    public const string CheckImgAlt = "Check";
    public const string ActImg = "Act.img";
    public const string ActImgAlt = "Act";
    public const string InfoImg = "QuestInfo.img";
    public const string InfoImgAlt = "QuestInfo";
    public const string SayImg = "Say.img";
    public const string SayImgAlt = "Say";

    // ── Requirements (Check.img) ──────────────────────────────────────────────
    public const string LvMin = "lvmin";
    public const string LvMax = "lvmax";
    public const string Npc = "npc";
    public const string Item = "item";
    public const string Quest = "quest";
    public const string Skill = "skill";
    public const string Job = "job";
    public const string Pet = "pet";
    public const string FieldEnter = "fieldEnter";
    public const string Mob = "mob";
    public const string Info = CommonKeys.Info;
    public const string Interval = "interval";
    public const string StartHour = "startHour";
    public const string EndHour = "endHour";
    public const string Pop = "pop";
    public const string TamingMobLevelMin = "tamingmoblevelmin";
    public const string DayOfWeek = "dayOfWeek";

    // ── Rewards (Act.img) ─────────────────────────────────────────────────────
    public const string Exp = "exp";
    public const string Money = "money";
    public const string NextQuest = "nextQuest";
    public const string Fame = "fame";
    public const string Ap = "ap";
    public const string Buff = "buff";
    public const string BuffItemId = "buffItemID";
    public const string Sp = "sp";
    public const string NpcAct = "npcAct";

    // ── Info (QuestInfo.img) ──────────────────────────────────────────────────
    public const string Name = CommonKeys.Name;

    public const string Parent = "parent";
    public const string Summary = "summary";
    public const string RewardSummary = "rewardSummary";
    public const string DemandSummary = "demandSummary";

    // ── Sub-entry field keys ──────────────────────────────────────────────────
    // Used to read child nodes within Check/Act list entries.
    public static class Entry
    {
        public const string Id = "id";
        public const string Count = "count";
        public const string Order = "order";
        public const string Acquired = "acquired";
        public const string Prop = "prop";
        public const string Period = "period";
        public const string Gender = "gender";
        public const string Job = "job";
        public const string SkillLevel = "skillLevel";
        public const string MasterLevel = "masterLevel";
        public const string State = "state";
        public const string ItemId = "itemID";
        public const string Sp = "sp";
    }

    // ── QuestInfo.img per-quest flag / value keys ─────────────────────────────
    public static class InfoProps
    {
        public const string AutoStart = "autoStart";
        public const string AutoComplete = "autoComplete";
        public const string AutoCancel = "autoCancel";
        public const string AutoAccept = "autoAccept";
        public const string AutoPreComplete = "autoPreComplete";
        public const string OneShot = "oneShot";
        public const string Blocked = "blocked";
        public const string YellowMarker = "yellow";
        public const string TimeLimit = "timeLimit";
        public const string TimeLimit2 = "timeLimit2";
        public const string Area = "area";
        public const string Order = "order";
        public const string SelectedMob = "selectedMob";
        public const string MedalCategory = "medalCategory";
        public const string ViewMedalItem = "viewMedalItem";
    }

    public static class SayProps
    {
        public const string StartGroup = "0";
        public const string EndGroup = "1";
        public const string Ask = "ask";
    }
}
