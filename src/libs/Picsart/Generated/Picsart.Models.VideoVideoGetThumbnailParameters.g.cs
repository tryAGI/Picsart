
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoVideoGetThumbnailParameters
    {
        /// <summary>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.VideoVideoGetThumbnailParametersSourceJsonConverter))]
        public global::Picsart.VideoVideoGetThumbnailParametersSource? Source { get; set; }

        /// <summary>
        /// List up to 4 timestamps to extract frames from.  &lt;a href="https://docs.picsart.io/docs/video-timestamps/"&gt;Several timestamp formats&lt;/a&gt; are supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamps")]
        public global::System.Collections.Generic.IList<string>? Timestamps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoVideoGetThumbnailParameters" /> class.
        /// </summary>
        /// <param name="source">
        /// Default Value: auto
        /// </param>
        /// <param name="timestamps">
        /// List up to 4 timestamps to extract frames from.  &lt;a href="https://docs.picsart.io/docs/video-timestamps/"&gt;Several timestamp formats&lt;/a&gt; are supported.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoVideoGetThumbnailParameters(
            global::Picsart.VideoVideoGetThumbnailParametersSource? source,
            global::System.Collections.Generic.IList<string>? timestamps)
        {
            this.Source = source;
            this.Timestamps = timestamps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoVideoGetThumbnailParameters" /> class.
        /// </summary>
        public VideoVideoGetThumbnailParameters()
        {
        }
    }
}