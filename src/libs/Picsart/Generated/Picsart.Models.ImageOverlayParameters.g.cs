
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageOverlayParameters
    {
        /// <summary>
        /// Overlay image file (binary). (If this parameter is present, the other image source parameters must be empty.) This only has an effect when output=cutout.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overlay_image")]
        public byte[]? OverlayImage { get; set; }

        /// <summary>
        /// Overlay image file (binary). (If this parameter is present, the other image source parameters must be empty.) This only has an effect when output=cutout.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overlay_imagename")]
        public string? OverlayImagename { get; set; }

        /// <summary>
        /// Overlay image URL. (If this parameter is present, the other image source parameters must be empty.) If this has a value, the output value is dismissed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overlay_image_url")]
        public string? OverlayImageUrl { get; set; }

        /// <summary>
        /// Overlay image ID of an image previously uploaded to Picsart or result image ID from a different API. (If this parameter is present, the other image source parameters must be empty.) See /upload method. If this has a value, the output value is dismissed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overlay_image_id")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? OverlayImageId { get; set; }

        /// <summary>
        /// Define the opacity of the overlay added to the main image.<br/>
        ///   Takes values from 0 to 100. Default is 100 (opaque). Set to 0 to make it transparent.<br/>
        /// Default Value: 100
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("opacity")]
        public int? Opacity { get; set; }

        /// <summary>
        /// The blend mode. Choose one of normal, darken, multiply, lighten, screen, color_dodge, overlay, soft_light, hard_light, hue, saturation, color, luminosity.  Defaults to normal.<br/>
        /// Default Value: normal
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blend_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.ImageOverlayParametersBlendModeJsonConverter))]
        public global::Picsart.ImageOverlayParametersBlendMode? BlendMode { get; set; }

        /// <summary>
        /// Optionally select one of the image formats (JPG is chosen if left blank). Options are as follows:<br/>
        ///   * JPG<br/>
        ///   * PNG<br/>
        ///   * WEBP<br/>
        /// Default Value: JPG
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.ImageOverlayParametersFormatJsonConverter))]
        public global::Picsart.ImageOverlayParametersFormat? Format { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageOverlayParameters" /> class.
        /// </summary>
        /// <param name="overlayImage">
        /// Overlay image file (binary). (If this parameter is present, the other image source parameters must be empty.) This only has an effect when output=cutout.
        /// </param>
        /// <param name="overlayImagename">
        /// Overlay image file (binary). (If this parameter is present, the other image source parameters must be empty.) This only has an effect when output=cutout.
        /// </param>
        /// <param name="overlayImageUrl">
        /// Overlay image URL. (If this parameter is present, the other image source parameters must be empty.) If this has a value, the output value is dismissed.
        /// </param>
        /// <param name="opacity">
        /// Define the opacity of the overlay added to the main image.<br/>
        ///   Takes values from 0 to 100. Default is 100 (opaque). Set to 0 to make it transparent.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="blendMode">
        /// The blend mode. Choose one of normal, darken, multiply, lighten, screen, color_dodge, overlay, soft_light, hard_light, hue, saturation, color, luminosity.  Defaults to normal.<br/>
        /// Default Value: normal
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
        public ImageOverlayParameters(
            byte[]? overlayImage,
            string? overlayImagename,
            string? overlayImageUrl,
            int? opacity,
            global::Picsart.ImageOverlayParametersBlendMode? blendMode,
            global::Picsart.ImageOverlayParametersFormat? format)
        {
            this.OverlayImage = overlayImage;
            this.OverlayImagename = overlayImagename;
            this.OverlayImageUrl = overlayImageUrl;
            this.Opacity = opacity;
            this.BlendMode = blendMode;
            this.Format = format;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageOverlayParameters" /> class.
        /// </summary>
        public ImageOverlayParameters()
        {
        }
    }
}