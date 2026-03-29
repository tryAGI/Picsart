
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VDExportVariableDataContentParameters
    {
        /// <summary>
        /// Comma separated mapping of fields.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mapping")]
        public string? Mapping { get; set; }

        /// <summary>
        /// Optionally select one of the export formats. Options are as follows:<br/>
        ///   * PDF<br/>
        ///   * PNG<br/>
        ///   * JPG<br/>
        ///   * MP4<br/>
        ///   * REPLAY<br/>
        /// Default Value: PDF
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.VDExportVariableDataContentParametersFormatJsonConverter))]
        public global::Picsart.VDExportVariableDataContentParametersFormat? Format { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VDExportVariableDataContentParameters" /> class.
        /// </summary>
        /// <param name="mapping">
        /// Comma separated mapping of fields.
        /// </param>
        /// <param name="format">
        /// Optionally select one of the export formats. Options are as follows:<br/>
        ///   * PDF<br/>
        ///   * PNG<br/>
        ///   * JPG<br/>
        ///   * MP4<br/>
        ///   * REPLAY<br/>
        /// Default Value: PDF
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VDExportVariableDataContentParameters(
            string? mapping,
            global::Picsart.VDExportVariableDataContentParametersFormat? format)
        {
            this.Mapping = mapping;
            this.Format = format;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VDExportVariableDataContentParameters" /> class.
        /// </summary>
        public VDExportVariableDataContentParameters()
        {
        }
    }
}