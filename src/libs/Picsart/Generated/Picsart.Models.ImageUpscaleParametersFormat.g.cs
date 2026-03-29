
#nullable enable

namespace Picsart
{
    /// <summary>
    /// Optionally select one of the output image formats (JPG is chosen if left blank). Options are as follows:<br/>
    ///   * JPG<br/>
    ///   * PNG<br/>
    ///   * WEBP<br/>
    /// Default Value: JPG
    /// </summary>
    public enum ImageUpscaleParametersFormat
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
    public static class ImageUpscaleParametersFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageUpscaleParametersFormat value)
        {
            return value switch
            {
                ImageUpscaleParametersFormat.Jpg => "JPG",
                ImageUpscaleParametersFormat.Png => "PNG",
                ImageUpscaleParametersFormat.Webp => "WEBP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageUpscaleParametersFormat? ToEnum(string value)
        {
            return value switch
            {
                "JPG" => ImageUpscaleParametersFormat.Jpg,
                "PNG" => ImageUpscaleParametersFormat.Png,
                "WEBP" => ImageUpscaleParametersFormat.Webp,
                _ => null,
            };
        }
    }
}