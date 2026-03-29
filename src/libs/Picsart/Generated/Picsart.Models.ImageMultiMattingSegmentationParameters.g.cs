
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageMultiMattingSegmentationParameters
    {
        /// <summary>
        /// The type of segmentation to perform. Must be one of the following values:<br/>
        ///   * hair<br/>
        ///   * skin<br/>
        ///   * lips<br/>
        ///   * teeth<br/>
        ///   * eyes<br/>
        ///   * clothes<br/>
        ///   * glasses<br/>
        ///   * background<br/>
        ///   * foreground<br/>
        ///   * sky
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segmentation_class")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.ImageMultiMattingSegmentationParametersSegmentationClassJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Picsart.ImageMultiMattingSegmentationParametersSegmentationClass SegmentationClass { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageMultiMattingSegmentationParameters" /> class.
        /// </summary>
        /// <param name="segmentationClass">
        /// The type of segmentation to perform. Must be one of the following values:<br/>
        ///   * hair<br/>
        ///   * skin<br/>
        ///   * lips<br/>
        ///   * teeth<br/>
        ///   * eyes<br/>
        ///   * clothes<br/>
        ///   * glasses<br/>
        ///   * background<br/>
        ///   * foreground<br/>
        ///   * sky
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageMultiMattingSegmentationParameters(
            global::Picsart.ImageMultiMattingSegmentationParametersSegmentationClass segmentationClass)
        {
            this.SegmentationClass = segmentationClass;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageMultiMattingSegmentationParameters" /> class.
        /// </summary>
        public ImageMultiMattingSegmentationParameters()
        {
        }
    }
}