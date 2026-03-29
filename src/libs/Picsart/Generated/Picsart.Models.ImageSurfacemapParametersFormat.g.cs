
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
    public enum ImageSurfacemapParametersFormat
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
    public static class ImageSurfacemapParametersFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageSurfacemapParametersFormat value)
        {
            return value switch
            {
                ImageSurfacemapParametersFormat.Jpg => "JPG",
                ImageSurfacemapParametersFormat.Png => "PNG",
                ImageSurfacemapParametersFormat.Webp => "WEBP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageSurfacemapParametersFormat? ToEnum(string value)
        {
            return value switch
            {
                "JPG" => ImageSurfacemapParametersFormat.Jpg,
                "PNG" => ImageSurfacemapParametersFormat.Png,
                "WEBP" => ImageSurfacemapParametersFormat.Webp,
                _ => null,
            };
        }
    }
}