
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoExtractAudioParameters
    {
        /// <summary>
        /// Optionally select one of the audio formats (mp3 is chosen if left blank). Options are as follows:<br/>
        ///   * mp3<br/>
        ///   * m4a<br/>
        ///   * wav<br/>
        ///   * flac<br/>
        /// Default Value: mp3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.VideoExtractAudioParametersFormatJsonConverter))]
        public global::Picsart.VideoExtractAudioParametersFormat? Format { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoExtractAudioParameters" /> class.
        /// </summary>
        /// <param name="format">
        /// Optionally select one of the audio formats (mp3 is chosen if left blank). Options are as follows:<br/>
        ///   * mp3<br/>
        ///   * m4a<br/>
        ///   * wav<br/>
        ///   * flac<br/>
        /// Default Value: mp3
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoExtractAudioParameters(
            global::Picsart.VideoExtractAudioParametersFormat? format)
        {
            this.Format = format;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoExtractAudioParameters" /> class.
        /// </summary>
        public VideoExtractAudioParameters()
        {
        }
    }
}