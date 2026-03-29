
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageSurfacemapParameters
    {
        /// <summary>
        /// Source mask file (binary). (If this parameter is present, the other mask source parameters must be empty.)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask")]
        public byte[]? Mask { get; set; }

        /// <summary>
        /// Source mask file (binary). (If this parameter is present, the other mask source parameters must be empty.)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maskname")]
        public string? Maskname { get; set; }

        /// <summary>
        /// Source mask URL. (If this parameter is present, the other mask source parameters must be empty.)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask_url")]
        public string? MaskUrl { get; set; }

        /// <summary>
        /// Source mask ID of an mask previously uploaded to Picsart or result mask ID from a different API. (If this parameter is present, the other mask source parameters must be empty.)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask_id")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? MaskId { get; set; }

        /// <summary>
        /// Source sticker file (binary). (If this parameter is present, the other sticker source parameters must be empty.)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sticker")]
        public byte[]? Sticker { get; set; }

        /// <summary>
        /// Source sticker file (binary). (If this parameter is present, the other sticker source parameters must be empty.)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stickername")]
        public string? Stickername { get; set; }

        /// <summary>
        /// Source sticker URL. (If this parameter is present, the other sticker source parameters must be empty.)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sticker_url")]
        public string? StickerUrl { get; set; }

        /// <summary>
        /// Source sticker ID of an sticker previously uploaded to Picsart or result sticker ID from a different API. (If this parameter is present, the other sticker source parameters must be empty.)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sticker_id")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? StickerId { get; set; }

        /// <summary>
        /// Optionally select one of the image formats (JPG is chosen if left blank). Options are as follows:<br/>
        ///   * JPG<br/>
        ///   * PNG<br/>
        ///   * WEBP<br/>
        /// Default Value: JPG
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.ImageSurfacemapParametersFormatJsonConverter))]
        public global::Picsart.ImageSurfacemapParametersFormat? Format { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageSurfacemapParameters" /> class.
        /// </summary>
        /// <param name="mask">
        /// Source mask file (binary). (If this parameter is present, the other mask source parameters must be empty.)
        /// </param>
        /// <param name="maskname">
        /// Source mask file (binary). (If this parameter is present, the other mask source parameters must be empty.)
        /// </param>
        /// <param name="maskUrl">
        /// Source mask URL. (If this parameter is present, the other mask source parameters must be empty.)
        /// </param>
        /// <param name="sticker">
        /// Source sticker file (binary). (If this parameter is present, the other sticker source parameters must be empty.)
        /// </param>
        /// <param name="stickername">
        /// Source sticker file (binary). (If this parameter is present, the other sticker source parameters must be empty.)
        /// </param>
        /// <param name="stickerUrl">
        /// Source sticker URL. (If this parameter is present, the other sticker source parameters must be empty.)
        /// </param>
        /// <param name="format">
        /// Optionally select one of the image formats (JPG is chosen if left blank). Options are as follows:<br/>
        ///   * JPG<br/>
        ///   * PNG<br/>
        ///   * WEBP<br/>
        /// Default Value: JPG
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageSurfacemapParameters(
            byte[]? mask,
            string? maskname,
            string? maskUrl,
            byte[]? sticker,
            string? stickername,
            string? stickerUrl,
            global::Picsart.ImageSurfacemapParametersFormat? format)
        {
            this.Mask = mask;
            this.Maskname = maskname;
            this.MaskUrl = maskUrl;
            this.Sticker = sticker;
            this.Stickername = stickername;
            this.StickerUrl = stickerUrl;
            this.Format = format;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageSurfacemapParameters" /> class.
        /// </summary>
        public ImageSurfacemapParameters()
        {
        }
    }
}