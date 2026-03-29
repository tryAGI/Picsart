
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VDExportReplayParameters
    {
        /// <summary>
        /// Optionally select one of the export formats. Options are as follows:<br/>
        ///   * PDF (Print-Ready PDF file)<br/>
        /// Default Value: PDF
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.VDExportReplayParametersFormatJsonConverter))]
        public global::Picsart.VDExportReplayParametersFormat? Format { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VDExportReplayParameters" /> class.
        /// </summary>
        /// <param name="format">
        /// Optionally select one of the export formats. Options are as follows:<br/>
        ///   * PDF (Print-Ready PDF file)<br/>
        /// Default Value: PDF
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VDExportReplayParameters(
            global::Picsart.VDExportReplayParametersFormat? format)
        {
            this.Format = format;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VDExportReplayParameters" /> class.
        /// </summary>
        public VDExportReplayParameters()
        {
        }
    }
}