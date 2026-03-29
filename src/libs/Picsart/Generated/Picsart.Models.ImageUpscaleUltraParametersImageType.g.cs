
#nullable enable

namespace Picsart
{
    /// <summary>
    /// Optionally define your image type. If you know what your image is about, it's better this type is provided. It will help the service optimize and use the best model for that image type. Available options are as follows:<br/>
    ///   * product<br/>
    ///   * portrait<br/>
    ///   * nature<br/>
    ///   * graphics
    /// </summary>
    public enum ImageUpscaleUltraParametersImageType
    {
        /// <summary>
        /// 
        /// </summary>
        Graphics,
        /// <summary>
        /// 
        /// </summary>
        Nature,
        /// <summary>
        /// 
        /// </summary>
        Portrait,
        /// <summary>
        /// 
        /// </summary>
        Product,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageUpscaleUltraParametersImageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageUpscaleUltraParametersImageType value)
        {
            return value switch
            {
                ImageUpscaleUltraParametersImageType.Graphics => "graphics",
                ImageUpscaleUltraParametersImageType.Nature => "nature",
                ImageUpscaleUltraParametersImageType.Portrait => "portrait",
                ImageUpscaleUltraParametersImageType.Product => "product",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageUpscaleUltraParametersImageType? ToEnum(string value)
        {
            return value switch
            {
                "graphics" => ImageUpscaleUltraParametersImageType.Graphics,
                "nature" => ImageUpscaleUltraParametersImageType.Nature,
                "portrait" => ImageUpscaleUltraParametersImageType.Portrait,
                "product" => ImageUpscaleUltraParametersImageType.Product,
                _ => null,
            };
        }
    }
}