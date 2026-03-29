
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public enum VideoTrimResponseStatus
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
    public static class VideoTrimResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoTrimResponseStatus value)
        {
            return value switch
            {
                VideoTrimResponseStatus.Error => "error",
                VideoTrimResponseStatus.Processing => "processing",
                VideoTrimResponseStatus.Queued => "queued",
                VideoTrimResponseStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoTrimResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => VideoTrimResponseStatus.Error,
                "processing" => VideoTrimResponseStatus.Processing,
                "queued" => VideoTrimResponseStatus.Queued,
                "success" => VideoTrimResponseStatus.Success,
                _ => null,
            };
        }
    }
}