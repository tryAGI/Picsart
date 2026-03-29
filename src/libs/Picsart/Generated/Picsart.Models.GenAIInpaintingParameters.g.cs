
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenAIInpaintingParameters
    {
        /// <summary>
        /// The prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// The negative prompt (don’t generate this type of images). Don't use the nagitve keywords such as 'no', e.g. don't use 'no distorted faces', use 'distorted faces'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("negative_prompt")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? NegativePrompt { get; set; }

        /// <summary>
        /// The number of images to generate.<br/>
        /// Default Value: 2<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        public int? Count { get; set; }

        /// <summary>
        /// Optionally select one of the image formats (JPG is default). Options are as follows:<br/>
        ///   * JPG<br/>
        ///   * PNG<br/>
        ///   * WEBP<br/>
        /// Default Value: JPG
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.GenAIInpaintingParametersFormatJsonConverter))]
        public global::Picsart.GenAIInpaintingParametersFormat? Format { get; set; }

        /// <summary>
        /// Use this query parameter to establish the processing mode. Acceptable values are sync, async and auto (sync is default):<br/>
        ///   * sync: issues a synchronous request, response is given when the result is ready.<br/>
        ///   * async: forces an asynchronous request, the response, which is instantaneous, contains a "transaction_id" which is used to poll for the result.<br/>
        ///   * REMOVED - auto: the processing mode decision is made by the service, which depends upon the expected processing time.<br/>
        /// Default Value: sync
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.GenAIInpaintingParametersModeJsonConverter))]
        public global::Picsart.GenAIInpaintingParametersMode? Mode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenAIInpaintingParameters" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The prompt.
        /// </param>
        /// <param name="count">
        /// The number of images to generate.<br/>
        /// Default Value: 2<br/>
        /// Example: 2
        /// </param>
        /// <param name="format">
        /// Optionally select one of the image formats (JPG is default). Options are as follows:<br/>
        ///   * JPG<br/>
        ///   * PNG<br/>
        ///   * WEBP<br/>
        /// Default Value: JPG
        /// </param>
        /// <param name="mode">
        /// Use this query parameter to establish the processing mode. Acceptable values are sync, async and auto (sync is default):<br/>
        ///   * sync: issues a synchronous request, response is given when the result is ready.<br/>
        ///   * async: forces an asynchronous request, the response, which is instantaneous, contains a "transaction_id" which is used to poll for the result.<br/>
        ///   * REMOVED - auto: the processing mode decision is made by the service, which depends upon the expected processing time.<br/>
        /// Default Value: sync
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenAIInpaintingParameters(
            string prompt,
            int? count,
            global::Picsart.GenAIInpaintingParametersFormat? format,
            global::Picsart.GenAIInpaintingParametersMode? mode)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Count = count;
            this.Format = format;
            this.Mode = mode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenAIInpaintingParameters" /> class.
        /// </summary>
        public GenAIInpaintingParameters()
        {
        }
    }
}