
#nullable enable

namespace Picsart
{
    /// <summary>
    /// Default Value: processing
    /// </summary>
    public enum GenaiText2videoGetresultResponseStatus
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
    public static class GenaiText2videoGetresultResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenaiText2videoGetresultResponseStatus value)
        {
            return value switch
            {
                GenaiText2videoGetresultResponseStatus.Error => "error",
                GenaiText2videoGetresultResponseStatus.Processing => "processing",
                GenaiText2videoGetresultResponseStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenaiText2videoGetresultResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => GenaiText2videoGetresultResponseStatus.Error,
                "processing" => GenaiText2videoGetresultResponseStatus.Processing,
                "success" => GenaiText2videoGetresultResponseStatus.Success,
                _ => null,
            };
        }
    }
}