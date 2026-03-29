
#nullable enable

namespace Picsart
{
    /// <summary>
    /// Optionally select one of the output video formats (MP4 is chosen if left blank). Container options are as follows<br/>
    ///   * MOV<br/>
    ///   * MP4<br/>
    ///   * WEBM<br/>
    ///   * GIF<br/>
    /// Default Value: MP4
    /// </summary>
    public enum VideoExtendedExportParametersExportFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Gif,
        /// <summary>
        /// 
        /// </summary>
        Mov,
        /// <summary>
        /// 
        /// </summary>
        Mp4,
        /// <summary>
        /// 
        /// </summary>
        Webm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoExtendedExportParametersExportFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoExtendedExportParametersExportFormat value)
        {
            return value switch
            {
                VideoExtendedExportParametersExportFormat.Gif => "GIF",
                VideoExtendedExportParametersExportFormat.Mov => "MOV",
                VideoExtendedExportParametersExportFormat.Mp4 => "MP4",
                VideoExtendedExportParametersExportFormat.Webm => "WEBM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoExtendedExportParametersExportFormat? ToEnum(string value)
        {
            return value switch
            {
                "GIF" => VideoExtendedExportParametersExportFormat.Gif,
                "MOV" => VideoExtendedExportParametersExportFormat.Mov,
                "MP4" => VideoExtendedExportParametersExportFormat.Mp4,
                "WEBM" => VideoExtendedExportParametersExportFormat.Webm,
                _ => null,
            };
        }
    }
}