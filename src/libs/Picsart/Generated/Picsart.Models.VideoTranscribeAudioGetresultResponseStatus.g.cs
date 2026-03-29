
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public enum VideoTranscribeAudioGetresultResponseStatus
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
    public static class VideoTranscribeAudioGetresultResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoTranscribeAudioGetresultResponseStatus value)
        {
            return value switch
            {
                VideoTranscribeAudioGetresultResponseStatus.Error => "error",
                VideoTranscribeAudioGetresultResponseStatus.Processing => "processing",
                VideoTranscribeAudioGetresultResponseStatus.Queued => "queued",
                VideoTranscribeAudioGetresultResponseStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoTranscribeAudioGetresultResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => VideoTranscribeAudioGetresultResponseStatus.Error,
                "processing" => VideoTranscribeAudioGetresultResponseStatus.Processing,
                "queued" => VideoTranscribeAudioGetresultResponseStatus.Queued,
                "success" => VideoTranscribeAudioGetresultResponseStatus.Success,
                _ => null,
            };
        }
    }
}