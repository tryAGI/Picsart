
#nullable enable

namespace Picsart
{
    /// <summary>
    /// Optionally choose a specific AI model to use for this request.<br/>
    /// If not specified, a default model will be applied. Please note that the default model may change over time as Picsart continues to improve performance and accuracy. Any change to the default will be made only after thorough testing and validation to ensure it delivers better results.<br/>
    /// If you require consistent behavior or wish to evaluate different models on your own, we recommend explicitly setting this parameter.<br/>
    /// Default Value: urn:air:openai:model:openai:gpt-4o-mini@1
    /// </summary>
    public enum GenAIText2TextModelsModel
    {
        /// <summary>
        /// 
        /// </summary>
        Urn_air_anthropic_model_anthropic_claudeSonnet45Latest_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_google_model_google_gemini20Flash001_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_google_model_google_gemini20FlashLite_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_google_model_google_gemini25Flash_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_google_model_google_gemini25Pro_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_google_model_google_gemini3ProPreview_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_openai_model_openai_gpt35Turbo_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_openai_model_openai_gpt4Turbo_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_openai_model_openai_gpt41Mini_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_openai_model_openai_gpt41Nano_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_openai_model_openai_gpt41_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_openai_model_openai_gpt4oMini_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_openai_model_openai_gpt4oSearchPreview_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_openai_model_openai_gpt4o_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_openai_model_openai_gpt5Mini_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_openai_model_openai_gpt5Nano_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_openai_model_openai_gpt5SearchApi_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_openai_model_openai_gpt51Chat_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_openai_model_openai_gpt51_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_openai_model_openai_gpt52_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_openai_model_openai_gpt5_1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenAIText2TextModelsModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenAIText2TextModelsModel value)
        {
            return value switch
            {
                GenAIText2TextModelsModel.Urn_air_anthropic_model_anthropic_claudeSonnet45Latest_1 => "urn:air:anthropic:model:anthropic:claude-sonnet-4-5-latest@1",
                GenAIText2TextModelsModel.Urn_air_google_model_google_gemini20Flash001_1 => "urn:air:google:model:google:gemini-2.0-flash-001@1",
                GenAIText2TextModelsModel.Urn_air_google_model_google_gemini20FlashLite_1 => "urn:air:google:model:google:gemini-2.0-flash-lite@1",
                GenAIText2TextModelsModel.Urn_air_google_model_google_gemini25Flash_1 => "urn:air:google:model:google:gemini-2.5-flash@1",
                GenAIText2TextModelsModel.Urn_air_google_model_google_gemini25Pro_1 => "urn:air:google:model:google:gemini-2.5-pro@1",
                GenAIText2TextModelsModel.Urn_air_google_model_google_gemini3ProPreview_1 => "urn:air:google:model:google:gemini-3-pro-preview@1",
                GenAIText2TextModelsModel.Urn_air_openai_model_openai_gpt35Turbo_1 => "urn:air:openai:model:openai:gpt-3.5-turbo@1",
                GenAIText2TextModelsModel.Urn_air_openai_model_openai_gpt4Turbo_1 => "urn:air:openai:model:openai:gpt-4-turbo@1",
                GenAIText2TextModelsModel.Urn_air_openai_model_openai_gpt41Mini_1 => "urn:air:openai:model:openai:gpt-4.1-mini@1",
                GenAIText2TextModelsModel.Urn_air_openai_model_openai_gpt41Nano_1 => "urn:air:openai:model:openai:gpt-4.1-nano@1",
                GenAIText2TextModelsModel.Urn_air_openai_model_openai_gpt41_1 => "urn:air:openai:model:openai:gpt-4.1@1",
                GenAIText2TextModelsModel.Urn_air_openai_model_openai_gpt4oMini_1 => "urn:air:openai:model:openai:gpt-4o-mini@1",
                GenAIText2TextModelsModel.Urn_air_openai_model_openai_gpt4oSearchPreview_1 => "urn:air:openai:model:openai:gpt-4o-search-preview@1",
                GenAIText2TextModelsModel.Urn_air_openai_model_openai_gpt4o_1 => "urn:air:openai:model:openai:gpt-4o@1",
                GenAIText2TextModelsModel.Urn_air_openai_model_openai_gpt5Mini_1 => "urn:air:openai:model:openai:gpt-5-mini@1",
                GenAIText2TextModelsModel.Urn_air_openai_model_openai_gpt5Nano_1 => "urn:air:openai:model:openai:gpt-5-nano@1",
                GenAIText2TextModelsModel.Urn_air_openai_model_openai_gpt5SearchApi_1 => "urn:air:openai:model:openai:gpt-5-search-api@1",
                GenAIText2TextModelsModel.Urn_air_openai_model_openai_gpt51Chat_1 => "urn:air:openai:model:openai:gpt-5.1-chat@1",
                GenAIText2TextModelsModel.Urn_air_openai_model_openai_gpt51_1 => "urn:air:openai:model:openai:gpt-5.1@1",
                GenAIText2TextModelsModel.Urn_air_openai_model_openai_gpt52_1 => "urn:air:openai:model:openai:gpt-5.2@1",
                GenAIText2TextModelsModel.Urn_air_openai_model_openai_gpt5_1 => "urn:air:openai:model:openai:gpt-5@1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenAIText2TextModelsModel? ToEnum(string value)
        {
            return value switch
            {
                "urn:air:anthropic:model:anthropic:claude-sonnet-4-5-latest@1" => GenAIText2TextModelsModel.Urn_air_anthropic_model_anthropic_claudeSonnet45Latest_1,
                "urn:air:google:model:google:gemini-2.0-flash-001@1" => GenAIText2TextModelsModel.Urn_air_google_model_google_gemini20Flash001_1,
                "urn:air:google:model:google:gemini-2.0-flash-lite@1" => GenAIText2TextModelsModel.Urn_air_google_model_google_gemini20FlashLite_1,
                "urn:air:google:model:google:gemini-2.5-flash@1" => GenAIText2TextModelsModel.Urn_air_google_model_google_gemini25Flash_1,
                "urn:air:google:model:google:gemini-2.5-pro@1" => GenAIText2TextModelsModel.Urn_air_google_model_google_gemini25Pro_1,
                "urn:air:google:model:google:gemini-3-pro-preview@1" => GenAIText2TextModelsModel.Urn_air_google_model_google_gemini3ProPreview_1,
                "urn:air:openai:model:openai:gpt-3.5-turbo@1" => GenAIText2TextModelsModel.Urn_air_openai_model_openai_gpt35Turbo_1,
                "urn:air:openai:model:openai:gpt-4-turbo@1" => GenAIText2TextModelsModel.Urn_air_openai_model_openai_gpt4Turbo_1,
                "urn:air:openai:model:openai:gpt-4.1-mini@1" => GenAIText2TextModelsModel.Urn_air_openai_model_openai_gpt41Mini_1,
                "urn:air:openai:model:openai:gpt-4.1-nano@1" => GenAIText2TextModelsModel.Urn_air_openai_model_openai_gpt41Nano_1,
                "urn:air:openai:model:openai:gpt-4.1@1" => GenAIText2TextModelsModel.Urn_air_openai_model_openai_gpt41_1,
                "urn:air:openai:model:openai:gpt-4o-mini@1" => GenAIText2TextModelsModel.Urn_air_openai_model_openai_gpt4oMini_1,
                "urn:air:openai:model:openai:gpt-4o-search-preview@1" => GenAIText2TextModelsModel.Urn_air_openai_model_openai_gpt4oSearchPreview_1,
                "urn:air:openai:model:openai:gpt-4o@1" => GenAIText2TextModelsModel.Urn_air_openai_model_openai_gpt4o_1,
                "urn:air:openai:model:openai:gpt-5-mini@1" => GenAIText2TextModelsModel.Urn_air_openai_model_openai_gpt5Mini_1,
                "urn:air:openai:model:openai:gpt-5-nano@1" => GenAIText2TextModelsModel.Urn_air_openai_model_openai_gpt5Nano_1,
                "urn:air:openai:model:openai:gpt-5-search-api@1" => GenAIText2TextModelsModel.Urn_air_openai_model_openai_gpt5SearchApi_1,
                "urn:air:openai:model:openai:gpt-5.1-chat@1" => GenAIText2TextModelsModel.Urn_air_openai_model_openai_gpt51Chat_1,
                "urn:air:openai:model:openai:gpt-5.1@1" => GenAIText2TextModelsModel.Urn_air_openai_model_openai_gpt51_1,
                "urn:air:openai:model:openai:gpt-5.2@1" => GenAIText2TextModelsModel.Urn_air_openai_model_openai_gpt52_1,
                "urn:air:openai:model:openai:gpt-5@1" => GenAIText2TextModelsModel.Urn_air_openai_model_openai_gpt5_1,
                _ => null,
            };
        }
    }
}