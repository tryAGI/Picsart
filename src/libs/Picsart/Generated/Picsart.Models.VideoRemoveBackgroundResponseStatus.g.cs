
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public enum VideoRemoveBackgroundResponseStatus
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
    public static class VideoRemoveBackgroundResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoRemoveBackgroundResponseStatus value)
        {
            return value switch
            {
                VideoRemoveBackgroundResponseStatus.Error => "error",
                VideoRemoveBackgroundResponseStatus.Processing => "processing",
                VideoRemoveBackgroundResponseStatus.Queued => "queued",
                VideoRemoveBackgroundResponseStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoRemoveBackgroundResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => VideoRemoveBackgroundResponseStatus.Error,
                "processing" => VideoRemoveBackgroundResponseStatus.Processing,
                "queued" => VideoRemoveBackgroundResponseStatus.Queued,
                "success" => VideoRemoveBackgroundResponseStatus.Success,
                _ => null,
            };
        }
    }
}