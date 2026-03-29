
#nullable enable

namespace Picsart
{
    /// <summary>
    /// Optionally select one of the image formats. Options are as follows:<br/>
    ///   * JPG<br/>
    ///   * PNG<br/>
    ///   * WEBP<br/>
    /// Default Value: PNG
    /// </summary>
    public enum ImageMasksParametersFormat
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
    public static class ImageMasksParametersFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageMasksParametersFormat value)
        {
            return value switch
            {
                ImageMasksParametersFormat.Jpg => "JPG",
                ImageMasksParametersFormat.Png => "PNG",
                ImageMasksParametersFormat.Webp => "WEBP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageMasksParametersFormat? ToEnum(string value)
        {
            return value switch
            {
                "JPG" => ImageMasksParametersFormat.Jpg,
                "PNG" => ImageMasksParametersFormat.Png,
                "WEBP" => ImageMasksParametersFormat.Webp,
                _ => null,
            };
        }
    }
}