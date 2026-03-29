
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VDImageParameters
    {
        /// <summary>
        /// Source image file (binary). (If this parameter is present, the other image source parameters must be empty.)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public byte[]? Image { get; set; }

        /// <summary>
        /// Source image file (binary). (If this parameter is present, the other image source parameters must be empty.)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagename")]
        public string? Imagename { get; set; }

        /// <summary>
        /// Source image URL. (If this parameter is present, the other image source parameters must be empty.)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// Source image ID of an image previously uploaded to Picsart or result image ID from a different API. (If this parameter is present, the other image source parameters must be empty.)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_id")]
        public string? ImageId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VDImageParameters" /> class.
        /// </summary>
        /// <param name="image">
        /// Source image file (binary). (If this parameter is present, the other image source parameters must be empty.)
        /// </param>
        /// <param name="imagename">
        /// Source image file (binary). (If this parameter is present, the other image source parameters must be empty.)
        /// </param>
        /// <param name="imageUrl">
        /// Source image URL. (If this parameter is present, the other image source parameters must be empty.)
        /// </param>
        /// <param name="imageId">
        /// Source image ID of an image previously uploaded to Picsart or result image ID from a different API. (If this parameter is present, the other image source parameters must be empty.)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VDImageParameters(
            byte[]? image,
            string? imagename,
            string? imageUrl,
            string? imageId)
        {
            this.Image = image;
            this.Imagename = imagename;
            this.ImageUrl = imageUrl;
            this.ImageId = imageId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VDImageParameters" /> class.
        /// </summary>
        public VDImageParameters()
        {
        }
    }
}