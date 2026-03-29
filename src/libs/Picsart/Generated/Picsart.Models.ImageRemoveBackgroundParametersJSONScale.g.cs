
#nullable enable

namespace Picsart
{
    /// <summary>
    /// Fit is where the longer side (width/height) fits the background. Fill is where the shorter side fits the background. Fit is the default.<br/>
    /// Default Value: fit
    /// </summary>
    public enum ImageRemoveBackgroundParametersJSONScale
    {
        /// <summary>
        /// 
        /// </summary>
        Fill,
        /// <summary>
        /// 
        /// </summary>
        Fit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageRemoveBackgroundParametersJSONScaleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageRemoveBackgroundParametersJSONScale value)
        {
            return value switch
            {
                ImageRemoveBackgroundParametersJSONScale.Fill => "fill",
                ImageRemoveBackgroundParametersJSONScale.Fit => "fit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageRemoveBackgroundParametersJSONScale? ToEnum(string value)
        {
            return value switch
            {
                "fill" => ImageRemoveBackgroundParametersJSONScale.Fill,
                "fit" => ImageRemoveBackgroundParametersJSONScale.Fit,
                _ => null,
            };
        }
    }
}