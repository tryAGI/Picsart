
#nullable enable

namespace Picsart
{
    /// <summary>
    /// Default Value: processing
    /// </summary>
    public enum GenaiText2soundResponseStatus
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
    public static class GenaiText2soundResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenaiText2soundResponseStatus value)
        {
            return value switch
            {
                GenaiText2soundResponseStatus.Error => "error",
                GenaiText2soundResponseStatus.Processing => "processing",
                GenaiText2soundResponseStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenaiText2soundResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => GenaiText2soundResponseStatus.Error,
                "processing" => GenaiText2soundResponseStatus.Processing,
                "success" => GenaiText2soundResponseStatus.Success,
                _ => null,
            };
        }
    }
}