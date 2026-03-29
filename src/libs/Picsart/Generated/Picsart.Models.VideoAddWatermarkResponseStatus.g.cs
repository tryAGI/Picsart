
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public enum VideoAddWatermarkResponseStatus
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
    public static class VideoAddWatermarkResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoAddWatermarkResponseStatus value)
        {
            return value switch
            {
                VideoAddWatermarkResponseStatus.Error => "error",
                VideoAddWatermarkResponseStatus.Processing => "processing",
                VideoAddWatermarkResponseStatus.Queued => "queued",
                VideoAddWatermarkResponseStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoAddWatermarkResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => VideoAddWatermarkResponseStatus.Error,
                "processing" => VideoAddWatermarkResponseStatus.Processing,
                "queued" => VideoAddWatermarkResponseStatus.Queued,
                "success" => VideoAddWatermarkResponseStatus.Success,
                _ => null,
            };
        }
    }
}