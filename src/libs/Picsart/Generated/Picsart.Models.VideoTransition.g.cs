
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoTransition
    {
        /// <summary>
        /// Default Value: none
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transition")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.VideoTransitionTransitionJsonConverter))]
        public global::Picsart.VideoTransitionTransition? Transition { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoTransition" /> class.
        /// </summary>
        /// <param name="transition">
        /// Default Value: none
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoTransition(
            global::Picsart.VideoTransitionTransition? transition)
        {
            this.Transition = transition;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoTransition" /> class.
        /// </summary>
        public VideoTransition()
        {
        }
    }
}