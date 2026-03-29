
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public enum VideoConcatResponseStatus
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
    public static class VideoConcatResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoConcatResponseStatus value)
        {
            return value switch
            {
                VideoConcatResponseStatus.Error => "error",
                VideoConcatResponseStatus.Processing => "processing",
                VideoConcatResponseStatus.Queued => "queued",
                VideoConcatResponseStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoConcatResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => VideoConcatResponseStatus.Error,
                "processing" => VideoConcatResponseStatus.Processing,
                "queued" => VideoConcatResponseStatus.Queued,
                "success" => VideoConcatResponseStatus.Success,
                _ => null,
            };
        }
    }
}