namespace Maple.WzSchema;

/// <summary>
/// WZ node key strings for the Etc.wz miscellaneous data archive.
/// Contains canonical image names and field keys for cross-reference tables,
/// set bonus definitions, guild skills, and travel schedule data.
/// </summary>
public static class EtcKeys
{
    // ── Archive root ──────────────────────────────────────────────────────────
    public const string Root = "Etc";

    // ── Image node names within Etc.wz ───────────────────────────────────────
    public const string NpcLocationImg = "NpcLocation.img";
    public const string MobLocationImg = "MobLocation.img";
    public const string RewardItemImg = "RewardItem.img";
    public const string SetItemInfoImg = "SetItemInfo.img";
    public const string GuildSkillImg = "GuildSkill.img";
    public const string ContinentMoveImg = "ContinentMove.img";
    public const string QuestCheckImg = "QuestCheck.img";
    public const string ExpImg = "Exp.img";
    public const string TitleItemImg = "TitleItem.img";
    public const string MakeCharInfoImg = "MakeCharInfo.img";
    public const string MobEquipImg = "MobEquip.img";
    public const string SummonedSetImg = "SummonedSet.img";
    public const string ItemMakeInfoImg = "itemMakeInfo.img";
    public const string ItemMakeInfoImgAlt = "ItemMake";
    public const string RecipeImgAlt = "Recipe";
    public const string MorphNode = "Morph";

    // ── TitleItem.img field keys ─────────────────────────────────────────────
    /// <summary>Properties under Etc.wz/TitleItem.img/{titleItemId}/.</summary>
    public static class TitleItem
    {
        public const string DateExpire = "dateExpire";
        public const string OnlyUseInField = "onlyUseInField";
    }

    // ── Morph.wz/{morphId}.img — root-level action node keys and info/ stat keys ─
    /// <summary>
    /// Keys for Morph.wz/{morphId}.img (CMorphTemplate, game_types.h:41225).
    /// Root-level <c>JumpNode</c>/<c>FlyNode</c> presence drives <c>nMovability</c>:
    /// 0 = jump only, 1 = fly only, 2 = both (PDB-verified derivation in RegisterMorph).
    /// </summary>
    public static class Morph
    {
        public const string InfoNode = CommonKeys.Info;
        public const string Name = CommonKeys.Name;

        /// <summary>Root-level action sub-node whose presence indicates jump capability (SP 6844 in RegisterMorph).</summary>
        public const string JumpNode = "nJump";

        /// <summary>Root-level action sub-node whose presence indicates fly capability (SP 6833 in RegisterMorph).</summary>
        public const string FlyNode = "nFly";

        public static readonly WzProperty<int> Speed = new("nSpeed", 0);
        public static readonly WzProperty<int> Jump = new("nJump", 0);
        public static readonly WzProperty<float> Fs = new("dFs", 1.0f);
        public static readonly WzProperty<int> Swim = new("nSwim", 0);
        public static readonly WzPresenceFlag MorphEffect = new("bMorphEffect");
        public static readonly WzPresenceFlag SuperMan = new("bSuperMan");
        public static readonly WzPresenceFlag Hide = new("bHide");
        public static readonly WzPresenceFlag Attackable = new("bAttackable");
    }

    // ── TamingMob.wz/{tamingMobId}.img/info/ field keys ──────────────────────
    /// <summary>
    /// Keys for TamingMob.wz/{id:D7}.img/info/ (CTamingMobTemplate, game_types.h:61725).
    /// Stat keys are identical to <see cref="Morph"/> info/ keys except Fatigue replaces
    /// the bool flags. Speed clamp: 80–190; Jump clamp: ≤123 (PDB-confirmed RegisterTamingMob).
    /// </summary>
    public static class TamingMobTemplate
    {
        public const string InfoNode = CommonKeys.Info;
        public const string Name = CommonKeys.Name;

        public static readonly WzProperty<int> Speed = new("nSpeed", 0);
        public static readonly WzProperty<int> Jump = new("nJump", 0);
        public static readonly WzProperty<float> Fs = new("dFs", 1.0f);
        public static readonly WzProperty<int> Swim = new("nSwim", 0);

        /// <summary>Mount fatigue/stamina field (nFatigue). SP 3342 in RegisterTamingMob.</summary>
        public static readonly WzProperty<int> Fatigue = new("nFatigue", 0);
    }

    // ── SetItemInfo.img field keys ────────────────────────────────────────────
    /// <summary>Child node under {setId}/ containing all item IDs in the set (WZ: "ItemID").</summary>
    public static class SetItemInfo
    {
        public const string ItemIdNode = "ItemID";
        public const string ItemIdNodeAlt = "ItemId";

        /// <summary>
        /// Prefix of effect bonus nodes — followed by the required piece count.
        /// Node names are e.g. "Effect2", "Effect3" (WZ) or "effect2", "effect3".
        /// Case-insensitive comparison should be used when searching.
        /// </summary>
        public const string EffectPrefix = "Effect";

        /// <summary>Optional set name property stored directly on the set node (alternate to String.wz).</summary>
        public const string SetItemName = "setItemName";
    }

