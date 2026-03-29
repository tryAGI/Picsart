
#nullable enable

namespace Picsart
{
    /// <summary>
    /// Default Value: processing
    /// </summary>
    public enum GenaiText2audioGetresultResponseStatus
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
    public static class GenaiText2audioGetresultResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenaiText2audioGetresultResponseStatus value)
        {
            return value switch
            {
                GenaiText2audioGetresultResponseStatus.Error => "error",
                GenaiText2audioGetresultResponseStatus.Processing => "processing",
                GenaiText2audioGetresultResponseStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenaiText2audioGetresultResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => GenaiText2audioGetresultResponseStatus.Error,
                "processing" => GenaiText2audioGetresultResponseStatus.Processing,
                "success" => GenaiText2audioGetresultResponseStatus.Success,
                _ => null,
            };
        }
    }
}