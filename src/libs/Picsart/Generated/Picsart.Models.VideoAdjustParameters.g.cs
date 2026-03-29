
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoAdjustParameters
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
        /// Enter an integer value from -100 to 100.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("brightness")]
        public int? Brightness { get; set; }

        /// <summary>
        /// Enter an integer value from -100 to 100.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contrast")]
        public int? Contrast { get; set; }

        /// <summary>
        /// Enter an integer value from -100 to 100.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clarity")]
        public int? Clarity { get; set; }

        /// <summary>
        /// Enter an integer value from -100 to 100.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("saturation")]
        public int? Saturation { get; set; }

        /// <summary>
        /// Enter an integer value from -100 to 100.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hue")]
        public int? Hue { get; set; }

        /// <summary>
        /// Enter an integer value from -100 to 100.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shadows")]
        public int? Shadows { get; set; }

        /// <summary>
        /// Enter an integer value from -100 to 100.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("highlights")]
        public int? Highlights { get; set; }

        /// <summary>
        /// Enter an integer value from -100 to 100.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public int? Temperature { get; set; }

        /// <summary>
        /// Enter an integer value from 0 to 100.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sharpen")]
        public int? Sharpen { get; set; }

        /// <summary>
        /// Enter an integer value from 0 to 100.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("noise")]
        public int? Noise { get; set; }

        /// <summary>
        /// Enter an integer value from 0 to 100.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vignette")]
        public int? Vignette { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoAdjustParameters" /> class.
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
        /// <param name="brightness">
        /// Enter an integer value from -100 to 100.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="contrast">
        /// Enter an integer value from -100 to 100.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="clarity">
        /// Enter an integer value from -100 to 100.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="saturation">
        /// Enter an integer value from -100 to 100.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="hue">
        /// Enter an integer value from -100 to 100.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="shadows">
        /// Enter an integer value from -100 to 100.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="highlights">
        /// Enter an integer value from -100 to 100.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="temperature">
        /// Enter an integer value from -100 to 100.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="sharpen">
        /// Enter an integer value from 0 to 100.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="noise">
        /// Enter an integer value from 0 to 100.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="vignette">
        /// Enter an integer value from 0 to 100.<br/>
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoAdjustParameters(
            string? audioUrl,
            int? audioVolume,
            int? videoVolume,
            int? brightness,
            int? contrast,
            int? clarity,
            int? saturation,
            int? hue,
            int? shadows,
            int? highlights,
            int? temperature,
            int? sharpen,
            int? noise,
            int? vignette)
        {
            this.AudioUrl = audioUrl;
            this.AudioVolume = audioVolume;
            this.VideoVolume = videoVolume;
            this.Brightness = brightness;
            this.Contrast = contrast;
            this.Clarity = clarity;
            this.Saturation = saturation;
            this.Hue = hue;
            this.Shadows = shadows;
            this.Highlights = highlights;
            this.Temperature = temperature;
            this.Sharpen = sharpen;
            this.Noise = noise;
            this.Vignette = vignette;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoAdjustParameters" /> class.
        /// </summary>
        public VideoAdjustParameters()
        {
        }
    }
}