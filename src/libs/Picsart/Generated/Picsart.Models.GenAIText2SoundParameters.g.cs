
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenAIText2SoundParameters
    {
        /// <summary>
        /// The prompt for the music/sound generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// The duration for the generated audio in seconds<br/>
        /// Note these ranges from vendors: ElevenLabs: 0.5-22. Kling: 3-10. Auto if omitted.<br/>
        /// Example: 3
        /// </summary>
        /// <example>3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// Create looping audio. The usage of this param is not guarantteed as limited number of models do support this. (For example: Supported by ElevenLabs only.)<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("loop")]
        public bool? Loop { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenAIText2SoundParameters" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The prompt for the music/sound generation.
        /// </param>
        /// <param name="duration">
        /// The duration for the generated audio in seconds<br/>
        /// Note these ranges from vendors: ElevenLabs: 0.5-22. Kling: 3-10. Auto if omitted.<br/>
        /// Example: 3
        /// </param>
        /// <param name="loop">
        /// Create looping audio. The usage of this param is not guarantteed as limited number of models do support this. (For example: Supported by ElevenLabs only.)<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenAIText2SoundParameters(
            string prompt,
            double? duration,
            bool? loop)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Duration = duration;
            this.Loop = loop;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenAIText2SoundParameters" /> class.
        /// </summary>
        public GenAIText2SoundParameters()
        {
        }
    }
}