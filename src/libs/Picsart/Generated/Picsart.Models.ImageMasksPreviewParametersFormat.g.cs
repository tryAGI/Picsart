
#nullable enable

namespace Picsart
{
    /// <summary>
    /// Optionally select one of the image formats (JPG is chosen if left blank). Options are as follows:<br/>
    ///   * JPG<br/>
    ///   * PNG<br/>
    ///   * WEBP<br/>
    /// Default Value: PNG
    /// </summary>
    public enum ImageMasksPreviewParametersFormat
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
    public static class ImageMasksPreviewParametersFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageMasksPreviewParametersFormat value)
        {
            return value switch
            {
                ImageMasksPreviewParametersFormat.Jpg => "JPG",
                ImageMasksPreviewParametersFormat.Png => "PNG",
                ImageMasksPreviewParametersFormat.Webp => "WEBP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageMasksPreviewParametersFormat? ToEnum(string value)
        {
            return value switch
            {
                "JPG" => ImageMasksPreviewParametersFormat.Jpg,
                "PNG" => ImageMasksPreviewParametersFormat.Png,
                "WEBP" => ImageMasksPreviewParametersFormat.Webp,
                _ => null,
            };
        }
    }
}