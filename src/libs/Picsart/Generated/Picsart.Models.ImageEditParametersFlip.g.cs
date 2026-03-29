
#nullable enable

namespace Picsart
{
    /// <summary>
    /// Choose a way to flip the image.
    /// </summary>
    public enum ImageEditParametersFlip
    {
        /// <summary>
        /// 
        /// </summary>
        Horizontal,
        /// <summary>
        /// 
        /// </summary>
        Vertical,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageEditParametersFlipExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageEditParametersFlip value)
        {
            return value switch
            {
                ImageEditParametersFlip.Horizontal => "horizontal",
                ImageEditParametersFlip.Vertical => "vertical",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageEditParametersFlip? ToEnum(string value)
        {
            return value switch
            {
                "horizontal" => ImageEditParametersFlip.Horizontal,
                "vertical" => ImageEditParametersFlip.Vertical,
                _ => null,
            };
        }
    }
}