
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoApplyEffectResponse
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.VideoApplyEffectResponseStatusJsonConverter))]
        public global::Picsart.VideoApplyEffectResponseStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoApplyEffectResponse" /> class.
        /// </summary>
        /// <param name="transactionId"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoApplyEffectResponse(
            string? transactionId,
            global::Picsart.VideoApplyEffectResponseStatus? status)
        {
            this.TransactionId = transactionId;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoApplyEffectResponse" /> class.
        /// </summary>
        public VideoApplyEffectResponse()
        {
        }
    }
}