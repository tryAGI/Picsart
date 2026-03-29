
#nullable enable

namespace Picsart
{
    /// <summary>
    /// Optionally select one of the export formats. Options are as follows:<br/>
    ///   * PDF<br/>
    ///   * PNG<br/>
    ///   * JPG<br/>
    ///   * MP4<br/>
    ///   * REPLAY<br/>
    /// Default Value: PDF
    /// </summary>
    public enum VDExportVariableDataContentParametersFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Jpg,
        /// <summary>
        /// 
        /// </summary>
        Mp4,
        /// <summary>
        /// 
        /// </summary>
        Pdf,
        /// <summary>
        /// 
        /// </summary>
        Png,
        /// <summary>
        /// 
        /// </summary>
        Replay,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VDExportVariableDataContentParametersFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VDExportVariableDataContentParametersFormat value)
        {
            return value switch
            {
                VDExportVariableDataContentParametersFormat.Jpg => "JPG",
                VDExportVariableDataContentParametersFormat.Mp4 => "MP4",
                VDExportVariableDataContentParametersFormat.Pdf => "PDF",
                VDExportVariableDataContentParametersFormat.Png => "PNG",
                VDExportVariableDataContentParametersFormat.Replay => "REPLAY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VDExportVariableDataContentParametersFormat? ToEnum(string value)
        {
            return value switch
            {
                "JPG" => VDExportVariableDataContentParametersFormat.Jpg,
                "MP4" => VDExportVariableDataContentParametersFormat.Mp4,
                "PDF" => VDExportVariableDataContentParametersFormat.Pdf,
                "PNG" => VDExportVariableDataContentParametersFormat.Png,
                "REPLAY" => VDExportVariableDataContentParametersFormat.Replay,
                _ => null,
            };
        }
    }
}