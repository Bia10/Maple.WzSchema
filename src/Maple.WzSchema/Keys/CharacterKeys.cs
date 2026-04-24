using System.Collections.Frozen;

namespace Maple.WzSchema;

/// <summary>
/// WZ node key strings for the Character domain (Character.wz / Character.nx).
/// Covers archive categories, action/pose node names, common part nodes, and
/// frame metadata filters shared by sprite and compositing services.
/// </summary>
public static class CharacterKeys
{
    public const string Root = "Character";
    public static readonly string[] RootNodes = [Root];
    public static readonly string[] ZMapNodes = ["zmap", "ZMap", "Zmap"];

    public static class Category
    {
        public const string Hair = "Hair";
        public const string Face = "Face";

        /// <summary>
        /// Equipment category folder names present in the Character.wz/nx archive.
        /// Used to enumerate all possible equipment nodes.
        /// </summary>
        public static readonly string[] EquipCategories =
        [
            "Accessory",
            "Cap",
            "Cape",
            "Coat",
            "Dragon",
            "Earring",
            "Eye",
            "Face",
            "Glove",
            "Hair",
            "Longcoat",
            "Mechanic",
            "Pants",
            "PetEquip",
            "Ring",
            "Shield",
            "Shoes",
            "TamingMob",
            "Weapon",
        ];
    }

    public static class Action
    {
        public const string Default = CommonKeys.Default;
        public const string Stand1 = "stand1";
        public const string Stand2 = "stand2";
        public const string Alert = "alert";
        public const string Walk1 = "walk1";
        public const string Attack1 = "attack1";
        public const string Jump = "jump";
        public const string Prone = "prone";
        public const string Sit = "sit";

        public const string BackHair = "backHair";
        public const string CapDefault = "capDefault";
        public const string CapBelowBody = "capBelowBody";

        public const string Blink = "blink";
        public const string Troubled = "troubled";
        public const string Smile = "smile";
        public const string Cry = "cry";
        public const string Angry = "angry";
        public const string Bewildered = "bewildered";
        public const string Stunned = "stunned";
        public const string Hit = "hit";

        public static readonly string[] SkinPreviewPoses = [Stand1, Stand2, Alert, Default];

        public static readonly string[] SkinAnimationPoses = [Stand1, Walk1, Attack1, Stand2, Alert, Jump, Prone, Sit];

        public static readonly string[] HairSequenceNames = [Default, BackHair, CapDefault, CapBelowBody];

        public static readonly string[] FaceExpressions =
        [
            Default,
            Blink,
            Troubled,
            Smile,
            Cry,
            Angry,
            Bewildered,
            Stunned,
            Hit,
        ];
    }

    public static class Part
    {
        public const string Body = "body";
        public const string Head = "head";
        public const string Face = "face";
        public const string Hair = "hair";

        public static readonly string[] HairPartNames = [Hair, "hairOverHead", "hairBelowBody", "backHair"];
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

    public static class Anchor
    {
        public const string Brow = "brow";
        public const string Nose = "nose";
        public const string Neck = "neck";
        public const string Navel = "navel";
        public const string Hand = "hand";
        public const string HandMove = "handMove";
        public const string Muzzle = "muzzle";
    }

    public static class Equip
    {
        public const string Male = "male";
        public const string Female = "female";
    }

    public static class Frame
    {
        private static readonly FrozenSet<string> s_metadataNodes = FrozenSet.Create(
            StringComparer.OrdinalIgnoreCase,
            CommonKeys.Info,
            CommonKeys.Origin,
            CommonKeys.Map,
            CommonKeys.Z,
            CommonKeys.Delay
        );

        private static readonly FrozenSet<string> s_bodyMetadataNodes = FrozenSet.Create(
            StringComparer.OrdinalIgnoreCase,
            CommonKeys.Info,
            CommonKeys.Origin,
            CommonKeys.Map,
            CommonKeys.Z,
            CommonKeys.Delay,
            CommonKeys.Seat
        );

        public static bool IsMetadataNode(string nodeName) => s_metadataNodes.Contains(nodeName);

        public static bool IsBodyMetadataNode(string nodeName) => s_bodyMetadataNodes.Contains(nodeName);

        // String constants for frame child node navigation (used by client-side loaders)

        /// <summary>Body canvas sub-node (skin layers).</summary>
        public const string Body = "body";

        /// <summary>Head canvas sub-node.</summary>
        public const string Head = "head";

        /// <summary>Attachment-point map sub-node.</summary>
        public const string Map = "map";

        /// <summary>Info metadata sub-node.</summary>
        public const string Info = "info";

        /// <summary>Z-layer name sub-node.</summary>
        public const string ZMap = "z";

