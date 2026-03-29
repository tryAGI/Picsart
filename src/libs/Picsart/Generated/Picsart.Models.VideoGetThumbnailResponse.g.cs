
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoGetThumbnailResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::Picsart.VideoGetThumbnailResponseDataItem>? Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.VideoGetThumbnailResponseStatusJsonConverter))]
        public global::Picsart.VideoGetThumbnailResponseStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoGetThumbnailResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoGetThumbnailResponse(
            global::System.Collections.Generic.IList<global::Picsart.VideoGetThumbnailResponseDataItem>? data,
            global::Picsart.VideoGetThumbnailResponseStatus? status)
        {
            this.Data = data;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoGetThumbnailResponse" /> class.
        /// </summary>
        public VideoGetThumbnailResponse()
        {
        }
    }
}