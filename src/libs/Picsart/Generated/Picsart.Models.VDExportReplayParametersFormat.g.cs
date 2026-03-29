
#nullable enable

namespace Picsart
{
    /// <summary>
    /// Optionally select one of the export formats. Options are as follows:<br/>
    ///   * PDF (Print-Ready PDF file)<br/>
    /// Default Value: PDF
    /// </summary>
    public enum VDExportReplayParametersFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Pdf,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VDExportReplayParametersFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VDExportReplayParametersFormat value)
        {
            return value switch
            {
                VDExportReplayParametersFormat.Pdf => "PDF",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VDExportReplayParametersFormat? ToEnum(string value)
        {
            return value switch
            {
                "PDF" => VDExportReplayParametersFormat.Pdf,
                _ => null,
            };
        }
    }
}