namespace Maple.WzSchema;

/// <summary>
/// WZ node key strings for the Equip domain (Character.wz / Item.wz equip sections).
/// Covers stats, requirements, tradability flags, upgrade data, element resistance, and item skills.
/// </summary>
public static class EquipKeys
{
    // ── Stat bonuses ─────────────────────────────────────────────────────────
    public const string IncStr = "incSTR";
    public const string IncDex = "incDEX";
    public const string IncInt = "incINT";
    public const string IncLuk = "incLUK";
    public const string IncMaxHp = "incMHP";
    public const string IncMaxMp = "incMMP";
    public const string IncPad = "incPAD";
    public const string IncMad = "incMAD";
    public const string IncPdd = "incPDD";
    public const string IncMdd = "incMDD";
    public const string IncAcc = "incACC";
    public const string IncEva = "incEVA";
    public const string IncCraft = "incCraft";
    public const string IncSpeed = "incSpeed";
    public const string IncJump = "incJump";

    // BDR/IMDR appear in both prefixed and raw variants — use with ResolveShortFirst
    public const string IncBdr = "incBDR";
    public const string BdrRaw = "bdR";
    public const string IncImdr = "incIMDR";
    public const string ImdrRaw = "imR";

    public const string IncRDamage = "incRDamage";
    public const string IncMaxHpR = "incMHPr";
    public const string IncMaxMpR = "incMMPr";
    public const string IncSwim = "incSwim";
    public const string IncFatigue = "incFatigue";
    public const string Knockback = "knockback";
    public const string Recovery = "recovery";
    public const string Fs = "fs";
    public const string Swim = "swim";
    public const string TamingMob = "tamingMob";
    public const string PddR = "pddR";
    public const string MddR = "mddR";
    public const string DamR = "damR";
    public const string Hp = "hp";
    public const string Mp = "mp";
    public const string RandomStatNode = "apLevelInfo";

    // ── Requirements ─────────────────────────────────────────────────────────
    public const string ReqLevel = "reqLevel";
    public const string ReqJob = "reqJob";
    public const string ReqStr = "reqSTR";
    public const string ReqDex = "reqDEX";
    public const string ReqInt = "reqINT";
    public const string ReqLuk = "reqLUK";
    public const string ReqFame = "reqPOP";

    // Both variants appear in data — use with ResolveIntFirst
    public const string ReqMobLevel = "reqMobLevel";
    public const string ReqMobLevelAlt = "reqMobLv";

    // ── Tradability flags ─────────────────────────────────────────────────────
    // Note: Cash, Only, TradeBlock, Quest, NotSale, TimeLimited, PartyQuest, ExpireOnLogout,
    // AccountSharable, BigSize, ReplaceItemId*, ReplaceMsg* are intentionally also declared in
    // ItemKeys for bundle items — same WZ keys, separate class hierarchy.
    public static readonly WzPresenceFlag Cash = new("cash");
    public static readonly WzPresenceFlag Only = new("only");
    public static readonly WzPresenceFlag TradeBlock = new("tradeBlock");
    public static readonly WzPresenceFlag Quest = new("quest");
    public static readonly WzPresenceFlag NotSale = new("notSale");
    public static readonly WzPresenceFlag TimeLimited = new("timeLimited");
    public static readonly WzPresenceFlag PartyQuest = new("partyQuest");
    public static readonly WzPresenceFlag ExpireOnLogout = new("expireOnLogout");
    public static readonly WzPresenceFlag AccountSharable = new("accountSharable");
    public static readonly WzPresenceFlag OnlyEquip = new("onlyEquip");
    public static readonly WzPresenceFlag NotExtend = new("bNotExtend");

    // Primary key per catalog (literal aEquiptradebloc, C++ bBindedWhenEquiped); older typo variants kept as fallbacks.
    // Cannot be WzPresenceFlag — multi-alt lookup required; use ResolveIntFirst with all three.
    public const string BindedWhenEquipped = "equipTradeBlock";
    public const string BindedWhenEquippedAlt = "bindedWhenEquipped";
    public const string BindedWhenEquippedAlt2 = "bindedWhenEquiped";

    public static readonly WzPresenceFlag SharableOnce = new("sharableOnce");
    public static readonly WzPresenceFlag Weekly = new("bWeekly");
    public static readonly WzPresenceFlag TradeAvailable = new("tradeAvailable");

    // ── Upgrade data ──────────────────────────────────────────────────────────
    public const string RemainingUpgrades = "tuc";
    public const string TotalUpgrades = "totalUpgradeCount";

    // Three variant spellings — use with ResolveIntFirst
    public const string Iuc = "iuc";
    public const string IucAlt = "IUC";
    public const string IucMax = "iucMax";
    public const string IucMaxAlt = "IUCMax";
    public const string IucMaxAlt2 = "iucmax";

    public const string MinGrade = "grade";
    public const string KarmaType = "appliableKarmaType";
    public const string EnchantCategory = "enchantCategory";
    public const string SetItemId = "setItemID";

