
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoExtendedExportParameters
    {
        /// <summary>
        /// Default Value: {"format":"MP4","quality":"medium,","codec":"default,","audio_codec":"default,","frame_rate":"30,","color_space":"SRGB"}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("export")]
        public global::Picsart.VideoExtendedExportParametersExport? Export { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoExtendedExportParameters" /> class.
        /// </summary>
        /// <param name="export">
        /// Default Value: {"format":"MP4","quality":"medium,","codec":"default,","audio_codec":"default,","frame_rate":"30,","color_space":"SRGB"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoExtendedExportParameters(
            global::Picsart.VideoExtendedExportParametersExport? export)
        {
            this.Export = export;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoExtendedExportParameters" /> class.
        /// </summary>
        public VideoExtendedExportParameters()
        {
        }
    }
}