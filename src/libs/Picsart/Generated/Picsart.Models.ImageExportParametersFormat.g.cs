
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
    public enum ImageExportParametersFormat
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
    public static class ImageExportParametersFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageExportParametersFormat value)
        {
            return value switch
            {
                ImageExportParametersFormat.Jpg => "JPG",
                ImageExportParametersFormat.Png => "PNG",
                ImageExportParametersFormat.Webp => "WEBP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageExportParametersFormat? ToEnum(string value)
        {
            return value switch
            {
                "JPG" => ImageExportParametersFormat.Jpg,
                "PNG" => ImageExportParametersFormat.Png,
                "WEBP" => ImageExportParametersFormat.Webp,
                _ => null,
            };
        }
    }
}