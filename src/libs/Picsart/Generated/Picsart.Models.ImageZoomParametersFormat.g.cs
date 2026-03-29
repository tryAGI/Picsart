
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
    public enum ImageZoomParametersFormat
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
    public static class ImageZoomParametersFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageZoomParametersFormat value)
        {
            return value switch
            {
                ImageZoomParametersFormat.Jpg => "JPG",
                ImageZoomParametersFormat.Png => "PNG",
                ImageZoomParametersFormat.Webp => "WEBP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageZoomParametersFormat? ToEnum(string value)
        {
            return value switch
            {
                "JPG" => ImageZoomParametersFormat.Jpg,
                "PNG" => ImageZoomParametersFormat.Png,
                "WEBP" => ImageZoomParametersFormat.Webp,
                _ => null,
            };
        }
    }
}