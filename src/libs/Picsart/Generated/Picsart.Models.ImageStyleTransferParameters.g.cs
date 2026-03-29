
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageStyleTransferParameters
    {
        /// <summary>
        /// Select a level from the dropdown menu. Smaller numbers preserve more from the original image, bigger numbers make the original image look closer to the reference image. The level options are as follows.<br/>
        ///   * l1<br/>
        ///   * l2<br/>
        ///   * l3<br/>
        ///   * l4<br/>
        ///   * l5<br/>
        /// Default Value: l1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.ImageStyleTransferParametersLevelJsonConverter))]
        public global::Picsart.ImageStyleTransferParametersLevel? Level { get; set; }

        /// <summary>
        /// Optionally select one of the image formats (JPG is chosen if left blank). Options are as follows:<br/>
        ///   * JPG<br/>
        ///   * PNG<br/>
        ///   * WEBP<br/>
        /// Default Value: JPG
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.ImageStyleTransferParametersFormatJsonConverter))]
        public global::Picsart.ImageStyleTransferParametersFormat? Format { get; set; }

        /// <summary>
        /// Source image file (binary). (If this parameter is present, the other image source parameters must be empty.)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_image")]
        public byte[]? ReferenceImage { get; set; }

        /// <summary>
        /// Source image file (binary). (If this parameter is present, the other image source parameters must be empty.)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_imagename")]
        public string? ReferenceImagename { get; set; }

        /// <summary>
        /// Enter the Picsart image ID if you previously uploaded the image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_image_id")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? ReferenceImageId { get; set; }

        /// <summary>
        /// Source image URL. (If this parameter is present, the other image source parameters must be empty.)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_image_url")]
        public string? ReferenceImageUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageStyleTransferParameters" /> class.
        /// </summary>
        /// <param name="level">
        /// Select a level from the dropdown menu. Smaller numbers preserve more from the original image, bigger numbers make the original image look closer to the reference image. The level options are as follows.<br/>
        ///   * l1<br/>
        ///   * l2<br/>
        ///   * l3<br/>
        ///   * l4<br/>
        ///   * l5<br/>
        /// Default Value: l1
        /// </param>
        /// <param name="format">
        /// Optionally select one of the image formats (JPG is chosen if left blank). Options are as follows:<br/>
        ///   * JPG<br/>
        ///   * PNG<br/>
        ///   * WEBP<br/>
        /// Default Value: JPG
        /// </param>
        /// <param name="referenceImage">
        /// Source image file (binary). (If this parameter is present, the other image source parameters must be empty.)
        /// </param>
        /// <param name="referenceImagename">
        /// Source image file (binary). (If this parameter is present, the other image source parameters must be empty.)
        /// </param>
        /// <param name="referenceImageUrl">
        /// Source image URL. (If this parameter is present, the other image source parameters must be empty.)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageStyleTransferParameters(
            global::Picsart.ImageStyleTransferParametersLevel? level,
            global::Picsart.ImageStyleTransferParametersFormat? format,
            byte[]? referenceImage,
            string? referenceImagename,
            string? referenceImageUrl)
        {
            this.Level = level;
            this.Format = format;
            this.ReferenceImage = referenceImage;
            this.ReferenceImagename = referenceImagename;
            this.ReferenceImageUrl = referenceImageUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageStyleTransferParameters" /> class.
        /// </summary>
        public ImageStyleTransferParameters()
        {
        }
    }
}