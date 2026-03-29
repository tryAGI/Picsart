
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public enum VideoTranscribeAudioResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Processing,
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoTranscribeAudioResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoTranscribeAudioResponseStatus value)
        {
            return value switch
            {
                VideoTranscribeAudioResponseStatus.Error => "error",
                VideoTranscribeAudioResponseStatus.Processing => "processing",
                VideoTranscribeAudioResponseStatus.Queued => "queued",
                VideoTranscribeAudioResponseStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoTranscribeAudioResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => VideoTranscribeAudioResponseStatus.Error,
                "processing" => VideoTranscribeAudioResponseStatus.Processing,
                "queued" => VideoTranscribeAudioResponseStatus.Queued,
                "success" => VideoTranscribeAudioResponseStatus.Success,
                _ => null,
            };
        }
    }
}