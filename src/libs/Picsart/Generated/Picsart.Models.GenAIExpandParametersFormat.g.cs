
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
    public enum GenAIExpandParametersFormat
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
    public static class GenAIExpandParametersFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenAIExpandParametersFormat value)
        {
            return value switch
            {
                GenAIExpandParametersFormat.Jpg => "JPG",
                GenAIExpandParametersFormat.Png => "PNG",
                GenAIExpandParametersFormat.Webp => "WEBP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenAIExpandParametersFormat? ToEnum(string value)
        {
            return value switch
            {
                "JPG" => GenAIExpandParametersFormat.Jpg,
                "PNG" => GenAIExpandParametersFormat.Png,
                "WEBP" => GenAIExpandParametersFormat.Webp,
                _ => null,
            };
        }
    }
}