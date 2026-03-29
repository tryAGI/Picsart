
#nullable enable

namespace Picsart
{
    /// <summary>
    /// Default Value: processing
    /// </summary>
    public enum GenaiText2imageResponseStatus
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
    public static class GenaiText2imageResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenaiText2imageResponseStatus value)
        {
            return value switch
            {
                GenaiText2imageResponseStatus.Error => "error",
                GenaiText2imageResponseStatus.Processing => "processing",
                GenaiText2imageResponseStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenaiText2imageResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => GenaiText2imageResponseStatus.Error,
                "processing" => GenaiText2imageResponseStatus.Processing,
                "success" => GenaiText2imageResponseStatus.Success,
                _ => null,
            };
        }
    }
}