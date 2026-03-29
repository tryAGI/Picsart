
#nullable enable

namespace Picsart
{
    /// <summary>
    /// Optionally choose a specific AI model to use for this request.<br/>
    /// If not specified, a default model will be applied. Please note that the default model may change over time as Picsart continues to improve performance and accuracy. Any change to the default will be made only after thorough testing and validation to ensure it delivers better results.<br/>
    /// If you require consistent behavior or wish to evaluate different models on your own, we recommend explicitly setting this parameter.<br/>
    /// Default Value: urn:air:picsart:model:picsart:sod@10
    /// </summary>
    public enum ImageRemoveBackgroundParametersModel
    {
        /// <summary>
        /// 
        /// </summary>
        Urn_air_picsart_model_picsart_sod_10,
        /// <summary>
        /// 
        /// </summary>
        Urn_air_picsart_model_picsart_sod_101,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageRemoveBackgroundParametersModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageRemoveBackgroundParametersModel value)
        {
            return value switch
            {
                ImageRemoveBackgroundParametersModel.Urn_air_picsart_model_picsart_sod_10 => "urn:air:picsart:model:picsart:sod@10",
                ImageRemoveBackgroundParametersModel.Urn_air_picsart_model_picsart_sod_101 => "urn:air:picsart:model:picsart:sod@10.1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageRemoveBackgroundParametersModel? ToEnum(string value)
        {
            return value switch
            {
                "urn:air:picsart:model:picsart:sod@10" => ImageRemoveBackgroundParametersModel.Urn_air_picsart_model_picsart_sod_10,
                "urn:air:picsart:model:picsart:sod@10.1" => ImageRemoveBackgroundParametersModel.Urn_air_picsart_model_picsart_sod_101,
                _ => null,
            };
        }
    }
}