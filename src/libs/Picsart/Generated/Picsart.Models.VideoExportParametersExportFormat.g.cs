
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
    public enum VideoExportParametersExportFormat
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
    public static class VideoExportParametersExportFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoExportParametersExportFormat value)
        {
            return value switch
            {
                VideoExportParametersExportFormat.Gif => "GIF",
                VideoExportParametersExportFormat.Mov => "MOV",
                VideoExportParametersExportFormat.Mp4 => "MP4",
                VideoExportParametersExportFormat.Webm => "WEBM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoExportParametersExportFormat? ToEnum(string value)
        {
            return value switch
            {
                "GIF" => VideoExportParametersExportFormat.Gif,
                "MOV" => VideoExportParametersExportFormat.Mov,
                "MP4" => VideoExportParametersExportFormat.Mp4,
                "WEBM" => VideoExportParametersExportFormat.Webm,
                _ => null,
            };
        }
    }
}