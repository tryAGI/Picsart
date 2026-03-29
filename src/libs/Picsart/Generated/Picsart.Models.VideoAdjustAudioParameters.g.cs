
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoAdjustAudioParameters
    {
        /// <summary>
        /// The sound file url.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_url")]
        public string? AudioUrl { get; set; }

        /// <summary>
        /// The volume of the audio.<br/>
        /// Default Value: 100
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_volume")]
        public int? AudioVolume { get; set; }

        /// <summary>
        /// The volume of the video.<br/>
        /// Default Value: 100
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_volume")]
        public int? VideoVolume { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoAdjustAudioParameters" /> class.
        /// </summary>
        /// <param name="audioUrl">
        /// The sound file url.
        /// </param>
        /// <param name="audioVolume">
        /// The volume of the audio.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="videoVolume">
        /// The volume of the video.<br/>
        /// Default Value: 100
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoAdjustAudioParameters(
            string? audioUrl,
            int? audioVolume,
            int? videoVolume)
        {
            this.AudioUrl = audioUrl;
            this.AudioVolume = audioVolume;
            this.VideoVolume = videoVolume;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoAdjustAudioParameters" /> class.
        /// </summary>
        public VideoAdjustAudioParameters()
        {
        }
    }
}