
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public enum VideoGetaudioresultResponseStatus
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
    public static class VideoGetaudioresultResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoGetaudioresultResponseStatus value)
        {
            return value switch
            {
                VideoGetaudioresultResponseStatus.Error => "error",
                VideoGetaudioresultResponseStatus.Processing => "processing",
                VideoGetaudioresultResponseStatus.Queued => "queued",
                VideoGetaudioresultResponseStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoGetaudioresultResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => VideoGetaudioresultResponseStatus.Error,
                "processing" => VideoGetaudioresultResponseStatus.Processing,
                "queued" => VideoGetaudioresultResponseStatus.Queued,
                "success" => VideoGetaudioresultResponseStatus.Success,
                _ => null,
            };
        }
    }
}