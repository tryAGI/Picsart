
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenAIText2VideoModels
    {
        /// <summary>
        /// Optionally choose a specific AI model to use for this video generation.<br/>
        /// If not specified, a default model will be applied. Please note that the default model may change over time as Picsart continues to improve performance and accuracy. Any change to the default will be made only after thorough testing and validation to ensure it delivers better results.<br/>
        /// If you require consistent behavior or wish to evaluate different models on your own, we recommend explicitly setting this parameter.<br/>
        /// Default Value: urn:air:google:model:google:veo-3.1-fast-text-to-video@1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.GenAIText2VideoModelsModelJsonConverter))]
        public global::Picsart.GenAIText2VideoModelsModel? Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenAIText2VideoModels" /> class.
        /// </summary>
        /// <param name="model">
        /// Optionally choose a specific AI model to use for this video generation.<br/>
        /// If not specified, a default model will be applied. Please note that the default model may change over time as Picsart continues to improve performance and accuracy. Any change to the default will be made only after thorough testing and validation to ensure it delivers better results.<br/>
        /// If you require consistent behavior or wish to evaluate different models on your own, we recommend explicitly setting this parameter.<br/>
        /// Default Value: urn:air:google:model:google:veo-3.1-fast-text-to-video@1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenAIText2VideoModels(
            global::Picsart.GenAIText2VideoModelsModel? model)
        {
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenAIText2VideoModels" /> class.
        /// </summary>
        public GenAIText2VideoModels()
        {
        }
    }
}