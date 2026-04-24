using System.Globalization;

namespace Maple.WzSchema;

/// <summary>
/// Sentinel and default values used in WZ data. Centralizes magic numbers
/// that mean "none", "same map", "all jobs", etc.
/// </summary>
public static class WzDefaults
{
    // Map sentinels — WZ sentinel value 999999999 means "no different map target" in all contexts.
    // returnMap=999999999 → no return portal; forcedReturn=999999999 → no forced redirect.
    public const int SameMap = 999999999;
    public const int NoTargetMap = SameMap;

    // Item sentinels
    public const int AllJobs = 0;
    public const int BeginnerOnly = -1;
    public const int GenderBoth = 2;
    public const int InfiniteDurability = -1;
    public const int ReturnToTown = -1;

    // Mob defaults
    public const int MobDefaultLevel = 1;

    /// <summary>
    /// Offset added to a mob's raw WZ speed to produce the client-facing speed value.
    /// Client speed = WZ speed + 100 (e.g. WZ speed 10 → client speed 110).
    /// </summary>
    public const int MobSpeedOffset = 100;

    // Mob skill level data defaults (PDB-confirmed)
    /// <summary>Default HP% threshold for mob skill activation (schema §1.5, C++ default = 50).</summary>
    public const int MobSkillHpBelowDefault = 50;

    /// <summary>Default max-targets for mob skills (-1 = unlimited, schema §1.5 C++ field nTargetUserCount).</summary>
    public const int MobSkillUnlimitedTargets = -1;

    // Mob speak defaults (PDB-confirmed, schema §1.4)
    /// <summary>Default HP% threshold for mob speak activation (schema §1.4, C++ field nHP = 50).</summary>
    public const int MobSpeakHpDefault = 50;

    /// <summary>Default MP threshold for mob speak activation (schema §1.4, C++ field nMP = 0).</summary>
    public const int MobSpeakMpDefault = 0;

    // Speak/probability defaults
    public const int DefaultPercent = 100;

    // Packed date encoding (YYYYMMDD)
    public const int PackedDateYearMultiplier = 10_000;
    public const int PackedDateMonthMultiplier = 100;
    public const int NpcScriptDefaultStartDate = 19000101;
    public const int NpcScriptDefaultEndDate = 20790101;

    // NPC defaults
    public const int NpcDefaultSpeed = 70;

    // Animation frame delay defaults (milliseconds)
    public const int DefaultFrameDelay = 100;
    public const int DefaultMobFrameDelay = 120;
    public const int DefaultNpcFrameDelay = 180;
    public const int DefaultReactorFrameDelay = 100;

    // Damage clamping
    public const int MaxMobDamage = 29999;
    public const int MaxDefenseRate = 100;
    public const int SpeedMin = 0;
    public const int SpeedMax = 140;

    // Character appearance defaults
    public const int SkinMinId = 2000;
    public const int SkinMaxId = 2011;

    // Map renderer sort layers
    public const int PortalSpriteZOrder = 999_999;
    public const int BackgroundFrontZBase = 1_200_000;
    public const int BackgroundBackZBase = -100_000;

    public static int EncodePackedDate(DateTime date) =>
        (date.Year * PackedDateYearMultiplier) + (date.Month * PackedDateMonthMultiplier) + date.Day;

    public static string? FormatPackedDate(int packedDate)
    {
        if (packedDate <= 0)
            return null;

        // Parse through DateTime to validate the encoded date is structurally correct
        // (e.g. rejects month=13, day=32). Returns the canonical "yyyyMMdd" string.
        // TryParseExact avoids throwing on corrupt but positive WZ packed dates (e.g. 19991399).
        return DateTime.TryParseExact(
            packedDate.ToString(CultureInfo.InvariantCulture),
            "yyyyMMdd",
            CultureInfo.InvariantCulture,
            DateTimeStyles.None,
            out DateTime date
        )
            ? date.ToString("yyyyMMdd", CultureInfo.InvariantCulture)
            : null;
    }
}
