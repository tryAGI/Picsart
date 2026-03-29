
#nullable enable

namespace Picsart
{
    /// <summary>
    /// Optionally choose a specific AI model to use for this request.<br/>
    /// If not specified, a default model will be applied. Please note that the default model may change over time as Picsart continues to improve performance and accuracy. Any change to the default will be made only after thorough testing and validation to ensure it delivers better results.<br/>
    /// If you require consistent behavior or wish to evaluate different models on your own, we recommend explicitly setting this parameter.<br/>
    /// Default Value: urn:air:sdxl:model:fluxai:flux_kontext_max@1
    /// </summary>
    public enum GenAILaserEngravingModelsModel
    {
        /// <summary>
        /// 
        /// </summary>
        Urn_air_sdxl_model_fluxai_fluxKontextMax_1,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_sdxl_model_fluxai_fluxKontextPro_1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenAILaserEngravingModelsModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenAILaserEngravingModelsModel value)
        {
            return value switch
            {
                GenAILaserEngravingModelsModel.Urn_air_sdxl_model_fluxai_fluxKontextMax_1 => "urn:air:sdxl:model:fluxai:flux_kontext_max@1",
                GenAILaserEngravingModelsModel.Urn_air_sdxl_model_fluxai_fluxKontextPro_1 => "urn:air:sdxl:model:fluxai:flux_kontext_pro@1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenAILaserEngravingModelsModel? ToEnum(string value)
        {
            return value switch
            {
                "urn:air:sdxl:model:fluxai:flux_kontext_max@1" => GenAILaserEngravingModelsModel.Urn_air_sdxl_model_fluxai_fluxKontextMax_1,
                "urn:air:sdxl:model:fluxai:flux_kontext_pro@1" => GenAILaserEngravingModelsModel.Urn_air_sdxl_model_fluxai_fluxKontextPro_1,
                _ => null,
            };
        }
    }
}