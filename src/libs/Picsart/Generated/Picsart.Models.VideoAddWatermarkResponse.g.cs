
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoAddWatermarkResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
        public string? TransactionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.VideoAddWatermarkResponseStatusJsonConverter))]
        public global::Picsart.VideoAddWatermarkResponseStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoAddWatermarkResponse" /> class.
        /// </summary>
        /// <param name="transactionId"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoAddWatermarkResponse(
            string? transactionId,
            global::Picsart.VideoAddWatermarkResponseStatus? status)
        {
            this.TransactionId = transactionId;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoAddWatermarkResponse" /> class.
        /// </summary>
        public VideoAddWatermarkResponse()
        {
        }
    }
}