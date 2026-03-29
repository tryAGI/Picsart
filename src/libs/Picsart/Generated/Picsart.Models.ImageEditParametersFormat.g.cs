
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
    public enum ImageEditParametersFormat
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
    public static class ImageEditParametersFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageEditParametersFormat value)
        {
            return value switch
            {
                ImageEditParametersFormat.Jpg => "JPG",
                ImageEditParametersFormat.Png => "PNG",
                ImageEditParametersFormat.Webp => "WEBP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageEditParametersFormat? ToEnum(string value)
        {
            return value switch
            {
                "JPG" => ImageEditParametersFormat.Jpg,
                "PNG" => ImageEditParametersFormat.Png,
                "WEBP" => ImageEditParametersFormat.Webp,
                _ => null,
            };
        }
    }
}