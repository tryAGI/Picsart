
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenAIText2SpeechParameters
    {
        /// <summary>
        /// The text to speak. Up to 5000 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// The language to speak.<br/>
        /// Default Value: en
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.GenAIText2SpeechParametersLanguageJsonConverter))]
        public global::Picsart.GenAIText2SpeechParametersLanguage? Language { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenAIText2SpeechParameters" /> class.
        /// </summary>
        /// <param name="text">
        /// The text to speak. Up to 5000 characters.
        /// </param>
        /// <param name="language">
        /// The language to speak.<br/>
        /// Default Value: en
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenAIText2SpeechParameters(
            string text,
            global::Picsart.GenAIText2SpeechParametersLanguage? language)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Language = language;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenAIText2SpeechParameters" /> class.
        /// </summary>
        public GenAIText2SpeechParameters()
        {
        }
    }
}