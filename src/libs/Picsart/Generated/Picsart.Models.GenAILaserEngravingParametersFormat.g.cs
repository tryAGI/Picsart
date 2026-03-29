
#nullable enable

namespace Picsart
{
    /// <summary>
    /// Optionally select one of the output image formats (JPG is chosen if left blank). Options are as follows:<br/>
    ///   * JPG<br/>
    ///   * PNG<br/>
    ///   * WEBP<br/>
    ///   * SVG<br/>
    /// Default Value: JPG
    /// </summary>
    public enum GenAILaserEngravingParametersFormat
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
        Svg,
        /// <summary>
        /// 
        /// </summary>
        Webp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenAILaserEngravingParametersFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenAILaserEngravingParametersFormat value)
        {
            return value switch
            {
                GenAILaserEngravingParametersFormat.Jpg => "JPG",
                GenAILaserEngravingParametersFormat.Png => "PNG",
                GenAILaserEngravingParametersFormat.Svg => "SVG",
                GenAILaserEngravingParametersFormat.Webp => "WEBP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenAILaserEngravingParametersFormat? ToEnum(string value)
        {
            return value switch
            {
                "JPG" => GenAILaserEngravingParametersFormat.Jpg,
                "PNG" => GenAILaserEngravingParametersFormat.Png,
                "SVG" => GenAILaserEngravingParametersFormat.Svg,
                "WEBP" => GenAILaserEngravingParametersFormat.Webp,
                _ => null,
            };
        }
    }
}