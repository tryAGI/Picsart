
#nullable enable

namespace Picsart
{
    /// <summary>
    /// Fit is where the longer side (width/height) fits the video canvas (e.g. see the width and height params). Fill is where the shorter side fits the background. Fit is the default.<br/>
    /// Default Value: fit
    /// </summary>
    public enum VideoConcatImageParametersScale
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
    public static class VideoConcatImageParametersScaleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoConcatImageParametersScale value)
        {
            return value switch
            {
                VideoConcatImageParametersScale.Fill => "fill",
                VideoConcatImageParametersScale.Fit => "fit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoConcatImageParametersScale? ToEnum(string value)
        {
            return value switch
            {
                "fill" => VideoConcatImageParametersScale.Fill,
                "fit" => VideoConcatImageParametersScale.Fit,
                _ => null,
            };
        }
    }
}