
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public enum VideoTranscribeAudioGetresultResponseStatus2
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
    public static class VideoTranscribeAudioGetresultResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoTranscribeAudioGetresultResponseStatus2 value)
        {
            return value switch
            {
                VideoTranscribeAudioGetresultResponseStatus2.Error => "error",
                VideoTranscribeAudioGetresultResponseStatus2.Processing => "processing",
                VideoTranscribeAudioGetresultResponseStatus2.Queued => "queued",
                VideoTranscribeAudioGetresultResponseStatus2.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoTranscribeAudioGetresultResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => VideoTranscribeAudioGetresultResponseStatus2.Error,
                "processing" => VideoTranscribeAudioGetresultResponseStatus2.Processing,
                "queued" => VideoTranscribeAudioGetresultResponseStatus2.Queued,
                "success" => VideoTranscribeAudioGetresultResponseStatus2.Success,
                _ => null,
            };
        }
    }
}