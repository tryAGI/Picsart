
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public enum VideoUpscaleFpsGetresultResponseStatus2
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
    public static class VideoUpscaleFpsGetresultResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoUpscaleFpsGetresultResponseStatus2 value)
        {
            return value switch
            {
                VideoUpscaleFpsGetresultResponseStatus2.Error => "error",
                VideoUpscaleFpsGetresultResponseStatus2.Processing => "processing",
                VideoUpscaleFpsGetresultResponseStatus2.Queued => "queued",
                VideoUpscaleFpsGetresultResponseStatus2.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoUpscaleFpsGetresultResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => VideoUpscaleFpsGetresultResponseStatus2.Error,
                "processing" => VideoUpscaleFpsGetresultResponseStatus2.Processing,
                "queued" => VideoUpscaleFpsGetresultResponseStatus2.Queued,
                "success" => VideoUpscaleFpsGetresultResponseStatus2.Success,
                _ => null,
            };
        }
    }
}