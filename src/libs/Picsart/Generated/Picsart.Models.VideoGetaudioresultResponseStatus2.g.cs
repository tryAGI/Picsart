
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public enum VideoGetaudioresultResponseStatus2
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
    public static class VideoGetaudioresultResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoGetaudioresultResponseStatus2 value)
        {
            return value switch
            {
                VideoGetaudioresultResponseStatus2.Error => "error",
                VideoGetaudioresultResponseStatus2.Processing => "processing",
                VideoGetaudioresultResponseStatus2.Queued => "queued",
                VideoGetaudioresultResponseStatus2.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoGetaudioresultResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => VideoGetaudioresultResponseStatus2.Error,
                "processing" => VideoGetaudioresultResponseStatus2.Processing,
                "queued" => VideoGetaudioresultResponseStatus2.Queued,
                "success" => VideoGetaudioresultResponseStatus2.Success,
                _ => null,
            };
        }
    }
}