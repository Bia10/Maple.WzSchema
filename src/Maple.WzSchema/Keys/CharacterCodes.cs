namespace Maple.WzSchema;

/// <summary>
/// V95-verified numeric codes and slot indices for character compositing.
/// Source: PDB symbol table from <c>CCharacterLook</c> and <c>AvatarLook</c>.
/// </summary>
public static class CharacterCodes
{
    /// <summary>
    /// Equipment slot indices into <c>AvatarLook.anHairEquip[60]</c>.
    /// Source: V95 RE of <c>CActionMan::LoadCharacterAction</c> pseudocode.
    /// Slots 12+ are rings/medals/pendants loaded dynamically when non-zero.
    /// </summary>
    public enum EquipSlot
    {
        Body = 0,
        Cap = 1,

        /// <summary>
        /// Face accessory slot (sISlot "Fa"). Item category 101xxxx.
        /// NOTE: <c>LoadCharacterAction</c> always clears slot 2 to 0 —
        /// face accessories are excluded from the V95 compositing pipeline.
        /// The face sprite itself is stored in <c>AvatarLook.nFace</c>, not here.
        /// </summary>
        FaceAccessory = 2,

        /// <summary>Earring slot (sISlot "Er"). Item category 102xxxx. V95 RE: cleared if == 1022079.</summary>
        Earring = 3,

        /// <summary>Eye accessory slot (sISlot "Ay"). Item category 103xxxx. V95 RE: cleared if == 1032024.</summary>
        EyeAccessory = 4,

        Coat = 5,
        Pants = 6,
        Shoes = 7,

        /// <summary>Gloves slot (sISlot "Glv"). Item category 108xxxx. V95 RE: cleared if == 1082102.</summary>
        Gloves = 8,

        /// <summary>Cape slot (sISlot "Sr"). Item category 110xxxx. V95 RE: cleared if == 1102039.</summary>
        Cape = 9,

        /// <summary>Main weapon slot (sISlot "Wp"). V95 RE: cleared for vehicles and nAction==100.</summary>
        Weapon = 10,

        /// <summary>Sub-weapon / shield slot (sISlot "Su"). V95 RE: cleared when nWeaponStickerID matches sticker IDs.</summary>
        Shield = 11,

        // 12+ = rings, medals, pendants — loaded dynamically when non-zero
    }

    /// <summary>Skin tone IDs used in body/head WZ path construction.</summary>
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

    /// <summary>
    /// Face expression keys used in
    /// <c>Character.wz/{faceId:D8}.img/{expression}/{frameIndex}/</c>.
    /// </summary>
    public static class FaceExpression
    {
        public const string Default = "default";
        public const string Hit = "hit";
        public const string Smile = "smile";
        public const string Troubled = "troubled";
        public const string Cry = "cry";
        public const string Angry = "angry";
        public const string Bewildered = "bewildered";
        public const string Stunned = "stunned";
        public const string Blinking = "blink";
    }

    /// <summary>Default equipment item IDs for newly created characters (v95 GMS).</summary>
    public static class DefaultItems
    {
        public const int CoatMale = 1040036;
        public const int CoatFemale = 1041046;
        public const int PantsMale = 1060026;
        public const int PantsFemale = 1061039;
    }
}
