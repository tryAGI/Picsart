
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoExportParameters
    {
        /// <summary>
        /// Default Value: {"format":"MP4","frame_rate":30}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("export")]
        public global::Picsart.VideoExportParametersExport? Export { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoExportParameters" /> class.
        /// </summary>
        /// <param name="export">
        /// Default Value: {"format":"MP4","frame_rate":30}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoExportParameters(
            global::Picsart.VideoExportParametersExport? export)
        {
            this.Export = export;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoExportParameters" /> class.
        /// </summary>
        public VideoExportParameters()
        {
        }
    }
}