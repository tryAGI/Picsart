
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
    public enum ImageUpscaleUltraParametersFormat
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
    public static class ImageUpscaleUltraParametersFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageUpscaleUltraParametersFormat value)
        {
            return value switch
            {
                ImageUpscaleUltraParametersFormat.Jpg => "JPG",
                ImageUpscaleUltraParametersFormat.Png => "PNG",
                ImageUpscaleUltraParametersFormat.Webp => "WEBP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageUpscaleUltraParametersFormat? ToEnum(string value)
        {
            return value switch
            {
                "JPG" => ImageUpscaleUltraParametersFormat.Jpg,
                "PNG" => ImageUpscaleUltraParametersFormat.Png,
                "WEBP" => ImageUpscaleUltraParametersFormat.Webp,
                _ => null,
            };
        }
    }
}