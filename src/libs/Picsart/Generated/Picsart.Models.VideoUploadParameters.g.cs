
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoUploadParameters
    {
        /// <summary>
        /// Source file (binary).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        public byte[]? File { get; set; }

        /// <summary>
        /// Source file (binary).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoUploadParameters" /> class.
        /// </summary>
        /// <param name="file">
        /// Source file (binary).
        /// </param>
        /// <param name="filename">
        /// Source file (binary).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoUploadParameters(
            byte[]? file,
            string? filename)
        {
            this.File = file;
            this.Filename = filename;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoUploadParameters" /> class.
        /// </summary>
        public VideoUploadParameters()
        {
        }
    }
}