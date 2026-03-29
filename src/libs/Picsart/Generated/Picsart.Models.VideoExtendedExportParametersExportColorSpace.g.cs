
#nullable enable

namespace Picsart
{
    /// <summary>
    /// The color space of the output video.<br/>
    /// Default Value: SRGB
    /// </summary>
    public enum VideoExtendedExportParametersExportColorSpace
    {
        /// <summary>
        /// 
        /// </summary>
        DisplayP3,
        /// <summary>
        /// 
        /// </summary>
        Srgb,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoExtendedExportParametersExportColorSpaceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoExtendedExportParametersExportColorSpace value)
        {
            return value switch
            {
                VideoExtendedExportParametersExportColorSpace.DisplayP3 => "DisplayP3",
                VideoExtendedExportParametersExportColorSpace.Srgb => "SRGB",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoExtendedExportParametersExportColorSpace? ToEnum(string value)
        {
            return value switch
            {
                "DisplayP3" => VideoExtendedExportParametersExportColorSpace.DisplayP3,
                "SRGB" => VideoExtendedExportParametersExportColorSpace.Srgb,
                _ => null,
            };
        }
    }
}