
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public enum VideoSetThumbnailGetresultResponseStatus2
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
    public static class VideoSetThumbnailGetresultResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoSetThumbnailGetresultResponseStatus2 value)
        {
            return value switch
            {
                VideoSetThumbnailGetresultResponseStatus2.Error => "error",
                VideoSetThumbnailGetresultResponseStatus2.Processing => "processing",
                VideoSetThumbnailGetresultResponseStatus2.Queued => "queued",
                VideoSetThumbnailGetresultResponseStatus2.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoSetThumbnailGetresultResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => VideoSetThumbnailGetresultResponseStatus2.Error,
                "processing" => VideoSetThumbnailGetresultResponseStatus2.Processing,
                "queued" => VideoSetThumbnailGetresultResponseStatus2.Queued,
                "success" => VideoSetThumbnailGetresultResponseStatus2.Success,
                _ => null,
            };
        }
    }
}