
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public enum VideoAdjustResponseStatus
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
    public static class VideoAdjustResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoAdjustResponseStatus value)
        {
            return value switch
            {
                VideoAdjustResponseStatus.Error => "error",
                VideoAdjustResponseStatus.Processing => "processing",
                VideoAdjustResponseStatus.Queued => "queued",
                VideoAdjustResponseStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoAdjustResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => VideoAdjustResponseStatus.Error,
                "processing" => VideoAdjustResponseStatus.Processing,
                "queued" => VideoAdjustResponseStatus.Queued,
                "success" => VideoAdjustResponseStatus.Success,
                _ => null,
            };
        }
    }
}