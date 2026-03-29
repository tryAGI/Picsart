
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public enum VideoExtractAudioResponseStatus
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
    public static class VideoExtractAudioResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoExtractAudioResponseStatus value)
        {
            return value switch
            {
                VideoExtractAudioResponseStatus.Error => "error",
                VideoExtractAudioResponseStatus.Processing => "processing",
                VideoExtractAudioResponseStatus.Queued => "queued",
                VideoExtractAudioResponseStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoExtractAudioResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => VideoExtractAudioResponseStatus.Error,
                "processing" => VideoExtractAudioResponseStatus.Processing,
                "queued" => VideoExtractAudioResponseStatus.Queued,
                "success" => VideoExtractAudioResponseStatus.Success,
                _ => null,
            };
        }
    }
}