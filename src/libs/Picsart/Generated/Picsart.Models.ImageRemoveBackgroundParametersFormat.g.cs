
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
    public enum ImageRemoveBackgroundParametersFormat
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
    public static class ImageRemoveBackgroundParametersFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageRemoveBackgroundParametersFormat value)
        {
            return value switch
            {
                ImageRemoveBackgroundParametersFormat.Jpg => "JPG",
                ImageRemoveBackgroundParametersFormat.Png => "PNG",
                ImageRemoveBackgroundParametersFormat.Webp => "WEBP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageRemoveBackgroundParametersFormat? ToEnum(string value)
        {
            return value switch
            {
                "JPG" => ImageRemoveBackgroundParametersFormat.Jpg,
                "PNG" => ImageRemoveBackgroundParametersFormat.Png,
                "WEBP" => ImageRemoveBackgroundParametersFormat.Webp,
                _ => null,
            };
        }
    }
}