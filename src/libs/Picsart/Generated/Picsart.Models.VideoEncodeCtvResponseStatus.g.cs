
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public enum VideoEncodeCtvResponseStatus
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
    public static class VideoEncodeCtvResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoEncodeCtvResponseStatus value)
        {
            return value switch
            {
                VideoEncodeCtvResponseStatus.Error => "error",
                VideoEncodeCtvResponseStatus.Processing => "processing",
                VideoEncodeCtvResponseStatus.Queued => "queued",
                VideoEncodeCtvResponseStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoEncodeCtvResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => VideoEncodeCtvResponseStatus.Error,
                "processing" => VideoEncodeCtvResponseStatus.Processing,
                "queued" => VideoEncodeCtvResponseStatus.Queued,
                "success" => VideoEncodeCtvResponseStatus.Success,
                _ => null,
            };
        }
    }
}