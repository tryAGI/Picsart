
#nullable enable

namespace Picsart
{
    /// <summary>
    /// Select one of the two output options. If you submit a photo of a person, **cutout** returns the person as a sticker while **mask** returns a mask photo of the person.<br/>
    /// Default Value: cutout
    /// </summary>
    public enum ImageRemoveBackgroundParametersJSONOutputType
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
    public static class ImageRemoveBackgroundParametersJSONOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageRemoveBackgroundParametersJSONOutputType value)
        {
            return value switch
            {
                ImageRemoveBackgroundParametersJSONOutputType.Cutout => "cutout",
                ImageRemoveBackgroundParametersJSONOutputType.Mask => "mask",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageRemoveBackgroundParametersJSONOutputType? ToEnum(string value)
        {
            return value switch
            {
                "cutout" => ImageRemoveBackgroundParametersJSONOutputType.Cutout,
                "mask" => ImageRemoveBackgroundParametersJSONOutputType.Mask,
                _ => null,
            };
        }
    }
}