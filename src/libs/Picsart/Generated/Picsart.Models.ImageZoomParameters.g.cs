
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageZoomParameters
    {
        /// <summary>
        /// The scale factor. 50 means 2x, and 75 means 1.5x.<br/>
        /// Default Value: 2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scale_factor")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ScaleFactor { get; set; }

        /// <summary>
        /// Anchor point for zooming. Determines which part of the image to focus on. Expect longer response times when 'ai' is used.<br/>
        /// Default Value: center-middle
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("anchor_point")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.ImageZoomParametersAnchorPointJsonConverter))]
        public global::Picsart.ImageZoomParametersAnchorPoint? AnchorPoint { get; set; }

        /// <summary>
        /// Optionally select one of the image formats. Options are as follows:<br/>
        ///   * JPG<br/>
        ///   * PNG<br/>
        ///   * WEBP<br/>
        /// Default Value: JPG
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.ImageZoomParametersFormatJsonConverter))]
        public global::Picsart.ImageZoomParametersFormat? Format { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageZoomParameters" /> class.
        /// </summary>
        /// <param name="scaleFactor">
        /// The scale factor. 50 means 2x, and 75 means 1.5x.<br/>
        /// Default Value: 2
        /// </param>
        /// <param name="anchorPoint">
        /// Anchor point for zooming. Determines which part of the image to focus on. Expect longer response times when 'ai' is used.<br/>
        /// Default Value: center-middle
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
        public ImageZoomParameters(
            int scaleFactor,
            global::Picsart.ImageZoomParametersAnchorPoint? anchorPoint,
            global::Picsart.ImageZoomParametersFormat? format)
        {
            this.ScaleFactor = scaleFactor;
            this.AnchorPoint = anchorPoint;
            this.Format = format;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageZoomParameters" /> class.
        /// </summary>
        public ImageZoomParameters()
        {
        }
    }
}