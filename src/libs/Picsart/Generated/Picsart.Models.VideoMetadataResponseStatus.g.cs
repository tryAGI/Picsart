
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public enum VideoMetadataResponseStatus
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
    public static class VideoMetadataResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoMetadataResponseStatus value)
        {
            return value switch
            {
                VideoMetadataResponseStatus.Error => "error",
                VideoMetadataResponseStatus.Processing => "processing",
                VideoMetadataResponseStatus.Queued => "queued",
                VideoMetadataResponseStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoMetadataResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => VideoMetadataResponseStatus.Error,
                "processing" => VideoMetadataResponseStatus.Processing,
                "queued" => VideoMetadataResponseStatus.Queued,
                "success" => VideoMetadataResponseStatus.Success,
                _ => null,
            };
        }
    }
}