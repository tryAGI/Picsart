
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenaiText2videoGetresultResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::Picsart.GenaiText2videoGetresultResponseData? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenaiText2videoGetresultResponse" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenaiText2videoGetresultResponse(
            string? status,
            global::Picsart.GenaiText2videoGetresultResponseData? data)
        {
            this.Status = status;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenaiText2videoGetresultResponse" /> class.
        /// </summary>
        public GenaiText2videoGetresultResponse()
        {
        }
    }
}