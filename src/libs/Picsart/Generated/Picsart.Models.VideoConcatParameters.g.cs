
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoConcatParameters
    {
        /// <summary>
        /// List of videos and images to combine into a slideshow.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public global::System.Collections.Generic.IList<global::Picsart.AllOf<global::Picsart.VideoConcatVideoParameters, global::Picsart.VideoConcatImageParameters, global::Picsart.VideoTransition>>? Items { get; set; }

        /// <summary>
        /// Background audio/sound URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bg_audio_url")]
        public string? BgAudioUrl { get; set; }

        /// <summary>
        /// Use true to repeat the audion in the background for the whole video duration or false if you want to play the audio only once.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bg_audio_repeat")]
        public bool? BgAudioRepeat { get; set; }

        /// <summary>
        /// Control the audio volume. Adjust from 0 to 100. 0 will mute the audio completely and 100 will have it at max.<br/>
        /// Default Value: 100
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bg_audio_volume")]
        public int? BgAudioVolume { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoConcatParameters" /> class.
        /// </summary>
        /// <param name="items">
        /// List of videos and images to combine into a slideshow.
        /// </param>
        /// <param name="bgAudioUrl">
        /// Background audio/sound URL.
        /// </param>
        /// <param name="bgAudioRepeat">
        /// Use true to repeat the audion in the background for the whole video duration or false if you want to play the audio only once.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="bgAudioVolume">
        /// Control the audio volume. Adjust from 0 to 100. 0 will mute the audio completely and 100 will have it at max.<br/>
        /// Default Value: 100
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoConcatParameters(
            global::System.Collections.Generic.IList<global::Picsart.AllOf<global::Picsart.VideoConcatVideoParameters, global::Picsart.VideoConcatImageParameters, global::Picsart.VideoTransition>>? items,
            string? bgAudioUrl,
            bool? bgAudioRepeat,
            int? bgAudioVolume)
        {
            this.Items = items;
            this.BgAudioUrl = bgAudioUrl;
            this.BgAudioRepeat = bgAudioRepeat;
            this.BgAudioVolume = bgAudioVolume;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoConcatParameters" /> class.
        /// </summary>
        public VideoConcatParameters()
        {
        }
    }
}