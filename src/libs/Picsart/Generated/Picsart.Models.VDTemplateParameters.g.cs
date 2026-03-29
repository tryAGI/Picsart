
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VDTemplateParameters
    {
        /// <summary>
        /// Source template ID from Picsart Inventory. (If this parameter is present, the other template source parameters must be empty.)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_id")]
        public string? TemplateId { get; set; }

        /// <summary>
        /// Source replay file (binary). (If this parameter is present, the other template source parameters must be empty.)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template")]
        public byte[]? Template { get; set; }

        /// <summary>
        /// Source replay file (binary). (If this parameter is present, the other template source parameters must be empty.)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("templatename")]
        public string? Templatename { get; set; }

        /// <summary>
        /// Source replay URL. (If this parameter is present, the other template source parameters must be empty.)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_url")]
        public string? TemplateUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VDTemplateParameters" /> class.
        /// </summary>
        /// <param name="templateId">
        /// Source template ID from Picsart Inventory. (If this parameter is present, the other template source parameters must be empty.)
        /// </param>
        /// <param name="template">
        /// Source replay file (binary). (If this parameter is present, the other template source parameters must be empty.)
        /// </param>
        /// <param name="templatename">
        /// Source replay file (binary). (If this parameter is present, the other template source parameters must be empty.)
        /// </param>
        /// <param name="templateUrl">
        /// Source replay URL. (If this parameter is present, the other template source parameters must be empty.)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VDTemplateParameters(
            string? templateId,
            byte[]? template,
            string? templatename,
            string? templateUrl)
        {
            this.TemplateId = templateId;
            this.Template = template;
            this.Templatename = templatename;
            this.TemplateUrl = templateUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VDTemplateParameters" /> class.
        /// </summary>
        public VDTemplateParameters()
        {
        }
    }
}