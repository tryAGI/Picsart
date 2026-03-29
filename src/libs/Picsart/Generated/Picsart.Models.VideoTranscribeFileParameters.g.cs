
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoTranscribeFileParameters
    {
        /// <summary>
        /// Source video or audio URL. The maximum file size is 25mb.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_url")]
        public string? FileUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoTranscribeFileParameters" /> class.
        /// </summary>
        /// <param name="fileUrl">
        /// Source video or audio URL. The maximum file size is 25mb.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoTranscribeFileParameters(
            string? fileUrl)
        {
            this.FileUrl = fileUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoTranscribeFileParameters" /> class.
        /// </summary>
        public VideoTranscribeFileParameters()
        {
        }
    }
}