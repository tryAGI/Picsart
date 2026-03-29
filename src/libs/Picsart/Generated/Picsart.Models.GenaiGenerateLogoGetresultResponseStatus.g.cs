
#nullable enable

namespace Picsart
{
    /// <summary>
    /// Default Value: processing
    /// </summary>
    public enum GenaiGenerateLogoGetresultResponseStatus
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
    public static class GenaiGenerateLogoGetresultResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenaiGenerateLogoGetresultResponseStatus value)
        {
            return value switch
            {
                GenaiGenerateLogoGetresultResponseStatus.Error => "error",
                GenaiGenerateLogoGetresultResponseStatus.Processing => "processing",
                GenaiGenerateLogoGetresultResponseStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenaiGenerateLogoGetresultResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => GenaiGenerateLogoGetresultResponseStatus.Error,
                "processing" => GenaiGenerateLogoGetresultResponseStatus.Processing,
                "success" => GenaiGenerateLogoGetresultResponseStatus.Success,
                _ => null,
            };
        }
    }
}