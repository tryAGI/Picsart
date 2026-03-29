
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageUpscaleUltraParameters
    {
        /// <summary>
        /// Upscale an image with a given upscale factor. The upscale factor increases the image’s resolution without increasing its size. Upscale factor can be between 2 - 16 (default is 2).<br/>
        /// Default Value: 2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upscale_factor")]
        public int? UpscaleFactor { get; set; }

        /// <summary>
        /// Optionally define your image type. If you know what your image is about, it's better this type is provided. It will help the service optimize and use the best model for that image type. Available options are as follows:<br/>
        ///   * product<br/>
        ///   * portrait<br/>
        ///   * nature<br/>
        ///   * graphics
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("product_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.ImageUpscaleUltraParametersProductTypeJsonConverter))]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::Picsart.ImageUpscaleUltraParametersProductType? ProductType { get; set; }

        /// <summary>
        /// Optionally define your image type. If you know what your image is about, it's better this type is provided. It will help the service optimize and use the best model for that image type. Available options are as follows:<br/>
        ///   * product<br/>
        ///   * portrait<br/>
        ///   * nature<br/>
        ///   * graphics
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.ImageUpscaleUltraParametersImageTypeJsonConverter))]
        public global::Picsart.ImageUpscaleUltraParametersImageType? ImageType { get; set; }

        /// <summary>
        /// Use this query parameter to establish the processing mode. Acceptable values are sync, async and auto:<br/>
        ///   * sync: issues a synchronous request, response is given when the result is ready.<br/>
        ///   * async: forces an asynchronous request, the response, which is instantaneous, contains a "transaction_id" which is used to poll for the result.<br/>
        ///   * auto: the processing mode decision is made by the service, which depends upon the expected processing time.<br/>
        /// Default Value: sync
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.ImageUpscaleUltraParametersModeJsonConverter))]
        public global::Picsart.ImageUpscaleUltraParametersMode? Mode { get; set; }

        /// <summary>
        /// Optionally select one of the image formats. Options are as follows:<br/>
        ///   * JPG<br/>
        ///   * PNG<br/>
        ///   * WEBP<br/>
        /// Default Value: JPG
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.ImageUpscaleUltraParametersFormatJsonConverter))]
        public global::Picsart.ImageUpscaleUltraParametersFormat? Format { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageUpscaleUltraParameters" /> class.
        /// </summary>
        /// <param name="upscaleFactor">
        /// Upscale an image with a given upscale factor. The upscale factor increases the image’s resolution without increasing its size. Upscale factor can be between 2 - 16 (default is 2).<br/>
        /// Default Value: 2
        /// </param>
        /// <param name="imageType">
        /// Optionally define your image type. If you know what your image is about, it's better this type is provided. It will help the service optimize and use the best model for that image type. Available options are as follows:<br/>
        ///   * product<br/>
        ///   * portrait<br/>
        ///   * nature<br/>
        ///   * graphics
        /// </param>
        /// <param name="mode">
        /// Use this query parameter to establish the processing mode. Acceptable values are sync, async and auto:<br/>
        ///   * sync: issues a synchronous request, response is given when the result is ready.<br/>
        ///   * async: forces an asynchronous request, the response, which is instantaneous, contains a "transaction_id" which is used to poll for the result.<br/>
        ///   * auto: the processing mode decision is made by the service, which depends upon the expected processing time.<br/>
        /// Default Value: sync
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
        public ImageUpscaleUltraParameters(
            int? upscaleFactor,
            global::Picsart.ImageUpscaleUltraParametersImageType? imageType,
            global::Picsart.ImageUpscaleUltraParametersMode? mode,
            global::Picsart.ImageUpscaleUltraParametersFormat? format)
        {
            this.UpscaleFactor = upscaleFactor;
            this.ImageType = imageType;
            this.Mode = mode;
            this.Format = format;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageUpscaleUltraParameters" /> class.
        /// </summary>
        public ImageUpscaleUltraParameters()
        {
        }
    }
}