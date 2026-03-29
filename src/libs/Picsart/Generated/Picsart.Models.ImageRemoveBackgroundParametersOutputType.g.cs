
#nullable enable

namespace Picsart
{
    /// <summary>
    /// Select one of the two output options. If you submit a photo of a person, **cutout** returns the person as a sticker while **mask** returns a mask photo of the person.<br/>
    /// Default Value: cutout
    /// </summary>
    public enum ImageRemoveBackgroundParametersOutputType
    {
        /// <summary>
        /// 
        /// </summary>
        Cutout,
        /// <summary>
        /// 
        /// </summary>
        Mask,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageRemoveBackgroundParametersOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageRemoveBackgroundParametersOutputType value)
        {
            return value switch
            {
                ImageRemoveBackgroundParametersOutputType.Cutout => "cutout",
                ImageRemoveBackgroundParametersOutputType.Mask => "mask",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageRemoveBackgroundParametersOutputType? ToEnum(string value)
        {
            return value switch
            {
                "cutout" => ImageRemoveBackgroundParametersOutputType.Cutout,
                "mask" => ImageRemoveBackgroundParametersOutputType.Mask,
                _ => null,
            };
        }
    }
}