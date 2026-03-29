
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenAIMaskParameters
    {
        /// <summary>
        /// Source mask file (binary). (If this parameter is present, the other mask source parameters must be empty.)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask_image")]
        public byte[]? MaskImage { get; set; }

        /// <summary>
        /// Source mask file (binary). (If this parameter is present, the other mask source parameters must be empty.)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask_imagename")]
        public string? MaskImagename { get; set; }

        /// <summary>
        /// Source mask URL. (If this parameter is present, the other mask source parameters must be empty.)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask_image_url")]
        public string? MaskImageUrl { get; set; }

        /// <summary>
        /// Deprecated. Source mask ID of an mask previously uploaded to Picsart or result mask ID from a different API. (If this parameter is present, the other mask source parameters must be empty.)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask_image_id")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? MaskImageId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenAIMaskParameters" /> class.
        /// </summary>
        /// <param name="maskImage">
        /// Source mask file (binary). (If this parameter is present, the other mask source parameters must be empty.)
        /// </param>
        /// <param name="maskImagename">
        /// Source mask file (binary). (If this parameter is present, the other mask source parameters must be empty.)
        /// </param>
        /// <param name="maskImageUrl">
        /// Source mask URL. (If this parameter is present, the other mask source parameters must be empty.)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenAIMaskParameters(
            byte[]? maskImage,
            string? maskImagename,
            string? maskImageUrl)
        {
            this.MaskImage = maskImage;
            this.MaskImagename = maskImagename;
            this.MaskImageUrl = maskImageUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenAIMaskParameters" /> class.
        /// </summary>
        public GenAIMaskParameters()
        {
        }
    }
}