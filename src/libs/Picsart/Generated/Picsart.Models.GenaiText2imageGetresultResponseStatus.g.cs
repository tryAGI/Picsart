
#nullable enable

namespace Picsart
{
    /// <summary>
    /// Default Value: processing
    /// </summary>
    public enum GenaiText2imageGetresultResponseStatus
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
    public static class GenaiText2imageGetresultResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenaiText2imageGetresultResponseStatus value)
        {
            return value switch
            {
                GenaiText2imageGetresultResponseStatus.Error => "error",
                GenaiText2imageGetresultResponseStatus.Processing => "processing",
                GenaiText2imageGetresultResponseStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenaiText2imageGetresultResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => GenaiText2imageGetresultResponseStatus.Error,
                "processing" => GenaiText2imageGetresultResponseStatus.Processing,
                "success" => GenaiText2imageGetresultResponseStatus.Success,
                _ => null,
            };
        }
    }
}