        /// <summary>Sound-effect node on audio-event frames.</summary>
        public const string Sfx = "sSfx";
    }

    // ── Extended action set (client compositing / rendering) ──────────────────
    /// <summary>
    /// Extended character animation action keys used by compositing and avatar loaders.
    /// Includes all combat/movement actions from the PDB symbol table.
    /// For admin-panel preview poses, see <see cref="Action"/>.
    /// </summary>
    public static class Actions
    {
        public const string Stand1 = "stand1";
        public const string Stand2 = "stand2";
        public const string Walk1 = "walk1";
        public const string Walk2 = "walk2";
        public const string Jump = "jump";
        public const string Alert = "alert";
        public const string Fly1 = "fly1";
        public const string Ladder = "ladderMoveL";
        public const string Rope = "ropeMove";
        public const string Prone = "prone";
        public const string ProneStab = "proneStab";
        public const string Sit = "sit";
        public const string Dead = "dead";
        public const string Heal = "heal";
        public const string Summon = "summon";
        public const string Dance = "dance";
        public const string Attack1 = "attack1";
        public const string Attack2 = "attack2";
        public const string Attack3 = "attack3";
        public const string StabO1 = "stabO1";
        public const string StabO2 = "stabO2";
        public const string SwingO1 = "swingO1";
        public const string SwingO2 = "swingO2";
        public const string SwingO3 = "swingO3";
        public const string Shoot1 = "shoot1";
        public const string Shoot2 = "shoot2";
        public const string ShootF = "shootF";
        public const string ThrowO1 = "throwO1";
    }

    // ── Equipment folder names (Character.wz sub-folders) ─────────────────────
    /// <summary>
    /// Equipment sub-folder names under <c>Character.wz/</c>.
    /// Used by avatar compositing to locate equip sprite images.
    /// </summary>
    public static class Folders
    {
        public const string Cap = "Cap";
        public const string Coat = "Coat";
        public const string Pants = "Pants";
        public const string Shoes = "Shoes";
        public const string Glove = "Glove";
        public const string Shield = "Shield";
        public const string Cape = "Cape";
        public const string Longcoat = "Longcoat";
        public const string Weapon = "Weapon";
        public const string Accessory = "Accessory";
        public const string Face = "Face";
        public const string Hair = "Hair";
    }

    // ── Z-order table ─────────────────────────────────────────────────────────
    /// <summary>
    /// Canonical z-order string table — 36 entries (index 0 = furthest back).
    /// Source: PDB-verified <c>m_aZMapKey[]</c> from <c>CCharacterLook</c>.
    /// Z &lt; <see cref="FaceZIndex"/> → <c>pCanvasUnderFace</c>;
    /// Z &gt;= <see cref="FaceZIndex"/> → <c>pCanvasOverFace</c>.
    /// </summary>
    public static readonly string[] ZOrderTable =
    [
        "capeBackHead", // 0
        "capeBack", // 1
        "backDefault", // 2
        "weaponBelowBody", // 3
        "capeOverBody", // 4
        "pants", // 5
        "pantsOverShoes", // 6
        "shoeBelowPants", // 7
        "shoes", // 8
        "body", // 9  ← navel = canonical (0,0)
        "coat", // 10
        "armBelowHead", // 11
        "arm", // 12
        "armOverHead", // 13
        "handBelowWeapon", // 14
        "weapon", // 15
        "handOverWeapon", // 16
        "glove", // 17
        "weaponOverHand", // 18
        "gloveWrist", // 19
        "weaponOverGlove", // 20
        "face", // 21 ← SPLIT POINT
        "head", // 22
        "capeBelowHead", // 23
        "capeOverHead", // 24
        "accessoryEar", // 25
        "accessoryFace", // 26
        "accessoryEye", // 27
        "hair", // 28
        "hairBelowBody", // 29
        "hairBelowHead", // 30
        "hairBelowCap", // 31
        "hairOverHead", // 32
        "hairOverCap", // 33
        "capAttr", // 34
        "cap", // 35
    ];

    /// <summary>Z-index of the <c>face</c> layer (split point for under/over face canvas).</summary>
    public const int FaceZIndex = 21;

    // ── WZ path helpers ───────────────────────────────────────────────────────

    /// <summary>File prefix for body skin sprites: <c>Character.wz/00002{skinId:D3}.img</c>.</summary>
    public const string BodyPathPrefix = "00002";

    /// <summary>File prefix for head skin sprites: <c>Character.wz/00012{skinId:D3}.img</c>.</summary>
    public const string HeadPathPrefix = "00012";

    /// <summary>Sub-node key for hair default animation clips.</summary>
    public const string HairDefault = "default";

    /// <summary>Default face expression key.</summary>
    public const string FaceExpressionDefault = "default";
}
