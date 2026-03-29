
#nullable enable

namespace Picsart
{
    /// <summary>
    /// Optionally select one of the image formats (JPG is chosen if left blank). Options are as follows:<br/>
    ///   * JPG<br/>
    ///   * PNG<br/>
    ///   * WEBP<br/>
    /// Default Value: JPG
    /// </summary>
    public enum ImageOverlayParametersFormat
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
    public static class ImageOverlayParametersFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageOverlayParametersFormat value)
        {
            return value switch
            {
                ImageOverlayParametersFormat.Jpg => "JPG",
                ImageOverlayParametersFormat.Png => "PNG",
                ImageOverlayParametersFormat.Webp => "WEBP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageOverlayParametersFormat? ToEnum(string value)
        {
            return value switch
            {
                "JPG" => ImageOverlayParametersFormat.Jpg,
                "PNG" => ImageOverlayParametersFormat.Png,
                "WEBP" => ImageOverlayParametersFormat.Webp,
                _ => null,
            };
        }
    }
}