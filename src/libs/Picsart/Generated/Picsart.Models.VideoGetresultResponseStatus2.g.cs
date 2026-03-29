
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public enum VideoGetresultResponseStatus2
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
    public static class VideoGetresultResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoGetresultResponseStatus2 value)
        {
            return value switch
            {
                VideoGetresultResponseStatus2.Error => "error",
                VideoGetresultResponseStatus2.Processing => "processing",
                VideoGetresultResponseStatus2.Queued => "queued",
                VideoGetresultResponseStatus2.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoGetresultResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => VideoGetresultResponseStatus2.Error,
                "processing" => VideoGetresultResponseStatus2.Processing,
                "queued" => VideoGetresultResponseStatus2.Queued,
                "success" => VideoGetresultResponseStatus2.Success,
                _ => null,
            };
        }
    }
}