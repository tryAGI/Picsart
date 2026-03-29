
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public enum ImageMasksPreviewParametersMaskItem
    {
        /// <summary>
        /// 
        /// </summary>
        Lace1,
        /// <summary>
        /// 
        /// </summary>
        Lace2,
        /// <summary>
        /// 
        /// </summary>
        Lace3,
        /// <summary>
        /// 
        /// </summary>
        Lace4,
        /// <summary>
        /// 
        /// </summary>
        Prsm10,
        /// <summary>
        /// 
        /// </summary>
        Prsm3,
        /// <summary>
        /// 
        /// </summary>
        Prsm9,
        /// <summary>
        /// 
        /// </summary>
        Rpl3,
        /// <summary>
        /// 
        /// </summary>
        Rpl5,
        /// <summary>
        /// 
        /// </summary>
        Shdw17,
        /// <summary>
        /// 
        /// </summary>
        Shdw2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageMasksPreviewParametersMaskItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageMasksPreviewParametersMaskItem value)
        {
            return value switch
            {
                ImageMasksPreviewParametersMaskItem.Lace1 => "lace1",
                ImageMasksPreviewParametersMaskItem.Lace2 => "lace2",
                ImageMasksPreviewParametersMaskItem.Lace3 => "lace3",
                ImageMasksPreviewParametersMaskItem.Lace4 => "lace4",
                ImageMasksPreviewParametersMaskItem.Prsm10 => "prsm10",
                ImageMasksPreviewParametersMaskItem.Prsm3 => "prsm3",
                ImageMasksPreviewParametersMaskItem.Prsm9 => "prsm9",
                ImageMasksPreviewParametersMaskItem.Rpl3 => "rpl3",
                ImageMasksPreviewParametersMaskItem.Rpl5 => "rpl5",
                ImageMasksPreviewParametersMaskItem.Shdw17 => "shdw17",
                ImageMasksPreviewParametersMaskItem.Shdw2 => "shdw2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageMasksPreviewParametersMaskItem? ToEnum(string value)
        {
            return value switch
            {
                "lace1" => ImageMasksPreviewParametersMaskItem.Lace1,
                "lace2" => ImageMasksPreviewParametersMaskItem.Lace2,
                "lace3" => ImageMasksPreviewParametersMaskItem.Lace3,
                "lace4" => ImageMasksPreviewParametersMaskItem.Lace4,
                "prsm10" => ImageMasksPreviewParametersMaskItem.Prsm10,
                "prsm3" => ImageMasksPreviewParametersMaskItem.Prsm3,
                "prsm9" => ImageMasksPreviewParametersMaskItem.Prsm9,
                "rpl3" => ImageMasksPreviewParametersMaskItem.Rpl3,
                "rpl5" => ImageMasksPreviewParametersMaskItem.Rpl5,
                "shdw17" => ImageMasksPreviewParametersMaskItem.Shdw17,
                "shdw2" => ImageMasksPreviewParametersMaskItem.Shdw2,
                _ => null,
            };
        }
    }
}