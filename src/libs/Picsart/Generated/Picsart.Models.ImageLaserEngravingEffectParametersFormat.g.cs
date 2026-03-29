
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
    public enum ImageLaserEngravingEffectParametersFormat
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
    public static class ImageLaserEngravingEffectParametersFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageLaserEngravingEffectParametersFormat value)
        {
            return value switch
            {
                ImageLaserEngravingEffectParametersFormat.Jpg => "JPG",
                ImageLaserEngravingEffectParametersFormat.Png => "PNG",
                ImageLaserEngravingEffectParametersFormat.Svg => "SVG",
                ImageLaserEngravingEffectParametersFormat.Webp => "WEBP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageLaserEngravingEffectParametersFormat? ToEnum(string value)
        {
            return value switch
            {
                "JPG" => ImageLaserEngravingEffectParametersFormat.Jpg,
                "PNG" => ImageLaserEngravingEffectParametersFormat.Png,
                "SVG" => ImageLaserEngravingEffectParametersFormat.Svg,
                "WEBP" => ImageLaserEngravingEffectParametersFormat.Webp,
                _ => null,
            };
        }
    }
}