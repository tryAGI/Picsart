
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public enum VideoSetThumbnailGetresultResponseStatus
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
    public static class VideoSetThumbnailGetresultResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoSetThumbnailGetresultResponseStatus value)
        {
            return value switch
            {
                VideoSetThumbnailGetresultResponseStatus.Error => "error",
                VideoSetThumbnailGetresultResponseStatus.Processing => "processing",
                VideoSetThumbnailGetresultResponseStatus.Queued => "queued",
                VideoSetThumbnailGetresultResponseStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoSetThumbnailGetresultResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => VideoSetThumbnailGetresultResponseStatus.Error,
                "processing" => VideoSetThumbnailGetresultResponseStatus.Processing,
                "queued" => VideoSetThumbnailGetresultResponseStatus.Queued,
                "success" => VideoSetThumbnailGetresultResponseStatus.Success,
                _ => null,
            };
        }
    }
}