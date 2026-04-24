namespace Maple.WzSchema;

/// <summary>
/// WZ node key strings for the Item domain (String.wz / Item.wz bundle sections).
/// Covers bundle category lookups, info props, consume spec, lottery, pet evolution, and bridle data.
/// </summary>
public static class ItemKeys
{
    // ── String.wz image node names ────────────────────────────────────────────
    // Note: EqpImg intentionally has no ".img" suffix. The WZ layout wraps equip strings
    // under "Eqp.img" (use StringKeys.EqpImg for that outer node), and further under an
    // inner child named "Eqp". This constant is used both to find the wrapper via
    // MatchesNodeName and to navigate into its "Eqp" child. All other *Img constants in
    // this file refer to top-level image nodes and include the ".img" suffix.
    public const string EqpImg = "Eqp";
    public const string ConsumeImg = "Consume.img";
    public const string InstallImg = "Ins.img";
    public const string EtcImg = "Etc.img";
    public const string CashImg = "Cash.img";
    public const string PetImg = "Pet.img";
    public const string SpecialImg = "Special.img";

    // ── Icon nested class (client loader compatibility) ───────────────────────
    /// <summary>Icon canvas variants within an item info node.</summary>
    public static class Icon
    {
        public const string Standard = "icon";
        public const string Raw = "iconRaw";
    }

    // ── Item.wz folder / category names ──────────────────────────────────────
    // These are the NX/WZ folder names used at runtime to navigate the item archive.
    // Kept separate from info-prop keys to avoid naming collisions.
    public static class Category
    {
        public const string ItemRoot = "Item";
        public const string Equip = "Equip";
        public const string EquipLegacy = "Eqp";
        public const string Consume = "Consume";
        public const string Install = "Install";
        public const string InstallStringFolder = "Ins";
        public const string Etc = "Etc";
        public const string Cash = "Cash";
        public const string Pet = "Pet";
        public const string Special = "Special";

        public static readonly string[] EquipNodes = [Equip, EquipLegacy];
    }

    // ── Equipment category folder names (Character.wz / Item.wz equip sub-folders) ──
    /// <summary>
    /// Equipment sub-category folder names under <c>Item.wz/Equip/</c>.
    /// Maps <c>itemId / 10000</c> to directory names.
    /// </summary>
    public static class EquipCategory
    {
        public const string Cap = "Cap";
        public const string Accessory = "Accessory";
        public const string Face = "Face";
        public const string Coat = "Coat";
        public const string Pants = "Pants";
        public const string Shoes = "Shoes";
        public const string Glove = "Glove";
        public const string Shield = "Shield";
        public const string Cape = "Cape";
        public const string Longcoat = "Longcoat";
        public const string Weapon = "Weapon";
    }

    // ── Info node props ───────────────────────────────────────────────────────
    public const string SlotMax = "slotMax";
    public const string Price = "price";

    /// <summary>
    /// Per-unit sell price for stackable bundle items (WZ key confirmed: SP 0x95E; C++ field <c>dSellUnitPrice</c>).
    /// A double value; 0.0 means use <see cref="Price"/> as the flat sell price instead.
    /// </summary>
    public const string UnitPrice = "unitPrice";

    public static readonly WzPresenceFlag Cash = new("cash");
    public static readonly WzPresenceFlag Quest = new("quest");
    public static readonly WzPresenceFlag Only = new("only");
    public static readonly WzPresenceFlag TradeBlock = new("tradeBlock");
    public static readonly WzPresenceFlag NotSale = new("notSale");
    public const string ReqLevel = "reqLevel";
    public const string Max = "max";
    public static readonly WzPresenceFlag PartyQuest = new("partyQuest");
    public static readonly WzPresenceFlag AccountSharable = new("accountSharable");
    public const string ReqField = "reqField";
    public const string ReqQuestOnProgress = "reqQuestOnProgress";
    public static readonly WzPresenceFlag MonsterBookCard = new("monsterBookCard");
    public const string McType = "mcType";

    // Battle/buff stats (HP/MP accept both cases)
    public const string Hp = "hp";
    public const string HpUpper = "HP";
    public const string Mp = "mp";
    public const string MpUpper = "MP";
    public const string HpR = "hpR";
    public const string HpRUpper = "HPR";
    public const string HpRLower = "hpRr";
    public const string MpR = "mpR";
    public const string MpRUpper = "MPR";
    public const string MpRLower = "mpRr";
    public const string HpQ = "hpQ";
    public const string HpQUpper = "HPQ";
    public const string MpQ = "mpQ";
    public const string MpQUpper = "MPQ";

