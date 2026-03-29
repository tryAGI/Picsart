
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoTranscribeAudioGetresultResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::Picsart.VideoTranscribeAudioGetresultResponseData? Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.VideoTranscribeAudioGetresultResponseStatusJsonConverter))]
        public global::Picsart.VideoTranscribeAudioGetresultResponseStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoTranscribeAudioGetresultResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoTranscribeAudioGetresultResponse(
            global::Picsart.VideoTranscribeAudioGetresultResponseData? data,
            global::Picsart.VideoTranscribeAudioGetresultResponseStatus? status)
        {
            this.Data = data;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoTranscribeAudioGetresultResponse" /> class.
        /// </summary>
        public VideoTranscribeAudioGetresultResponse()
        {
        }
    }
}