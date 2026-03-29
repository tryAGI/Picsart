
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
    public enum ImageSmartCropParametersFormat
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
    public static class ImageSmartCropParametersFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageSmartCropParametersFormat value)
        {
            return value switch
            {
                ImageSmartCropParametersFormat.Jpg => "JPG",
                ImageSmartCropParametersFormat.Png => "PNG",
                ImageSmartCropParametersFormat.Webp => "WEBP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageSmartCropParametersFormat? ToEnum(string value)
        {
            return value switch
            {
                "JPG" => ImageSmartCropParametersFormat.Jpg,
                "PNG" => ImageSmartCropParametersFormat.Png,
                "WEBP" => ImageSmartCropParametersFormat.Webp,
                _ => null,
            };
        }
    }
}