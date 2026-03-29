
#nullable enable

namespace Picsart
{
    /// <summary>
    /// Default Value: {"format":"MP4","quality":"medium,","codec":"default,","audio_codec":"default,","frame_rate":"30,","color_space":"SRGB"}
    /// </summary>
    public sealed partial class VideoExtendedExportParametersExport
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.VideoExtendedExportParametersExportFormatJsonConverter))]
        public global::Picsart.VideoExtendedExportParametersExportFormat? Format { get; set; }

        /// <summary>
        /// The maximum target size in megabytes (not strict).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_size_mb")]
        public long? MaxSizeMb { get; set; }

        /// <summary>
        /// The quality of the output video. You can choose from low, medium or high quality outputs. By default medium is applied.<br/>
        /// Default Value: medium
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.VideoExtendedExportParametersExportQualityJsonConverter))]
        public global::Picsart.VideoExtendedExportParametersExportQuality? Quality { get; set; }

        /// <summary>
        /// The video codec. Use "default" to keep the video codec the same.<br/>
        /// Default Value: default
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("codec")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.VideoExtendedExportParametersExportCodecJsonConverter))]
        public global::Picsart.VideoExtendedExportParametersExportCodec? Codec { get; set; }

        /// <summary>
        /// The audio codec. Use "default" to keep the video codec the same.<br/>
        /// Default Value: default
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_codec")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.VideoExtendedExportParametersExportAudioCodecJsonConverter))]
        public global::Picsart.VideoExtendedExportParametersExportAudioCodec? AudioCodec { get; set; }

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
        /// The color space of the output video.<br/>
        /// Default Value: SRGB
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color_space")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.VideoExtendedExportParametersExportColorSpaceJsonConverter))]
        public global::Picsart.VideoExtendedExportParametersExportColorSpace? ColorSpace { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoExtendedExportParametersExport" /> class.
        /// </summary>
        /// <param name="format">
        /// Optionally select one of the output video formats (MP4 is chosen if left blank). Container options are as follows<br/>
        ///   * MOV<br/>
        ///   * MP4<br/>
        ///   * WEBM<br/>
        ///   * GIF<br/>
        /// Default Value: MP4
        /// </param>
        /// <param name="maxSizeMb">
        /// The maximum target size in megabytes (not strict).
        /// </param>
        /// <param name="quality">
        /// The quality of the output video. You can choose from low, medium or high quality outputs. By default medium is applied.<br/>
        /// Default Value: medium
        /// </param>
        /// <param name="codec">
        /// The video codec. Use "default" to keep the video codec the same.<br/>
        /// Default Value: default
        /// </param>
        /// <param name="audioCodec">
        /// The audio codec. Use "default" to keep the video codec the same.<br/>
        /// Default Value: default
        /// </param>
        /// <param name="frameRate">
        /// The output video frame rate.<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="bitrate">
        /// The output video bitrate in kb/s. Leave empty to set automatically and optimize accordingly.
        /// </param>
        /// <param name="colorSpace">
        /// The color space of the output video.<br/>
        /// Default Value: SRGB
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoExtendedExportParametersExport(
            global::Picsart.VideoExtendedExportParametersExportFormat? format,
            long? maxSizeMb,
            global::Picsart.VideoExtendedExportParametersExportQuality? quality,
            global::Picsart.VideoExtendedExportParametersExportCodec? codec,
            global::Picsart.VideoExtendedExportParametersExportAudioCodec? audioCodec,
            int? frameRate,
            int? bitrate,
            global::Picsart.VideoExtendedExportParametersExportColorSpace? colorSpace)
        {
            this.Format = format;
            this.MaxSizeMb = maxSizeMb;
            this.Quality = quality;
            this.Codec = codec;
            this.AudioCodec = audioCodec;
            this.FrameRate = frameRate;
            this.Bitrate = bitrate;
            this.ColorSpace = colorSpace;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoExtendedExportParametersExport" /> class.
        /// </summary>
        public VideoExtendedExportParametersExport()
        {
        }
    }
}