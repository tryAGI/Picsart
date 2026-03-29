
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageLaserEngravingEffectParameters
    {
        /// <summary>
        /// Can be a hexcolor code (e.g., #82d5fa, #fff) or a color name (e.g., blue). For semi-transparency, 4-/8-digit hexcodes are also supported (e.g., #18d4ff87).<br/>
        /// Default Value: black
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("engrave_color")]
        public string? EngraveColor { get; set; }

        /// <summary>
        /// Can be a hexcolor code (e.g., #82d5fa, #fff) or a color name (e.g., blue). For semi-transparency, 4-/8-digit hexcodes are also supported (e.g., #18d4ff87).<br/>
        /// Default Value: white
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background_color")]
        public string? BackgroundColor { get; set; }

        /// <summary>
        /// Optionally select one of the output image formats (JPG is chosen if left blank). Options are as follows:<br/>
        ///   * JPG<br/>
        ///   * PNG<br/>
        ///   * WEBP<br/>
        ///   * SVG<br/>
        /// Default Value: JPG
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.ImageLaserEngravingEffectParametersFormatJsonConverter))]
        public global::Picsart.ImageLaserEngravingEffectParametersFormat? Format { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageLaserEngravingEffectParameters" /> class.
        /// </summary>
        /// <param name="engraveColor">
        /// Can be a hexcolor code (e.g., #82d5fa, #fff) or a color name (e.g., blue). For semi-transparency, 4-/8-digit hexcodes are also supported (e.g., #18d4ff87).<br/>
        /// Default Value: black
        /// </param>
        /// <param name="backgroundColor">
        /// Can be a hexcolor code (e.g., #82d5fa, #fff) or a color name (e.g., blue). For semi-transparency, 4-/8-digit hexcodes are also supported (e.g., #18d4ff87).<br/>
        /// Default Value: white
        /// </param>
        /// <param name="format">
        /// Optionally select one of the output image formats (JPG is chosen if left blank). Options are as follows:<br/>
        ///   * JPG<br/>
        ///   * PNG<br/>
        ///   * WEBP<br/>
        ///   * SVG<br/>
        /// Default Value: JPG
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageLaserEngravingEffectParameters(
            string? engraveColor,
            string? backgroundColor,
            global::Picsart.ImageLaserEngravingEffectParametersFormat? format)
        {
            this.EngraveColor = engraveColor;
            this.BackgroundColor = backgroundColor;
            this.Format = format;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageLaserEngravingEffectParameters" /> class.
        /// </summary>
        public ImageLaserEngravingEffectParameters()
        {
        }
    }
}