
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageSelectiveBlurParameters
    {
        /// <summary>
        /// The segment to add the blur effect to.<br/>
        /// Use either 'foreground', or 'background', or define the name of the segments such as 'faces' or 'car plates'.<br/>
        /// Recommendation: use short and clear names of the segment (e.g. object or area). We don't recommend using long prompts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Segment { get; set; }

        /// <summary>
        /// The blur amount to add.<br/>
        /// Default Value: 50
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blur")]
        public int? Blur { get; set; }

        /// <summary>
        /// Optionally select one of the image formats. Options are as follows:<br/>
        ///   * JPG<br/>
        ///   * PNG<br/>
        ///   * WEBP<br/>
        /// Default Value: JPG
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.ImageSelectiveBlurParametersFormatJsonConverter))]
        public global::Picsart.ImageSelectiveBlurParametersFormat? Format { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageSelectiveBlurParameters" /> class.
        /// </summary>
        /// <param name="segment">
        /// The segment to add the blur effect to.<br/>
        /// Use either 'foreground', or 'background', or define the name of the segments such as 'faces' or 'car plates'.<br/>
        /// Recommendation: use short and clear names of the segment (e.g. object or area). We don't recommend using long prompts.
        /// </param>
        /// <param name="blur">
        /// The blur amount to add.<br/>
        /// Default Value: 50
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
        public ImageSelectiveBlurParameters(
            string segment,
            int? blur,
            global::Picsart.ImageSelectiveBlurParametersFormat? format)
        {
            this.Segment = segment ?? throw new global::System.ArgumentNullException(nameof(segment));
            this.Blur = blur;
            this.Format = format;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageSelectiveBlurParameters" /> class.
        /// </summary>
        public ImageSelectiveBlurParameters()
        {
        }
    }
}