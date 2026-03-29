
#nullable enable

namespace Picsart
{
    /// <summary>
    /// Default Value: processing
    /// </summary>
    public enum GenaiImage2videoResponseStatus
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
    public static class GenaiImage2videoResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenaiImage2videoResponseStatus value)
        {
            return value switch
            {
                GenaiImage2videoResponseStatus.Error => "error",
                GenaiImage2videoResponseStatus.Processing => "processing",
                GenaiImage2videoResponseStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenaiImage2videoResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => GenaiImage2videoResponseStatus.Error,
                "processing" => GenaiImage2videoResponseStatus.Processing,
                "success" => GenaiImage2videoResponseStatus.Success,
                _ => null,
            };
        }
    }
}