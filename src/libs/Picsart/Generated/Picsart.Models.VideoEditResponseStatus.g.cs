
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public enum VideoEditResponseStatus
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
    public static class VideoEditResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoEditResponseStatus value)
        {
            return value switch
            {
                VideoEditResponseStatus.Error => "error",
                VideoEditResponseStatus.Processing => "processing",
                VideoEditResponseStatus.Queued => "queued",
                VideoEditResponseStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoEditResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => VideoEditResponseStatus.Error,
                "processing" => VideoEditResponseStatus.Processing,
                "queued" => VideoEditResponseStatus.Queued,
                "success" => VideoEditResponseStatus.Success,
                _ => null,
            };
        }
    }
}