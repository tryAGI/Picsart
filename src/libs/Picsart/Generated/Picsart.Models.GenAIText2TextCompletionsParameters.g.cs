
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenAIText2TextCompletionsParameters
    {
        /// <summary>
        /// The messages containing the original text and instructions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Picsart.GenAIText2TextCompletionsParametersMessage> Messages { get; set; }

        /// <summary>
        /// Default Value: 512
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public double? MaxTokens { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenAIText2TextCompletionsParameters" /> class.
        /// </summary>
        /// <param name="messages">
        /// The messages containing the original text and instructions.
        /// </param>
        /// <param name="maxTokens">
        /// Default Value: 512
        /// </param>
        /// <param name="temperature">
        /// Default Value: 1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenAIText2TextCompletionsParameters(
            global::System.Collections.Generic.IList<global::Picsart.GenAIText2TextCompletionsParametersMessage> messages,
            double? maxTokens,
            double? temperature)
        {
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.MaxTokens = maxTokens;
            this.Temperature = temperature;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenAIText2TextCompletionsParameters" /> class.
        /// </summary>
        public GenAIText2TextCompletionsParameters()
        {
        }
    }
}