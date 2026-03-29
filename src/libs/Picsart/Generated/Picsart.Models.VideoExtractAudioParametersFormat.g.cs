
#nullable enable

namespace Picsart
{
    /// <summary>
    /// Optionally select one of the audio formats (mp3 is chosen if left blank). Options are as follows:<br/>
    ///   * mp3<br/>
    ///   * m4a<br/>
    ///   * wav<br/>
    ///   * flac<br/>
    /// Default Value: mp3
    /// </summary>
    public enum VideoExtractAudioParametersFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Flac,
        /// <summary>
        /// 
        /// </summary>
        M4a,
        /// <summary>
        /// 
        /// </summary>
        Mp3,
        /// <summary>
        /// 
        /// </summary>
        Wav,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoExtractAudioParametersFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoExtractAudioParametersFormat value)
        {
            return value switch
            {
                VideoExtractAudioParametersFormat.Flac => "flac",
                VideoExtractAudioParametersFormat.M4a => "m4a",
                VideoExtractAudioParametersFormat.Mp3 => "mp3",
                VideoExtractAudioParametersFormat.Wav => "wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoExtractAudioParametersFormat? ToEnum(string value)
        {
            return value switch
            {
                "flac" => VideoExtractAudioParametersFormat.Flac,
                "m4a" => VideoExtractAudioParametersFormat.M4a,
                "mp3" => VideoExtractAudioParametersFormat.Mp3,
                "wav" => VideoExtractAudioParametersFormat.Wav,
                _ => null,
            };
        }
    }
}