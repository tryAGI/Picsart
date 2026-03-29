
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageWatermarkParameters
    {
        /// <summary>
        /// Source watermark image file (binary). (If this parameter is present, the other watermark image source parameters must be empty.)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("watermark")]
        public byte[]? Watermark { get; set; }

        /// <summary>
        /// Source watermark image file (binary). (If this parameter is present, the other watermark image source parameters must be empty.)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("watermarkname")]
        public string? Watermarkname { get; set; }

        /// <summary>
        /// Source watermark image URL. (If this parameter is present, the other watermark image source parameters must be empty.)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("watermark_url")]
        public string? WatermarkUrl { get; set; }

        /// <summary>
        /// Default Value: center-middle
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("anchor_point")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.ImageWatermarkParametersAnchorPointJsonConverter))]
        public global::Picsart.ImageWatermarkParametersAnchorPoint? AnchorPoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("watermark_width")]
        public int? WatermarkWidth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("watermark_height")]
        public int? WatermarkHeight { get; set; }

        /// <summary>
        /// Define the opacity of the watermark. Takes values from 0 to 100. Default is 100 (opaque). Set to 0 to make it transparent.<br/>
        /// Default Value: 50
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("watermark_opacity")]
        public int? WatermarkOpacity { get; set; }

        /// <summary>
        /// Define the angle of the watermark. Takes values from 0 to 360.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("watermark_angle")]
        public int? WatermarkAngle { get; set; }

        /// <summary>
        /// Define the horizontal padding of the watermark.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("watermark_padding_x")]
        public int? WatermarkPaddingX { get; set; }

        /// <summary>
        /// Define the vertical padding of the watermark.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("watermark_padding_y")]
        public int? WatermarkPaddingY { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageWatermarkParameters" /> class.
        /// </summary>
        /// <param name="watermark">
        /// Source watermark image file (binary). (If this parameter is present, the other watermark image source parameters must be empty.)
        /// </param>
        /// <param name="watermarkname">
        /// Source watermark image file (binary). (If this parameter is present, the other watermark image source parameters must be empty.)
        /// </param>
        /// <param name="watermarkUrl">
        /// Source watermark image URL. (If this parameter is present, the other watermark image source parameters must be empty.)
        /// </param>
        /// <param name="anchorPoint">
        /// Default Value: center-middle
        /// </param>
        /// <param name="watermarkWidth"></param>
        /// <param name="watermarkHeight"></param>
        /// <param name="watermarkOpacity">
        /// Define the opacity of the watermark. Takes values from 0 to 100. Default is 100 (opaque). Set to 0 to make it transparent.<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="watermarkAngle">
        /// Define the angle of the watermark. Takes values from 0 to 360.
        /// </param>
        /// <param name="watermarkPaddingX">
        /// Define the horizontal padding of the watermark.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="watermarkPaddingY">
        /// Define the vertical padding of the watermark.<br/>
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageWatermarkParameters(
            byte[]? watermark,
            string? watermarkname,
            string? watermarkUrl,
            global::Picsart.ImageWatermarkParametersAnchorPoint? anchorPoint,
            int? watermarkWidth,
            int? watermarkHeight,
            int? watermarkOpacity,
            int? watermarkAngle,
            int? watermarkPaddingX,
            int? watermarkPaddingY)
        {
            this.Watermark = watermark;
            this.Watermarkname = watermarkname;
            this.WatermarkUrl = watermarkUrl;
            this.AnchorPoint = anchorPoint;
            this.WatermarkWidth = watermarkWidth;
            this.WatermarkHeight = watermarkHeight;
            this.WatermarkOpacity = watermarkOpacity;
            this.WatermarkAngle = watermarkAngle;
            this.WatermarkPaddingX = watermarkPaddingX;
            this.WatermarkPaddingY = watermarkPaddingY;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageWatermarkParameters" /> class.
        /// </summary>
        public ImageWatermarkParameters()
        {
        }
    }
}