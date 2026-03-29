
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageTextureParameters
    {
        /// <summary>
        /// Optionally select one of the image formats (JPG is chosen if left blank). Options are as follows:<br/>
        ///   * JPG<br/>
        ///   * PNG<br/>
        ///   * WEBP<br/>
        /// Default Value: JPG
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.ImageTextureParametersFormatJsonConverter))]
        public global::Picsart.ImageTextureParametersFormat? Format { get; set; }

        /// <summary>
        /// Specify the width of the output image in pixels. The default is 1024 and the maximum acceptable value is 8000.<br/>
        /// Default Value: 1024
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public int? Width { get; set; }

        /// <summary>
        /// Specify the height of the output image in pixels. The default is 1024 and the maximum acceptable value is 8000.<br/>
        /// Default Value: 1024
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public int? Height { get; set; }

        /// <summary>
        /// Specify the pattern location, with x(width). Calculation starts from the center of the image. Default is 0.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset_x")]
        public int? OffsetX { get; set; }

        /// <summary>
        /// Specify the pattern location  with y(height). Calculation starts from the center of the image. Default is 0.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset_y")]
        public int? OffsetY { get; set; }

        /// <summary>
        /// Choose a pattern for the background texture. Default is hex.<br/>
        /// Default Value: hex
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pattern")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.ImageTextureParametersPatternJsonConverter))]
        public global::Picsart.ImageTextureParametersPattern? Pattern { get; set; }

        /// <summary>
        /// Enter an integer value to rotate the texture pattern from -180 to +180. Default is 0.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rotate")]
        public int? Rotate { get; set; }

        /// <summary>
        /// Enter a floating point number between 0.5 - 10.0 to scale the background texture. Default is 1.0.<br/>
        /// Default Value: 1.0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scale")]
        public float? Scale { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageTextureParameters" /> class.
        /// </summary>
        /// <param name="format">
        /// Optionally select one of the image formats (JPG is chosen if left blank). Options are as follows:<br/>
        ///   * JPG<br/>
        ///   * PNG<br/>
        ///   * WEBP<br/>
        /// Default Value: JPG
        /// </param>
        /// <param name="width">
        /// Specify the width of the output image in pixels. The default is 1024 and the maximum acceptable value is 8000.<br/>
        /// Default Value: 1024
        /// </param>
        /// <param name="height">
        /// Specify the height of the output image in pixels. The default is 1024 and the maximum acceptable value is 8000.<br/>
        /// Default Value: 1024
        /// </param>
        /// <param name="offsetX">
        /// Specify the pattern location, with x(width). Calculation starts from the center of the image. Default is 0.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="offsetY">
        /// Specify the pattern location  with y(height). Calculation starts from the center of the image. Default is 0.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="pattern">
        /// Choose a pattern for the background texture. Default is hex.<br/>
        /// Default Value: hex
        /// </param>
        /// <param name="rotate">
        /// Enter an integer value to rotate the texture pattern from -180 to +180. Default is 0.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="scale">
        /// Enter a floating point number between 0.5 - 10.0 to scale the background texture. Default is 1.0.<br/>
        /// Default Value: 1.0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageTextureParameters(
            global::Picsart.ImageTextureParametersFormat? format,
            int? width,
            int? height,
            int? offsetX,
            int? offsetY,
            global::Picsart.ImageTextureParametersPattern? pattern,
            int? rotate,
            float? scale)
        {
            this.Format = format;
            this.Width = width;
            this.Height = height;
            this.OffsetX = offsetX;
            this.OffsetY = offsetY;
            this.Pattern = pattern;
            this.Rotate = rotate;
            this.Scale = scale;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageTextureParameters" /> class.
        /// </summary>
        public ImageTextureParameters()
        {
        }
    }
}