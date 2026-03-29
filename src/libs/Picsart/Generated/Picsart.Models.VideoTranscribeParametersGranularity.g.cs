
#nullable enable

namespace Picsart
{
    /// <summary>
    /// Define the granularity of the subtitles. This works for SRT, VTT and SBV formats only.<br/>
    /// Default Value: sentence
    /// </summary>
    public enum VideoTranscribeParametersGranularity
    {
        /// <summary>
        /// 
        /// </summary>
        x1Word,
        /// <summary>
        /// 
        /// </summary>
        x2Words,
        /// <summary>
        /// 
        /// </summary>
        Sentence,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoTranscribeParametersGranularityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoTranscribeParametersGranularity value)
        {
            return value switch
            {
                VideoTranscribeParametersGranularity.x1Word => "1-word",
                VideoTranscribeParametersGranularity.x2Words => "2-words",
                VideoTranscribeParametersGranularity.Sentence => "sentence",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoTranscribeParametersGranularity? ToEnum(string value)
        {
            return value switch
            {
                "1-word" => VideoTranscribeParametersGranularity.x1Word,
                "2-words" => VideoTranscribeParametersGranularity.x2Words,
                "sentence" => VideoTranscribeParametersGranularity.Sentence,
                _ => null,
            };
        }
    }
}