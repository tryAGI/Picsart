
#nullable enable

namespace Picsart
{
    /// <summary>
    /// Optionally select one of the image formats. Options are as follows:<br/>
    ///   * JPG<br/>
    ///   * PNG<br/>
    ///   * WEBP<br/>
    /// Default Value: JPG
    /// </summary>
    public enum ImageSelectiveBlurParametersFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Jpg,
        /// <summary>
        /// 
        /// </summary>
        Png,
        /// <summary>
        /// 
        /// </summary>
        Webp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageSelectiveBlurParametersFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageSelectiveBlurParametersFormat value)
        {
            return value switch
            {
                ImageSelectiveBlurParametersFormat.Jpg => "JPG",
                ImageSelectiveBlurParametersFormat.Png => "PNG",
                ImageSelectiveBlurParametersFormat.Webp => "WEBP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageSelectiveBlurParametersFormat? ToEnum(string value)
        {
            return value switch
            {
                "JPG" => ImageSelectiveBlurParametersFormat.Jpg,
                "PNG" => ImageSelectiveBlurParametersFormat.Png,
                "WEBP" => ImageSelectiveBlurParametersFormat.Webp,
                _ => null,
            };
        }
    }
}