    // ── Item flags / misc ─────────────────────────────────────────────────────
    public const string Price = "price";
    public static readonly WzPresenceFlag BigSize = new("bigSize");
    public const string Epic = "epicItem";
    public const string Transform = "transform";
    public const string NameTag = "nameTag";
    public const string ChatBalloon = "chatBalloon";
    public const string Durability = "durability";
    public const string Gender = "gender";

    /// <summary>Weapon attack speed value in Item.wz info/ (WZ key "attack", C++ nAttackSpeed). See <see cref="Animation"/> for the Character.wz animation node of the same name.</summary>
    public const string Attack = "attack";
    public static readonly WzPresenceFlag Invisible = new("invisible");
    public const string AfterImage = "afterImage";

    public const string SpecialId = "specialID";
    public const string SpecialIdAlt = "specialId";
    public const string ReplaceItemId = "replaceItemID";
    public const string ReplaceItemIdAlt = "replaceItem";
    public const string ReplaceMsg = "replaceMsg";
    public const string ReplaceMsgAlt = "replaceItemMsg";

    // Slot strings — use with ResolveStringFirst
    public const string ISlot = "iSlot";
    public const string ISlotAlt = "sISlot";
    public const string VSlot = "vSlot";
    public const string VSlotAlt = "sVSlot";
    public const string Sfx = "sfx";
    public const string SfxAlt = "sSfx";

    /// <summary>
    /// Character.wz animation override node name keys.
    /// These WZ keys name animation sub-nodes inside a weapon's Character.wz img node,
    /// and are distinct from the Item.wz stat fields that may share the same string value.
    /// </summary>
    public static class Animation
    {
        /// <summary>Walk animation override node.</summary>
        public const string Walk = "nWalk";
        public const string WalkAlt = "walk";

        /// <summary>Stand animation override node. WZ uses <c>"move"</c> here, not <c>"nStand"</c>.</summary>
        public const string Stand = "move";
        public const string StandAlt = "nStand";

        /// <summary>Attack animation override node. WZ uses <c>"attack"</c> here, not <c>"nAttack"</c>.</summary>
        public const string Attack = "attack";
        public const string AttackAlt = "nAttack";

        public const string AttackSpeed = "nAttackSpeed";
        public const string AttackSpeedAlt = "attackSpeed";
    }

    // ── Element resistance sub-node ───────────────────────────────────────────
    public static class ElementResist
    {
        public const string Poison = "nirPoison";
        public const string Ice = "nirIce";
        public const string Fire = "nirFire";
        public const string Lightning = "nirLight";
        public const string Holy = "nirHoly"; // WZ exposes five nir* fields; there is no nirDark
    }

    // ── Addition sub-nodes ───────────────────────────────────────────────────
    public static class Addition
    {
        public const string Node = "addition";
        public const string ConNode = "con";

        // Condition keys
        public const string Level = "level";
        public const string Job = "job";
        public const string Str = "str";
        public const string Dex = "dex";
        public const string Int = "int";
        public const string Luk = "luk";
        public const string Craft = "craft";
        public const string ItemQuality = "itemquality";

        // Sub-type nodes
        public const string Skill = "skill";
        public const string MobCategory = "mobcategory";
        public const string ElemBoost = "elemboost";
        public const string Critical = "critical";
        public const string Boss = "boss";
        public const string MobDie = "mobdie";
        public const string HpMpChange = "hpmpchange";

        // Skill payload
        public const string Id = "id";

        // MobCategory / Critical / Boss payload
        public const string Category = "category";
        public const string Damage = "damage";
        public const string Prob = "prob";

        // ElemBoost payload
        public const string ElemVol = "elemvol";

        // MobDie payload
        public const string HpIncOnMobDie = "hpinconmobdie";
        public const string MpIncOnMobDie = "mpinconmobdie";
        public const string HpProp = "hpprop";
        public const string MpProp = "mpprop";
        public const string HpIncRatioOnMobDie = "hpincratioonmo"; // WZ-truncated literal due to the 14-character key limit
        public const string MpIncRatioOnMobDie = "mpincratioonmo"; // WZ-truncated literal due to the 14-character key limit
        public const string HpRatioProp = "hpratioprop";
        public const string MpRatioProp = "mpratioprop";

        // HpMpChange payload
        public const string HpChangePerTime = "hpchangepertim"; // WZ-truncated literal due to the 14-character key limit
        public const string MpChangePerTime = "mpchangepertim"; // WZ-truncated literal due to the 14-character key limit
    }

    // ── Skill sub-nodes ───────────────────────────────────────────────────────
    public static class ItemSkill
    {
        public const string LevelBonusNode = "skillLevelBonus";

        // Child-entry field keys
        public const string Id = "id";

        /// <summary>WZ key for both the skill group sub-node and the skill ID field within it — both are "skill" in WZ.</summary>
        public const string SkillNode = "skill";
        public const string SkillId = SkillNode;
        public const string Level = "level";
        public const string SkillLevel = "skillLevel";
    }
}
