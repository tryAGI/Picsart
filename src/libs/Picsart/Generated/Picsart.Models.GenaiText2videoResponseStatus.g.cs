
#nullable enable

namespace Picsart
{
    /// <summary>
    /// Default Value: processing
    /// </summary>
    public enum GenaiText2videoResponseStatus
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
    public static class GenaiText2videoResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenaiText2videoResponseStatus value)
        {
            return value switch
            {
                GenaiText2videoResponseStatus.Error => "error",
                GenaiText2videoResponseStatus.Processing => "processing",
                GenaiText2videoResponseStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenaiText2videoResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => GenaiText2videoResponseStatus.Error,
                "processing" => GenaiText2videoResponseStatus.Processing,
                "success" => GenaiText2videoResponseStatus.Success,
                _ => null,
            };
        }
    }
}