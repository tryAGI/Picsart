
#nullable enable

namespace Picsart
{
    /// <summary>
    /// Video output quality/resolution.<br/>
    /// Default Value: 480p
    /// </summary>
    public enum GenAIText2VideoParametersQuality
    {
        /// <summary>
        /// 
        /// </summary>
        x1080p,
        /// <summary>
        /// 
        /// </summary>
        x480p,
        /// <summary>
        /// 
        /// </summary>
        x720p,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenAIText2VideoParametersQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenAIText2VideoParametersQuality value)
        {
            return value switch
            {
                GenAIText2VideoParametersQuality.x1080p => "1080p",
                GenAIText2VideoParametersQuality.x480p => "480p",
                GenAIText2VideoParametersQuality.x720p => "720p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenAIText2VideoParametersQuality? ToEnum(string value)
        {
            return value switch
            {
                "1080p" => GenAIText2VideoParametersQuality.x1080p,
                "480p" => GenAIText2VideoParametersQuality.x480p,
                "720p" => GenAIText2VideoParametersQuality.x720p,
                _ => null,
            };
        }
    }
}