    // ── itemMakeInfo.img crafting/recipe field keys ──────────────────────────
    /// <summary>Properties under itemMakeInfo.img recipe definitions.</summary>
    public static class ItemCrafting
    {
        public const string RecipeNode = "recipe";
        public const string ReqItemNode = "reqItem";
        public const string IngredientNode = "ingredient";
        public const string MaterialsNode = "materials";
        public const string OutputNode = "output";

        public const string Id = "id";
        public const string RecipeId = "recipeId";
        public const string RecipeIdAlt = "recipeID";
        public const string Item = "item";
        public const string ItemId = "itemId";
        public const string ItemIdAlt = "itemID";
        public const string Target = "target";
        public const string Result = "result";
        public const string Count = "count";
        public const string Quantity = "quantity";
        public const string Num = "num";
        public const string ResultCount = "resultCount";

        /// <summary>WZ key "prop" — crafting "property" sub-node (not a typo; WZ uses "prop" for this, not "prob"). Use with ResolveIntOrStringFirst alongside <see cref="ProbNode"/>.</summary>
        public const string PropNode = "prop"; // WZ key is literally "prop", NOT a typo of "prob"

        /// <summary>WZ key "prob" — probability field (distinct from PropNode). In many recipes these appear together.</summary>
        public const string ProbNode = "prob";
        public const string ProbabilityAlt = "probability";
        public const string Qty = "qty";

        public const string ReqLevel = "reqLevel";
        public const string ReqLevelAlt = "reqLev";
        public const string ReqLevelAlt2 = "reqlevel";
        public const string ReqSkill = "reqSkill";
        public const string ReqSkillId = "reqSkillId";
        public const string ReqSkillIdAlt = "reqSkillID";
        public const string ReqSkillLevel = "reqSkillLevel";
        public const string ReqSkillLevelAlt = "reqSkillLev";
        public const string ReqSkillLevelAlt2 = "reqSkillLv";
        public const string ReqSkillProficiency = "reqSkillProficiency";
        public const string ReqSkillProb = "reqSkillProb";
        public const string ReqSkillProbability = "reqSkillProbility"; // WZ typo: "Probility" (missing 'a') — preserved as-is
        public const string ReqMeso = "reqMeso";
        public const string ReqMoney = "reqMoney";
        public const string Cost = "cost";
    }

    // ── GuildSkill.img level field keys ──────────────────────────────────────
    /// <summary>Properties under GuildSkill.img/{skillId}/level/{N}/.</summary>
    public static class GuildSkill
    {
        public const string LevelNode = "level";

        public static readonly WzProperty<int> X = new("x", 0);
        public static readonly WzProperty<int> Y = new("y", 0);
        public static readonly WzProperty<int> Time = new("time", 0);
        public static readonly WzProperty<int> Skill = new("skill", 0);
        public static readonly WzProperty<int> Point = new("point", 0);
        public static readonly WzProperty<int> Money = new("money", 0);

        /// <summary>Level description string stored in GuildSkill.img (not always present).</summary>
        public const string Desc = "desc";

        /// <summary>Effect script name string.</summary>
        public const string Effect = "effect";
    }

    // ── ContinentMove.img field keys ─────────────────────────────────────────
    /// <summary>Properties under ContinentMove.img/{lineIndex}/info/.</summary>
    public static class ContinentMove
    {
        public const string InfoNode = "info";

        public static readonly WzProperty<int> OriginFieldId = new("originFieldID", 0);
        public static readonly WzProperty<int> DestFieldId = new("destFieldID", 0);
        public static readonly WzProperty<int> WaitFieldId = new("waitFieldID", 0);
        public static readonly WzProperty<int> MoveFieldId = new("moveFieldID", 0);
        public static readonly WzProperty<int> BoardTime = new("tBoard", 0);
        public static readonly WzProperty<int> MoveTime = new("tMove", 0);
        public static readonly WzProperty<int> WaitTime = new("tWait", 0);
        public static readonly WzProperty<int> BoardBeforeTime = new("tBoardBefore", 0);
        public static readonly WzProperty<int> BoardAfterTime = new("tBoardAfter", 0);
        public static readonly WzProperty<int> IngameTime = new("tIngame", 0);
        public static readonly WzProperty<int> EventBeforeTime = new("tEventBefore", 0);
        public static readonly WzProperty<int> EventAfterTime = new("tEventAfter", 0);
        public static readonly WzPresenceFlag BackToOrigin = new("backToOrigin");
        public static readonly WzProperty<float> MobRateDuringTravel = new("mobRateDuringTravel", 0f);
    }

    // ── MakeCharInfo.img field keys ──────────────────────────────────────────
    public static class MakeCharInfo
    {
        public const string CharInfoNode = "CharInfo";
        public const string GenderNode = "gender";

        public static class Equipment
        {
            public const string Face = "Face";
            public const string Hair = "Hair";
            public const string HairColor = "HairColor";
            public const string Skin = "Skin";
            public const string Top = "Top";
            public const string Bottom = "Bottom";
            public const string Shoes = "Shoes";
            public const string Weapon = "Weapon";
        }
    }
}
