
#nullable enable

namespace Picsart
{
    /// <summary>
    /// Optionally choose a specific AI model to use for this video generation.<br/>
    /// If not specified, a default model will be applied. Please note that the default model may change over time as Picsart continues to improve performance and accuracy. Any change to the default will be made only after thorough testing and validation to ensure it delivers better results.<br/>
    /// If you require consistent behavior or wish to evaluate different models on your own, we recommend explicitly setting this parameter.<br/>
    /// Default Value: urn:air:google:model:google:veo-3.1-fast-text-to-video@1
    /// </summary>
    public enum GenAIImage2VideoModelsModel
    {
        /// <summary>
        /// 
        /// </summary>
        Urn_air_google_model_google_veo20ExpImageToVideo_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_google_model_google_veo20ImageToVideo_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_google_model_google_veo31FastImageToVideo_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_google_model_google_veo31FastPreviewImageToVideo_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_google_model_google_veo31ImageToVideo_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_google_model_google_veo31PreviewImageToVideo_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_kling_model_kling_klingV21ImageToVideo_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_kling_model_kling_klingV21MasterImageToVideo_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_kling_model_kling_klingV25TurboImageToVideo_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_kling_model_kling_klingV26ImageToVideo_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_kling_model_kling_klingV2MasterImageToVideo_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_kling_model_kling_klingV3ImageToVideo_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_luma_model_luma_photon1ImageToVideo_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_luma_model_luma_photonFlash1ImageToVideo_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_luma_model_luma_ray16ImageToVideo_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_luma_model_luma_ray2ImageToVideo_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_luma_model_luma_rayFlash2ImageToVideo_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_minimax_model_minimax_hailuo02ProImageToVideo_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_openai_model_openai_sora2ImageToVideo_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_openai_model_openai_sora2ProImageToVideo_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_ovi_model_ovi_oviImageToVideo_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_runway_model_runway_gen45ImageToVideo_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_seedance_model_seedance_seedance10ProFastImageToVideo_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_seedance_model_seedance_seedance10ProImageToVideo_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_seedance_model_seedance_seedance15ProImageToVideo_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_wan_model_wan_wan25ImageToVideo_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_wan_model_wan_wan26ImageToVideo_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_xai_model_xai_grokImagineVideoImageToVideo_1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenAIImage2VideoModelsModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenAIImage2VideoModelsModel value)
        {
            return value switch
            {
                GenAIImage2VideoModelsModel.Urn_air_google_model_google_veo20ExpImageToVideo_1 => "urn:air:google:model:google:veo-2.0-exp-image-to-video@1",
                GenAIImage2VideoModelsModel.Urn_air_google_model_google_veo20ImageToVideo_1 => "urn:air:google:model:google:veo-2.0-image-to-video@1",
                GenAIImage2VideoModelsModel.Urn_air_google_model_google_veo31FastImageToVideo_1 => "urn:air:google:model:google:veo-3.1-fast-image-to-video@1",
                GenAIImage2VideoModelsModel.Urn_air_google_model_google_veo31FastPreviewImageToVideo_1 => "urn:air:google:model:google:veo-3.1-fast-preview-image-to-video@1",
                GenAIImage2VideoModelsModel.Urn_air_google_model_google_veo31ImageToVideo_1 => "urn:air:google:model:google:veo-3.1-image-to-video@1",
                GenAIImage2VideoModelsModel.Urn_air_google_model_google_veo31PreviewImageToVideo_1 => "urn:air:google:model:google:veo-3.1-preview-image-to-video@1",
                GenAIImage2VideoModelsModel.Urn_air_kling_model_kling_klingV21ImageToVideo_1 => "urn:air:kling:model:kling:kling-v2-1-image-to-video@1",
                GenAIImage2VideoModelsModel.Urn_air_kling_model_kling_klingV21MasterImageToVideo_1 => "urn:air:kling:model:kling:kling-v2-1-master-image-to-video@1",
                GenAIImage2VideoModelsModel.Urn_air_kling_model_kling_klingV25TurboImageToVideo_1 => "urn:air:kling:model:kling:kling-v2-5-turbo-image-to-video@1",
                GenAIImage2VideoModelsModel.Urn_air_kling_model_kling_klingV26ImageToVideo_1 => "urn:air:kling:model:kling:kling-v2-6-image-to-video@1",
                GenAIImage2VideoModelsModel.Urn_air_kling_model_kling_klingV2MasterImageToVideo_1 => "urn:air:kling:model:kling:kling-v2-master-image-to-video@1",
                GenAIImage2VideoModelsModel.Urn_air_kling_model_kling_klingV3ImageToVideo_1 => "urn:air:kling:model:kling:kling-v3-image-to-video@1",
                GenAIImage2VideoModelsModel.Urn_air_luma_model_luma_photon1ImageToVideo_1 => "urn:air:luma:model:luma:photon-1-image-to-video@1",
                GenAIImage2VideoModelsModel.Urn_air_luma_model_luma_photonFlash1ImageToVideo_1 => "urn:air:luma:model:luma:photon-flash-1-image-to-video@1",
                GenAIImage2VideoModelsModel.Urn_air_luma_model_luma_ray16ImageToVideo_1 => "urn:air:luma:model:luma:ray-1-6-image-to-video@1",
                GenAIImage2VideoModelsModel.Urn_air_luma_model_luma_ray2ImageToVideo_1 => "urn:air:luma:model:luma:ray-2-image-to-video@1",
                GenAIImage2VideoModelsModel.Urn_air_luma_model_luma_rayFlash2ImageToVideo_1 => "urn:air:luma:model:luma:ray-flash-2-image-to-video@1",
                GenAIImage2VideoModelsModel.Urn_air_minimax_model_minimax_hailuo02ProImageToVideo_1 => "urn:air:minimax:model:minimax:hailuo-02-pro-image-to-video@1",
                GenAIImage2VideoModelsModel.Urn_air_openai_model_openai_sora2ImageToVideo_1 => "urn:air:openai:model:openai:sora-2-image-to-video@1",
                GenAIImage2VideoModelsModel.Urn_air_openai_model_openai_sora2ProImageToVideo_1 => "urn:air:openai:model:openai:sora-2-pro-image-to-video@1",
                GenAIImage2VideoModelsModel.Urn_air_ovi_model_ovi_oviImageToVideo_1 => "urn:air:ovi:model:ovi:ovi-image-to-video@1",
                GenAIImage2VideoModelsModel.Urn_air_runway_model_runway_gen45ImageToVideo_1 => "urn:air:runway:model:runway:gen4.5-image-to-video@1",
                GenAIImage2VideoModelsModel.Urn_air_seedance_model_seedance_seedance10ProFastImageToVideo_1 => "urn:air:seedance:model:seedance:seedance-1.0-pro-fast-image-to-video@1",
                GenAIImage2VideoModelsModel.Urn_air_seedance_model_seedance_seedance10ProImageToVideo_1 => "urn:air:seedance:model:seedance:seedance-1.0-pro-image-to-video@1",
                GenAIImage2VideoModelsModel.Urn_air_seedance_model_seedance_seedance15ProImageToVideo_1 => "urn:air:seedance:model:seedance:seedance-1.5-pro-image-to-video@1",
                GenAIImage2VideoModelsModel.Urn_air_wan_model_wan_wan25ImageToVideo_1 => "urn:air:wan:model:wan:wan-2.5-image-to-video@1",
                GenAIImage2VideoModelsModel.Urn_air_wan_model_wan_wan26ImageToVideo_1 => "urn:air:wan:model:wan:wan-2.6-image-to-video@1",
                GenAIImage2VideoModelsModel.Urn_air_xai_model_xai_grokImagineVideoImageToVideo_1 => "urn:air:xai:model:xai:grok-imagine-video-image-to-video@1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenAIImage2VideoModelsModel? ToEnum(string value)
        {
            return value switch
            {
                "urn:air:google:model:google:veo-2.0-exp-image-to-video@1" => GenAIImage2VideoModelsModel.Urn_air_google_model_google_veo20ExpImageToVideo_1,
                "urn:air:google:model:google:veo-2.0-image-to-video@1" => GenAIImage2VideoModelsModel.Urn_air_google_model_google_veo20ImageToVideo_1,
                "urn:air:google:model:google:veo-3.1-fast-image-to-video@1" => GenAIImage2VideoModelsModel.Urn_air_google_model_google_veo31FastImageToVideo_1,
                "urn:air:google:model:google:veo-3.1-fast-preview-image-to-video@1" => GenAIImage2VideoModelsModel.Urn_air_google_model_google_veo31FastPreviewImageToVideo_1,
                "urn:air:google:model:google:veo-3.1-image-to-video@1" => GenAIImage2VideoModelsModel.Urn_air_google_model_google_veo31ImageToVideo_1,
                "urn:air:google:model:google:veo-3.1-preview-image-to-video@1" => GenAIImage2VideoModelsModel.Urn_air_google_model_google_veo31PreviewImageToVideo_1,
                "urn:air:kling:model:kling:kling-v2-1-image-to-video@1" => GenAIImage2VideoModelsModel.Urn_air_kling_model_kling_klingV21ImageToVideo_1,
                "urn:air:kling:model:kling:kling-v2-1-master-image-to-video@1" => GenAIImage2VideoModelsModel.Urn_air_kling_model_kling_klingV21MasterImageToVideo_1,
                "urn:air:kling:model:kling:kling-v2-5-turbo-image-to-video@1" => GenAIImage2VideoModelsModel.Urn_air_kling_model_kling_klingV25TurboImageToVideo_1,
                "urn:air:kling:model:kling:kling-v2-6-image-to-video@1" => GenAIImage2VideoModelsModel.Urn_air_kling_model_kling_klingV26ImageToVideo_1,
                "urn:air:kling:model:kling:kling-v2-master-image-to-video@1" => GenAIImage2VideoModelsModel.Urn_air_kling_model_kling_klingV2MasterImageToVideo_1,
                "urn:air:kling:model:kling:kling-v3-image-to-video@1" => GenAIImage2VideoModelsModel.Urn_air_kling_model_kling_klingV3ImageToVideo_1,
                "urn:air:luma:model:luma:photon-1-image-to-video@1" => GenAIImage2VideoModelsModel.Urn_air_luma_model_luma_photon1ImageToVideo_1,
                "urn:air:luma:model:luma:photon-flash-1-image-to-video@1" => GenAIImage2VideoModelsModel.Urn_air_luma_model_luma_photonFlash1ImageToVideo_1,
                "urn:air:luma:model:luma:ray-1-6-image-to-video@1" => GenAIImage2VideoModelsModel.Urn_air_luma_model_luma_ray16ImageToVideo_1,
                "urn:air:luma:model:luma:ray-2-image-to-video@1" => GenAIImage2VideoModelsModel.Urn_air_luma_model_luma_ray2ImageToVideo_1,
                "urn:air:luma:model:luma:ray-flash-2-image-to-video@1" => GenAIImage2VideoModelsModel.Urn_air_luma_model_luma_rayFlash2ImageToVideo_1,
                "urn:air:minimax:model:minimax:hailuo-02-pro-image-to-video@1" => GenAIImage2VideoModelsModel.Urn_air_minimax_model_minimax_hailuo02ProImageToVideo_1,
                "urn:air:openai:model:openai:sora-2-image-to-video@1" => GenAIImage2VideoModelsModel.Urn_air_openai_model_openai_sora2ImageToVideo_1,
                "urn:air:openai:model:openai:sora-2-pro-image-to-video@1" => GenAIImage2VideoModelsModel.Urn_air_openai_model_openai_sora2ProImageToVideo_1,
                "urn:air:ovi:model:ovi:ovi-image-to-video@1" => GenAIImage2VideoModelsModel.Urn_air_ovi_model_ovi_oviImageToVideo_1,
                "urn:air:runway:model:runway:gen4.5-image-to-video@1" => GenAIImage2VideoModelsModel.Urn_air_runway_model_runway_gen45ImageToVideo_1,
                "urn:air:seedance:model:seedance:seedance-1.0-pro-fast-image-to-video@1" => GenAIImage2VideoModelsModel.Urn_air_seedance_model_seedance_seedance10ProFastImageToVideo_1,
                "urn:air:seedance:model:seedance:seedance-1.0-pro-image-to-video@1" => GenAIImage2VideoModelsModel.Urn_air_seedance_model_seedance_seedance10ProImageToVideo_1,
                "urn:air:seedance:model:seedance:seedance-1.5-pro-image-to-video@1" => GenAIImage2VideoModelsModel.Urn_air_seedance_model_seedance_seedance15ProImageToVideo_1,
                "urn:air:wan:model:wan:wan-2.5-image-to-video@1" => GenAIImage2VideoModelsModel.Urn_air_wan_model_wan_wan25ImageToVideo_1,
                "urn:air:wan:model:wan:wan-2.6-image-to-video@1" => GenAIImage2VideoModelsModel.Urn_air_wan_model_wan_wan26ImageToVideo_1,
                "urn:air:xai:model:xai:grok-imagine-video-image-to-video@1" => GenAIImage2VideoModelsModel.Urn_air_xai_model_xai_grokImagineVideoImageToVideo_1,
                _ => null,
            };
        }
    }
}