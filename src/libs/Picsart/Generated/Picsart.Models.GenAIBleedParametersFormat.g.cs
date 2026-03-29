
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
    public enum GenAIBleedParametersFormat
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
    public static class GenAIBleedParametersFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenAIBleedParametersFormat value)
        {
            return value switch
            {
                GenAIBleedParametersFormat.Jpg => "JPG",
                GenAIBleedParametersFormat.Png => "PNG",
                GenAIBleedParametersFormat.Webp => "WEBP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenAIBleedParametersFormat? ToEnum(string value)
        {
            return value switch
            {
                "JPG" => GenAIBleedParametersFormat.Jpg,
                "PNG" => GenAIBleedParametersFormat.Png,
                "WEBP" => GenAIBleedParametersFormat.Webp,
                _ => null,
            };
        }
    }
}