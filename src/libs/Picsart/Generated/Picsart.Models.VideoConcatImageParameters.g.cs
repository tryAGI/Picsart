
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoConcatImageParameters
    {
        /// <summary>
        /// Source image URL. (Use either image_url or video_url.)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// Fit is where the longer side (width/height) fits the video canvas (e.g. see the width and height params). Fill is where the shorter side fits the background. Fit is the default.<br/>
        /// Default Value: fit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scale")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.VideoConcatImageParametersScaleJsonConverter))]
        public global::Picsart.VideoConcatImageParametersScale? Scale { get; set; }

        /// <summary>
        /// Duration of the image in milliseconds. Applies only if the image_url is provided.<br/>
        /// Default Value: 1000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoConcatImageParameters" /> class.
        /// </summary>
        /// <param name="imageUrl">
        /// Source image URL. (Use either image_url or video_url.)
        /// </param>
        /// <param name="scale">
        /// Fit is where the longer side (width/height) fits the video canvas (e.g. see the width and height params). Fill is where the shorter side fits the background. Fit is the default.<br/>
        /// Default Value: fit
        /// </param>
        /// <param name="duration">
        /// Duration of the image in milliseconds. Applies only if the image_url is provided.<br/>
        /// Default Value: 1000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoConcatImageParameters(
            string? imageUrl,
            global::Picsart.VideoConcatImageParametersScale? scale,
            int? duration)
        {
            this.ImageUrl = imageUrl;
            this.Scale = scale;
            this.Duration = duration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoConcatImageParameters" /> class.
        /// </summary>
        public VideoConcatImageParameters()
        {
        }
    }
}