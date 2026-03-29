
#nullable enable

namespace Picsart
{
    /// <summary>
    /// Optionally choose a specific AI model to use for this request.<br/>
    /// If not specified, a default model will be applied. Please note that the default model may change over time as Picsart continues to improve performance and accuracy. Any change to the default will be made only after thorough testing and validation to ensure it delivers better results.<br/>
    /// If you require consistent behavior or wish to evaluate different models on your own, we recommend explicitly setting this parameter.<br/>
    /// Default Value: urn:air:sdxl:model:fluxai:flux_kontext_max@1
    /// </summary>
    public enum GenAIText2StickerModelsModel
    {
        /// <summary>
        /// 
        /// </summary>
        Urn_air_fluxai_model_fluxai_flux2Flex_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_fluxai_model_fluxai_flux2Max_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_fluxai_model_fluxai_flux2Pro_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_google_model_google_gemini25FlashImage_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_google_model_google_gemini3ProImagePreview_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_google_model_google_imagen40FastGenerate001_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_google_model_google_imagen40Generate001_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_google_model_google_imagen40UltraGenerate001_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_hunyuan_model_hunyuan_hunyuanImage_3,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_ideogram_model_ideogram_ideogram2aTurbo_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_ideogram_model_ideogram_ideogram2a_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_ideogram_model_ideogram_ideogramTurbo_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_ideogram_model_ideogram_ideogramTurbo_2,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_ideogram_model_ideogram_ideogram_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_ideogram_model_ideogram_ideogram_2,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_ideogram_model_ideogram_ideogram_3,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_openai_model_openai_dallE3_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_openai_model_openai_gptImage15_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_openai_model_openai_gptImage1_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_qwen_model_qwen_qwenImage25_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_reve_model_reve_reve_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_runway_model_runway_gen4ImageRef_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_sdxl_model_fluxai_fluxKontextMax_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_sdxl_model_fluxai_fluxKontextPro_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_seedream_model_seedream_seedream_40,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_seedream_model_seedream_seedream_45,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenAIText2StickerModelsModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenAIText2StickerModelsModel value)
        {
            return value switch
            {
                GenAIText2StickerModelsModel.Urn_air_fluxai_model_fluxai_flux2Flex_1 => "urn:air:fluxai:model:fluxai:flux-2-flex@1",
                GenAIText2StickerModelsModel.Urn_air_fluxai_model_fluxai_flux2Max_1 => "urn:air:fluxai:model:fluxai:flux-2-max@1",
                GenAIText2StickerModelsModel.Urn_air_fluxai_model_fluxai_flux2Pro_1 => "urn:air:fluxai:model:fluxai:flux-2-pro@1",
                GenAIText2StickerModelsModel.Urn_air_google_model_google_gemini25FlashImage_1 => "urn:air:google:model:google:gemini-2.5-flash-image@1",
                GenAIText2StickerModelsModel.Urn_air_google_model_google_gemini3ProImagePreview_1 => "urn:air:google:model:google:gemini-3-pro-image-preview@1",
                GenAIText2StickerModelsModel.Urn_air_google_model_google_imagen40FastGenerate001_1 => "urn:air:google:model:google:imagen-4.0-fast-generate-001@1",
                GenAIText2StickerModelsModel.Urn_air_google_model_google_imagen40Generate001_1 => "urn:air:google:model:google:imagen-4.0-generate-001@1",
                GenAIText2StickerModelsModel.Urn_air_google_model_google_imagen40UltraGenerate001_1 => "urn:air:google:model:google:imagen-4.0-ultra-generate-001@1",
                GenAIText2StickerModelsModel.Urn_air_hunyuan_model_hunyuan_hunyuanImage_3 => "urn:air:hunyuan:model:hunyuan:hunyuan-image@3",
                GenAIText2StickerModelsModel.Urn_air_ideogram_model_ideogram_ideogram2aTurbo_1 => "urn:air:ideogram:model:ideogram:ideogram-2a-turbo@1",
                GenAIText2StickerModelsModel.Urn_air_ideogram_model_ideogram_ideogram2a_1 => "urn:air:ideogram:model:ideogram:ideogram-2a@1",
                GenAIText2StickerModelsModel.Urn_air_ideogram_model_ideogram_ideogramTurbo_1 => "urn:air:ideogram:model:ideogram:ideogram-turbo@1",
                GenAIText2StickerModelsModel.Urn_air_ideogram_model_ideogram_ideogramTurbo_2 => "urn:air:ideogram:model:ideogram:ideogram-turbo@2",
                GenAIText2StickerModelsModel.Urn_air_ideogram_model_ideogram_ideogram_1 => "urn:air:ideogram:model:ideogram:ideogram@1",
                GenAIText2StickerModelsModel.Urn_air_ideogram_model_ideogram_ideogram_2 => "urn:air:ideogram:model:ideogram:ideogram@2",
                GenAIText2StickerModelsModel.Urn_air_ideogram_model_ideogram_ideogram_3 => "urn:air:ideogram:model:ideogram:ideogram@3",
                GenAIText2StickerModelsModel.Urn_air_openai_model_openai_dallE3_1 => "urn:air:openai:model:openai:dall-e-3@1",
                GenAIText2StickerModelsModel.Urn_air_openai_model_openai_gptImage15_1 => "urn:air:openai:model:openai:gpt-image-1.5@1",
                GenAIText2StickerModelsModel.Urn_air_openai_model_openai_gptImage1_1 => "urn:air:openai:model:openai:gpt-image-1@1",
                GenAIText2StickerModelsModel.Urn_air_qwen_model_qwen_qwenImage25_1 => "urn:air:qwen:model:qwen:qwen-image-2.5@1",
                GenAIText2StickerModelsModel.Urn_air_reve_model_reve_reve_1 => "urn:air:reve:model:reve:reve@1",
                GenAIText2StickerModelsModel.Urn_air_runway_model_runway_gen4ImageRef_1 => "urn:air:runway:model:runway:gen4-image-ref@1",
                GenAIText2StickerModelsModel.Urn_air_sdxl_model_fluxai_fluxKontextMax_1 => "urn:air:sdxl:model:fluxai:flux_kontext_max@1",
                GenAIText2StickerModelsModel.Urn_air_sdxl_model_fluxai_fluxKontextPro_1 => "urn:air:sdxl:model:fluxai:flux_kontext_pro@1",
                GenAIText2StickerModelsModel.Urn_air_seedream_model_seedream_seedream_40 => "urn:air:seedream:model:seedream:seedream@4.0",
                GenAIText2StickerModelsModel.Urn_air_seedream_model_seedream_seedream_45 => "urn:air:seedream:model:seedream:seedream@4.5",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenAIText2StickerModelsModel? ToEnum(string value)
        {
            return value switch
            {
                "urn:air:fluxai:model:fluxai:flux-2-flex@1" => GenAIText2StickerModelsModel.Urn_air_fluxai_model_fluxai_flux2Flex_1,
                "urn:air:fluxai:model:fluxai:flux-2-max@1" => GenAIText2StickerModelsModel.Urn_air_fluxai_model_fluxai_flux2Max_1,
                "urn:air:fluxai:model:fluxai:flux-2-pro@1" => GenAIText2StickerModelsModel.Urn_air_fluxai_model_fluxai_flux2Pro_1,
                "urn:air:google:model:google:gemini-2.5-flash-image@1" => GenAIText2StickerModelsModel.Urn_air_google_model_google_gemini25FlashImage_1,
                "urn:air:google:model:google:gemini-3-pro-image-preview@1" => GenAIText2StickerModelsModel.Urn_air_google_model_google_gemini3ProImagePreview_1,
                "urn:air:google:model:google:imagen-4.0-fast-generate-001@1" => GenAIText2StickerModelsModel.Urn_air_google_model_google_imagen40FastGenerate001_1,
                "urn:air:google:model:google:imagen-4.0-generate-001@1" => GenAIText2StickerModelsModel.Urn_air_google_model_google_imagen40Generate001_1,
                "urn:air:google:model:google:imagen-4.0-ultra-generate-001@1" => GenAIText2StickerModelsModel.Urn_air_google_model_google_imagen40UltraGenerate001_1,
                "urn:air:hunyuan:model:hunyuan:hunyuan-image@3" => GenAIText2StickerModelsModel.Urn_air_hunyuan_model_hunyuan_hunyuanImage_3,
                "urn:air:ideogram:model:ideogram:ideogram-2a-turbo@1" => GenAIText2StickerModelsModel.Urn_air_ideogram_model_ideogram_ideogram2aTurbo_1,
                "urn:air:ideogram:model:ideogram:ideogram-2a@1" => GenAIText2StickerModelsModel.Urn_air_ideogram_model_ideogram_ideogram2a_1,
                "urn:air:ideogram:model:ideogram:ideogram-turbo@1" => GenAIText2StickerModelsModel.Urn_air_ideogram_model_ideogram_ideogramTurbo_1,
                "urn:air:ideogram:model:ideogram:ideogram-turbo@2" => GenAIText2StickerModelsModel.Urn_air_ideogram_model_ideogram_ideogramTurbo_2,
                "urn:air:ideogram:model:ideogram:ideogram@1" => GenAIText2StickerModelsModel.Urn_air_ideogram_model_ideogram_ideogram_1,
                "urn:air:ideogram:model:ideogram:ideogram@2" => GenAIText2StickerModelsModel.Urn_air_ideogram_model_ideogram_ideogram_2,
                "urn:air:ideogram:model:ideogram:ideogram@3" => GenAIText2StickerModelsModel.Urn_air_ideogram_model_ideogram_ideogram_3,
                "urn:air:openai:model:openai:dall-e-3@1" => GenAIText2StickerModelsModel.Urn_air_openai_model_openai_dallE3_1,
                "urn:air:openai:model:openai:gpt-image-1.5@1" => GenAIText2StickerModelsModel.Urn_air_openai_model_openai_gptImage15_1,
                "urn:air:openai:model:openai:gpt-image-1@1" => GenAIText2StickerModelsModel.Urn_air_openai_model_openai_gptImage1_1,
                "urn:air:qwen:model:qwen:qwen-image-2.5@1" => GenAIText2StickerModelsModel.Urn_air_qwen_model_qwen_qwenImage25_1,
                "urn:air:reve:model:reve:reve@1" => GenAIText2StickerModelsModel.Urn_air_reve_model_reve_reve_1,
                "urn:air:runway:model:runway:gen4-image-ref@1" => GenAIText2StickerModelsModel.Urn_air_runway_model_runway_gen4ImageRef_1,
                "urn:air:sdxl:model:fluxai:flux_kontext_max@1" => GenAIText2StickerModelsModel.Urn_air_sdxl_model_fluxai_fluxKontextMax_1,
                "urn:air:sdxl:model:fluxai:flux_kontext_pro@1" => GenAIText2StickerModelsModel.Urn_air_sdxl_model_fluxai_fluxKontextPro_1,
                "urn:air:seedream:model:seedream:seedream@4.0" => GenAIText2StickerModelsModel.Urn_air_seedream_model_seedream_seedream_40,
                "urn:air:seedream:model:seedream:seedream@4.5" => GenAIText2StickerModelsModel.Urn_air_seedream_model_seedream_seedream_45,
                _ => null,
            };
        }
    }
}