
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public enum VideoUploadResponseStatus
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
    public static class VideoUploadResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoUploadResponseStatus value)
        {
            return value switch
            {
                VideoUploadResponseStatus.Error => "error",
                VideoUploadResponseStatus.Processing => "processing",
                VideoUploadResponseStatus.Queued => "queued",
                VideoUploadResponseStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoUploadResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => VideoUploadResponseStatus.Error,
                "processing" => VideoUploadResponseStatus.Processing,
                "queued" => VideoUploadResponseStatus.Queued,
                "success" => VideoUploadResponseStatus.Success,
                _ => null,
            };
        }
    }
}