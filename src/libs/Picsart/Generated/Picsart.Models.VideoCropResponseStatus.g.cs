
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public enum VideoCropResponseStatus
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
    public static class VideoCropResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoCropResponseStatus value)
        {
            return value switch
            {
                VideoCropResponseStatus.Error => "error",
                VideoCropResponseStatus.Processing => "processing",
                VideoCropResponseStatus.Queued => "queued",
                VideoCropResponseStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoCropResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => VideoCropResponseStatus.Error,
                "processing" => VideoCropResponseStatus.Processing,
                "queued" => VideoCropResponseStatus.Queued,
                "success" => VideoCropResponseStatus.Success,
                _ => null,
            };
        }
    }
}