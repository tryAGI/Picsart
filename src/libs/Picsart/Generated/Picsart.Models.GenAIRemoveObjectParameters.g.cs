
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenAIRemoveObjectParameters
    {
        /// <summary>
        /// Optionally select one of the image formats (JPG is default). Options are as follows:<br/>
        ///   * JPG<br/>
        ///   * PNG<br/>
        ///   * WEBP<br/>
        /// Default Value: JPG
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.GenAIRemoveObjectParametersFormatJsonConverter))]
        public global::Picsart.GenAIRemoveObjectParametersFormat? Format { get; set; }

        /// <summary>
        /// Use this query parameter to establish the processing mode. Acceptable values are sync, async and auto (sync is default):<br/>
        ///   * sync: issues a synchronous request, response is given when the result is ready.<br/>
        ///   * async: forces an asynchronous request, the response, which is instantaneous, contains a "transaction_id" which is used to poll for the result.<br/>
        ///   * auto: the processing mode decision is made by the service, which depends upon the expected processing time.<br/>
        /// Default Value: sync
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.GenAIRemoveObjectParametersModeJsonConverter))]
        public global::Picsart.GenAIRemoveObjectParametersMode? Mode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenAIRemoveObjectParameters" /> class.
        /// </summary>
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
        ///   * auto: the processing mode decision is made by the service, which depends upon the expected processing time.<br/>
        /// Default Value: sync
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenAIRemoveObjectParameters(
            global::Picsart.GenAIRemoveObjectParametersFormat? format,
            global::Picsart.GenAIRemoveObjectParametersMode? mode)
        {
            this.Format = format;
            this.Mode = mode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenAIRemoveObjectParameters" /> class.
        /// </summary>
        public GenAIRemoveObjectParameters()
        {
        }
    }
}