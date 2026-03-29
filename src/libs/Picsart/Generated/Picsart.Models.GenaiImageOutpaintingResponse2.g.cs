
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenaiImageOutpaintingResponse2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

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
        /// Initializes a new instance of the <see cref="GenaiImageOutpaintingResponse2" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="inferenceId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenaiImageOutpaintingResponse2(
            string? status,
            string? inferenceId)
        {
            this.Status = status;
            this.InferenceId = inferenceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenaiImageOutpaintingResponse2" /> class.
        /// </summary>
        public GenaiImageOutpaintingResponse2()
        {
        }
    }
}