
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoConcatSegmentsParameters
    {
        /// <summary>
        /// List of segments to combine/merge.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trim_segments")]
        public global::System.Collections.Generic.IList<global::Picsart.VideoConcatSegmentsParametersTrimSegment>? TrimSegments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoConcatSegmentsParameters" /> class.
        /// </summary>
        /// <param name="trimSegments">
        /// List of segments to combine/merge.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoConcatSegmentsParameters(
            global::System.Collections.Generic.IList<global::Picsart.VideoConcatSegmentsParametersTrimSegment>? trimSegments)
        {
            this.TrimSegments = trimSegments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoConcatSegmentsParameters" /> class.
        /// </summary>
        public VideoConcatSegmentsParameters()
        {
        }
    }
}