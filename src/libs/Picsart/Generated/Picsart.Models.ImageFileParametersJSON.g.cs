
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageFileParametersJSON
    {
        /// <summary>
        /// Source file URL. (If this parameter is present, the other source parameters must be empty.)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_url")]
        public string? FileUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageFileParametersJSON" /> class.
        /// </summary>
        /// <param name="fileUrl">
        /// Source file URL. (If this parameter is present, the other source parameters must be empty.)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageFileParametersJSON(
            string? fileUrl)
        {
            this.FileUrl = fileUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageFileParametersJSON" /> class.
        /// </summary>
        public ImageFileParametersJSON()
        {
        }
    }
}