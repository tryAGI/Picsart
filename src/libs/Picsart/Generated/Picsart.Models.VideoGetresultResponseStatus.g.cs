
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public enum VideoGetresultResponseStatus
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
    public static class VideoGetresultResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoGetresultResponseStatus value)
        {
            return value switch
            {
                VideoGetresultResponseStatus.Error => "error",
                VideoGetresultResponseStatus.Processing => "processing",
                VideoGetresultResponseStatus.Queued => "queued",
                VideoGetresultResponseStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoGetresultResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => VideoGetresultResponseStatus.Error,
                "processing" => VideoGetresultResponseStatus.Processing,
                "queued" => VideoGetresultResponseStatus.Queued,
                "success" => VideoGetresultResponseStatus.Success,
                _ => null,
            };
        }
    }
}