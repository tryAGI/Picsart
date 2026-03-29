
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageDesignImportGetresultResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::Picsart.ImageDesignImportGetresultResponseData? Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageDesignImportGetresultResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageDesignImportGetresultResponse(
            global::Picsart.ImageDesignImportGetresultResponseData? data,
            string? status)
        {
            this.Data = data;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageDesignImportGetresultResponse" /> class.
        /// </summary>
        public ImageDesignImportGetresultResponse()
        {
        }
    }
}