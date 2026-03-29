
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageVectorizerParameters
    {
        /// <summary>
        /// Large images can be downscaled. Use -1 to turn off downscaling. Otherwise the image is downscaled by 0.5 until max(width, height) &lt; downscale_to. When downscale_to is disabled with -1, the image width and height should be less than 4000px.<br/>
        /// Default Value: 2048
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("downscale_to")]
        public int? DownscaleTo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageVectorizerParameters" /> class.
        /// </summary>
        /// <param name="downscaleTo">
        /// Large images can be downscaled. Use -1 to turn off downscaling. Otherwise the image is downscaled by 0.5 until max(width, height) &lt; downscale_to. When downscale_to is disabled with -1, the image width and height should be less than 4000px.<br/>
        /// Default Value: 2048
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageVectorizerParameters(
            int? downscaleTo)
        {
            this.DownscaleTo = downscaleTo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageVectorizerParameters" /> class.
        /// </summary>
        public ImageVectorizerParameters()
        {
        }
    }
}