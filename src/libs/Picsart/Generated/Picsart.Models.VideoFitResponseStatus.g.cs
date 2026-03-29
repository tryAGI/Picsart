
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public enum VideoFitResponseStatus
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
    public static class VideoFitResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoFitResponseStatus value)
        {
            return value switch
            {
                VideoFitResponseStatus.Error => "error",
                VideoFitResponseStatus.Processing => "processing",
                VideoFitResponseStatus.Queued => "queued",
                VideoFitResponseStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoFitResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => VideoFitResponseStatus.Error,
                "processing" => VideoFitResponseStatus.Processing,
                "queued" => VideoFitResponseStatus.Queued,
                "success" => VideoFitResponseStatus.Success,
                _ => null,
            };
        }
    }
}