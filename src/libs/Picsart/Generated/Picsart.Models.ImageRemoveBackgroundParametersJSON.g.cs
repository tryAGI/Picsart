
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageRemoveBackgroundParametersJSON
    {
        /// <summary>
        /// Select one of the two output options. If you submit a photo of a person, **cutout** returns the person as a sticker while **mask** returns a mask photo of the person.<br/>
        /// Default Value: cutout
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.ImageRemoveBackgroundParametersJSONOutputTypeJsonConverter))]
        public global::Picsart.ImageRemoveBackgroundParametersJSONOutputType? OutputType { get; set; }

        /// <summary>
        /// Source image URL. (If this parameter is present, the other image source parameters must be empty.) If this has a value, the output value is dismissed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bg_image_url")]
        public string? BgImageUrl { get; set; }

        /// <summary>
        /// Can be a hexcolor code (e.g., #82d5fa, #fff) or a color name (e.g., blue). For semi-transparency, 4-/8-digit hexcodes are also supported (e.g., #18d4ff87). (If this parameter is present, the other bg_ parameters must be empty).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bg_color")]
        public string? BgColor { get; set; }

        /// <summary>
        /// Enter an integer value from 0 to +100.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bg_blur")]
        public int? BgBlur { get; set; }

        /// <summary>
        /// Size, in pixels, for the width. If left blank, the background is left at its original width.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bg_width")]
        public int? BgWidth { get; set; }

        /// <summary>
        /// Size, in pixels, for the height. If left blank, the background is left at its original height.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bg_height")]
        public int? BgHeight { get; set; }

        /// <summary>
        /// Fit is where the longer side (width/height) fits the background. Fill is where the shorter side fits the background. Fit is the default.<br/>
        /// Default Value: fit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scale")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.ImageRemoveBackgroundParametersJSONScaleJsonConverter))]
        public global::Picsart.ImageRemoveBackgroundParametersJSONScale? Scale { get; set; }

        /// <summary>
        /// Automatically center the object. Works only, when output_type=cutout.<br/>
        ///   We don't recommend using this flag when the object is visible only partially (e.g. half-cup or half-shoe is in the image).<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_center")]
        public bool? AutoCenter { get; set; }

        /// <summary>
        /// Add a solid stroke (border) around the cutout result. Works when output_type=cutout. Set 0 to remove. Takes values from 0 to 100.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stroke_size")]
        public int? StrokeSize { get; set; }

        /// <summary>
        /// Define the color of the stroke. <br/>
        ///   Can be a hexcolor code (e.g., #82d5fa, #fff; with or without #) or a color name (e.g., blue; in English).<br/>
        ///   For semi-transparency, 4-/8-digit hexcodes are also supported (e.g., #18d4ff87).<br/>
        ///   Gets applied if the stroke_size is 1 and above.<br/>
        /// Default Value: FFFFFF
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stroke_color")]
        public string? StrokeColor { get; set; }

        /// <summary>
        /// Define the opacity of the stroke added to the cutout result. Works when output_type=cutout and stroke_size is 1 and above.<br/>
        ///   Takes values from 0 to 100. Default is 100 (opaque). Set to 0 to make it transparent.<br/>
        /// Default Value: 100
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stroke_opacity")]
        public int? StrokeOpacity { get; set; }

        /// <summary>
        /// A universal parameter to configure the shadow. The default value is "disabled" and it will make sure that the shadow is not rendered. The "custom" value allows to define custom position for the shadow, when this value is chosen, the shadow_offset_x and the shadow_offset_y will get applied. Other values are shadow directions with preset shadow setup (10px).<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shadow")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.ImageRemoveBackgroundParametersJSONShadowJsonConverter))]
        public global::Picsart.ImageRemoveBackgroundParametersJSONShadow? Shadow { get; set; }

        /// <summary>
        /// Shadow Opacity. Works when shadow is enabled (a non-disabled value).<br/>
        /// Default Value: 20
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shadow_opacity")]
        public int? ShadowOpacity { get; set; }

        /// <summary>
        /// Shadow Blur. Works when shadow is enabled.<br/>
        /// Default Value: 50
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shadow_blur")]
        public int? ShadowBlur { get; set; }

        /// <summary>
        /// Shadow Offset X. This is mandatory to specify when shadow=custom.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shadow_offset_x")]
        public int? ShadowOffsetX { get; set; }

        /// <summary>
        /// Shadow Offset Y. This is mandatory to specify when shadow=custom.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shadow_offset_y")]
        public int? ShadowOffsetY { get; set; }

        /// <summary>
        /// Optionally choose a specific AI model to use for this request.<br/>
        /// If not specified, a default model will be applied. Please note that the default model may change over time as Picsart continues to improve performance and accuracy. Any change to the default will be made only after thorough testing and validation to ensure it delivers better results.<br/>
        /// If you require consistent behavior or wish to evaluate different models on your own, we recommend explicitly setting this parameter.<br/>
        /// Default Value: urn:air:picsart:model:picsart:sod@10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.ImageRemoveBackgroundParametersJSONModelJsonConverter))]
        public global::Picsart.ImageRemoveBackgroundParametersJSONModel? Model { get; set; }

        /// <summary>
        /// Optionally select one of the image formats (PNG is chosen if left blank). Options are as follows:<br/>
        ///   * JPG<br/>
        ///   * PNG<br/>
        ///   * WEBP<br/>
        /// Default Value: PNG
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.ImageRemoveBackgroundParametersJSONFormatJsonConverter))]
        public global::Picsart.ImageRemoveBackgroundParametersJSONFormat? Format { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageRemoveBackgroundParametersJSON" /> class.
        /// </summary>
        /// <param name="outputType">
        /// Select one of the two output options. If you submit a photo of a person, **cutout** returns the person as a sticker while **mask** returns a mask photo of the person.<br/>
        /// Default Value: cutout
        /// </param>
        /// <param name="bgImageUrl">
        /// Source image URL. (If this parameter is present, the other image source parameters must be empty.) If this has a value, the output value is dismissed.
        /// </param>
        /// <param name="bgColor">
        /// Can be a hexcolor code (e.g., #82d5fa, #fff) or a color name (e.g., blue). For semi-transparency, 4-/8-digit hexcodes are also supported (e.g., #18d4ff87). (If this parameter is present, the other bg_ parameters must be empty).
        /// </param>
        /// <param name="bgBlur">
        /// Enter an integer value from 0 to +100.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="bgWidth">
        /// Size, in pixels, for the width. If left blank, the background is left at its original width.
        /// </param>
        /// <param name="bgHeight">
        /// Size, in pixels, for the height. If left blank, the background is left at its original height.
        /// </param>
        /// <param name="scale">
        /// Fit is where the longer side (width/height) fits the background. Fill is where the shorter side fits the background. Fit is the default.<br/>
        /// Default Value: fit
        /// </param>
        /// <param name="autoCenter">
        /// Automatically center the object. Works only, when output_type=cutout.<br/>
        ///   We don't recommend using this flag when the object is visible only partially (e.g. half-cup or half-shoe is in the image).<br/>
        /// Default Value: false
        /// </param>
        /// <param name="strokeSize">
        /// Add a solid stroke (border) around the cutout result. Works when output_type=cutout. Set 0 to remove. Takes values from 0 to 100.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="strokeColor">
        /// Define the color of the stroke. <br/>
        ///   Can be a hexcolor code (e.g., #82d5fa, #fff; with or without #) or a color name (e.g., blue; in English).<br/>
        ///   For semi-transparency, 4-/8-digit hexcodes are also supported (e.g., #18d4ff87).<br/>
        ///   Gets applied if the stroke_size is 1 and above.<br/>
        /// Default Value: FFFFFF
        /// </param>
        /// <param name="strokeOpacity">
        /// Define the opacity of the stroke added to the cutout result. Works when output_type=cutout and stroke_size is 1 and above.<br/>
        ///   Takes values from 0 to 100. Default is 100 (opaque). Set to 0 to make it transparent.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="shadow">
        /// A universal parameter to configure the shadow. The default value is "disabled" and it will make sure that the shadow is not rendered. The "custom" value allows to define custom position for the shadow, when this value is chosen, the shadow_offset_x and the shadow_offset_y will get applied. Other values are shadow directions with preset shadow setup (10px).<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="shadowOpacity">
        /// Shadow Opacity. Works when shadow is enabled (a non-disabled value).<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="shadowBlur">
        /// Shadow Blur. Works when shadow is enabled.<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="shadowOffsetX">
        /// Shadow Offset X. This is mandatory to specify when shadow=custom.
        /// </param>
        /// <param name="shadowOffsetY">
        /// Shadow Offset Y. This is mandatory to specify when shadow=custom.
        /// </param>
        /// <param name="model">
        /// Optionally choose a specific AI model to use for this request.<br/>
        /// If not specified, a default model will be applied. Please note that the default model may change over time as Picsart continues to improve performance and accuracy. Any change to the default will be made only after thorough testing and validation to ensure it delivers better results.<br/>
        /// If you require consistent behavior or wish to evaluate different models on your own, we recommend explicitly setting this parameter.<br/>
        /// Default Value: urn:air:picsart:model:picsart:sod@10
        /// </param>
        /// <param name="format">
        /// Optionally select one of the image formats (PNG is chosen if left blank). Options are as follows:<br/>
        ///   * JPG<br/>
        ///   * PNG<br/>
        ///   * WEBP<br/>
        /// Default Value: PNG
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageRemoveBackgroundParametersJSON(
            global::Picsart.ImageRemoveBackgroundParametersJSONOutputType? outputType,
            string? bgImageUrl,
            string? bgColor,
            int? bgBlur,
            int? bgWidth,
            int? bgHeight,
            global::Picsart.ImageRemoveBackgroundParametersJSONScale? scale,
            bool? autoCenter,
            int? strokeSize,
            string? strokeColor,
            int? strokeOpacity,
            global::Picsart.ImageRemoveBackgroundParametersJSONShadow? shadow,
            int? shadowOpacity,
            int? shadowBlur,
            int? shadowOffsetX,
            int? shadowOffsetY,
            global::Picsart.ImageRemoveBackgroundParametersJSONModel? model,
            global::Picsart.ImageRemoveBackgroundParametersJSONFormat? format)
        {
            this.OutputType = outputType;
            this.BgImageUrl = bgImageUrl;
            this.BgColor = bgColor;
            this.BgBlur = bgBlur;
            this.BgWidth = bgWidth;
            this.BgHeight = bgHeight;
            this.Scale = scale;
            this.AutoCenter = autoCenter;
            this.StrokeSize = strokeSize;
            this.StrokeColor = strokeColor;
            this.StrokeOpacity = strokeOpacity;
            this.Shadow = shadow;
            this.ShadowOpacity = shadowOpacity;
            this.ShadowBlur = shadowBlur;
            this.ShadowOffsetX = shadowOffsetX;
            this.ShadowOffsetY = shadowOffsetY;
            this.Model = model;
            this.Format = format;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageRemoveBackgroundParametersJSON" /> class.
        /// </summary>
        public ImageRemoveBackgroundParametersJSON()
        {
        }
    }
}