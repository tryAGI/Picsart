
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageUpscaleEnhanceParameters
    {
        /// <summary>
        /// Upscale an image with a given upscale factor. The upscale factor increases the image’s resolution without increasing its size. Upscale factor can be between 2 - 16 (default is 2).<br/>
        /// Default Value: 2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upscale_factor")]
        public int? UpscaleFactor { get; set; }

        /// <summary>
        /// Optionally select one of the image formats (JPG is chosen if left blank). Options are as follows:<br/>
        ///   * JPG<br/>
        ///   * PNG<br/>
        ///   * WEBP<br/>
        /// Default Value: JPG
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.ImageUpscaleEnhanceParametersFormatJsonConverter))]
        public global::Picsart.ImageUpscaleEnhanceParametersFormat? Format { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageUpscaleEnhanceParameters" /> class.
        /// </summary>
        /// <param name="upscaleFactor">
        /// Upscale an image with a given upscale factor. The upscale factor increases the image’s resolution without increasing its size. Upscale factor can be between 2 - 16 (default is 2).<br/>
        /// Default Value: 2
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
        public ImageUpscaleEnhanceParameters(
            int? upscaleFactor,
            global::Picsart.ImageUpscaleEnhanceParametersFormat? format)
        {
            this.UpscaleFactor = upscaleFactor;
            this.Format = format;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageUpscaleEnhanceParameters" /> class.
        /// </summary>
        public ImageUpscaleEnhanceParameters()
        {
        }
    }
}