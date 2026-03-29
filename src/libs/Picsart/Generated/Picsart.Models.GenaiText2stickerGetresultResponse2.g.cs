
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenaiText2stickerGetresultResponse2
    {
        /// <summary>
        /// Default Value: processing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.GenaiText2stickerGetresultResponseStatusJsonConverter))]
        public global::Picsart.GenaiText2stickerGetresultResponseStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inference_id")]
        public string? InferenceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenaiText2stickerGetresultResponse2" /> class.
        /// </summary>
        /// <param name="status">
        /// Default Value: processing
        /// </param>
        /// <param name="inferenceId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenaiText2stickerGetresultResponse2(
            global::Picsart.GenaiText2stickerGetresultResponseStatus? status,
            string? inferenceId)
        {
            this.Status = status;
            this.InferenceId = inferenceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenaiText2stickerGetresultResponse2" /> class.
        /// </summary>
        public GenaiText2stickerGetresultResponse2()
        {
        }
    }
}