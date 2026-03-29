
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
    public enum ImageAIEffectsParametersFormat
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
    public static class ImageAIEffectsParametersFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageAIEffectsParametersFormat value)
        {
            return value switch
            {
                ImageAIEffectsParametersFormat.Jpg => "JPG",
                ImageAIEffectsParametersFormat.Png => "PNG",
                ImageAIEffectsParametersFormat.Webp => "WEBP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageAIEffectsParametersFormat? ToEnum(string value)
        {
            return value switch
            {
                "JPG" => ImageAIEffectsParametersFormat.Jpg,
                "PNG" => ImageAIEffectsParametersFormat.Png,
                "WEBP" => ImageAIEffectsParametersFormat.Webp,
                _ => null,
            };
        }
    }
}