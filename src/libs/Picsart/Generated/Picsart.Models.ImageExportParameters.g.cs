
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageExportParameters
    {
        /// <summary>
        /// Optionally select one of the image formats (JPG is chosen if left blank). Options are as follows:<br/>
        ///   * JPG<br/>
        ///   * PNG<br/>
        ///   * WEBP<br/>
        /// Default Value: JPG
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.ImageExportParametersFormatJsonConverter))]
        public global::Picsart.ImageExportParametersFormat? Format { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageExportParameters" /> class.
        /// </summary>
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
        public ImageExportParameters(
            global::Picsart.ImageExportParametersFormat? format)
        {
            this.Format = format;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageExportParameters" /> class.
        /// </summary>
        public ImageExportParameters()
        {
        }
    }
}