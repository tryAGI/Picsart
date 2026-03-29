
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageFaceEnhanceParameters
    {
        /// <summary>
        /// Optionally select one of the image formats (JPG is the default). Options are as follows:<br/>
        ///   * JPG<br/>
        ///   * PNG<br/>
        ///   * WEBP<br/>
        /// Default Value: JPG
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.ImageFaceEnhanceParametersFormatJsonConverter))]
        public global::Picsart.ImageFaceEnhanceParametersFormat? Format { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageFaceEnhanceParameters" /> class.
        /// </summary>
        /// <param name="format">
        /// Optionally select one of the image formats (JPG is the default). Options are as follows:<br/>
        ///   * JPG<br/>
        ///   * PNG<br/>
        ///   * WEBP<br/>
        /// Default Value: JPG
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageFaceEnhanceParameters(
            global::Picsart.ImageFaceEnhanceParametersFormat? format)
        {
            this.Format = format;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageFaceEnhanceParameters" /> class.
        /// </summary>
        public ImageFaceEnhanceParameters()
        {
        }
    }
}