
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
    public enum ImageStyleTransferParametersFormat
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
    public static class ImageStyleTransferParametersFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageStyleTransferParametersFormat value)
        {
            return value switch
            {
                ImageStyleTransferParametersFormat.Jpg => "JPG",
                ImageStyleTransferParametersFormat.Png => "PNG",
                ImageStyleTransferParametersFormat.Webp => "WEBP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageStyleTransferParametersFormat? ToEnum(string value)
        {
            return value switch
            {
                "JPG" => ImageStyleTransferParametersFormat.Jpg,
                "PNG" => ImageStyleTransferParametersFormat.Png,
                "WEBP" => ImageStyleTransferParametersFormat.Webp,
                _ => null,
            };
        }
    }
}