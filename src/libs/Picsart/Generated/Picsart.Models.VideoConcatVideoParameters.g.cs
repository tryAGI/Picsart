
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoConcatVideoParameters
    {
        /// <summary>
        /// Source video URL. (Use either image_url or video_url.)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_url")]
        public string? VideoUrl { get; set; }

        /// <summary>
        /// Control the video volume. Adjust from 0 to 100. 0 will mute the video completely and 100 will have it at max.<br/>
        /// Default Value: 100
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume")]
        public int? Volume { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoConcatVideoParameters" /> class.
        /// </summary>
        /// <param name="videoUrl">
        /// Source video URL. (Use either image_url or video_url.)
        /// </param>
        /// <param name="volume">
        /// Control the video volume. Adjust from 0 to 100. 0 will mute the video completely and 100 will have it at max.<br/>
        /// Default Value: 100
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoConcatVideoParameters(
            string? videoUrl,
            int? volume)
        {
            this.VideoUrl = videoUrl;
            this.Volume = volume;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoConcatVideoParameters" /> class.
        /// </summary>
        public VideoConcatVideoParameters()
        {
        }
    }
}