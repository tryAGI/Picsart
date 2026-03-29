
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoConcatSegmentsParametersTrimSegment
    {
        /// <summary>
        /// The start time of the segment in milliseconds.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Start { get; set; }

        /// <summary>
        /// The end time of the segment in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int End { get; set; }

        /// <summary>
        /// The transition between segments.<br/>
        /// Default Value: none
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transition")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.VideoConcatSegmentsParametersTrimSegmentTransitionJsonConverter))]
        public global::Picsart.VideoConcatSegmentsParametersTrimSegmentTransition? Transition { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoConcatSegmentsParametersTrimSegment" /> class.
        /// </summary>
        /// <param name="start">
        /// The start time of the segment in milliseconds.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="end">
        /// The end time of the segment in milliseconds.
        /// </param>
        /// <param name="transition">
        /// The transition between segments.<br/>
        /// Default Value: none
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoConcatSegmentsParametersTrimSegment(
            int start,
            int end,
            global::Picsart.VideoConcatSegmentsParametersTrimSegmentTransition? transition)
        {
            this.Start = start;
            this.End = end;
            this.Transition = transition;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoConcatSegmentsParametersTrimSegment" /> class.
        /// </summary>
        public VideoConcatSegmentsParametersTrimSegment()
        {
        }
    }
}