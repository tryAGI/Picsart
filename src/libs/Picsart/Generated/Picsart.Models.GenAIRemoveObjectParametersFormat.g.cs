
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
    public enum GenAIRemoveObjectParametersFormat
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
    public static class GenAIRemoveObjectParametersFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenAIRemoveObjectParametersFormat value)
        {
            return value switch
            {
                GenAIRemoveObjectParametersFormat.Jpg => "JPG",
                GenAIRemoveObjectParametersFormat.Png => "PNG",
                GenAIRemoveObjectParametersFormat.Webp => "WEBP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenAIRemoveObjectParametersFormat? ToEnum(string value)
        {
            return value switch
            {
                "JPG" => GenAIRemoveObjectParametersFormat.Jpg,
                "PNG" => GenAIRemoveObjectParametersFormat.Png,
                "WEBP" => GenAIRemoveObjectParametersFormat.Webp,
                _ => null,
            };
        }
    }
}