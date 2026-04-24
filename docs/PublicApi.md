# Public API Reference

## Public API Reference

```csharp
[assembly: System.Reflection.AssemblyMetadata("IsAotCompatible", "True")]
[assembly: System.Reflection.AssemblyMetadata("IsTrimmable", "True")]
[assembly: System.Reflection.AssemblyMetadata("RepositoryUrl", "https://github.com/Bia10/Maple.WzSchema/")]
[assembly: System.Resources.NeutralResourcesLanguage("en")]
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("Maple.WzSchema.Benchmarks")]
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("Maple.WzSchema.ComparisonBenchmarks")]
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("Maple.WzSchema.DocTest")]
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("Maple.WzSchema.Test")]
[assembly: System.Runtime.Versioning.TargetFramework(".NETCoreApp,Version=v10.0", FrameworkDisplayName=".NET 10.0")]
namespace Maple.WzSchema
{
    public static class CharacterCodes
    {
        public static class DefaultItems
        {
            public const int CoatFemale = 1041046;
            public const int CoatMale = 1040036;
            public const int PantsFemale = 1061039;
            public const int PantsMale = 1060026;
        }
        public enum EquipSlot
        {
            Body = 0,
            Cap = 1,
            FaceAccessory = 2,
            Earring = 3,
            EyeAccessory = 4,
            Coat = 5,
            Pants = 6,
            Shoes = 7,
            Gloves = 8,
            Cape = 9,
            Weapon = 10,
            Shield = 11,
        }
        public static class FaceExpression
        {
            public const string Angry = "angry";
            public const string Bewildered = "bewildered";
            public const string Blinking = "blink";
            public const string Cry = "cry";
            public const string Default = "default";
            public const string Hit = "hit";
            public const string Smile = "smile";
            public const string Stunned = "stunned";
            public const string Troubled = "troubled";
        }
        public enum SkinTone
        {
            Light = 0,
            Tanned = 1,
            Dark = 2,
            Pale = 3,
            Ghost = 4,
            Light2 = 5,
            Green = 9,
        }
    }
    public static class CharacterKeys
    {
        public const string BodyPathPrefix = "00002";
        public const string FaceExpressionDefault = "default";
        public const int FaceZIndex = 21;
        public const string HairDefault = "default";
        public const string HeadPathPrefix = "00012";
        public const string Root = "Character";
        public static readonly string[] RootNodes;
        public static readonly string[] ZMapNodes;
        public static readonly string[] ZOrderTable;
        public static class Action
        {
            public const string Alert = "alert";
            public const string Angry = "angry";
            public const string Attack1 = "attack1";
            public const string BackHair = "backHair";
            public const string Bewildered = "bewildered";
            public const string Blink = "blink";
            public const string CapBelowBody = "capBelowBody";
            public const string CapDefault = "capDefault";
            public const string Cry = "cry";
            public const string Default = "default";
            public const string Hit = "hit";
            public const string Jump = "jump";
            public const string Prone = "prone";
            public const string Sit = "sit";
            public const string Smile = "smile";
            public const string Stand1 = "stand1";
            public const string Stand2 = "stand2";
            public const string Stunned = "stunned";
            public const string Troubled = "troubled";
            public const string Walk1 = "walk1";
            public static readonly string[] FaceExpressions;
            public static readonly string[] HairSequenceNames;
            public static readonly string[] SkinAnimationPoses;
            public static readonly string[] SkinPreviewPoses;
        }
        public static class Actions
        {
            public const string Alert = "alert";
            public const string Attack1 = "attack1";
            public const string Attack2 = "attack2";
            public const string Attack3 = "attack3";
            public const string Dance = "dance";
            public const string Dead = "dead";
            public const string Fly1 = "fly1";
            public const string Heal = "heal";
            public const string Jump = "jump";
            public const string Ladder = "ladderMoveL";
            public const string Prone = "prone";
            public const string ProneStab = "proneStab";
            public const string Rope = "ropeMove";
            public const string Shoot1 = "shoot1";
            public const string Shoot2 = "shoot2";
            public const string ShootF = "shootF";
            public const string Sit = "sit";
            public const string StabO1 = "stabO1";
            public const string StabO2 = "stabO2";
            public const string Stand1 = "stand1";
            public const string Stand2 = "stand2";
            public const string Summon = "summon";
            public const string SwingO1 = "swingO1";
            public const string SwingO2 = "swingO2";
            public const string SwingO3 = "swingO3";
            public const string ThrowO1 = "throwO1";
            public const string Walk1 = "walk1";
            public const string Walk2 = "walk2";
        }
        public static class Anchor
        {
            public const string Brow = "brow";
            public const string Hand = "hand";
            public const string HandMove = "handMove";
            public const string Muzzle = "muzzle";
            public const string Navel = "navel";
            public const string Neck = "neck";
            public const string Nose = "nose";
        }
        public static class Category
        {
            public const string Face = "Face";
            public const string Hair = "Hair";
            public static readonly string[] EquipCategories;
        }
        public static class Equip
        {
            public const string Female = "female";
            public const string Male = "male";
        }
        public static class Folders
        {
            public const string Accessory = "Accessory";
            public const string Cap = "Cap";
            public const string Cape = "Cape";
            public const string Coat = "Coat";
            public const string Face = "Face";
            public const string Glove = "Glove";
            public const string Hair = "Hair";
            public const string Longcoat = "Longcoat";
            public const string Pants = "Pants";
            public const string Shield = "Shield";
            public const string Shoes = "Shoes";
            public const string Weapon = "Weapon";
        }
        public static class Frame
        {
            public const string Body = "body";
            public const string Head = "head";
            public const string Info = "info";
            public const string Map = "map";
            public const string Sfx = "sSfx";
            public const string ZMap = "z";
            public static bool IsBodyMetadataNode(string nodeName) { }
            public static bool IsMetadataNode(string nodeName) { }
        }
        public static class Part
        {
            public const string Body = "body";
            public const string Face = "face";
            public const string Hair = "hair";
            public const string Head = "head";
            public static readonly string[] HairPartNames;
        }
        public static class Slot
        {
            public const string ISlot = "islot";
            public const string ISlotAlt = "i";
            public const string ISlotAlt2 = "slot";
            public const string VSlot = "vslot";
            public const string VSlotAlt = "v";
            public const string VSlotAlt2 = "baseVSlot";
        }
    }
    public static class CommonKeys
    {
        public const string Action = "action";
        public const string Canvas = "canvas";
        public const string CanvasUpper = "Canvas";
        public const string Default = "default";
        public const string Delay = "delay";
        public const string Desc = "desc";
        public const string Frame0 = "0";
        public const string Frame1 = "1";
        public const string Icon = "icon";
        public const string IconDisabled = "iconDisabled";
        public const string IconDisabledRaw = "iconDisabledRaw";
        public const string IconMouseOver = "iconMouseOver";
        public const string IconRaw = "iconRaw";
        public const string ImgSuffix = ".img";
        public const string Info = "info";
        public const string Link = "link";
        public const string Map = "map";
        public const string Name = "name";
        public const string Origin = "origin";
        public const string Reward = "reward";
        public const string Seat = "seat";
        public const string X = "x";
        public const string Y = "y";
        public const string Z = "z";
        public const string ZUpper = "Z";
    }
    public static class EquipKeys
    {
        public const string AfterImage = "afterImage";
        public const string Attack = "attack";
        public const string BdrRaw = "bdR";
        public const string BindedWhenEquipped = "equipTradeBlock";
        public const string BindedWhenEquippedAlt = "bindedWhenEquipped";
        public const string BindedWhenEquippedAlt2 = "bindedWhenEquiped";
        public const string ChatBalloon = "chatBalloon";
        public const string DamR = "damR";
        public const string Durability = "durability";
        public const string EnchantCategory = "enchantCategory";
        public const string Epic = "epicItem";
        public const string Fs = "fs";
        public const string Gender = "gender";
        public const string Hp = "hp";
        public const string ISlot = "iSlot";
        public const string ISlotAlt = "sISlot";
        public const string ImdrRaw = "imR";
        public const string IncAcc = "incACC";
        public const string IncBdr = "incBDR";
        public const string IncCraft = "incCraft";
        public const string IncDex = "incDEX";
        public const string IncEva = "incEVA";
        public const string IncFatigue = "incFatigue";
        public const string IncImdr = "incIMDR";
        public const string IncInt = "incINT";
        public const string IncJump = "incJump";
        public const string IncLuk = "incLUK";
        public const string IncMad = "incMAD";
        public const string IncMaxHp = "incMHP";
        public const string IncMaxHpR = "incMHPr";
        public const string IncMaxMp = "incMMP";
        public const string IncMaxMpR = "incMMPr";
        public const string IncMdd = "incMDD";
        public const string IncPad = "incPAD";
        public const string IncPdd = "incPDD";
        public const string IncRDamage = "incRDamage";
        public const string IncSpeed = "incSpeed";
        public const string IncStr = "incSTR";
        public const string IncSwim = "incSwim";
        public const string Iuc = "iuc";
        public const string IucAlt = "IUC";
        public const string IucMax = "iucMax";
        public const string IucMaxAlt = "IUCMax";
        public const string IucMaxAlt2 = "iucmax";
        public const string KarmaType = "appliableKarmaType";
        public const string Knockback = "knockback";
        public const string MddR = "mddR";
        public const string MinGrade = "grade";
        public const string Mp = "mp";
        public const string NameTag = "nameTag";
        public const string PddR = "pddR";
        public const string Price = "price";
        public const string RandomStatNode = "apLevelInfo";
        public const string Recovery = "recovery";
        public const string RemainingUpgrades = "tuc";
        public const string ReplaceItemId = "replaceItemID";
        public const string ReplaceItemIdAlt = "replaceItem";
        public const string ReplaceMsg = "replaceMsg";
        public const string ReplaceMsgAlt = "replaceItemMsg";
        public const string ReqDex = "reqDEX";
        public const string ReqFame = "reqPOP";
        public const string ReqInt = "reqINT";
        public const string ReqJob = "reqJob";
        public const string ReqLevel = "reqLevel";
        public const string ReqLuk = "reqLUK";
        public const string ReqMobLevel = "reqMobLevel";
        public const string ReqMobLevelAlt = "reqMobLv";
        public const string ReqStr = "reqSTR";
        public const string SetItemId = "setItemID";
        public const string Sfx = "sfx";
        public const string SfxAlt = "sSfx";
        public const string SpecialId = "specialID";
        public const string SpecialIdAlt = "specialId";
        public const string Swim = "swim";
        public const string TamingMob = "tamingMob";
        public const string TotalUpgrades = "totalUpgradeCount";
        public const string Transform = "transform";
        public const string VSlot = "vSlot";
        public const string VSlotAlt = "sVSlot";
        public static readonly Maple.WzSchema.WzPresenceFlag AccountSharable;
        public static readonly Maple.WzSchema.WzPresenceFlag BigSize;
        public static readonly Maple.WzSchema.WzPresenceFlag Cash;
        public static readonly Maple.WzSchema.WzPresenceFlag ExpireOnLogout;
        public static readonly Maple.WzSchema.WzPresenceFlag Invisible;
        public static readonly Maple.WzSchema.WzPresenceFlag NotExtend;
        public static readonly Maple.WzSchema.WzPresenceFlag NotSale;
        public static readonly Maple.WzSchema.WzPresenceFlag Only;
        public static readonly Maple.WzSchema.WzPresenceFlag OnlyEquip;
        public static readonly Maple.WzSchema.WzPresenceFlag PartyQuest;
        public static readonly Maple.WzSchema.WzPresenceFlag Quest;
        public static readonly Maple.WzSchema.WzPresenceFlag SharableOnce;
        public static readonly Maple.WzSchema.WzPresenceFlag TimeLimited;
        public static readonly Maple.WzSchema.WzPresenceFlag TradeAvailable;
        public static readonly Maple.WzSchema.WzPresenceFlag TradeBlock;
        public static readonly Maple.WzSchema.WzPresenceFlag Weekly;
        public static class Addition
        {
            public const string Boss = "boss";
            public const string Category = "category";
            public const string ConNode = "con";
            public const string Craft = "craft";
            public const string Critical = "critical";
            public const string Damage = "damage";
            public const string Dex = "dex";
            public const string ElemBoost = "elemboost";
            public const string ElemVol = "elemvol";
            public const string HpChangePerTime = "hpchangepertim";
            public const string HpIncOnMobDie = "hpinconmobdie";
            public const string HpIncRatioOnMobDie = "hpincratioonmo";
            public const string HpMpChange = "hpmpchange";
            public const string HpProp = "hpprop";
            public const string HpRatioProp = "hpratioprop";
            public const string Id = "id";
            public const string Int = "int";
            public const string ItemQuality = "itemquality";
            public const string Job = "job";
            public const string Level = "level";
            public const string Luk = "luk";
            public const string MobCategory = "mobcategory";
            public const string MobDie = "mobdie";
            public const string MpChangePerTime = "mpchangepertim";
            public const string MpIncOnMobDie = "mpinconmobdie";
            public const string MpIncRatioOnMobDie = "mpincratioonmo";
            public const string MpProp = "mpprop";
            public const string MpRatioProp = "mpratioprop";
            public const string Node = "addition";
            public const string Prob = "prob";
            public const string Skill = "skill";
            public const string Str = "str";
        }
        public static class Animation
        {
            public const string Attack = "attack";
            public const string AttackAlt = "nAttack";
            public const string AttackSpeed = "nAttackSpeed";
            public const string AttackSpeedAlt = "attackSpeed";
            public const string Stand = "move";
            public const string StandAlt = "nStand";
            public const string Walk = "nWalk";
            public const string WalkAlt = "walk";
        }
        public static class ElementResist
        {
            public const string Fire = "nirFire";
            public const string Holy = "nirHoly";
            public const string Ice = "nirIce";
            public const string Lightning = "nirLight";
            public const string Poison = "nirPoison";
        }
        public static class ItemSkill
        {
            public const string Id = "id";
            public const string Level = "level";
            public const string LevelBonusNode = "skillLevelBonus";
            public const string SkillId = "skill";
            public const string SkillLevel = "skillLevel";
            public const string SkillNode = "skill";
        }
    }
    public static class EtcKeys
    {
        public const string ContinentMoveImg = "ContinentMove.img";
        public const string ExpImg = "Exp.img";
        public const string GuildSkillImg = "GuildSkill.img";
        public const string ItemMakeInfoImg = "itemMakeInfo.img";
        public const string ItemMakeInfoImgAlt = "ItemMake";
        public const string MakeCharInfoImg = "MakeCharInfo.img";
        public const string MobEquipImg = "MobEquip.img";
        public const string MobLocationImg = "MobLocation.img";
        public const string MorphNode = "Morph";
        public const string NpcLocationImg = "NpcLocation.img";
        public const string QuestCheckImg = "QuestCheck.img";
        public const string RecipeImgAlt = "Recipe";
        public const string RewardItemImg = "RewardItem.img";
        public const string Root = "Etc";
        public const string SetItemInfoImg = "SetItemInfo.img";
        public const string SummonedSetImg = "SummonedSet.img";
        public const string TitleItemImg = "TitleItem.img";
        public static class ContinentMove
        {
            public const string InfoNode = "info";
            public static readonly Maple.WzSchema.WzPresenceFlag BackToOrigin;
            public static readonly Maple.WzSchema.WzProperty<int> BoardAfterTime;
            public static readonly Maple.WzSchema.WzProperty<int> BoardBeforeTime;
            public static readonly Maple.WzSchema.WzProperty<int> BoardTime;
            public static readonly Maple.WzSchema.WzProperty<int> DestFieldId;
            public static readonly Maple.WzSchema.WzProperty<int> EventAfterTime;
            public static readonly Maple.WzSchema.WzProperty<int> EventBeforeTime;
            public static readonly Maple.WzSchema.WzProperty<int> IngameTime;
            public static readonly Maple.WzSchema.WzProperty<float> MobRateDuringTravel;
            public static readonly Maple.WzSchema.WzProperty<int> MoveFieldId;
            public static readonly Maple.WzSchema.WzProperty<int> MoveTime;
            public static readonly Maple.WzSchema.WzProperty<int> OriginFieldId;
            public static readonly Maple.WzSchema.WzProperty<int> WaitFieldId;
            public static readonly Maple.WzSchema.WzProperty<int> WaitTime;
        }
        public static class GuildSkill
        {
            public const string Desc = "desc";
            public const string Effect = "effect";
            public const string LevelNode = "level";
            public static readonly Maple.WzSchema.WzProperty<int> Money;
            public static readonly Maple.WzSchema.WzProperty<int> Point;
            public static readonly Maple.WzSchema.WzProperty<int> Skill;
            public static readonly Maple.WzSchema.WzProperty<int> Time;
            public static readonly Maple.WzSchema.WzProperty<int> X;
            public static readonly Maple.WzSchema.WzProperty<int> Y;
        }
        public static class ItemCrafting
        {
            public const string Cost = "cost";
            public const string Count = "count";
            public const string Id = "id";
            public const string IngredientNode = "ingredient";
            public const string Item = "item";
            public const string ItemId = "itemId";
            public const string ItemIdAlt = "itemID";
            public const string MaterialsNode = "materials";
            public const string Num = "num";
            public const string OutputNode = "output";
            public const string ProbNode = "prob";
            public const string ProbabilityAlt = "probability";
            public const string PropNode = "prop";
            public const string Qty = "qty";
            public const string Quantity = "quantity";
            public const string RecipeId = "recipeId";
            public const string RecipeIdAlt = "recipeID";
            public const string RecipeNode = "recipe";
            public const string ReqItemNode = "reqItem";
            public const string ReqLevel = "reqLevel";
            public const string ReqLevelAlt = "reqLev";
            public const string ReqLevelAlt2 = "reqlevel";
            public const string ReqMeso = "reqMeso";
            public const string ReqMoney = "reqMoney";
            public const string ReqSkill = "reqSkill";
            public const string ReqSkillId = "reqSkillId";
            public const string ReqSkillIdAlt = "reqSkillID";
            public const string ReqSkillLevel = "reqSkillLevel";
            public const string ReqSkillLevelAlt = "reqSkillLev";
            public const string ReqSkillLevelAlt2 = "reqSkillLv";
            public const string ReqSkillProb = "reqSkillProb";
            public const string ReqSkillProbability = "reqSkillProbility";
            public const string ReqSkillProficiency = "reqSkillProficiency";
            public const string Result = "result";
            public const string ResultCount = "resultCount";
            public const string Target = "target";
        }
        public static class MakeCharInfo
        {
            public const string CharInfoNode = "CharInfo";
            public const string GenderNode = "gender";
            public static class Equipment
            {
                public const string Bottom = "Bottom";
                public const string Face = "Face";
                public const string Hair = "Hair";
                public const string HairColor = "HairColor";
                public const string Shoes = "Shoes";
                public const string Skin = "Skin";
                public const string Top = "Top";
                public const string Weapon = "Weapon";
            }
        }
        public static class Morph
        {
            public const string FlyNode = "nFly";
            public const string InfoNode = "info";
            public const string JumpNode = "nJump";
            public const string Name = "name";
            public static readonly Maple.WzSchema.WzPresenceFlag Attackable;
            public static readonly Maple.WzSchema.WzProperty<float> Fs;
            public static readonly Maple.WzSchema.WzPresenceFlag Hide;
            public static readonly Maple.WzSchema.WzProperty<int> Jump;
            public static readonly Maple.WzSchema.WzPresenceFlag MorphEffect;
            public static readonly Maple.WzSchema.WzProperty<int> Speed;
            public static readonly Maple.WzSchema.WzPresenceFlag SuperMan;
            public static readonly Maple.WzSchema.WzProperty<int> Swim;
        }
        public static class SetItemInfo
        {
            public const string EffectPrefix = "Effect";
            public const string ItemIdNode = "ItemID";
            public const string ItemIdNodeAlt = "ItemId";
            public const string SetItemName = "setItemName";
        }
        public static class TamingMobTemplate
        {
            public const string InfoNode = "info";
            public const string Name = "name";
            public static readonly Maple.WzSchema.WzProperty<int> Fatigue;
            public static readonly Maple.WzSchema.WzProperty<float> Fs;
            public static readonly Maple.WzSchema.WzProperty<int> Jump;
            public static readonly Maple.WzSchema.WzProperty<int> Speed;
            public static readonly Maple.WzSchema.WzProperty<int> Swim;
        }
        public static class TitleItem
        {
            public const string DateExpire = "dateExpire";
            public const string OnlyUseInField = "onlyUseInField";
        }
    }
    public interface IWzNodeNavigator
    {
        System.Collections.Generic.IReadOnlyDictionary<string, Duey.Abstractions.IDataNode> BuildItemLookup(Duey.Abstractions.IDataNode categoryNode);
        Duey.Abstractions.IDataNode? FindChildByIds(Duey.Abstractions.IDataNode root, string id);
        Duey.Abstractions.IDataNode? FindItemNode(Duey.Abstractions.IDataNode categoryNode, int id);
        Duey.Abstractions.IDataNode? FindMobImgNode(Duey.Abstractions.IDataNode mobRoot, int mobId);
        Duey.Abstractions.IDataNode? FindNpcImgNode(Duey.Abstractions.IDataNode npcRoot, int npcId);
        Duey.Abstractions.IDataNode? GetChild(Duey.Abstractions.IDataNode root, string name);
        Duey.Abstractions.IDataNode? GetChild(Duey.Abstractions.IDataNode root, string name1, string name2);
        Duey.Abstractions.IDataNode? GetChild(Duey.Abstractions.IDataNode root, string name1, string name2, string name3);
        Duey.Abstractions.IDataNode? GetWzRoot(Duey.Abstractions.IDataNode? package, string childName);
        bool IsNxNode(Duey.Abstractions.IDataNode node);
        Duey.Abstractions.IDataNode ResolveMobLink(Duey.Abstractions.IDataNode primaryRoot, Duey.Abstractions.IDataNode mobNode, System.Collections.Generic.IReadOnlyList<Duey.Abstractions.IDataNode> allMobRoots);
        Duey.Abstractions.IDataNode ResolveNpcLink(Duey.Abstractions.IDataNode npcRoot, Duey.Abstractions.IDataNode npcNode);
        System.Collections.Generic.IReadOnlyList<Duey.Abstractions.IDataNode> SafeEnumerateChildren(Duey.Abstractions.IDataNode node);
        [return: System.Runtime.CompilerServices.TupleElementNames(new string[] {
                "Nodes",
                "Aborted"})]
        System.ValueTuple<System.Collections.Generic.IReadOnlyList<Duey.Abstractions.IDataNode>, bool> SafeEnumerateChildrenCounted(Duey.Abstractions.IDataNode node);
        string TrimImgSuffix(string nodeName);
        bool TryGetMapId(string name, out int id);
    }
    public static class ItemKeys
    {
        public const string AppliableKarmaType = "appliableKarmaType";
        public const string AutoReact = "autoReact";
        public const string AutoSpeaking = "autoSpeaking";
        public const string BuffItemId = "buffItemID";
        public const string BuffItemIdAlt = "buffItemId";
        public const string BuffItemIdAlt2 = "buffItem";
        public const string CashImg = "Cash.img";
        public const string ConsumeHp = "consumeHP";
        public const string ConsumeImg = "Consume.img";
        public const string ConsumeMp = "consumeMP";
        public const string Couple = "couple";
        public const string Cursed = "cursed";
        public const string CursedAlt = "curse";
        public const string Effect = "effect";
        public const string EqpImg = "Eqp";
        public const string EtcImg = "Etc.img";
        public const string Hp = "hp";
        public const string HpQ = "hpQ";
        public const string HpQUpper = "HPQ";
        public const string HpR = "hpR";
        public const string HpRLower = "hpRr";
        public const string HpRUpper = "HPR";
        public const string HpUpper = "HP";
        public const string IgnorePickup = "ignorePickup";
        public const string IncLevel = "incLevel";
        public const string InstallImg = "Ins.img";
        public const string InteractByUser = "interactbyuser";
        public const string Jump = "jump";
        public const string LongRange = "longRange";
        public const string Max = "max";
        public const string McType = "mcType";
        public const string MoveTo = "moveTo";
        public const string MoveToAlt = "moveToField";
        public const string Mp = "mp";
        public const string MpQ = "mpQ";
        public const string MpQUpper = "MPQ";
        public const string MpR = "mpR";
        public const string MpRLower = "mpRr";
        public const string MpRUpper = "MPR";
        public const string MpUpper = "MP";
        public const string NoMoveToLocker = "noMoveToLocker";
        public const string NoRevive = "noRevive";
        public const string Pad = "incPAD";
        public const string PadAlt = "PAD";
        public const string Pdd = "pdd";
        public const string PetChatBalloon = "chatBalloon";
        public const string PetHungry = "hungry";
        public const string PetId = "pet";
        public const string PetIdAlt = "petID";
        public const string PetIdAlt2 = "petId";
        public const string PetImg = "Pet.img";
        public const string PetLife = "life";
        public const string PetNameTag = "nameTag";
        public const string PetRecall = "recall";
        public const string PickUpItem = "pickUpItem";
        public const string PreventSlip = "preventSlip";
        public const string PreventSlipAlt = "preventslip";
        public const string Price = "price";
        public const string Recover = "recover";
        public const string RecoverAlt = "recovery";
        public const string ReplaceItemId = "replaceItemID";
        public const string ReplaceItemIdAlt = "replaceItem";
        public const string ReplaceMsg = "replaceMsg";
        public const string ReplaceMsgAlt = "replaceItemMsg";
        public const string ReplacePeriod = "replacePeriod";
        public const string ReqField = "reqField";
        public const string ReqLevel = "reqLevel";
        public const string ReqQuestOnProgress = "reqQuestOnProgress";
        public const string ReqSkillLevel = "reqSkillLevel";
        public const string ScrollId = "scrollId";
        public const string Skill = "skill";
        public const string SlotMax = "slotMax";
        public const string SpecialImg = "Special.img";
        public const string Speed = "speed";
        public const string Success = "success";
        public const string SuccessAlt = "succ";
        public const string SweepForDrop = "sweepForDrop";
        public const string Time = "time";
        public const string TimeAlt = "duration";
        public const string Type = "type";
        public const string UnitPrice = "unitPrice";
        public const string WarningState = "warningState";
        public static readonly Maple.WzSchema.WzPresenceFlag AccountSharable;
        public static readonly Maple.WzSchema.WzPresenceFlag BigSize;
        public static readonly Maple.WzSchema.WzPresenceFlag Cash;
        public static readonly Maple.WzSchema.WzPresenceFlag ExpireOnLogout;
        public static readonly Maple.WzSchema.WzPresenceFlag MonsterBookCard;
        public static readonly Maple.WzSchema.WzPresenceFlag NoCancelMouse;
        public static readonly Maple.WzSchema.WzPresenceFlag NotSale;
        public static readonly Maple.WzSchema.WzPresenceFlag Only;
        public static readonly Maple.WzSchema.WzPresenceFlag PartyQuest;
        public static readonly Maple.WzSchema.WzPresenceFlag Quest;
        public static readonly Maple.WzSchema.WzPresenceFlag TimeLimited;
        public static readonly Maple.WzSchema.WzPresenceFlag TradeBlock;
        public static class Bridle
        {
            public const string BridleProb = "bridleProb";
            public const string BridleProbAdj = "bridleProbAdj";
            public const string CatchPercentageHp = "catchPercentageHP";
            public const string CatchPercentageHpAlt = "catchHP";
            public const string CreateItemId = "createItemID";
            public const string CreateItemIdAlt = "createItem";
            public const string CreateItemPeriod = "createItemPeriod";
            public const string DelayMsg = "delayMsg";
            public const string NoMobMsg = "noMobMsg";
            public const string TargetMobId = "mob";
            public const string TargetMobIdAlt = "targetMobID";
            public const string UseDelay = "useDelay";
        }
        public static class Category
        {
            public const string Cash = "Cash";
            public const string Consume = "Consume";
            public const string Equip = "Equip";
            public const string EquipLegacy = "Eqp";
            public const string Etc = "Etc";
            public const string Install = "Install";
            public const string InstallStringFolder = "Ins";
            public const string ItemRoot = "Item";
            public const string Pet = "Pet";
            public const string Special = "Special";
            public static readonly string[] EquipNodes;
        }
        public static class EquipCategory
        {
            public const string Accessory = "Accessory";
            public const string Cap = "Cap";
            public const string Cape = "Cape";
            public const string Coat = "Coat";
            public const string Face = "Face";
            public const string Glove = "Glove";
            public const string Longcoat = "Longcoat";
            public const string Pants = "Pants";
            public const string Shield = "Shield";
            public const string Shoes = "Shoes";
            public const string Weapon = "Weapon";
        }
        public static class Icon
        {
            public const string Raw = "iconRaw";
            public const string Standard = "icon";
        }
        public static class ItemOption
        {
            public const string AttackType = "attackType";
            public const string Boss = "boss";
            public const string DamReflect = "DAMreflect";
            public const string Emotion = "emotion";
            public const string IgnoreDam = "ignoreDAM";
            public const string IgnoreDamR = "ignoreDAMr";
            public const string IgnoreTargetDef = "ignoreTargetDEF";
            public const string Img = "ItemOption.img";
            public const string IncAcc = "incACC";
            public const string IncAccR = "incACCr";
            public const string IncAllSkill = "incAllSkill";
            public const string IncCDr = "incCDr";
            public const string IncCr = "incCr";
            public const string IncDamR = "damR";
            public const string IncDex = "incDEX";
            public const string IncDexR = "incDEXr";
            public const string IncEva = "incEVA";
            public const string IncEvaR = "incEVAr";
            public const string IncHp = "incHP";
            public const string IncInt = "incINT";
            public const string IncIntR = "incINTr";
            public const string IncJump = "incJump";
            public const string IncLuk = "incLUK";
            public const string IncLukR = "incLUKr";
            public const string IncMad = "incMAD";
            public const string IncMadR = "incMADr";
            public const string IncMamR = "incMAMr";
            public const string IncMdd = "incMDD";
            public const string IncMddR = "mddR";
            public const string IncMesoProb = "incMesoProp";
            public const string IncMhp = "incMHP";
            public const string IncMhpR = "incMHPr";
            public const string IncMmp = "incMMP";
            public const string IncMmpR = "incMMPr";
            public const string IncMp = "incMP";
            public const string IncPad = "incPAD";
            public const string IncPadR = "incPADr";
            public const string IncPdd = "incPDD";
            public const string IncPddR = "pddR";
            public const string IncRewardProb = "incRewardProp";
            public const string IncSkill = "incSkill";
            public const string IncSpeed = "incSpeed";
            public const string IncStr = "incSTR";
            public const string IncStrR = "incSTRr";
            public const string InfoNode = "info";
            public const string Level = "level";
            public const string LevelNode = "level";
            public const string MpConReduce = "mpConReduce";
            public const string MpConRestore = "mpConRestore";
            public const string OptionType = "optionType";
            public const string Prob = "prob";
            public const string RecoveryHp = "recoveryHP";
            public const string RecoveryMp = "recoveryMP";
            public const string RecoveryUp = "recoveryUP";
            public const string ReqLevel = "reqLevel";
            public const string Time = "time";
        }
        public static class Lottery
        {
            public const string Effect = "effect";
            public const string ItemId = "itemID";
            public const string ItemIdAlt = "itemId";
            public const string ItemIdAlt2 = "item";
            public const string NodeName = "reward";
            public const string Period = "period";
            public const string Prob = "prob";
            public const string Quantity = "quantity";
            public const string WorldMsg = "worldMsg";
        }
        public static class PetEvolution
        {
            public const string ItemId = "itemid";
            public const string ItemIdAlt = "itemId";
            public const string ItemIdAlt2 = "itemID";
            public const string NodeName = "evol";
            public const string NodeNameAlt = "evolution";
            public const string Period = "period";
            public const string PeriodAlt = "time";
        }
        public static class Spec
        {
            public const string Acc = "acc";
            public const string AreaBuffType = "areaBuffType";
            public const string Craft = "craft";
            public const string Eva = "eva";
            public const string Hp = "hp";
            public const string HpR = "hpR";
            public const string HpUpper = "HP";
            public const string IncDex = "incDEX";
            public const string IncInt = "incINT";
            public const string IncLuk = "incLUK";
            public const string IncStr = "incSTR";
            public const string Jump = "jump";
            public const string Mad = "mad";
            public const string Mdd = "mdd";
            public const string Mp = "mp";
            public const string MpR = "mpR";
            public const string MpUpper = "MP";
            public const string NodeName = "spec";
            public const string Pad = "pad";
            public const string Pdd = "pdd";
            public const string Speed = "speed";
            public const string Time = "time";
        }
    }
    public static class MapKeys
    {
        public const string AllowedItemNode = "allowedItem";
        public const string AllowedItemNodeAlt = "allowedItemList";
        public const string AutoLieDetectorNode = "autoLieDetector";
        public const string BackPackageRoot = "Back";
        public const string BackgroundNode = "back";
        public const string BackgroundNodeAlt = "background";
        public const string BackgroundNodeAlt2 = "Background";
        public const string ClockNode = "clock";
        public const string FootholdNode = "foothold";
        public const string FootholdNodeAlt = "Foothold";
        public const string ForbidSkillNode = "forbiddenSkill";
        public const string ForbidSkillNodeAlt = "forbidSkill";
        public const string ForbidSkillNodeAlt2 = "forbidSkills";
        public const string HealerNode = "healer";
        public const string Help = "help";
        public const string HelpMsgNode = "help";
        public const string HelpMsgNodeAlt = "helpMsg";
        public const string InfoNode = "info";
        public const string InfoNodeAlt = "Info";
        public const string LadderRopeNode = "ladderRope";
        public const string LadderRopeNodeAlt = "LadderRope";
        public const string LifeNode = "life";
        public const string LifeNodeAlt = "Life";
        public const string MapAreaNode = "mapArea";
        public const string MapAreaNodeAlt = "area";
        public const string MapHelper = "MapHelper";
        public const string MapHelperImg = "MapHelper.img";
        public const string MapName = "mapName";
        public const string MapStringImg = "Map.img";
        public const string MiniMapNode = "miniMap";
        public const string MiniMapNodeAlt = "MiniMap";
        public const string MonsterCarnivalNode = "monsterCarnival";
        public const string ObjNode = "obj";
        public const string ObjPackageRoot = "Obj";
        public const string Physics = "Physics";
        public const string PhysicsImg = "Physics.img";
        public const string PortalNode = "portal";
        public const string PortalNodeAlt = "Portal";
        public const string PulleyNode = "pulley";
        public const string ReactorNode = "reactor";
        public const string ReactorNodeAlt = "Reactor";
        public const string Root = "Map";
        public const string SeatNode = "seat";
        public const string SeatNodeAlt = "seatInfo";
        public const string ShipNode = "ship";
        public const string StreetName = "streetName";
        public const string SwimRectNode = "swimArea";
        public const string SwimRectNodeAlt = "swimRect";
        public const string TileNode = "tile";
        public const string TilePackageRoot = "Tile";
        public static class AssetPath
        {
            public const string Back = "Back/";
            public const string Obj = "Obj/";
            public const string Tile = "Tile/";
        }
        public static class Back
        {
            public const string A = "a";
            public const string Ani = "ani";
            public const string BitmapSet = "bS";
            public const string CenterStart = "centerstart";
            public const string Cx = "cx";
            public const string Cy = "cy";
            public const string F = "f";
            public const string Front = "front";
            public const string MoveT = "moveT";
            public const string No = "no";
            public const string Period = "period";
            public const string R = "r";
            public const string Rx = "rx";
            public const string Ry = "ry";
            public const string ScreenMode = "screenMode";
            public const string Type = "type";
            public const string X = "x";
            public const string Y = "y";
        }
        public static class Background
        {
            public const string Alpha = "a";
            public const string Back = "back";
            public const string BgSet = "bS";
            public const string CenterStart = "centerstart";
            public const string Cx = "cx";
            public const string Cy = "cy";
            public const string Flip = "f";
            public const string IsAnim = "ani";
            public const string IsFront = "front";
            public const string MoveT = "moveT";
            public const string No = "no";
            public const string Period = "period";
            public const string R = "r";
            public const string Rx = "rx";
            public const string Ry = "ry";
            public const string ScreenMode = "screenMode";
            public const string Type = "type";
            public const string X = "x";
            public const string Y = "y";
        }
        public static class Carnival
        {
            public const string CpThresholdNode = "cpQ";
            public const string Desc = "desc";
            public const string GuardianGenMax = "guardianGenMax";
            public const string GuardianGenPosNode = "guardianGenPos";
            public const string GuardianNode = "guardian";
            public const string Id = "id";
            public const string MobNode = "mob";
            public const string Name = "name";
            public const string PointVersionUp = "pointVersionUp";
            public const string SkillNode = "skill";
            public const string SpendCp = "spendCP";
            public const string TimeLimit = "timeLimit";
            public const string X = "x";
            public const string Y = "y";
        }
        public static class Clock
        {
            public const string Height = "height";
            public const string Width = "width";
            public const string X = "x";
            public const string Y = "y";
        }
        public static class Cloud
        {
            public const string ImgPath = "Obj/cloud.img";
        }
        public static class Foothold
        {
            public const string CantThrough = "cant_through";
            public const string Drag = "drag";
            public const string ForbidFallDown = "forbidFallDown";
            public const string Force = "force";
            public const string Next = "next";
            public const string Piece = "piece";
            public const string Prev = "prev";
            public const string Walk = "walk";
            public const string X1 = "x1";
            public const string X2 = "x2";
            public const string Y1 = "y1";
            public const string Y2 = "y2";
        }
        public static class Frame
        {
            public const string Delay = "delay";
            public const string Origin = "origin";
        }
        public static class Healer
        {
            public const string X = "x";
            public const string Y = "ymin";
        }
        public static class Info
        {
            public const string Bgm = "bgm";
            public const string BoatType = "boatType";
            public const string Cloud = "cloud";
            public const string ConsumeItemCoolTime = "consumeItemCoolTime";
            public const string DecHp = "decHP";
            public const string DecHpAlt = "reduceHP";
            public const string DecHpAlt2 = "reduceHPAmount";
            public const string Everlast = "everlast";
            public const string ExpeditionOnly = "expeditionOnly";
            public const string FieldLimit = "fieldLimit";
            public const string FieldType = "fieldType";
            public const string FixedMobCapacity = "fixedMobCapacity";
            public const string ForcedReturn = "forcedReturn";
            public const string Fs = "fs";
            public const string HasBoat = "hasBoat";
            public const string Link = "link";
            public const string LvForceMove = "lvForceMove";
            public const string LvLimit = "lvLimit";
            public const string MapDesc = "mapDesc";
            public const string MapMark = "mapMark";
            public const string MapName = "mapName";
            public const string MapSpecificEffect = "mapSpecificEffect";
            public const string MirrorBottom = "mirror_Bottom";
            public const string MobCapacityMax = "mobCapacityMax";
            public const string MobCapacityMin = "mobCapacityMin";
            public const string MobRate = "mobRate";
            public const string MoveLimit = "moveLimit";
            public const string NBottom = "nBottom";
            public const string NSide = "nSide";
            public const string NTop = "nTop";
            public const string NoMapCmd = "noMapCmd";
            public const string NoWeather = "noWeather";
            public const string NoWeatherAlt = "noCashWeather";
            public const string NoWeatherAlt2 = "cannotUseCashWeather";
            public const string OnFirstUserEnter = "onFirstUserEnter";
            public const string OnUserEnter = "onUserEnter";
            public const string PartyOnly = "partyOnly";
            public const string Phase = "phase";
            public const string PhaseAlpha = "phaseAlpha";
            public const string PqStay = "pqStay";
            public const string ProtectItem = "protectItem";
            public const string ReactorShuffle = "reactorShuffle";
            public const string Recovery = "recovery";
            public const string RecoveryAlt = "recoveryRate";
            public const string ReduceHpPdb = "ReduceHP";
            public const string ReturnMap = "returnMap";
            public const string StreetName = "streetName";
            public const string TileSet = "tS";
            public const string TileSetAlt = "bS";
            public const string TimeLimit = "timeLimit";
            public const string VRBottom = "VRBottom";
            public const string VRLeft = "VRLeft";
            public const string VRRight = "VRRight";
            public const string VRTop = "VRTop";
            public const string Version = "version";
            public const string ViewMobLevel = "viewMobLevel";
            public const string WeatherItemId = "weatherItemID";
            public static readonly Maple.WzSchema.WzPresenceFlag DropEverlast;
            public static readonly Maple.WzSchema.WzPresenceFlag Fly;
            public static readonly Maple.WzSchema.WzPresenceFlag HideMinimap;
            public static readonly Maple.WzSchema.WzPresenceFlag NeedSkillForFly;
            public static readonly Maple.WzSchema.WzPresenceFlag PersonalShop;
            public static readonly Maple.WzSchema.WzPresenceFlag Swim;
            public static readonly Maple.WzSchema.WzPresenceFlag Town;
        }
        public static class LadderRope
        {
            public const string D = "d";
            public const string IsLadder = "l";
            public const string L = "l";
            public const string Page = "page";
            public const string UpperFoothold = "uf";
            public const string X = "x";
            public const string Y1 = "y1";
            public const string Y2 = "y2";
        }
        public static class Life
        {
            public const string Cy = "cy";
            public const string FaceDir = "f";
            public const string Fh = "fh";
            public const string Hide = "hide";
            public const string Id = "id";
            public const string MobTime = "mobTime";
            public const string Rx0 = "rx0";
            public const string Rx1 = "rx1";
            public const string Team = "team";
            public const string Type = "type";
            public const string TypeMob = "m";
            public const string TypeNpc = "n";
            public const string X = "x";
            public const string Y = "y";
        }
        public static class MiniMap
        {
            public const string Canvas = "canvas";
            public const string CenterX = "centerX";
            public const string CenterY = "centerY";
            public const string Height = "height";
            public const string Mag = "mag";
            public const string Width = "width";
        }
        public static class Obj
        {
            public const string A = "a";
            public const string Alpha = "a";
            public const string F = "f";
            public const string FlipH = "f";
            public const string HasFlow = "flow";
            public const string IsDynamic = "dynamic";
            public const string IsHidden = "hide";
            public const string IsReactive = "r";
            public const string L0 = "l0";
            public const string L1 = "l1";
            public const string L2 = "l2";
            public const string MoveP = "move_p";
            public const string MoveType = "moveType";
            public const string Name = "name";
            public const string ObjSet = "oS";
            public const string Piece = "piece";
            public const string QuestId = "quest";
            public const string Rx = "rx";
            public const string Ry = "ry";
            public const string X = "x";
            public const string Y = "y";
            public const string Z = "z";
            public const string ZM = "zM";
        }
        public static class Portal
        {
            public const string Delay = "delay";
            public const string EditorNode = "editor";
            public const string GameNode = "game";
            public const string HImpact = "hImpact";
            public const string HRange = "hRange";
            public const string HideTooltip = "hideTooltip";
            public const string Image = "image";
            public const string Name = "pn";
            public const string NameAlt = "name";
            public const string OnlyOnce = "onlyOnce";
            public const string ReactorName = "reactorName";
            public const string Script = "script";
            public const string SessionValue = "sessionValue";
            public const string SessionValueKey = "sessionValueKey";
            public const string TargetMap = "tm";
            public const string TargetMapId = "tm";
            public const string TargetName = "tn";
            public const string TargetPortalName = "tn";
            public const string Type = "pt";
            public const string VImpact = "vImpact";
            public const string VRange = "vRange";
            public const string X = "x";
            public const string Y = "y";
        }
        public static class PortalSprite
        {
            public const string Cp = "cp";
            public const string Default = "default";
            public const string Enter = "enter";
            public const string Exit = "exit";
            public const string Idle = "idle";
            public const string Ph = "ph";
            public const string Psh = "psh";
            public const string Pv = "pv";
            public const string Root = "Map/MapHelper.img/portal/game";
            public const string Sp = "sp";
            public const string Tp = "tp";
        }
        public static class Pulley
        {
            public const string Hp = "hp";
            public const string X = "x";
            public const string Y = "y";
        }
        public static class Reactor
        {
            public const string F = "f";
            public const string Id = "id";
            public const string Name = "name";
            public const string ReactorTime = "reactorTime";
            public const string X = "x";
            public const string Y = "y";
        }
        public static class Seat
        {
            public const string X = "x";
            public const string Y = "y";
        }
        public static class Section
        {
            public const string Back = "back";
            public const string Foothold = "foothold";
            public const string Info = "info";
            public const string LadderRope = "ladderRope";
            public const string LayerPrefix = "layer";
            public const string Life = "life";
            public const string MiniMap = "miniMap";
            public const string Obj = "obj";
            public const string Portal = "portal";
            public const string Tile = "tile";
        }
        public static class Ship
        {
            public const string Flip = "f";
            public const string LimitX = "limit_x";
            public const string LimitX0 = "limit_x0";
            public const string LimitY = "limit_y";
            public const string LimitY0 = "limit_y0";
            public const string ShipKind = "shipKind";
            public const string ShipObj = "shipObj";
            public const string TAppear = "tAppear";
            public const string TMove = "tMove";
            public const string X = "x";
            public const string X0 = "x0";
            public const string Y = "y";
            public const string Z = "z";
        }
        public static class SwimRect
        {
            public const string B = "b";
            public const string L = "l";
            public const string Lt = "lt";
            public const string R = "r";
            public const string Rb = "rb";
            public const string T = "t";
            public const string X = "x";
            public const string Y = "y";
        }
        public static class Tile
        {
            public const string FlipH = "f";
            public const string No = "no";
            public const string TileSet = "tS";
            public const string U = "u";
            public const string Variant = "u";
            public const string X = "x";
            public const string Y = "y";
            public const string ZM = "zM";
        }
        public static class WorldMap
        {
            public const string BaseImgNode = "BaseImg";
            public const string LinkImg = "linkImg";
            public const string LinkMap = "linkMap";
            public const string MapLinkNode = "mapLink";
            public const string MapListNode = "MapList";
            public const string MapNo = "mapNo";
            public const string Root = "WorldMap";
            public const string SpotNode = "spot";
            public const string ToolTip = "toolTip";
        }
    }
    public static class MobKeys
    {
        public const string ActionChase = "chase";
        public const string ActionFly = "fly";
        public const string ActionJump = "jump";
        public const string ActionMove = "move";
        public const string ActionRegen = "regen";
        public const string MobLocation = "MobLocation";
        public const string RewardItem = "RewardItem";
        public const string Root = "Mob";
        public const string RootImg = "Mob.img";
        public const string SkillPrefix = "skill";
        public static readonly string[] ActionFallbacks;
        public static class Actions
        {
            public const string Attack1 = "attack1";
            public const string Attack2 = "attack2";
            public const string Chase = "chase";
            public const string Die1 = "die1";
            public const string Die2 = "die2";
            public const string Fly = "fly";
            public const string Hit1 = "hit1";
            public const string Hit2 = "hit2";
            public const string Jump = "jump";
            public const string Move = "move";
            public const string Regen = "regen";
            public const string Skill0 = "skill0";
            public const string Skill1 = "skill1";
            public const string Stand = "stand";
        }
        public static class Attack
        {
            public const string AreaWarningUol = "areaWarning";
            public const string BallUol = "ball";
            public const string EffectUol = "effect";
            public const string Hit = "hit";
            public const string Lt = "lt";
            public const string Range = "range";
            public const string Rb = "rb";
            public static readonly Maple.WzSchema.WzProperty<int> AttackAfter;
            public static readonly Maple.WzSchema.WzProperty<int> BulletNumber;
            public static readonly Maple.WzSchema.WzProperty<int> BulletSpeed;
            public static readonly Maple.WzSchema.WzProperty<int> ConMP;
            public static readonly Maple.WzSchema.WzPresenceFlag Deadly;
            public static readonly Maple.WzSchema.WzPresenceFlag DoFirst;
            public static readonly Maple.WzSchema.WzProperty<int> EffectAfter;
            public static readonly Maple.WzSchema.WzProperty<int> ElemAttr;
            public static readonly Maple.WzSchema.WzPresenceFlag FacingAttatch;
            public static readonly Maple.WzSchema.WzPresenceFlag HitAttach;
            public static readonly Maple.WzSchema.WzPresenceFlag Inactive;
            public static readonly Maple.WzSchema.WzPresenceFlag JumpAttack;
            public static readonly Maple.WzSchema.WzPresenceFlag KnockBack;
            public static readonly Maple.WzSchema.WzProperty<int> MPBurn;
            public static readonly Maple.WzSchema.WzPresenceFlag Magic;
            public static readonly Maple.WzSchema.WzProperty<int> PADamage;
            public static readonly Maple.WzSchema.WzProperty<int> RandDelayAttack;
            public static readonly Maple.WzSchema.WzPresenceFlag Rush;
            public static readonly Maple.WzSchema.WzPresenceFlag SpeicalAttack;
            public static readonly Maple.WzSchema.WzPresenceFlag Tremble;
            public static readonly Maple.WzSchema.WzProperty<int> Type;
        }
        public static class Drop
        {
            public static readonly Maple.WzSchema.WzProperty<int> Item;
            public static readonly Maple.WzSchema.WzProperty<int> Max;
            public static readonly Maple.WzSchema.WzProperty<int> Min;
            public static readonly Maple.WzSchema.WzProperty<int> Prop;
        }
        public static class Frame
        {
            public const string Body = "body";
            public const string Head = "head";
            public const string Lt = "lt";
            public const string Rb = "rb";
            public const string Sfx = "sSfx";
            public static readonly Maple.WzSchema.WzProperty<int> Delay;
        }
        public static class Info
        {
            public const string DamagedBySelectedMob = "damagedByMob";
            public const string DamagedBySelectedSkill = "damagedBySkill";
            public const string ElemBonus = "elemBonus";
            public const string Revive = "revive";
            public static readonly Maple.WzSchema.WzProperty<int> Acc;
            public static readonly Maple.WzSchema.WzPresenceFlag AngerGauge;
            public static readonly Maple.WzSchema.WzProperty<int> BanType;
            public static readonly Maple.WzSchema.WzPresenceFlag BodyAttack;
            public static readonly Maple.WzSchema.WzPresenceFlag Boss;
            public static readonly Maple.WzSchema.WzPresenceFlag CannotEvade;
            public static readonly Maple.WzSchema.WzPresenceFlag CantPassByTeleport;
            public static readonly Maple.WzSchema.WzProperty<int> Category;
            public static readonly Maple.WzSchema.WzProperty<int> ChargeCount;
            public static readonly Maple.WzSchema.WzProperty<int> ChaseSpeed;
            public static readonly Maple.WzSchema.WzProperty<int> ChatBalloon;
            public static readonly Maple.WzSchema.WzProperty<int> DieCount;
            public static readonly Maple.WzSchema.WzPresenceFlag Disable;
            public static readonly Maple.WzSchema.WzProperty<int> DropItemPeriod;
            public static readonly Maple.WzSchema.WzProperty<string?> ElemAttr;
            public static readonly Maple.WzSchema.WzProperty<int> Escort;
            public static readonly Maple.WzSchema.WzProperty<int> EscortType;
            public static readonly Maple.WzSchema.WzProperty<int> Eva;
            public static readonly Maple.WzSchema.WzProperty<int> Exp;
            public static readonly Maple.WzSchema.WzPresenceFlag FirstAttack;
            public static readonly Maple.WzSchema.WzPresenceFlag FirstSelfDestruction;
            public static readonly Maple.WzSchema.WzProperty<int> FixedBodyAttackDamR;
            public static readonly Maple.WzSchema.WzProperty<int> FixedDamage;
            public static readonly Maple.WzSchema.WzProperty<int> FlySpeed;
            public static readonly Maple.WzSchema.WzProperty<float> Fs;
            public static readonly Maple.WzSchema.WzPresenceFlag HPGaugeHide;
            public static readonly Maple.WzSchema.WzProperty<int> HPRecovery;
            public static readonly Maple.WzSchema.WzPresenceFlag HideHP;
            public static readonly Maple.WzSchema.WzPresenceFlag HideLevel;
            public static readonly Maple.WzSchema.WzPresenceFlag HideName;
            public static readonly Maple.WzSchema.WzProperty<int> HitCount;
            public static readonly Maple.WzSchema.WzProperty<int> HpTagBgColor;
            public static readonly Maple.WzSchema.WzProperty<int> HpTagColor;
            public static readonly Maple.WzSchema.WzPresenceFlag Invincible;
            public static readonly Maple.WzSchema.WzProperty<int> Level;
            public static readonly Maple.WzSchema.WzProperty<int> MADamage;
            public static readonly Maple.WzSchema.WzProperty<int> MDRate;
            public static readonly Maple.WzSchema.WzProperty<int> MPRecovery;
            public static readonly Maple.WzSchema.WzProperty<int> MaxHP;
            public static readonly Maple.WzSchema.WzProperty<int> MaxMP;
            public static readonly Maple.WzSchema.WzProperty<int> MonsterBook;
            public static readonly Maple.WzSchema.WzPresenceFlag NoFlip;
            public static readonly Maple.WzSchema.WzPresenceFlag NoRegen;
            public static readonly Maple.WzSchema.WzPresenceFlag NotAttack;
            public static readonly Maple.WzSchema.WzPresenceFlag OnlyNormalAttack;
            public static readonly Maple.WzSchema.WzProperty<int> PADamage;
            public static readonly Maple.WzSchema.WzProperty<int> PDRate;
            public static readonly Maple.WzSchema.WzPresenceFlag PickUpDrop;
            public static readonly Maple.WzSchema.WzProperty<int> PushedDamage;
            public static readonly Maple.WzSchema.WzPresenceFlag SelfDestruction;
            public static readonly Maple.WzSchema.WzProperty<string?> Species;
            public static readonly Maple.WzSchema.WzProperty<int> Speed;
            public static readonly Maple.WzSchema.WzProperty<int> Type;
            public static readonly Maple.WzSchema.WzPresenceFlag Undead;
            public static readonly Maple.WzSchema.WzPresenceFlag UpperMostLayer;
            public static readonly Maple.WzSchema.WzProperty<int> Weapon;
        }
        public static class Skill
        {
            public static readonly Maple.WzSchema.WzProperty<int> CoolTime;
            public static readonly Maple.WzSchema.WzProperty<int> EffectAfter;
            public static readonly Maple.WzSchema.WzProperty<int> Level;
            public static readonly Maple.WzSchema.WzProperty<int> SkillId;
        }
        public static class Speak
        {
            public const string ConditionNode = "condition";
            public const string NodeName = "speak";
            public const string PetNode = "pet";
            public const string QuestNode = "quest";
            public const string StateNode = "state";
            public static readonly Maple.WzSchema.WzProperty<int> Action;
            public static readonly Maple.WzSchema.WzProperty<int> Hp;
            public static readonly Maple.WzSchema.WzProperty<int> Mp;
            public static readonly Maple.WzSchema.WzProperty<int> Prob;
            public static readonly Maple.WzSchema.WzProperty<int> Width;
        }
    }
    public static class MobSkillKeys
    {
        public const string Img = "MobSkill.img";
        public const string LevelNode = "level";
        public static class Level
        {
            public const string Affected = "affected";
            public const string Effect = "effect";
            public const string Hit = "hit";
            public const string Lt = "lt";
            public const string Mob = "mob";
            public const string Rb = "rb";
            public const string Summon = "summon";
            public const string Tile = "tile";
            public static readonly Maple.WzSchema.WzProperty<int> ConMP;
            public static readonly Maple.WzSchema.WzProperty<int> Count;
            public static readonly Maple.WzSchema.WzProperty<int> Dir;
            public static readonly Maple.WzSchema.WzProperty<int> Duration;
            public static readonly Maple.WzSchema.WzProperty<int> ElemAttr;
            public static readonly Maple.WzSchema.WzProperty<int> HpBelow;
            public static readonly Maple.WzSchema.WzProperty<int> Interval;
            public static readonly Maple.WzSchema.WzProperty<int> Limit;
            public static readonly Maple.WzSchema.WzProperty<int> NEffect;
            public static readonly Maple.WzSchema.WzProperty<int> Prop;
            public static readonly Maple.WzSchema.WzProperty<int> Random;
            public static readonly Maple.WzSchema.WzProperty<int> X;
            public static readonly Maple.WzSchema.WzProperty<int> Y;
        }
    }
    public static class NpcKeys
    {
        public const string ActionDefault = "default";
        public const string ActionFinger = "finger";
        public const string ActionHeart = "heart";
        public const string ActionMove = "move";
        public const string ActionSay = "say";
        public const string ActionShine = "shine";
        public const string ActionWink = "wink";
        public const string ConditionPrefix = "condition";
        public const string D0 = "d0";
        public const string D1 = "d1";
        public const string DcBottom = "dcBottom";
        public const string DcLeft = "dcLeft";
        public const string DcRangeNode = "dcRange";
        public const string DcRight = "dcRight";
        public const string DcTop = "dcTop";
        public const string DialogueNode = "dialogue";
        public const string Func = "func";
        public const string Imitate = "imitate";
        public const string InfoNode = "info";
        public const string LinkNode = "link";
        public const string MapleTvAdX = "MapleTVadX";
        public const string MapleTvAdY = "MapleTVadY";
        public const string MapleTvMsgX = "MapleTVmsgX";
        public const string MapleTvMsgY = "MapleTVmsgY";
        public const string MoveNode = "move";
        public const string NpcLocation = "NpcLocation";
        public const string NpcName = "npcName";
        public const string Root = "Npc";
        public const string RootImg = "Npc.img";
        public const string SayNode = "say";
        public const string Script = "script";
        public const string ShopNode = "shop";
        public const string SpeakNode = "speak";
        public const string SpecialAct = "specialAct";
        public const string Speed = "speed";
        public const string TrunkGet = "trunkGet";
        public const string TrunkPut = "trunkPut";
        public static readonly string[] ActionFallbacks;
        public static readonly Maple.WzSchema.WzPresenceFlag Cash;
        public static readonly Maple.WzSchema.WzPresenceFlag DcMark;
        public static readonly Maple.WzSchema.WzPresenceFlag Float;
        public static readonly Maple.WzSchema.WzPresenceFlag Hide;
        public static readonly Maple.WzSchema.WzPresenceFlag HideName;
        public static readonly Maple.WzSchema.WzPresenceFlag MapleTv;
        public static readonly Maple.WzSchema.WzPresenceFlag StoreBank;
        public static readonly Maple.WzSchema.WzPresenceFlag TalkMouseOnly;
        public static readonly Maple.WzSchema.WzPresenceFlag ViewToLocalUser;
        public static class Actions
        {
            public const string Stand = "stand";
            public const string Stand1 = "stand1";
        }
        public static class Frame
        {
            public const string Origin = "origin";
            public static readonly Maple.WzSchema.WzProperty<int> Delay;
        }
        public static class Info
        {
            public const string Link = "link";
        }
        public static class ScriptInfo
        {
            public const string EndDate = "endDate";
            public const string StartDate = "startDate";
        }
        public static class Shop
        {
            public const string ItemId = "item";
            public const string LimitPerDay = "limitPerDay";
            public const string MaxPerSlot = "maxPerSlot";
            public const string Period = "period";
            public const string Price = "price";
            public const string RunOut = "nRunOut";
            public const string Stock = "stock";
            public const string TamingMob = "tamingMob";
            public const string TokenItemId = "tokenItemID";
            public const string TokenPrice = "tokenPrice";
        }
        public static class SpeakCondition
        {
            public const string Gender = "gender";
            public const string Job = "job";
            public const string JobCategory = "jobCategory";
            public const string QuestId = "q";
        }
    }
    public static class PhysicsKeys
    {
        public const string FallSpeed = "fallSpeed";
        public const string FloatCoefficient = "floatCoefficient";
        public const string FloatDrag1 = "floatDrag1";
        public const string FloatDrag2 = "floatDrag2";
        public const string FlyForce = "flyForce";
        public const string FlyJumpDec = "flyJumpDec";
        public const string FlySpeed = "flySpeed";
        public const string GravityAcc = "gravityAcc";
        public const string JumpSpeed = "jumpSpeed";
        public const string MaxFriction = "maxFriction";
        public const string MinFriction = "minFriction";
        public const string SlipForce = "slipForce";
        public const string SlipSpeed = "slipSpeed";
        public const string SwimForce = "swimForce";
        public const string SwimSpeed = "swimSpeed";
        public const string SwimSpeedDec = "swimSpeedDec";
        public const string WalkDrag = "walkDrag";
        public const string WalkForce = "walkForce";
        public const string WalkSpeed = "walkSpeed";
    }
    public static class QuestKeys
    {
        public const string ActImg = "Act.img";
        public const string ActImgAlt = "Act";
        public const string Ap = "ap";
        public const string Buff = "buff";
        public const string BuffItemId = "buffItemID";
        public const string CheckImg = "Check.img";
        public const string CheckImgAlt = "Check";
        public const string DayOfWeek = "dayOfWeek";
        public const string DemandSummary = "demandSummary";
        public const string EndHour = "endHour";
        public const string Exp = "exp";
        public const string Fame = "fame";
        public const string FieldEnter = "fieldEnter";
        public const string Info = "info";
        public const string InfoImg = "QuestInfo.img";
        public const string InfoImgAlt = "QuestInfo";
        public const string Interval = "interval";
        public const string Item = "item";
        public const string Job = "job";
        public const string LvMax = "lvmax";
        public const string LvMin = "lvmin";
        public const string Mob = "mob";
        public const string Money = "money";
        public const string Name = "name";
        public const string NextQuest = "nextQuest";
        public const string Npc = "npc";
        public const string NpcAct = "npcAct";
        public const string Parent = "parent";
        public const string Pet = "pet";
        public const string Pop = "pop";
        public const string Quest = "quest";
        public const string RewardSummary = "rewardSummary";
        public const string Root = "Quest";
        public const string SayImg = "Say.img";
        public const string SayImgAlt = "Say";
        public const string Skill = "skill";
        public const string Sp = "sp";
        public const string StartHour = "startHour";
        public const string Summary = "summary";
        public const string TamingMobLevelMin = "tamingmoblevelmin";
        public static class Entry
        {
            public const string Acquired = "acquired";
            public const string Count = "count";
            public const string Gender = "gender";
            public const string Id = "id";
            public const string ItemId = "itemID";
            public const string Job = "job";
            public const string MasterLevel = "masterLevel";
            public const string Order = "order";
            public const string Period = "period";
            public const string Prop = "prop";
            public const string SkillLevel = "skillLevel";
            public const string Sp = "sp";
            public const string State = "state";
        }
        public static class InfoProps
        {
            public const string Area = "area";
            public const string AutoAccept = "autoAccept";
            public const string AutoCancel = "autoCancel";
            public const string AutoComplete = "autoComplete";
            public const string AutoPreComplete = "autoPreComplete";
            public const string AutoStart = "autoStart";
            public const string Blocked = "blocked";
            public const string MedalCategory = "medalCategory";
            public const string OneShot = "oneShot";
            public const string Order = "order";
            public const string SelectedMob = "selectedMob";
            public const string TimeLimit = "timeLimit";
            public const string TimeLimit2 = "timeLimit2";
            public const string ViewMedalItem = "viewMedalItem";
            public const string YellowMarker = "yellow";
        }
        public static class SayProps
        {
            public const string Ask = "ask";
            public const string EndGroup = "1";
            public const string StartGroup = "0";
        }
    }
    public static class ReactorKeys
    {
        public const string Root = "Reactor";
        public const string RootImg = "Reactor.img";
        public static readonly Maple.WzSchema.WzProperty<int> QuestId;
        public static class Event
        {
            public const string ActiveSkillId = "activeSkillID";
            public const string CheckRectLt = "lt";
            public const string CheckRectRb = "rb";
            public const string ItemCount = "itemCount";
            public const string ItemCountAlt = "nItemCount";
            public const string ItemId = "itemID";
            public const string ItemIdAlt = "nItemID";
            public static readonly Maple.WzSchema.WzProperty<int> NextState;
            public static readonly Maple.WzSchema.WzProperty<int> Type;
        }
        public static class Frame
        {
            public const string Origin = "origin";
            public static readonly Maple.WzSchema.WzProperty<int> A0;
            public static readonly Maple.WzSchema.WzProperty<int> A1;
            public static readonly Maple.WzSchema.WzProperty<int> Delay;
            public static readonly Maple.WzSchema.WzProperty<int> Z;
        }
        public static class Info
        {
            public const string Action = "action";
            public const string NodeName = "info";
            public static readonly Maple.WzSchema.WzPresenceFlag ActivateByTouch;
            public static readonly Maple.WzSchema.WzPresenceFlag CanMove;
            public static readonly Maple.WzSchema.WzProperty<int> Layer;
            public static readonly Maple.WzSchema.WzProperty<int> Link;
            public static readonly Maple.WzSchema.WzPresenceFlag NotHitable;
            public static readonly Maple.WzSchema.WzPresenceFlag RemoveInFieldSet;
            public static readonly Maple.WzSchema.WzProperty<int> StateCount;
        }
        public static class State
        {
            public const string EventNode = "event";
            public static readonly Maple.WzSchema.WzPresenceFlag Repeat;
            public static readonly Maple.WzSchema.WzProperty<int> Timeout;
        }
    }
    public static class SkillKeys
    {
        public const string ActionNode = "action";
        public const string Ball = "ball";
        public const string BallNode = "ball";
        public const string Common = "common";
        public const string CommonNode = "common";
        public const string DefaultMasterLevel = "defaultMasterLev";
        public const string DelayFrame = "delay";
        public const string ElemAttr = "elemAttr";
        public const string Element = "element";
        public const string FinalAttackNode = "finalAttack";
        public const string Hint = "h";
        public const string HoldFrame = "hold";
        public const string HpCon = "hpCon";
        public const string ItemConsume = "itemConsume";
        public const string ItemConsumeCount = "itemConsumeCount";
        public const string Job = "job";
        public const string JobName = "jobName";
        public const string JobStringImg = "Job";
        public const string Level = "level";
        public const string LevelDataNode = "levelData";
        public const string LevelDataNodeAlt = "LevelData";
        public const string LevelNode = "level";
        public const string LevelNodeAlt = "Level";
        public const string MasterLevel = "masterLevel";
        public const string MaxLevel = "maxLevel";
        public const string MobCode = "mob";
        public const string MoneyCon = "moneyCon";
        public const string MpCon = "mpCon";
        public const string PrepareAction = "prepareAction";
        public const string PrepareNode = "prepare";
        public const string PrepareTimeKey = "time";
        public const string Psd = "psd";
        public const string PsdSkill = "psdSkill";
        public const string ReqLevel = "reqLevel";
        public const string ReqNode = "req";
        public const string ReqSkillNode = "reqSkill";
        public const string Root = "Skill";
        public const string SkillGroupNode = "skill";
        public const string SkillGroupNodeAlt = "Skill";
        public const string SkillListNode = "skillList";
        public const string SkillNode = "skill";
        public const string SkillStringImg = "Skill.img";
        public const string SkillType = "skillType";
        public const string SkillTypeAlt = "type";
        public const string Speed = "speed";
        public const string SubWeapon = "subWeapon";
        public const string Weapon = "weapon";
        public static readonly Maple.WzSchema.WzPresenceFlag CombatOrders;
        public static readonly Maple.WzSchema.WzPresenceFlag ContinuousEffect;
        public static readonly Maple.WzSchema.WzPresenceFlag Hyper;
        public static readonly string[] IconNodeCandidates;
        public static readonly Maple.WzSchema.WzPresenceFlag Invisible;
        public static readonly Maple.WzSchema.WzPresenceFlag KeydownEnd;
        public static readonly Maple.WzSchema.WzPresenceFlag NotRemoved;
        public static readonly Maple.WzSchema.WzPresenceFlag PvpDisable;
        public static readonly string[] RootNodes;
        public static readonly string[] SkillGroupNodes;
        public static readonly Maple.WzSchema.WzProperty<int> SkillLvData;
        public static readonly Maple.WzSchema.WzPresenceFlag Summon;
        public static readonly Maple.WzSchema.WzPresenceFlag TimeLimited;
        public static readonly Maple.WzSchema.WzPresenceFlag UpButtonDisabled;
        public static class AdditionPsd
        {
            public const string Ar = "ar";
            public const string CdMin = "cdMin";
            public const string Cr = "cr";
            public const string DipR = "dipR";
            public const string ImpR = "impR";
            public const string MDamR = "mDamR";
            public const string PDamR = "pDamR";
        }
        public static class Animation
        {
            public const string Affected = "affected";
            public const string Affected0 = "affected0";
            public const string Afterimage = "afterimage";
            public const string Ball = "ball";
            public const string Effect = "effect";
            public const string Finish = "finish";
            public const string FlipBall = "flipBall";
            public const string Hit = "hit";
            public const string KeyDown = "keydown";
            public const string KeyDownEnd = "keydownend";
            public const string Mob = "mob";
            public const string Prepare = "prepare";
            public const string ScreenEffect = "screen";
            public const string Special = "special";
            public const string SpecialAffected = "specialAffected";
            public const string Summoned = "summoned";
            public const string Tile = "tile";
        }
        public static class Formula
        {
            public const string Acc = "acc";
            public const string AttackCount = "attackCount";
            public const string BulletConsume = "bulletConsume";
            public const string BulletCount = "bulletCount";
            public const string Cooltime = "cooltime";
            public const string Damage = "damage";
            public const string Dot = "dot";
            public const string DotInterval = "dotInterval";
            public const string DotTime = "dotTime";
            public const string Eva = "eva";
            public const string FixDamage = "fixdamage";
            public const string Hp = "hp";
            public const string HpCon = "hpCon";
            public const string ItemCon = "itemCon";
            public const string ItemConNo = "itemConNo";
            public const string Jump = "jump";
            public const string LtX = "lt/x";
            public const string LtY = "lt/y";
            public const string Mad = "mad";
            public const string Mastery = "mastery";
            public const string Mdd = "mdd";
            public const string MobCount = "mobCount";
            public const string MoneyCon = "moneyCon";
            public const string Mp = "mp";
            public const string MpCon = "mpCon";
            public const string Pad = "pad";
            public const string Pdd = "pdd";
            public const string Prop = "prop";
            public const string Range = "range";
            public const string RbX = "rb/x";
            public const string RbY = "rb/y";
            public const string Speed = "speed";
            public const string SubProp = "subProp";
            public const string SubTime = "subTime";
            public const string Time = "time";
            public const string X = "x";
            public const string Y = "y";
            public const string Z = "z";
        }
        public static class Icon
        {
            public const string Disabled = "iconDisabled";
            public const string MouseOver = "iconMouseOver";
            public const string Standard = "icon";
        }
        public static class ReqEntry
        {
            public const string Id = "id";
            public const string Level = "level";
        }
    }
    public static class StringKeys
    {
        public const string Autodesc = "autodesc";
        public const string CashImg = "Cash.img";
        public const string Catch = "catch";
        public const string ConsumeImg = "Consume.img";
        public const string D0 = "d0";
        public const string D1 = "d1";
        public const string Detail = "detail";
        public const string Dialogue = "dialogue";
        public const string EqpImg = "Eqp.img";
        public const string EtcImg = "Etc.img";
        public const string FamiliarImg = "Familiar.img";
        public const string Func = "func";
        public const string InsImg = "Ins.img";
        public const string JobImg = "Job.img";
        public const string MapImg = "Map.img";
        public const string MobImg = "Mob.img";
        public const string MonsterBookImg = "Monster Book.img";
        public const string MonsterBookImgAlt = "MonsterBook";
        public const string NpcImg = "Npc.img";
        public const string PetImg = "Pet.img";
        public const string Root = "String";
        public const string SkillHint = "h";
        public const string SkillImg = "Skill.img";
        public const string SpecialImg = "Special.img";
        public const string Story = "Story";
        public const string StoryImg = "Story.img";
    }
    public static class UiKeys
    {
        public static class Basic
        {
            public const string Checkbox = "Basic.img/Check";
            public const string Cursor = "Basic.img/Cursor";
        }
        public static class ButtonState
        {
            public const string Disabled = "disabled";
            public const string MouseOver = "mouseOver";
            public const string Normal = "normal";
            public const string Pressed = "pressed";
        }
        public static class Canvas
        {
            public const string Origin = "origin";
        }
        public static class Channel
        {
            public const string Background = "backgrnd";
            public const string BtCancel = "BtCancel";
            public const string BtChange = "BtChange";
            public const string Root = "Channel";
        }
        public static class Login
        {
            public static class CharSelect
            {
                public const string BtDelete = "BtDelete";
                public const string BtNew = "BtNew";
                public const string BtSelect = "BtSelect";
                public const string CharInfo = "charInfo";
                public const string CharInfo1 = "charInfo1";
                public const string Root = "CharSelect";
            }
            public static class Common
            {
                public const string Frame = "frame";
                public const string Grade = "grade";
                public const string Root = "Common";
            }
            public static class NewChar
            {
                public const string BtCheck = "BtCheck";
                public const string BtLeft = "BtLeft";
                public const string BtNo = "BtNo";
                public const string BtRight = "BtRight";
                public const string BtYes = "BtYes";
                public const string CharName = "charName";
                public const string CharSet = "charSet";
                public const string Root = "NewChar";
            }
            public static class Title
            {
                public const string BtHomePage = "BtHomePage";
                public const string BtLogin = "BtLogin";
                public const string BtLoginIdLost = "BtLoginIDLost";
                public const string BtLoginIdSave = "BtLoginIDSave";
                public const string BtNew = "BtNew";
                public const string BtPasswdLost = "BtPasswdLost";
                public const string BtQuit = "BtQuit";
                public const string CheckChecked = "check/1";
                public const string CheckUnchecked = "check/0";
                public const string Id = "ID";
                public const string Pw = "PW";
                public const string Root = "Title";
                public const string Signboard = "signboard";
            }
            public static class WorldSelect
            {
                public const string BtGoWorld = "BtGoworld";
                public const string BtViewAll = "BtViewAll";
                public const string BtViewChoice = "BtViewChoice";
                public const string BtWorldPrefix = "BtWorld";
                public const string ChBackground = "chBackgrn";
                public const string Root = "WorldSelect";
            }
        }
        public static class MiniMap
        {
            public const string BtMaximize = "BtMaximize";
            public const string BtMinimize = "BtMinimize";
            public const string BtWorldMap = "BtWorldMap";
            public const string Root = "UIWindow2.img/MiniMap";
            public const string SimpleFrameRoot = "UIWindow2.img/MiniMapSimpleMode/Window";
            public const string SimpleNormal = "Normal";
            public static class SimpleFrame
            {
                public const string DownCenter = "DownCenter";
                public const string DownLeft = "DownLeft";
                public const string DownRight = "DownRight";
                public const string MiddleLeft = "MiddleLeft";
                public const string MiddleRight = "MiddleRight";
                public const string UpCenter = "UpCenter";
                public const string UpLeft = "UpLeft";
                public const string UpRight = "UpRight";
            }
        }
        public static class StatusBar
        {
            public const string CooltimePrefix = "cooltime";
            public const string LvNumber = "lvNumber";
            public const string MainBar = "StatusBar2.img/mainBar";
            public static class Buttons
            {
                public const string BtCashShop = "BtCashShop";
                public const string BtChannel = "BtChannel";
                public const string BtCharacter = "BtCharacter";
                public const string BtChat = "BtChat";
                public const string BtClaim = "BtClaim";
                public const string BtEquip = "BtEquip";
                public const string BtInven = "BtInven";
                public const string BtKeysetting = "BtKeysetting";
                public const string BtMTS = "BtMTS";
                public const string BtMenu = "BtMenu";
                public const string BtQuest = "BtQuest";
                public const string BtSkill = "BtSkill";
                public const string BtStat = "BtStat";
                public const string BtSystem = "BtSystem";
                public const string ChatClose = "chatClose";
                public const string ChatOpen = "chatOpen";
            }
            public static class ChatTab
            {
                public const string All = "all";
                public const string Association = "association";
                public const string Expedition = "expedition";
                public const string Friend = "friend";
                public const string Guild = "guild";
                public const string Party = "party";
                public const string Root = "StatusBar2.img/chat/Tap";
            }
            public static class Gauge
            {
                public const string Center = "1";
                public const string Exp = "gaugeEXP";
                public const string Hp = "gaugeHP";
                public const string Left = "0";
                public const string Mp = "gaugeMP";
                public const string Right = "2";
            }
        }
    }
    public static class WzDefaults
    {
        public const int AllJobs = 0;
        public const int BackgroundBackZBase = -100000;
        public const int BackgroundFrontZBase = 1200000;
        public const int BeginnerOnly = -1;
        public const int DefaultFrameDelay = 100;
        public const int DefaultMobFrameDelay = 120;
        public const int DefaultNpcFrameDelay = 180;
        public const int DefaultPercent = 100;
        public const int DefaultReactorFrameDelay = 100;
        public const int GenderBoth = 2;
        public const int InfiniteDurability = -1;
        public const int MaxDefenseRate = 100;
        public const int MaxMobDamage = 29999;
        public const int MobDefaultLevel = 1;
        public const int MobSkillHpBelowDefault = 50;
        public const int MobSkillUnlimitedTargets = -1;
        public const int MobSpeakHpDefault = 50;
        public const int MobSpeakMpDefault = 0;
        public const int MobSpeedOffset = 100;
        public const int NoTargetMap = 999999999;
        public const int NpcDefaultSpeed = 70;
        public const int NpcScriptDefaultEndDate = 20790101;
        public const int NpcScriptDefaultStartDate = 19000101;
        public const int PackedDateMonthMultiplier = 100;
        public const int PackedDateYearMultiplier = 10000;
        public const int PortalSpriteZOrder = 999999;
        public const int ReturnToTown = -1;
        public const int SameMap = 999999999;
        public const int SkinMaxId = 2011;
        public const int SkinMinId = 2000;
        public const int SpeedMax = 140;
        public const int SpeedMin = 0;
        public static int EncodePackedDate(System.DateTime date) { }
        public static string? FormatPackedDate(int packedDate) { }
    }
    public static class WzNodeNavigator
    {
        public static System.Collections.Generic.IReadOnlyDictionary<string, Duey.Abstractions.IDataNode> BuildItemLookup(Duey.Abstractions.IDataNode categoryNode) { }
        public static Duey.Abstractions.IDataNode? FindChildByIds(Duey.Abstractions.IDataNode root, System.ReadOnlySpan<string> ids) { }
        public static Duey.Abstractions.IDataNode? FindChildByIds(Duey.Abstractions.IDataNode root, string id) { }
        public static Duey.Abstractions.IDataNode? FindItemNode(Duey.Abstractions.IDataNode categoryNode, int id) { }
        public static Duey.Abstractions.IDataNode? FindMobImgNode(Duey.Abstractions.IDataNode mobRoot, int mobId) { }
        public static Duey.Abstractions.IDataNode? FindNpcImgNode(Duey.Abstractions.IDataNode npcRoot, int npcId) { }
        public static Duey.Abstractions.IDataNode? GetChild(Duey.Abstractions.IDataNode root, [System.Runtime.CompilerServices.ParamCollection] [System.Runtime.CompilerServices.ScopedRef] System.ReadOnlySpan<string> names) { }
        public static Duey.Abstractions.IDataNode? GetChild(Duey.Abstractions.IDataNode root, string name) { }
        public static Duey.Abstractions.IDataNode? GetChild(Duey.Abstractions.IDataNode root, string name1, string name2) { }
        public static Duey.Abstractions.IDataNode? GetChild(Duey.Abstractions.IDataNode root, string name1, string name2, string name3) { }
        public static Duey.Abstractions.IDataNode? GetItemNodeCached(System.Collections.Concurrent.ConcurrentDictionary<string, System.Lazy<System.Collections.Generic.Dictionary<string, Duey.Abstractions.IDataNode>>> cache, Duey.Abstractions.IDataNode categoryNode, string categoryName, int id) { }
        public static Duey.Abstractions.IDataNode? GetWzRoot(Duey.Abstractions.IDataNode? package, string childName) { }
        public static bool IsNxNode(Duey.Abstractions.IDataNode node) { }
        public static bool MatchesNodeName(System.ReadOnlySpan<char> nodeName, System.ReadOnlySpan<char> id) { }
        public static int? ResolveLinkValue(Duey.Abstractions.IDataNode linkNode) { }
        public static Duey.Abstractions.IDataNode ResolveMobLink(Duey.Abstractions.IDataNode primaryRoot, Duey.Abstractions.IDataNode mobNode, System.Collections.Generic.IReadOnlyList<Duey.Abstractions.IDataNode> allMobRoots) { }
        public static Duey.Abstractions.IDataNode ResolveNpcLink(Duey.Abstractions.IDataNode npcRoot, Duey.Abstractions.IDataNode npcNode) { }
        public static System.Collections.Generic.IReadOnlyList<Duey.Abstractions.IDataNode> SafeEnumerateChildren(Duey.Abstractions.IDataNode node, Microsoft.Extensions.Logging.ILogger logger) { }
        [return: System.Runtime.CompilerServices.TupleElementNames(new string[] {
                "Nodes",
                "Aborted"})]
        public static System.ValueTuple<System.Collections.Generic.IReadOnlyList<Duey.Abstractions.IDataNode>, bool> SafeEnumerateChildrenCounted(Duey.Abstractions.IDataNode node, Microsoft.Extensions.Logging.ILogger logger) { }
        public static string TrimImgSuffix(string nodeName) { }
        public static bool TryGetMapId(string name, out int id) { }
        public static string? TryResolveString(Duey.Abstractions.IDataNode? node) { }
        public static bool TryResolveVector(Duey.Abstractions.IDataNode node, out int x, out int y) { }
    }
    public sealed class WzNodeNavigatorAdapter : Maple.WzSchema.IWzNodeNavigator
    {
        public WzNodeNavigatorAdapter(Microsoft.Extensions.Logging.ILogger<Maple.WzSchema.WzNodeNavigatorAdapter> logger) { }
        public System.Collections.Generic.IReadOnlyDictionary<string, Duey.Abstractions.IDataNode> BuildItemLookup(Duey.Abstractions.IDataNode categoryNode) { }
        public Duey.Abstractions.IDataNode? FindChildByIds(Duey.Abstractions.IDataNode root, string id) { }
        public Duey.Abstractions.IDataNode? FindItemNode(Duey.Abstractions.IDataNode categoryNode, int id) { }
        public Duey.Abstractions.IDataNode? FindMobImgNode(Duey.Abstractions.IDataNode mobRoot, int mobId) { }
        public Duey.Abstractions.IDataNode? FindNpcImgNode(Duey.Abstractions.IDataNode npcRoot, int npcId) { }
        public Duey.Abstractions.IDataNode? GetChild(Duey.Abstractions.IDataNode root, string name) { }
        public Duey.Abstractions.IDataNode? GetChild(Duey.Abstractions.IDataNode root, string name1, string name2) { }
        public Duey.Abstractions.IDataNode? GetChild(Duey.Abstractions.IDataNode root, string name1, string name2, string name3) { }
        public Duey.Abstractions.IDataNode? GetWzRoot(Duey.Abstractions.IDataNode? package, string childName) { }
        public bool IsNxNode(Duey.Abstractions.IDataNode node) { }
        public Duey.Abstractions.IDataNode ResolveMobLink(Duey.Abstractions.IDataNode primaryRoot, Duey.Abstractions.IDataNode mobNode, System.Collections.Generic.IReadOnlyList<Duey.Abstractions.IDataNode> allMobRoots) { }
        public Duey.Abstractions.IDataNode ResolveNpcLink(Duey.Abstractions.IDataNode npcRoot, Duey.Abstractions.IDataNode npcNode) { }
        public System.Collections.Generic.IReadOnlyList<Duey.Abstractions.IDataNode> SafeEnumerateChildren(Duey.Abstractions.IDataNode node) { }
        [return: System.Runtime.CompilerServices.TupleElementNames(new string[] {
                "Nodes",
                "Aborted"})]
        public System.ValueTuple<System.Collections.Generic.IReadOnlyList<Duey.Abstractions.IDataNode>, bool> SafeEnumerateChildrenCounted(Duey.Abstractions.IDataNode node) { }
        public string TrimImgSuffix(string nodeName) { }
        public bool TryGetMapId(string name, out int id) { }
    }
    public static class WzPath
    {
        public static string ItemImg(Maple.StrongId.ItemTemplateId id) { }
        public static string MapGroup(Maple.StrongId.FieldTemplateId mapId) { }
        public static string MapImg(Maple.StrongId.FieldTemplateId mapId) { }
        public static string MobImg(Maple.StrongId.MobTemplateId mobId) { }
        public static string NpcImg(Maple.StrongId.NpcTemplateId npcId) { }
        public static string ReactorImg(Maple.StrongId.ReactorTemplateId reactorId) { }
        public static string SkillJobImg(Maple.StrongId.JobId jobId) { }
    }
    public readonly struct WzPresenceFlag : System.IEquatable<Maple.WzSchema.WzPresenceFlag>
    {
        public WzPresenceFlag(string Key) { }
        public string Key { get; init; }
        public override string ToString() { }
        public static string op_Implicit(Maple.WzSchema.WzPresenceFlag flag) { }
    }
    public static class WzPropertyExtensions
    {
        public static bool Resolve(this Duey.Abstractions.IDataNode parent, Maple.WzSchema.WzPresenceFlag flag) { }
        public static float Resolve(this Duey.Abstractions.IDataNode parent, Maple.WzSchema.WzProperty<float> prop) { }
        public static int Resolve(this Duey.Abstractions.IDataNode parent, Maple.WzSchema.WzProperty<int> prop) { }
        public static string? Resolve(this Duey.Abstractions.IDataNode parent, Maple.WzSchema.WzProperty<string?> prop) { }
        public static bool Resolve(this System.Collections.Generic.IReadOnlyDictionary<string, Duey.Abstractions.IDataNode> idx, Maple.WzSchema.WzPresenceFlag flag) { }
        public static float Resolve(this System.Collections.Generic.IReadOnlyDictionary<string, Duey.Abstractions.IDataNode> idx, Maple.WzSchema.WzProperty<float> prop) { }
        public static int Resolve(this System.Collections.Generic.IReadOnlyDictionary<string, Duey.Abstractions.IDataNode> idx, Maple.WzSchema.WzProperty<int> prop) { }
        public static string? Resolve(this System.Collections.Generic.IReadOnlyDictionary<string, Duey.Abstractions.IDataNode> idx, Maple.WzSchema.WzProperty<string?> prop) { }
        public static float? ResolveIfPresent(this Duey.Abstractions.IDataNode parent, Maple.WzSchema.WzProperty<float> prop) { }
        public static int? ResolveIfPresent(this Duey.Abstractions.IDataNode parent, Maple.WzSchema.WzProperty<int> prop) { }
        public static float? ResolveIfPresent(this System.Collections.Generic.IReadOnlyDictionary<string, Duey.Abstractions.IDataNode> idx, Maple.WzSchema.WzProperty<float> prop) { }
        public static int? ResolveIfPresent(this System.Collections.Generic.IReadOnlyDictionary<string, Duey.Abstractions.IDataNode> idx, Maple.WzSchema.WzProperty<int> prop) { }
        public static float? ResolveNonZero(this Duey.Abstractions.IDataNode parent, Maple.WzSchema.WzProperty<float> prop) { }
        public static int? ResolveNonZero(this Duey.Abstractions.IDataNode parent, Maple.WzSchema.WzProperty<int> prop) { }
        public static float? ResolveNonZero(this System.Collections.Generic.IReadOnlyDictionary<string, Duey.Abstractions.IDataNode> idx, Maple.WzSchema.WzProperty<float> prop) { }
        public static int? ResolveNonZero(this System.Collections.Generic.IReadOnlyDictionary<string, Duey.Abstractions.IDataNode> idx, Maple.WzSchema.WzProperty<int> prop) { }
        public static short ResolveShort(this Duey.Abstractions.IDataNode parent, Maple.WzSchema.WzProperty<int> prop) { }
        public static short ResolveShort(this System.Collections.Generic.IReadOnlyDictionary<string, Duey.Abstractions.IDataNode> idx, Maple.WzSchema.WzProperty<int> prop) { }
    }
    public readonly struct WzProperty<T> : System.IEquatable<Maple.WzSchema.WzProperty<T>>
    {
        public WzProperty(string Key, T Default) { }
        public T Default { get; init; }
        public string Key { get; init; }
        public override string ToString() { }
        public static string op_Implicit(Maple.WzSchema.WzProperty<T> prop) { }
    }
    public static class WzSkinHelper
    {
        public static int GetSkinHeadTemplateId(int bodyTemplateId) { }
        public static int NormalizeSkinTemplateId(int skinId) { }
    }
}
```
