
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
    public enum ImageTextureParametersFormat
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
    public static class ImageTextureParametersFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageTextureParametersFormat value)
        {
            return value switch
            {
                ImageTextureParametersFormat.Jpg => "JPG",
                ImageTextureParametersFormat.Png => "PNG",
                ImageTextureParametersFormat.Webp => "WEBP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageTextureParametersFormat? ToEnum(string value)
        {
            return value switch
            {
                "JPG" => ImageTextureParametersFormat.Jpg,
                "PNG" => ImageTextureParametersFormat.Png,
                "WEBP" => ImageTextureParametersFormat.Webp,
                _ => null,
            };
        }
    }
}