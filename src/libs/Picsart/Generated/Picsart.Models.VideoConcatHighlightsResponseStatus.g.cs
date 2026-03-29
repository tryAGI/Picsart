
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public enum VideoConcatHighlightsResponseStatus
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
    public static class VideoConcatHighlightsResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoConcatHighlightsResponseStatus value)
        {
            return value switch
            {
                VideoConcatHighlightsResponseStatus.Error => "error",
                VideoConcatHighlightsResponseStatus.Processing => "processing",
                VideoConcatHighlightsResponseStatus.Queued => "queued",
                VideoConcatHighlightsResponseStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoConcatHighlightsResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => VideoConcatHighlightsResponseStatus.Error,
                "processing" => VideoConcatHighlightsResponseStatus.Processing,
                "queued" => VideoConcatHighlightsResponseStatus.Queued,
                "success" => VideoConcatHighlightsResponseStatus.Success,
                _ => null,
            };
        }
    }
}