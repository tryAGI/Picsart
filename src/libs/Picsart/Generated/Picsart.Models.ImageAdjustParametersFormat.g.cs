
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
    public enum ImageAdjustParametersFormat
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
    public static class ImageAdjustParametersFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageAdjustParametersFormat value)
        {
            return value switch
            {
                ImageAdjustParametersFormat.Jpg => "JPG",
                ImageAdjustParametersFormat.Png => "PNG",
                ImageAdjustParametersFormat.Webp => "WEBP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageAdjustParametersFormat? ToEnum(string value)
        {
            return value switch
            {
                "JPG" => ImageAdjustParametersFormat.Jpg,
                "PNG" => ImageAdjustParametersFormat.Png,
                "WEBP" => ImageAdjustParametersFormat.Webp,
                _ => null,
            };
        }
    }
}