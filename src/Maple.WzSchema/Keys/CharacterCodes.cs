namespace Maple.WzSchema;

/// <summary>Numeric codes and slot indices for character compositing.</summary>
public static class CharacterCodes
{
    /// <summary>
    /// Equipment slot indices into <c>AvatarLook.anHairEquip[60]</c>.
    /// Slots 12+ are rings/medals/pendants loaded dynamically when non-zero.
    /// </summary>
    public enum EquipSlot
    {
        Body = 0,
        Cap = 1,

        /// <summary>
        /// Face accessory slot.
        /// The face sprite itself is stored in <c>AvatarLook.nFace</c>, not here.
        /// </summary>
        FaceAccessory = 2,

        /// <summary>Earring slot.</summary>
        Earring = 3,

        /// <summary>Eye accessory slot.</summary>
        EyeAccessory = 4,

        Coat = 5,
        Pants = 6,
        Shoes = 7,

        /// <summary>Gloves slot.</summary>
        Gloves = 8,

        /// <summary>Cape slot.</summary>
        Cape = 9,

        /// <summary>Main weapon slot.</summary>
        Weapon = 10,

        /// <summary>Sub-weapon / shield slot.</summary>
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

    /// <summary>Default equipment item IDs for newly created characters.</summary>
    public static class DefaultItems
    {
        public const int CoatMale = 1040036;
        public const int CoatFemale = 1041046;
        public const int PantsMale = 1060026;
        public const int PantsFemale = 1061039;
    }
}
