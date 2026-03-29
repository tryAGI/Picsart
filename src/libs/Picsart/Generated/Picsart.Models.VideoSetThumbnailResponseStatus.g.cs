
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public enum VideoSetThumbnailResponseStatus
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
    public static class VideoSetThumbnailResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoSetThumbnailResponseStatus value)
        {
            return value switch
            {
                VideoSetThumbnailResponseStatus.Error => "error",
                VideoSetThumbnailResponseStatus.Processing => "processing",
                VideoSetThumbnailResponseStatus.Queued => "queued",
                VideoSetThumbnailResponseStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoSetThumbnailResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => VideoSetThumbnailResponseStatus.Error,
                "processing" => VideoSetThumbnailResponseStatus.Processing,
                "queued" => VideoSetThumbnailResponseStatus.Queued,
                "success" => VideoSetThumbnailResponseStatus.Success,
                _ => null,
            };
        }
    }
}