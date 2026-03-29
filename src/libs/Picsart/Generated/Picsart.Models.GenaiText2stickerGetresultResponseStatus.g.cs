
#nullable enable

namespace Picsart
{
    /// <summary>
    /// Default Value: processing
    /// </summary>
    public enum GenaiText2stickerGetresultResponseStatus
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
    public static class GenaiText2stickerGetresultResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenaiText2stickerGetresultResponseStatus value)
        {
            return value switch
            {
                GenaiText2stickerGetresultResponseStatus.Error => "error",
                GenaiText2stickerGetresultResponseStatus.Processing => "processing",
                GenaiText2stickerGetresultResponseStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenaiText2stickerGetresultResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => GenaiText2stickerGetresultResponseStatus.Error,
                "processing" => GenaiText2stickerGetresultResponseStatus.Processing,
                "success" => GenaiText2stickerGetresultResponseStatus.Success,
                _ => null,
            };
        }
    }
}