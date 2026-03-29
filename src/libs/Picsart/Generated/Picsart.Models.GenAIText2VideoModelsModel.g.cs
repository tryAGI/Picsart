
#nullable enable

namespace Picsart
{
    /// <summary>
    /// Optionally choose a specific AI model to use for this video generation.<br/>
    /// If not specified, a default model will be applied. Please note that the default model may change over time as Picsart continues to improve performance and accuracy. Any change to the default will be made only after thorough testing and validation to ensure it delivers better results.<br/>
    /// If you require consistent behavior or wish to evaluate different models on your own, we recommend explicitly setting this parameter.<br/>
    /// Default Value: urn:air:google:model:google:veo-3.1-fast-text-to-video@1
    /// </summary>
    public enum GenAIText2VideoModelsModel
    {
        /// <summary>
        /// 
        /// </summary>
        Urn_air_google_model_google_veo20ExpTextToVideo_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_google_model_google_veo20TextToVideo_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_google_model_google_veo31FastPreviewTextToVideo_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_google_model_google_veo31FastTextToVideo_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_google_model_google_veo31PreviewTextToVideo_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_google_model_google_veo31TextToVideo_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_kling_model_kling_klingV21MasterTextToVideo_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_kling_model_kling_klingV25TurboTextToVideo_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_kling_model_kling_klingV26TextToVideo_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_kling_model_kling_klingV2MasterTextToVideo_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_kling_model_kling_klingV3TextToVideo_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_ltxv_model_ltxv_ltxv2TextToVideoFast_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_ltxv_model_ltxv_ltxv2TextToVideo_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_minimax_model_minimax_hailuo02ProTextToVideo_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_openai_model_openai_sora2Pro_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_openai_model_openai_sora2_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_ovi_model_ovi_oviTextToVideo_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_pika_model_pika_pikaTextToVideoV22_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_runway_model_runway_gen45TextToVideo_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_seedance_model_seedance_seedance10ProFastTextToVideo_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_seedance_model_seedance_seedance10ProTextToVideo_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_seedance_model_seedance_seedance15ProTextToVideo_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_xai_model_xai_grokImagineVideoTextToVideo_1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenAIText2VideoModelsModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenAIText2VideoModelsModel value)
        {
            return value switch
            {
                GenAIText2VideoModelsModel.Urn_air_google_model_google_veo20ExpTextToVideo_1 => "urn:air:google:model:google:veo-2.0-exp-text-to-video@1",
                GenAIText2VideoModelsModel.Urn_air_google_model_google_veo20TextToVideo_1 => "urn:air:google:model:google:veo-2.0-text-to-video@1",
                GenAIText2VideoModelsModel.Urn_air_google_model_google_veo31FastPreviewTextToVideo_1 => "urn:air:google:model:google:veo-3.1-fast-preview-text-to-video@1",
                GenAIText2VideoModelsModel.Urn_air_google_model_google_veo31FastTextToVideo_1 => "urn:air:google:model:google:veo-3.1-fast-text-to-video@1",
                GenAIText2VideoModelsModel.Urn_air_google_model_google_veo31PreviewTextToVideo_1 => "urn:air:google:model:google:veo-3.1-preview-text-to-video@1",
                GenAIText2VideoModelsModel.Urn_air_google_model_google_veo31TextToVideo_1 => "urn:air:google:model:google:veo-3.1-text-to-video@1",
                GenAIText2VideoModelsModel.Urn_air_kling_model_kling_klingV21MasterTextToVideo_1 => "urn:air:kling:model:kling:kling-v2-1-master-text-to-video@1",
                GenAIText2VideoModelsModel.Urn_air_kling_model_kling_klingV25TurboTextToVideo_1 => "urn:air:kling:model:kling:kling-v2-5-turbo-text-to-video@1",
                GenAIText2VideoModelsModel.Urn_air_kling_model_kling_klingV26TextToVideo_1 => "urn:air:kling:model:kling:kling-v2-6-text-to-video@1",
                GenAIText2VideoModelsModel.Urn_air_kling_model_kling_klingV2MasterTextToVideo_1 => "urn:air:kling:model:kling:kling-v2-master-text-to-video@1",
                GenAIText2VideoModelsModel.Urn_air_kling_model_kling_klingV3TextToVideo_1 => "urn:air:kling:model:kling:kling-v3-text-to-video@1",
                GenAIText2VideoModelsModel.Urn_air_ltxv_model_ltxv_ltxv2TextToVideoFast_1 => "urn:air:ltxv:model:ltxv:ltxv-2-text-to-video-fast@1",
                GenAIText2VideoModelsModel.Urn_air_ltxv_model_ltxv_ltxv2TextToVideo_1 => "urn:air:ltxv:model:ltxv:ltxv-2-text-to-video@1",
                GenAIText2VideoModelsModel.Urn_air_minimax_model_minimax_hailuo02ProTextToVideo_1 => "urn:air:minimax:model:minimax:hailuo-02-pro-text-to-video@1",
                GenAIText2VideoModelsModel.Urn_air_openai_model_openai_sora2Pro_1 => "urn:air:openai:model:openai:sora-2-pro@1",
                GenAIText2VideoModelsModel.Urn_air_openai_model_openai_sora2_1 => "urn:air:openai:model:openai:sora-2@1",
                GenAIText2VideoModelsModel.Urn_air_ovi_model_ovi_oviTextToVideo_1 => "urn:air:ovi:model:ovi:ovi-text-to-video@1",
                GenAIText2VideoModelsModel.Urn_air_pika_model_pika_pikaTextToVideoV22_1 => "urn:air:pika:model:pika:pika-text-to-video-v2.2@1",
                GenAIText2VideoModelsModel.Urn_air_runway_model_runway_gen45TextToVideo_1 => "urn:air:runway:model:runway:gen4.5-text-to-video@1",
                GenAIText2VideoModelsModel.Urn_air_seedance_model_seedance_seedance10ProFastTextToVideo_1 => "urn:air:seedance:model:seedance:seedance-1.0-pro-fast-text-to-video@1",
                GenAIText2VideoModelsModel.Urn_air_seedance_model_seedance_seedance10ProTextToVideo_1 => "urn:air:seedance:model:seedance:seedance-1.0-pro-text-to-video@1",
                GenAIText2VideoModelsModel.Urn_air_seedance_model_seedance_seedance15ProTextToVideo_1 => "urn:air:seedance:model:seedance:seedance-1.5-pro-text-to-video@1",
                GenAIText2VideoModelsModel.Urn_air_xai_model_xai_grokImagineVideoTextToVideo_1 => "urn:air:xai:model:xai:grok-imagine-video-text-to-video@1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenAIText2VideoModelsModel? ToEnum(string value)
        {
            return value switch
            {
                "urn:air:google:model:google:veo-2.0-exp-text-to-video@1" => GenAIText2VideoModelsModel.Urn_air_google_model_google_veo20ExpTextToVideo_1,
                "urn:air:google:model:google:veo-2.0-text-to-video@1" => GenAIText2VideoModelsModel.Urn_air_google_model_google_veo20TextToVideo_1,
                "urn:air:google:model:google:veo-3.1-fast-preview-text-to-video@1" => GenAIText2VideoModelsModel.Urn_air_google_model_google_veo31FastPreviewTextToVideo_1,
                "urn:air:google:model:google:veo-3.1-fast-text-to-video@1" => GenAIText2VideoModelsModel.Urn_air_google_model_google_veo31FastTextToVideo_1,
                "urn:air:google:model:google:veo-3.1-preview-text-to-video@1" => GenAIText2VideoModelsModel.Urn_air_google_model_google_veo31PreviewTextToVideo_1,
                "urn:air:google:model:google:veo-3.1-text-to-video@1" => GenAIText2VideoModelsModel.Urn_air_google_model_google_veo31TextToVideo_1,
                "urn:air:kling:model:kling:kling-v2-1-master-text-to-video@1" => GenAIText2VideoModelsModel.Urn_air_kling_model_kling_klingV21MasterTextToVideo_1,
                "urn:air:kling:model:kling:kling-v2-5-turbo-text-to-video@1" => GenAIText2VideoModelsModel.Urn_air_kling_model_kling_klingV25TurboTextToVideo_1,
                "urn:air:kling:model:kling:kling-v2-6-text-to-video@1" => GenAIText2VideoModelsModel.Urn_air_kling_model_kling_klingV26TextToVideo_1,
                "urn:air:kling:model:kling:kling-v2-master-text-to-video@1" => GenAIText2VideoModelsModel.Urn_air_kling_model_kling_klingV2MasterTextToVideo_1,
                "urn:air:kling:model:kling:kling-v3-text-to-video@1" => GenAIText2VideoModelsModel.Urn_air_kling_model_kling_klingV3TextToVideo_1,
                "urn:air:ltxv:model:ltxv:ltxv-2-text-to-video-fast@1" => GenAIText2VideoModelsModel.Urn_air_ltxv_model_ltxv_ltxv2TextToVideoFast_1,
                "urn:air:ltxv:model:ltxv:ltxv-2-text-to-video@1" => GenAIText2VideoModelsModel.Urn_air_ltxv_model_ltxv_ltxv2TextToVideo_1,
                "urn:air:minimax:model:minimax:hailuo-02-pro-text-to-video@1" => GenAIText2VideoModelsModel.Urn_air_minimax_model_minimax_hailuo02ProTextToVideo_1,
                "urn:air:openai:model:openai:sora-2-pro@1" => GenAIText2VideoModelsModel.Urn_air_openai_model_openai_sora2Pro_1,
                "urn:air:openai:model:openai:sora-2@1" => GenAIText2VideoModelsModel.Urn_air_openai_model_openai_sora2_1,
                "urn:air:ovi:model:ovi:ovi-text-to-video@1" => GenAIText2VideoModelsModel.Urn_air_ovi_model_ovi_oviTextToVideo_1,
                "urn:air:pika:model:pika:pika-text-to-video-v2.2@1" => GenAIText2VideoModelsModel.Urn_air_pika_model_pika_pikaTextToVideoV22_1,
                "urn:air:runway:model:runway:gen4.5-text-to-video@1" => GenAIText2VideoModelsModel.Urn_air_runway_model_runway_gen45TextToVideo_1,
                "urn:air:seedance:model:seedance:seedance-1.0-pro-fast-text-to-video@1" => GenAIText2VideoModelsModel.Urn_air_seedance_model_seedance_seedance10ProFastTextToVideo_1,
                "urn:air:seedance:model:seedance:seedance-1.0-pro-text-to-video@1" => GenAIText2VideoModelsModel.Urn_air_seedance_model_seedance_seedance10ProTextToVideo_1,
                "urn:air:seedance:model:seedance:seedance-1.5-pro-text-to-video@1" => GenAIText2VideoModelsModel.Urn_air_seedance_model_seedance_seedance15ProTextToVideo_1,
                "urn:air:xai:model:xai:grok-imagine-video-text-to-video@1" => GenAIText2VideoModelsModel.Urn_air_xai_model_xai_grokImagineVideoTextToVideo_1,
                _ => null,
            };
        }
    }
}