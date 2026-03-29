
#nullable enable

namespace Picsart
{
    /// <summary>
    /// Optionally select one of the image formats (JPG is chosen if left blank). Options are as follows:<br/>
    ///   * JPG<br/>
    ///   * PNG<br/>
    ///   * WEBP<br/>
    /// Default Value: JPG
    /// </summary>
    public enum ImageUpscaleEnhanceParametersFormat
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
    public static class ImageUpscaleEnhanceParametersFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageUpscaleEnhanceParametersFormat value)
        {
            return value switch
            {
                ImageUpscaleEnhanceParametersFormat.Jpg => "JPG",
                ImageUpscaleEnhanceParametersFormat.Png => "PNG",
                ImageUpscaleEnhanceParametersFormat.Webp => "WEBP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageUpscaleEnhanceParametersFormat? ToEnum(string value)
        {
            return value switch
            {
                "JPG" => ImageUpscaleEnhanceParametersFormat.Jpg,
                "PNG" => ImageUpscaleEnhanceParametersFormat.Png,
                "WEBP" => ImageUpscaleEnhanceParametersFormat.Webp,
                _ => null,
            };
        }
    }
}