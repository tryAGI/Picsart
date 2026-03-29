
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public enum VideoUpscaleFpsGetresultResponseStatus
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
    public static class VideoUpscaleFpsGetresultResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoUpscaleFpsGetresultResponseStatus value)
        {
            return value switch
            {
                VideoUpscaleFpsGetresultResponseStatus.Error => "error",
                VideoUpscaleFpsGetresultResponseStatus.Processing => "processing",
                VideoUpscaleFpsGetresultResponseStatus.Queued => "queued",
                VideoUpscaleFpsGetresultResponseStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoUpscaleFpsGetresultResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => VideoUpscaleFpsGetresultResponseStatus.Error,
                "processing" => VideoUpscaleFpsGetresultResponseStatus.Processing,
                "queued" => VideoUpscaleFpsGetresultResponseStatus.Queued,
                "success" => VideoUpscaleFpsGetresultResponseStatus.Success,
                _ => null,
            };
        }
    }
}