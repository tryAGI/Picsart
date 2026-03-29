
#nullable enable

namespace Picsart
{
    /// <summary>
    /// The quality of the output video. You can choose from low, medium or high quality outputs. By default medium is applied.<br/>
    /// Default Value: medium
    /// </summary>
    public enum VideoExtendedExportParametersExportQuality
    {
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoExtendedExportParametersExportQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoExtendedExportParametersExportQuality value)
        {
            return value switch
            {
                VideoExtendedExportParametersExportQuality.High => "high",
                VideoExtendedExportParametersExportQuality.Low => "low",
                VideoExtendedExportParametersExportQuality.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoExtendedExportParametersExportQuality? ToEnum(string value)
        {
            return value switch
            {
                "high" => VideoExtendedExportParametersExportQuality.High,
                "low" => VideoExtendedExportParametersExportQuality.Low,
                "medium" => VideoExtendedExportParametersExportQuality.Medium,
                _ => null,
            };
        }
    }
}