    public const string Pdd = "pdd";
    public const string Pad = "incPAD"; // SP 0x817 — PDB-confirmed WZ key for throwing star PAD
    public const string PadAlt = "PAD"; // fallback variant seen in some WZ dumps

    public const string Time = "time";
    public const string TimeAlt = "duration";
    public const string Success = "success";
    public const string SuccessAlt = "succ";
    public const string Cursed = "cursed";
    public const string CursedAlt = "curse";
    public const string Recover = "recover";
    public const string RecoverAlt = "recovery";
    public const string PreventSlip = "preventSlip";
    public const string PreventSlipAlt = "preventslip";

    // Buff / target item
    public const string BuffItemId = "buffItemID";
    public const string BuffItemIdAlt = "buffItemId";
    public const string BuffItemIdAlt2 = "buffItem";
    public const string MoveTo = "moveTo";
    public const string MoveToAlt = "moveToField";
    public const string PetId = "pet";
    public const string PetIdAlt = "petID";
    public const string PetIdAlt2 = "petId";

    // Pet-specific
    public const string PetLife = "life";
    public const string PetHungry = "hungry";
    public const string NoRevive = "noRevive";
    public const string NoMoveToLocker = "noMoveToLocker";
    public const string Speed = "speed";
    public const string Jump = "jump";
    public const string ScrollId = "scrollId";
    public const string PetNameTag = "nameTag";
    public const string PetChatBalloon = "chatBalloon";
    public const string WarningState = "warningState";
    public const string Couple = "couple";
    public const string IncLevel = "incLevel";

    // Bundle-specific extension fields (§4.2 — CItemInfo::BUNDLEITEM)
    public const string AppliableKarmaType = "appliableKarmaType";
    public static readonly WzPresenceFlag NoCancelMouse = new("noCancelMouse");
    public static readonly WzPresenceFlag BigSize = new("bigSize"); // SP 0xDFA — big display flag
    public static readonly WzPresenceFlag ExpireOnLogout = new("expireOnLogout"); // SP 0xE2B
    public static readonly WzPresenceFlag TimeLimited = new("timeLimited"); // SP 0xB7D
    public const string ReplaceItemId = "replaceItemID";
    public const string ReplaceItemIdAlt = "replaceItem";
    public const string ReplaceMsg = "replaceMsg";
    public const string ReplaceMsgAlt = "replaceItemMsg";
    public const string ReplacePeriod = "replacePeriod";

    // Quest delivery
    public const string Type = "type";
    public const string Effect = "effect";
    public const string Skill = "skill";
    public const string ReqSkillLevel = "reqSkillLevel";

    // ── Spec sub-node ─────────────────────────────────────────────────────────
    public static class Spec
    {
        public const string NodeName = "spec";
        public const string Pad = "pad";
        public const string Pdd = "pdd";
        public const string Mad = "mad";
        public const string Mdd = "mdd";
        public const string Acc = "acc";
        public const string Eva = "eva";
        public const string Craft = "craft";
        public const string Speed = "speed";
        public const string Jump = "jump";
        public const string Time = "time";
        public const string Hp = "hp";
        public const string HpUpper = "HP";
        public const string Mp = "mp";
        public const string MpUpper = "MP";
        public const string HpR = "hpR";
        public const string MpR = "mpR";
        public const string AreaBuffType = "areaBuffType";

        // Base-stat bonuses from buff/elixir items (§4.3 — same key names as equip inc* fields)
        public const string IncStr = "incSTR";
        public const string IncDex = "incDEX";
        public const string IncInt = "incINT";
        public const string IncLuk = "incLUK";
    }

    // ── Pet ability flags (§4.4 — CPetTemplate.RegisterPet) ──────────────────
    // Keys inferred from PDB field naming; interactbyuser is a confirmed literal.
    public const string PickUpItem = "pickUpItem"; // SP 0xC38 ⚠️ bPickUpItem
    public const string ConsumeHp = "consumeHP"; // SP 0xC3B ⚠️ bConsumeHP
    public const string ConsumeMp = "consumeMP"; // SP 0xC3C ⚠️ bConsumeMP
    public const string SweepForDrop = "sweepForDrop"; // SP 0xC3D ⚠️ bSweepForDrop
    public const string LongRange = "longRange"; // SP 0xC3F ⚠️ bLongRange
    public const string IgnorePickup = "ignorePickup"; // SP 0xC40 ⚠️ bIgnorePickup
    public const string PetRecall = "recall"; // SP 0x1301 ⚠️ bRecall
    public const string AutoSpeaking = "autoSpeaking"; // SP 0x1A9F ⚠️ bAutoSpeaking
    public const string AutoReact = "autoReact"; // SP 0x1303 ⚠️ bAutoReact
    public const string InteractByUser = "interactbyuser"; // literal ✅ bInterActByUserAction

