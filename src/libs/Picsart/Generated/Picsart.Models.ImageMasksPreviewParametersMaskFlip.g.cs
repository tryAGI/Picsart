
#nullable enable

namespace Picsart
{
    /// <summary>
    /// Choose a mask flip option. The choices are as follows.<br/>
    ///   * left<br/>
    ///   * right<br/>
    ///   * mirror horizontal<br/>
    ///   * mirror vertical<br/>
    ///   * turnaround
    /// </summary>
    public enum ImageMasksPreviewParametersMaskFlip
    {
        /// <summary>
        /// 
        /// </summary>
        Left,
        /// <summary>
        /// 
        /// </summary>
        MirrorHorizontal,
        /// <summary>
        /// 
        /// </summary>
        MirrorVertical,
        /// <summary>
        /// 
        /// </summary>
        Right,
        /// <summary>
        /// 
        /// </summary>
        Turnaround,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageMasksPreviewParametersMaskFlipExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageMasksPreviewParametersMaskFlip value)
        {
            return value switch
            {
                ImageMasksPreviewParametersMaskFlip.Left => "left",
                ImageMasksPreviewParametersMaskFlip.MirrorHorizontal => "mirror horizontal",
                ImageMasksPreviewParametersMaskFlip.MirrorVertical => "mirror vertical",
                ImageMasksPreviewParametersMaskFlip.Right => "right",
                ImageMasksPreviewParametersMaskFlip.Turnaround => "turnaround",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageMasksPreviewParametersMaskFlip? ToEnum(string value)
        {
            return value switch
            {
                "left" => ImageMasksPreviewParametersMaskFlip.Left,
                "mirror horizontal" => ImageMasksPreviewParametersMaskFlip.MirrorHorizontal,
                "mirror vertical" => ImageMasksPreviewParametersMaskFlip.MirrorVertical,
                "right" => ImageMasksPreviewParametersMaskFlip.Right,
                "turnaround" => ImageMasksPreviewParametersMaskFlip.Turnaround,
                _ => null,
            };
        }
    }
}