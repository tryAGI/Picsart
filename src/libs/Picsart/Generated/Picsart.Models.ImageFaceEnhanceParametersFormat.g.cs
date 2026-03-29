
#nullable enable

namespace Picsart
{
    /// <summary>
    /// Optionally select one of the image formats (JPG is the default). Options are as follows:<br/>
    ///   * JPG<br/>
    ///   * PNG<br/>
    ///   * WEBP<br/>
    /// Default Value: JPG
    /// </summary>
    public enum ImageFaceEnhanceParametersFormat
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
    public static class ImageFaceEnhanceParametersFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageFaceEnhanceParametersFormat value)
        {
            return value switch
            {
                ImageFaceEnhanceParametersFormat.Jpg => "JPG",
                ImageFaceEnhanceParametersFormat.Png => "PNG",
                ImageFaceEnhanceParametersFormat.Webp => "WEBP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageFaceEnhanceParametersFormat? ToEnum(string value)
        {
            return value switch
            {
                "JPG" => ImageFaceEnhanceParametersFormat.Jpg,
                "PNG" => ImageFaceEnhanceParametersFormat.Png,
                "WEBP" => ImageFaceEnhanceParametersFormat.Webp,
                _ => null,
            };
        }
    }
}