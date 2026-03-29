
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
    public enum ImageEffectsParametersFormat
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
    public static class ImageEffectsParametersFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageEffectsParametersFormat value)
        {
            return value switch
            {
                ImageEffectsParametersFormat.Jpg => "JPG",
                ImageEffectsParametersFormat.Png => "PNG",
                ImageEffectsParametersFormat.Webp => "WEBP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageEffectsParametersFormat? ToEnum(string value)
        {
            return value switch
            {
                "JPG" => ImageEffectsParametersFormat.Jpg,
                "PNG" => ImageEffectsParametersFormat.Png,
                "WEBP" => ImageEffectsParametersFormat.Webp,
                _ => null,
            };
        }
    }
}