    // ── Lottery / reward sub-node ─────────────────────────────────────────────
    public static class Lottery
    {
        public const string NodeName = "reward";
        public const string ItemId = "itemID";
        public const string ItemIdAlt = "itemId";
        public const string ItemIdAlt2 = "item";
        public const string Prob = "prob";
        public const string Quantity = "quantity";
        public const string Period = "period";
        public const string Effect = "effect";
        public const string WorldMsg = "worldMsg";
    }

    // ── Pet evolution sub-node ────────────────────────────────────────────────
    public static class PetEvolution
    {
        public const string NodeName = "evol";
        public const string NodeNameAlt = "evolution";
        public const string ItemId = "itemid";
        public const string ItemIdAlt = "itemId";
        public const string ItemIdAlt2 = "itemID";
        public const string Period = "period";
        public const string PeriodAlt = "time";
    }

    // ── Bridle / taming info ──────────────────────────────────────────────────
    public static class Bridle
    {
        public const string TargetMobId = "mob";
        public const string TargetMobIdAlt = "targetMobID";
        public const string CreateItemId = "createItemID";
        public const string CreateItemIdAlt = "createItem";
        public const string CreateItemPeriod = "createItemPeriod";
        public const string CatchPercentageHp = "catchPercentageHP";
        public const string CatchPercentageHpAlt = "catchHP";
        public const string BridleProb = "bridleProb";
        public const string BridleProbAdj = "bridleProbAdj";
        public const string UseDelay = "useDelay";
        public const string DelayMsg = "delayMsg";
        public const string NoMobMsg = "noMobMsg";
    }

    // ── ItemOption.img potential data ─────────────────────────────────────────
    public static class ItemOption
    {
        public const string Img = "ItemOption.img";
        public const string InfoNode = "info";
        public const string LevelNode = "level";
        public const string ReqLevel = "reqLevel";
        public const string OptionType = "optionType";

        // Per-level flat stat keys
        public const string Prob = "prob";
        public const string Time = "time";
        public const string IncStr = "incSTR";
        public const string IncDex = "incDEX";
        public const string IncInt = "incINT";
        public const string IncLuk = "incLUK";
        public const string IncHp = "incHP";
        public const string IncMp = "incMP";
        public const string IncMhp = "incMHP";
        public const string IncMmp = "incMMP";
        public const string IncAcc = "incACC";
        public const string IncEva = "incEVA";
        public const string IncSpeed = "incSpeed";
        public const string IncJump = "incJump";
        public const string IncPad = "incPAD";
        public const string IncMad = "incMAD";
        public const string IncPdd = "incPDD";
        public const string IncMdd = "incMDD";

        // Per-level percentage stat keys
        public const string IncStrR = "incSTRr";
        public const string IncDexR = "incDEXr";
        public const string IncIntR = "incINTr";
        public const string IncLukR = "incLUKr";
        public const string IncMhpR = "incMHPr";
        public const string IncMmpR = "incMMPr";
        public const string IncAccR = "incACCr";
        public const string IncEvaR = "incEVAr";
        public const string IncPadR = "incPADr";
        public const string IncMadR = "incMADr";
        public const string IncPddR = "pddR";
        public const string IncMddR = "mddR";

        // Rate-based fields
        public const string IncCr = "incCr";
        public const string IncCDr = "incCDr";
        public const string IncMamR = "incMAMr";
        public const string IncSkill = "incSkill";
        public const string IncAllSkill = "incAllSkill";
        public const string RecoveryHp = "recoveryHP";
        public const string RecoveryMp = "recoveryMP";
        public const string RecoveryUp = "recoveryUP";
        public const string MpConReduce = "mpConReduce";
        public const string MpConRestore = "mpConRestore";
        public const string IgnoreTargetDef = "ignoreTargetDEF";
        public const string IgnoreDam = "ignoreDAM";
        public const string IgnoreDamR = "ignoreDAMr";
        public const string IncDamR = "damR";
        public const string DamReflect = "DAMreflect";
        public const string AttackType = "attackType";
        public const string IncMesoProb = "incMesoProp";
        public const string IncRewardProb = "incRewardProp";
        public const string Level = "level";
        public const string Boss = "boss";
        public const string Emotion = "emotion";
    }
}
