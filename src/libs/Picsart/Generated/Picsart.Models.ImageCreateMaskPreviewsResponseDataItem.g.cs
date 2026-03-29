
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageCreateMaskPreviewsResponseDataItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask_name")]
        public string? MaskName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageCreateMaskPreviewsResponseDataItem" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="url"></param>
        /// <param name="maskName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageCreateMaskPreviewsResponseDataItem(
            string? id,
            string? url,
            string? maskName)
        {
            this.Id = id;
            this.Url = url;
            this.MaskName = maskName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageCreateMaskPreviewsResponseDataItem" /> class.
        /// </summary>
        public ImageCreateMaskPreviewsResponseDataItem()
        {
        }
    }
}