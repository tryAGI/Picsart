
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenAIText2SpeechModels
    {
        /// <summary>
        /// Optionally choose a specific AI model to use for this audio generation.<br/>
        /// If not specified, a default model will be applied. Please note that the default model may change over time as Picsart continues to improve performance and accuracy. Any change to the default will be made only after thorough testing and validation to ensure it delivers better results.<br/>
        /// If you require consistent behavior or wish to evaluate different models on your own, we recommend explicitly setting this parameter.<br/>
        /// Default Value: urn:air:openai:model:openai:tts-1@1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.GenAIText2SpeechModelsModelJsonConverter))]
        public global::Picsart.GenAIText2SpeechModelsModel? Model { get; set; }

        /// <summary>
        /// Voice for speech synthesis.<br/>
        /// Considering different models have different voices and that list changes over time, the list of supported voices is not provided here. Please go ahead to check for available voices on each provider's website.<br/>
        /// When not provided, the following default voices will be applied:<br/>
        ///   * OpenAI &gt; alloy<br/>
        ///   * Eevenlabs &gt; Rachel<br/>
        ///   * Async &gt; nyomi
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        public string? Voice { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenAIText2SpeechModels" /> class.
        /// </summary>
        /// <param name="model">
        /// Optionally choose a specific AI model to use for this audio generation.<br/>
        /// If not specified, a default model will be applied. Please note that the default model may change over time as Picsart continues to improve performance and accuracy. Any change to the default will be made only after thorough testing and validation to ensure it delivers better results.<br/>
        /// If you require consistent behavior or wish to evaluate different models on your own, we recommend explicitly setting this parameter.<br/>
        /// Default Value: urn:air:openai:model:openai:tts-1@1
        /// </param>
        /// <param name="voice">
        /// Voice for speech synthesis.<br/>
        /// Considering different models have different voices and that list changes over time, the list of supported voices is not provided here. Please go ahead to check for available voices on each provider's website.<br/>
        /// When not provided, the following default voices will be applied:<br/>
        ///   * OpenAI &gt; alloy<br/>
        ///   * Eevenlabs &gt; Rachel<br/>
        ///   * Async &gt; nyomi
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenAIText2SpeechModels(
            global::Picsart.GenAIText2SpeechModelsModel? model,
            string? voice)
        {
            this.Model = model;
            this.Voice = voice;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenAIText2SpeechModels" /> class.
        /// </summary>
        public GenAIText2SpeechModels()
        {
        }
    }
}