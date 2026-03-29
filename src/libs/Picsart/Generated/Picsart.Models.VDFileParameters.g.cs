
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VDFileParameters
    {
        /// <summary>
        /// Source file (binary). (If this parameter is present, the other source parameters must be empty.)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        public byte[]? File { get; set; }

        /// <summary>
        /// Source file (binary). (If this parameter is present, the other source parameters must be empty.)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

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
        /// Initializes a new instance of the <see cref="VDFileParameters" /> class.
        /// </summary>
        /// <param name="file">
        /// Source file (binary). (If this parameter is present, the other source parameters must be empty.)
        /// </param>
        /// <param name="filename">
        /// Source file (binary). (If this parameter is present, the other source parameters must be empty.)
        /// </param>
        /// <param name="fileUrl">
        /// Source file URL. (If this parameter is present, the other source parameters must be empty.)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VDFileParameters(
            byte[]? file,
            string? filename,
            string? fileUrl)
        {
            this.File = file;
            this.Filename = filename;
            this.FileUrl = fileUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VDFileParameters" /> class.
        /// </summary>
        public VDFileParameters()
        {
        }
    }
}