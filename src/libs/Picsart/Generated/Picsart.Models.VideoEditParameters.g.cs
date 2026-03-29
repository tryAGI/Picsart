
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoEditParameters
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fit")]
        public global::Picsart.VideoFitParameters? Fit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("crop")]
        public global::Picsart.VideoCropParameters? Crop { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoEditParameters" /> class.
        /// </summary>
        /// <param name="fit"></param>
        /// <param name="crop"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoEditParameters(
            global::Picsart.VideoFitParameters? fit,
            global::Picsart.VideoCropParameters? crop)
        {
            this.Fit = fit;
            this.Crop = crop;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoEditParameters" /> class.
        /// </summary>
        public VideoEditParameters()
        {
        }
    }
}