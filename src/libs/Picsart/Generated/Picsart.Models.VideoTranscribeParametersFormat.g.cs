
#nullable enable

namespace Picsart
{
    /// <summary>
    /// Optionally select one of the transcription formats (TXT is chosen if left blank). Options are as follows:<br/>
    ///   * TXT<br/>
    ///   * SRT<br/>
    ///   * VTT<br/>
    ///   * SBV<br/>
    /// Default Value: TXT
    /// </summary>
    public enum VideoTranscribeParametersFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Sbv,
        /// <summary>
        /// 
        /// </summary>
        Srt,
        /// <summary>
        /// 
        /// </summary>
        Txt,
        /// <summary>
        /// 
        /// </summary>
        Vtt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoTranscribeParametersFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoTranscribeParametersFormat value)
        {
            return value switch
            {
                VideoTranscribeParametersFormat.Sbv => "SBV",
                VideoTranscribeParametersFormat.Srt => "SRT",
                VideoTranscribeParametersFormat.Txt => "TXT",
                VideoTranscribeParametersFormat.Vtt => "VTT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoTranscribeParametersFormat? ToEnum(string value)
        {
            return value switch
            {
                "SBV" => VideoTranscribeParametersFormat.Sbv,
                "SRT" => VideoTranscribeParametersFormat.Srt,
                "TXT" => VideoTranscribeParametersFormat.Txt,
                "VTT" => VideoTranscribeParametersFormat.Vtt,
                _ => null,
            };
        }
    }
}