
#nullable enable

namespace Picsart
{
    /// <summary>
    /// Default Value: processing
    /// </summary>
    public enum GenaiText2stickerLaserEngravingResponseStatus
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
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenaiText2stickerLaserEngravingResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenaiText2stickerLaserEngravingResponseStatus value)
        {
            return value switch
            {
                GenaiText2stickerLaserEngravingResponseStatus.Error => "error",
                GenaiText2stickerLaserEngravingResponseStatus.Processing => "processing",
                GenaiText2stickerLaserEngravingResponseStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenaiText2stickerLaserEngravingResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => GenaiText2stickerLaserEngravingResponseStatus.Error,
                "processing" => GenaiText2stickerLaserEngravingResponseStatus.Processing,
                "success" => GenaiText2stickerLaserEngravingResponseStatus.Success,
                _ => null,
            };
        }
    }
}