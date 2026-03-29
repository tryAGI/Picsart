
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenaiImageInpaintingResponse
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
        public global::System.Collections.Generic.IList<global::Picsart.GenaiImageInpaintingResponseDataItem>? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenaiImageInpaintingResponse" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenaiImageInpaintingResponse(
            string? status,
            global::System.Collections.Generic.IList<global::Picsart.GenaiImageInpaintingResponseDataItem>? data)
        {
            this.Status = status;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenaiImageInpaintingResponse" /> class.
        /// </summary>
        public GenaiImageInpaintingResponse()
        {
        }
    }
}