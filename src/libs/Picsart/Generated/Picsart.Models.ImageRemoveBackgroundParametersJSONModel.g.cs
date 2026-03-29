
#nullable enable

namespace Picsart
{
    /// <summary>
    /// Optionally choose a specific AI model to use for this request.<br/>
    /// If not specified, a default model will be applied. Please note that the default model may change over time as Picsart continues to improve performance and accuracy. Any change to the default will be made only after thorough testing and validation to ensure it delivers better results.<br/>
    /// If you require consistent behavior or wish to evaluate different models on your own, we recommend explicitly setting this parameter.<br/>
    /// Default Value: urn:air:picsart:model:picsart:sod@10
    /// </summary>
    public enum ImageRemoveBackgroundParametersJSONModel
    {
        /// <summary>
        /// 
        /// </summary>
        Urn_air_picsart_model_picsart_sod_10,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageRemoveBackgroundParametersJSONModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageRemoveBackgroundParametersJSONModel value)
        {
            return value switch
            {
                ImageRemoveBackgroundParametersJSONModel.Urn_air_picsart_model_picsart_sod_10 => "urn:air:picsart:model:picsart:sod@10",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageRemoveBackgroundParametersJSONModel? ToEnum(string value)
        {
            return value switch
            {
                "urn:air:picsart:model:picsart:sod@10" => ImageRemoveBackgroundParametersJSONModel.Urn_air_picsart_model_picsart_sod_10,
                _ => null,
            };
        }
    }
}