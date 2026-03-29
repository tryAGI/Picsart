
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenAIText2TextCompletionsParametersMessage
    {
        /// <summary>
        /// Each message object has a role (either system, user, or assistant) and content.<br/>
        /// The system message is optional and can be used to set the behavior of the assistant The user messages provide requests or comments for the assistant to respond to Assistant messages store previous assistant responses, but can also be written by you to give examples of desired behavior.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public string? Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenAIText2TextCompletionsParametersMessage" /> class.
        /// </summary>
        /// <param name="role">
        /// Each message object has a role (either system, user, or assistant) and content.<br/>
        /// The system message is optional and can be used to set the behavior of the assistant The user messages provide requests or comments for the assistant to respond to Assistant messages store previous assistant responses, but can also be written by you to give examples of desired behavior.
        /// </param>
        /// <param name="content"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenAIText2TextCompletionsParametersMessage(
            string? role,
            string? content)
        {
            this.Role = role;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenAIText2TextCompletionsParametersMessage" /> class.
        /// </summary>
        public GenAIText2TextCompletionsParametersMessage()
        {
        }
    }
}