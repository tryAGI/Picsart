
#nullable enable

namespace Picsart
{
    /// <summary>
    /// Optionally select one of the image formats (JPG is default). Options are as follows:<br/>
    ///   * JPG<br/>
    ///   * PNG<br/>
    ///   * WEBP<br/>
    /// Default Value: JPG
    /// </summary>
    public enum GenAIInpaintingParametersFormat
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
    public static class GenAIInpaintingParametersFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenAIInpaintingParametersFormat value)
        {
            return value switch
            {
                GenAIInpaintingParametersFormat.Jpg => "JPG",
                GenAIInpaintingParametersFormat.Png => "PNG",
                GenAIInpaintingParametersFormat.Webp => "WEBP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenAIInpaintingParametersFormat? ToEnum(string value)
        {
            return value switch
            {
                "JPG" => GenAIInpaintingParametersFormat.Jpg,
                "PNG" => GenAIInpaintingParametersFormat.Png,
                "WEBP" => GenAIInpaintingParametersFormat.Webp,
                _ => null,
            };
        }
    }
}