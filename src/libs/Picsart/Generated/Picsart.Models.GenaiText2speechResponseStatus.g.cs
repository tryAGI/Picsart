
#nullable enable

namespace Picsart
{
    /// <summary>
    /// Default Value: processing
    /// </summary>
    public enum GenaiText2speechResponseStatus
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
    public static class GenaiText2speechResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenaiText2speechResponseStatus value)
        {
            return value switch
            {
                GenaiText2speechResponseStatus.Error => "error",
                GenaiText2speechResponseStatus.Processing => "processing",
                GenaiText2speechResponseStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenaiText2speechResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => GenaiText2speechResponseStatus.Error,
                "processing" => GenaiText2speechResponseStatus.Processing,
                "success" => GenaiText2speechResponseStatus.Success,
                _ => null,
            };
        }
    }
}