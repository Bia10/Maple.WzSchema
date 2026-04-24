namespace Maple.WzSchema;

/// <summary>
/// Arithmetic helpers for skin template ID derivation.
/// Skin IDs 0–11 are short-form aliases; Character.wz stores them as 2000–2011.
/// </summary>
public static class WzSkinHelper
{
    private const int TemplateBaseId = 2000;
    private const int HeadTemplateOffset = 10000;

    /// <summary>
    /// Normalizes a skin ID to its full Character.wz template ID.
    /// Short-form IDs (0–11) are shifted to the 2000–2011 range; IDs already in that range
    /// are returned unchanged.
    /// </summary>
    public static int NormalizeSkinTemplateId(int skinId) => skinId < TemplateBaseId ? skinId + TemplateBaseId : skinId;

    /// <summary>
    /// Returns the head template ID that pairs with the given body template ID.
    /// Character.wz head images are stored at body ID + 10000 (e.g. body 2000 → head 12000).
    /// </summary>
    public static int GetSkinHeadTemplateId(int bodyTemplateId) => bodyTemplateId + HeadTemplateOffset;
}
