
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public enum VideoGetThumbnailResponseStatus
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
    public static class VideoGetThumbnailResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoGetThumbnailResponseStatus value)
        {
            return value switch
            {
                VideoGetThumbnailResponseStatus.Error => "error",
                VideoGetThumbnailResponseStatus.Processing => "processing",
                VideoGetThumbnailResponseStatus.Queued => "queued",
                VideoGetThumbnailResponseStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoGetThumbnailResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => VideoGetThumbnailResponseStatus.Error,
                "processing" => VideoGetThumbnailResponseStatus.Processing,
                "queued" => VideoGetThumbnailResponseStatus.Queued,
                "success" => VideoGetThumbnailResponseStatus.Success,
                _ => null,
            };
        }
    }
}