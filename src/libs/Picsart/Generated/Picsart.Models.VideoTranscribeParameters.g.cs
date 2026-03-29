
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoTranscribeParameters
    {
        /// <summary>
        /// Optionally select one of the languages in the 2-character format (ISO 639-1). Options are as follows:<br/>
        ///   * Afrikaans - af<br/>
        ///   * Arabic - ar<br/>
        ///   * Armenian - am<br/>
        ///   * Azerbaijani - az<br/>
        ///   * Belarusian - be<br/>
        ///   * Bosnian - bs<br/>
        ///   * Bulgarian - bg<br/>
        ///   * Catalan - ca<br/>
        ///   * Chinese - zh<br/>
        ///   * Croatian - hr<br/>
        ///   * Czech - cs<br/>
        ///   * Danish - da<br/>
        ///   * Dutch - nl<br/>
        ///   * English - en<br/>
        ///   * Estonian - et<br/>
        ///   * Finnish - fi<br/>
        ///   * French - fr<br/>
        ///   * Galician - gl<br/>
        ///   * German - de<br/>
        ///   * Greek - el<br/>
        ///   * Hebrew - he<br/>
        ///   * Hindi - hi<br/>
        ///   * Hungarian - hu<br/>
        ///   * Icelandic - is<br/>
        ///   * Indonesian - id<br/>
        ///   * Italian - it<br/>
        ///   * Japanese - ja<br/>
        ///   * Kannada - kn<br/>
        ///   * Kazakh - kk<br/>
        ///   * Korean - ko<br/>
        ///   * Latvian - lv<br/>
        ///   * Lithuanian - lt <br/>
        ///   * Macedonian - mk<br/>
        ///   * Malay - ms<br/>
        ///   * Marathi - mr<br/>
        ///   * Maori - mi<br/>
        ///   * Nepali - ne<br/>
        ///   * Norwegian - no<br/>
        ///   * Persian - fa<br/>
        ///   * Polish - pl<br/>
        ///   * Portuguese - pt<br/>
        ///   * Romanian - ro<br/>
        ///   * Russian - ru<br/>
        ///   * Serbian - sr<br/>
        ///   * Slovak - sk<br/>
        ///   * Slovenian - sl<br/>
        ///   * Spanish - es<br/>
        ///   * Swahili - sw<br/>
        ///   * Swedish - sv<br/>
        ///   * Tagalog - tl<br/>
        ///   * Tamil - ta<br/>
        ///   * Thai - th<br/>
        ///   * Turkish - tr<br/>
        ///   * Ukrainian - uk<br/>
        ///   * Urdu - ur<br/>
        ///   * Vietnamese - vi<br/>
        ///   * Welsh - cy<br/>
        /// Default Value: en
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.VideoTranscribeParametersLanguageJsonConverter))]
        public global::Picsart.VideoTranscribeParametersLanguage? Language { get; set; }

        /// <summary>
        /// Optionally select one of the transcription formats (TXT is chosen if left blank). Options are as follows:<br/>
        ///   * TXT<br/>
        ///   * SRT<br/>
        ///   * VTT<br/>
        ///   * SBV<br/>
        /// Default Value: TXT
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.VideoTranscribeParametersFormatJsonConverter))]
        public global::Picsart.VideoTranscribeParametersFormat? Format { get; set; }

        /// <summary>
        /// Define the granularity of the subtitles. This works for SRT, VTT and SBV formats only.<br/>
        /// Default Value: sentence
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("granularity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.VideoTranscribeParametersGranularityJsonConverter))]
        public global::Picsart.VideoTranscribeParametersGranularity? Granularity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoTranscribeParameters" /> class.
        /// </summary>
        /// <param name="language">
        /// Optionally select one of the languages in the 2-character format (ISO 639-1). Options are as follows:<br/>
        ///   * Afrikaans - af<br/>
        ///   * Arabic - ar<br/>
        ///   * Armenian - am<br/>
        ///   * Azerbaijani - az<br/>
        ///   * Belarusian - be<br/>
        ///   * Bosnian - bs<br/>
        ///   * Bulgarian - bg<br/>
        ///   * Catalan - ca<br/>
        ///   * Chinese - zh<br/>
        ///   * Croatian - hr<br/>
        ///   * Czech - cs<br/>
        ///   * Danish - da<br/>
        ///   * Dutch - nl<br/>
        ///   * English - en<br/>
        ///   * Estonian - et<br/>
        ///   * Finnish - fi<br/>
        ///   * French - fr<br/>
        ///   * Galician - gl<br/>
        ///   * German - de<br/>
        ///   * Greek - el<br/>
        ///   * Hebrew - he<br/>
        ///   * Hindi - hi<br/>
        ///   * Hungarian - hu<br/>
        ///   * Icelandic - is<br/>
        ///   * Indonesian - id<br/>
        ///   * Italian - it<br/>
        ///   * Japanese - ja<br/>
        ///   * Kannada - kn<br/>
        ///   * Kazakh - kk<br/>
        ///   * Korean - ko<br/>
        ///   * Latvian - lv<br/>
        ///   * Lithuanian - lt <br/>
        ///   * Macedonian - mk<br/>
        ///   * Malay - ms<br/>
        ///   * Marathi - mr<br/>
        ///   * Maori - mi<br/>
        ///   * Nepali - ne<br/>
        ///   * Norwegian - no<br/>
        ///   * Persian - fa<br/>
        ///   * Polish - pl<br/>
        ///   * Portuguese - pt<br/>
        ///   * Romanian - ro<br/>
        ///   * Russian - ru<br/>
        ///   * Serbian - sr<br/>
        ///   * Slovak - sk<br/>
        ///   * Slovenian - sl<br/>
        ///   * Spanish - es<br/>
        ///   * Swahili - sw<br/>
        ///   * Swedish - sv<br/>
        ///   * Tagalog - tl<br/>
        ///   * Tamil - ta<br/>
        ///   * Thai - th<br/>
        ///   * Turkish - tr<br/>
        ///   * Ukrainian - uk<br/>
        ///   * Urdu - ur<br/>
        ///   * Vietnamese - vi<br/>
        ///   * Welsh - cy<br/>
        /// Default Value: en
        /// </param>
        /// <param name="format">
        /// Optionally select one of the transcription formats (TXT is chosen if left blank). Options are as follows:<br/>
        ///   * TXT<br/>
        ///   * SRT<br/>
        ///   * VTT<br/>
        ///   * SBV<br/>
        /// Default Value: TXT
        /// </param>
        /// <param name="granularity">
        /// Define the granularity of the subtitles. This works for SRT, VTT and SBV formats only.<br/>
        /// Default Value: sentence
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoTranscribeParameters(
            global::Picsart.VideoTranscribeParametersLanguage? language,
            global::Picsart.VideoTranscribeParametersFormat? format,
            global::Picsart.VideoTranscribeParametersGranularity? granularity)
        {
            this.Language = language;
            this.Format = format;
            this.Granularity = granularity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoTranscribeParameters" /> class.
        /// </summary>
        public VideoTranscribeParameters()
        {
        }
    }
}