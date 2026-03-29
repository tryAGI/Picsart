
#nullable enable

namespace Picsart
{
    /// <summary>
    /// Optionally choose a specific AI model to use for this audio generation.<br/>
    /// If not specified, a default model will be applied. Please note that the default model may change over time as Picsart continues to improve performance and accuracy. Any change to the default will be made only after thorough testing and validation to ensure it delivers better results.<br/>
    /// If you require consistent behavior or wish to evaluate different models on your own, we recommend explicitly setting this parameter.<br/>
    /// Default Value: urn:air:openai:model:openai:tts-1@1
    /// </summary>
    public enum GenAIText2SpeechModelsModel
    {
        /// <summary>
        /// 
        /// </summary>
        Urn_air_async_model_async_asyncFlashV10_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_elevenlabs_model_elevenlabs_elevenV3_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_openai_model_openai_tts1_1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenAIText2SpeechModelsModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenAIText2SpeechModelsModel value)
        {
            return value switch
            {
                GenAIText2SpeechModelsModel.Urn_air_async_model_async_asyncFlashV10_1 => "urn:air:async:model:async:async-flash-v1.0@1",
                GenAIText2SpeechModelsModel.Urn_air_elevenlabs_model_elevenlabs_elevenV3_1 => "urn:air:elevenlabs:model:elevenlabs:eleven-v3@1",
                GenAIText2SpeechModelsModel.Urn_air_openai_model_openai_tts1_1 => "urn:air:openai:model:openai:tts-1@1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenAIText2SpeechModelsModel? ToEnum(string value)
        {
            return value switch
            {
                "urn:air:async:model:async:async-flash-v1.0@1" => GenAIText2SpeechModelsModel.Urn_air_async_model_async_asyncFlashV10_1,
                "urn:air:elevenlabs:model:elevenlabs:eleven-v3@1" => GenAIText2SpeechModelsModel.Urn_air_elevenlabs_model_elevenlabs_elevenV3_1,
                "urn:air:openai:model:openai:tts-1@1" => GenAIText2SpeechModelsModel.Urn_air_openai_model_openai_tts1_1,
                _ => null,
            };
        }
    }
}