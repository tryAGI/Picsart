
#nullable enable

namespace Picsart
{
    /// <summary>
    /// Default Value: processing
    /// </summary>
    public enum GenaiText2stickerResponseStatus
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
    public static class GenaiText2stickerResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenaiText2stickerResponseStatus value)
        {
            return value switch
            {
                GenaiText2stickerResponseStatus.Error => "error",
                GenaiText2stickerResponseStatus.Processing => "processing",
                GenaiText2stickerResponseStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenaiText2stickerResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => GenaiText2stickerResponseStatus.Error,
                "processing" => GenaiText2stickerResponseStatus.Processing,
                "success" => GenaiText2stickerResponseStatus.Success,
                _ => null,
            };
        }
    }
}