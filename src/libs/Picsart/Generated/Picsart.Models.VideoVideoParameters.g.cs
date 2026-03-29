
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoVideoParameters
    {
        /// <summary>
        /// Source video URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_url")]
        public string? VideoUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoVideoParameters" /> class.
        /// </summary>
        /// <param name="videoUrl">
        /// Source video URL.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoVideoParameters(
            string? videoUrl)
        {
            this.VideoUrl = videoUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoVideoParameters" /> class.
        /// </summary>
        public VideoVideoParameters()
        {
        }
    }
}