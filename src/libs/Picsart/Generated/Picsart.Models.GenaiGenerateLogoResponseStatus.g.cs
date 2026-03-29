
#nullable enable

namespace Picsart
{
    /// <summary>
    /// Default Value: processing
    /// </summary>
    public enum GenaiGenerateLogoResponseStatus
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
    public static class GenaiGenerateLogoResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenaiGenerateLogoResponseStatus value)
        {
            return value switch
            {
                GenaiGenerateLogoResponseStatus.Error => "error",
                GenaiGenerateLogoResponseStatus.Processing => "processing",
                GenaiGenerateLogoResponseStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenaiGenerateLogoResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => GenaiGenerateLogoResponseStatus.Error,
                "processing" => GenaiGenerateLogoResponseStatus.Processing,
                "success" => GenaiGenerateLogoResponseStatus.Success,
                _ => null,
            };
        }
    }
}