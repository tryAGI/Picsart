
#nullable enable

namespace Picsart
{
    /// <summary>
    /// Default Value: {"format":"MP4","frame_rate":30}
    /// </summary>
    public sealed partial class VideoExportParametersExport
    {
        /// <summary>
        /// Optionally select one of the output video formats (MP4 is chosen if left blank). Container options are as follows<br/>
        ///   * MOV<br/>
        ///   * MP4<br/>
        ///   * WEBM<br/>
        ///   * GIF<br/>
        /// Default Value: MP4
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.VideoExportParametersExportFormatJsonConverter))]
        public global::Picsart.VideoExportParametersExportFormat? Format { get; set; }

        /// <summary>
        /// The output video frame rate.<br/>
        /// Default Value: 30
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frame_rate")]
        public int? FrameRate { get; set; }

        /// <summary>
        /// The output video bitrate in kb/s. Leave empty to set automatically and optimize accordingly.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bitrate")]
        public int? Bitrate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoExportParametersExport" /> class.
        /// </summary>
        /// <param name="format">
        /// Optionally select one of the output video formats (MP4 is chosen if left blank). Container options are as follows<br/>
        ///   * MOV<br/>
        ///   * MP4<br/>
        ///   * WEBM<br/>
        ///   * GIF<br/>
        /// Default Value: MP4
        /// </param>
        /// <param name="frameRate">
        /// The output video frame rate.<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="bitrate">
        /// The output video bitrate in kb/s. Leave empty to set automatically and optimize accordingly.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoExportParametersExport(
            global::Picsart.VideoExportParametersExportFormat? format,
            int? frameRate,
            int? bitrate)
        {
            this.Format = format;
            this.FrameRate = frameRate;
            this.Bitrate = bitrate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoExportParametersExport" /> class.
        /// </summary>
        public VideoExportParametersExport()
        {
        }
    }
}