
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoTrimParameters
    {
        /// <summary>
        /// This is the point in time of the video from where the trimming begins in milliseconds.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Start { get; set; }

        /// <summary>
        /// This is the point in time of the video where the trimming ends in milliseconds. It must be greater than `start`.<br/>
        /// Default Value: 1000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int End { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoTrimParameters" /> class.
        /// </summary>
        /// <param name="start">
        /// This is the point in time of the video from where the trimming begins in milliseconds.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="end">
        /// This is the point in time of the video where the trimming ends in milliseconds. It must be greater than `start`.<br/>
        /// Default Value: 1000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoTrimParameters(
            int start,
            int end)
        {
            this.Start = start;
            this.End = end;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoTrimParameters" /> class.
        /// </summary>
        public VideoTrimParameters()
        {
        }
    }
}