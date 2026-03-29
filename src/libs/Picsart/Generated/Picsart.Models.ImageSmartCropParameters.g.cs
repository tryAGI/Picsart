
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageSmartCropParameters
    {
        /// <summary>
        /// The segment to crop.<br/>
        /// Use either 'foreground', or define the name of the segments such as 'hat' or 'boots'.<br/>
        /// Recommendation: use short and clear names of the segment (e.g. object or area). We don't recommend using long prompts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Segment { get; set; }

        /// <summary>
        /// Optionally enforce the ration of the result image. When both width and height parameters are provided, they should match this ratio.<br/>
        /// In case either width or height are provided, the other value will be calculated based on this ratio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.ImageSmartCropParametersRatioJsonConverter))]
        public global::Picsart.ImageSmartCropParametersRatio? Ratio { get; set; }

        /// <summary>
        /// Specify the width of the output image in pixels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public int? Width { get; set; }

        /// <summary>
        /// Specify the height of the output image in pixels. The default is 1024 and the maximum acceptable value is 8000.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public int? Height { get; set; }

        /// <summary>
        /// The margin to add around the crop segment. Values are defined in pixels.<br/>
        /// When ratio is provided, that is applied after the margin is applied to guarantee the minimum gap before the edge of the image.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("margin")]
        public int? Margin { get; set; }

        /// <summary>
        /// Optionally select one of the image formats. Options are as follows:<br/>
        ///   * JPG<br/>
        ///   * PNG<br/>
        ///   * WEBP<br/>
        /// Default Value: JPG
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.ImageSmartCropParametersFormatJsonConverter))]
        public global::Picsart.ImageSmartCropParametersFormat? Format { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageSmartCropParameters" /> class.
        /// </summary>
        /// <param name="segment">
        /// The segment to crop.<br/>
        /// Use either 'foreground', or define the name of the segments such as 'hat' or 'boots'.<br/>
        /// Recommendation: use short and clear names of the segment (e.g. object or area). We don't recommend using long prompts.
        /// </param>
        /// <param name="ratio">
        /// Optionally enforce the ration of the result image. When both width and height parameters are provided, they should match this ratio.<br/>
        /// In case either width or height are provided, the other value will be calculated based on this ratio.
        /// </param>
        /// <param name="width">
        /// Specify the width of the output image in pixels.
        /// </param>
        /// <param name="height">
        /// Specify the height of the output image in pixels. The default is 1024 and the maximum acceptable value is 8000.
        /// </param>
        /// <param name="margin">
        /// The margin to add around the crop segment. Values are defined in pixels.<br/>
        /// When ratio is provided, that is applied after the margin is applied to guarantee the minimum gap before the edge of the image.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="format">
        /// Optionally select one of the image formats. Options are as follows:<br/>
        ///   * JPG<br/>
        ///   * PNG<br/>
        ///   * WEBP<br/>
        /// Default Value: JPG
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageSmartCropParameters(
            string segment,
            global::Picsart.ImageSmartCropParametersRatio? ratio,
            int? width,
            int? height,
            int? margin,
            global::Picsart.ImageSmartCropParametersFormat? format)
        {
            this.Segment = segment ?? throw new global::System.ArgumentNullException(nameof(segment));
            this.Ratio = ratio;
            this.Width = width;
            this.Height = height;
            this.Margin = margin;
            this.Format = format;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageSmartCropParameters" /> class.
        /// </summary>
        public ImageSmartCropParameters()
        {
        }
    }
}