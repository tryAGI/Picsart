
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public enum VideoApplyEffectResponseStatus
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
    public static class VideoApplyEffectResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoApplyEffectResponseStatus value)
        {
            return value switch
            {
                VideoApplyEffectResponseStatus.Error => "error",
                VideoApplyEffectResponseStatus.Processing => "processing",
                VideoApplyEffectResponseStatus.Queued => "queued",
                VideoApplyEffectResponseStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoApplyEffectResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => VideoApplyEffectResponseStatus.Error,
                "processing" => VideoApplyEffectResponseStatus.Processing,
                "queued" => VideoApplyEffectResponseStatus.Queued,
                "success" => VideoApplyEffectResponseStatus.Success,
                _ => null,
            };
        }
    }
}