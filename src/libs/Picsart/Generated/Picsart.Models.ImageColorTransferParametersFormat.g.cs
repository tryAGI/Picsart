
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
    public enum ImageColorTransferParametersFormat
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
    public static class ImageColorTransferParametersFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageColorTransferParametersFormat value)
        {
            return value switch
            {
                ImageColorTransferParametersFormat.Jpg => "JPG",
                ImageColorTransferParametersFormat.Png => "PNG",
                ImageColorTransferParametersFormat.Webp => "WEBP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageColorTransferParametersFormat? ToEnum(string value)
        {
            return value switch
            {
                "JPG" => ImageColorTransferParametersFormat.Jpg,
                "PNG" => ImageColorTransferParametersFormat.Png,
                "WEBP" => ImageColorTransferParametersFormat.Webp,
                _ => null,
            };
        }
    }
}