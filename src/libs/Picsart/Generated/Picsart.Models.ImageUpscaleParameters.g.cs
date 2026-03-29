
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageUpscaleParameters
    {
        /// <summary>
        /// Choose one of the upscale factors. The options are as follows<br/>
        ///   * 2<br/>
        ///   * 4<br/>
        ///   * 6<br/>
        ///   * 8<br/>
        /// Default Value: 2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upscale_factor")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UpscaleFactor { get; set; }

        /// <summary>
        /// Optionally select one of the output image formats (JPG is chosen if left blank). Options are as follows:<br/>
        ///   * JPG<br/>
        ///   * PNG<br/>
        ///   * WEBP<br/>
        /// Default Value: JPG
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.ImageUpscaleParametersFormatJsonConverter))]
        public global::Picsart.ImageUpscaleParametersFormat? Format { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageUpscaleParameters" /> class.
        /// </summary>
        /// <param name="upscaleFactor">
        /// Choose one of the upscale factors. The options are as follows<br/>
        ///   * 2<br/>
        ///   * 4<br/>
        ///   * 6<br/>
        ///   * 8<br/>
        /// Default Value: 2
        /// </param>
        /// <param name="format">
        /// Optionally select one of the output image formats (JPG is chosen if left blank). Options are as follows:<br/>
        ///   * JPG<br/>
        ///   * PNG<br/>
        ///   * WEBP<br/>
        /// Default Value: JPG
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageUpscaleParameters(
            int upscaleFactor,
            global::Picsart.ImageUpscaleParametersFormat? format)
        {
            this.UpscaleFactor = upscaleFactor;
            this.Format = format;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageUpscaleParameters" /> class.
        /// </summary>
        public ImageUpscaleParameters()
        {
        }
    }
}