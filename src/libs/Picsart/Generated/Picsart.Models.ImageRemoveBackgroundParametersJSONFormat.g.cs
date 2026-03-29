
#nullable enable

namespace Picsart
{
    /// <summary>
    /// Optionally select one of the image formats (PNG is chosen if left blank). Options are as follows:<br/>
    ///   * JPG<br/>
    ///   * PNG<br/>
    ///   * WEBP<br/>
    /// Default Value: PNG
    /// </summary>
    public enum ImageRemoveBackgroundParametersJSONFormat
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
    public static class ImageRemoveBackgroundParametersJSONFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageRemoveBackgroundParametersJSONFormat value)
        {
            return value switch
            {
                ImageRemoveBackgroundParametersJSONFormat.Jpg => "JPG",
                ImageRemoveBackgroundParametersJSONFormat.Png => "PNG",
                ImageRemoveBackgroundParametersJSONFormat.Webp => "WEBP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageRemoveBackgroundParametersJSONFormat? ToEnum(string value)
        {
            return value switch
            {
                "JPG" => ImageRemoveBackgroundParametersJSONFormat.Jpg,
                "PNG" => ImageRemoveBackgroundParametersJSONFormat.Png,
                "WEBP" => ImageRemoveBackgroundParametersJSONFormat.Webp,
                _ => null,
            };
        }
    }
}