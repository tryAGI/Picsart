
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
    public enum ImageEffectsPreviewsParametersFormat
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
    public static class ImageEffectsPreviewsParametersFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageEffectsPreviewsParametersFormat value)
        {
            return value switch
            {
                ImageEffectsPreviewsParametersFormat.Jpg => "JPG",
                ImageEffectsPreviewsParametersFormat.Png => "PNG",
                ImageEffectsPreviewsParametersFormat.Webp => "WEBP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageEffectsPreviewsParametersFormat? ToEnum(string value)
        {
            return value switch
            {
                "JPG" => ImageEffectsPreviewsParametersFormat.Jpg,
                "PNG" => ImageEffectsPreviewsParametersFormat.Png,
                "WEBP" => ImageEffectsPreviewsParametersFormat.Webp,
                _ => null,
            };
        }
    }
}