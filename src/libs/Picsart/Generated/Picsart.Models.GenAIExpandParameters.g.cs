
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenAIExpandParameters
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
        /// Specify the width of the output image in pixels. The default is 1024 and the maximum acceptable value is 8000.<br/>
        /// Default Value: 1024
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public int? Width { get; set; }

        /// <summary>
        /// Specify the width of the output image in pixels. The default is 1024 and the maximum acceptable value is 8000.<br/>
        /// Default Value: 1024
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public int? Height { get; set; }

        /// <summary>
        /// Use this parameter to define in which direction the source image should be expanded. Available values are:<br/>
        ///   * center: Add pixels and expand the image from all sides. The original image will remain in the center.<br/>
        ///   * top-left: Add pixels and expand to the top-left. The original image will remain the bottom-right corner.<br/>
        ///   * top-right: Add pixels and expand to the top-right. The original image will remain the bottom-left corner.<br/>
        ///   * bottom-left: Add pixels and expand to the bottom-left. The original image will remain the top-right corner.<br/>
        ///   * bottom-right:Add pixels and expand to the bottom-right. The original image will remain the top-left corner.<br/>
        /// Default Value: center
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("direction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.GenAIExpandParametersDirectionJsonConverter))]
        public global::Picsart.GenAIExpandParametersDirection? Direction { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.GenAIExpandParametersFormatJsonConverter))]
        public global::Picsart.GenAIExpandParametersFormat? Format { get; set; }

        /// <summary>
        /// Use this query parameter to establish the processing mode. Acceptable values are sync, async and auto (sync is default):<br/>
        ///   * sync: issues a synchronous request, response is given when the result is ready.<br/>
        ///   * async: forces an asynchronous request, the response, which is instantaneous, contains a "transaction_id" which is used to poll for the result.<br/>
        ///   * auto: the processing mode decision is made by the service, which depends upon the expected processing time.<br/>
        /// Default Value: sync
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.GenAIExpandParametersModeJsonConverter))]
        public global::Picsart.GenAIExpandParametersMode? Mode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenAIExpandParameters" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The prompt.
        /// </param>
        /// <param name="width">
        /// Specify the width of the output image in pixels. The default is 1024 and the maximum acceptable value is 8000.<br/>
        /// Default Value: 1024
        /// </param>
        /// <param name="height">
        /// Specify the width of the output image in pixels. The default is 1024 and the maximum acceptable value is 8000.<br/>
        /// Default Value: 1024
        /// </param>
        /// <param name="direction">
        /// Use this parameter to define in which direction the source image should be expanded. Available values are:<br/>
        ///   * center: Add pixels and expand the image from all sides. The original image will remain in the center.<br/>
        ///   * top-left: Add pixels and expand to the top-left. The original image will remain the bottom-right corner.<br/>
        ///   * top-right: Add pixels and expand to the top-right. The original image will remain the bottom-left corner.<br/>
        ///   * bottom-left: Add pixels and expand to the bottom-left. The original image will remain the top-right corner.<br/>
        ///   * bottom-right:Add pixels and expand to the bottom-right. The original image will remain the top-left corner.<br/>
        /// Default Value: center
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
        ///   * auto: the processing mode decision is made by the service, which depends upon the expected processing time.<br/>
        /// Default Value: sync
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenAIExpandParameters(
            string prompt,
            int? width,
            int? height,
            global::Picsart.GenAIExpandParametersDirection? direction,
            int? count,
            global::Picsart.GenAIExpandParametersFormat? format,
            global::Picsart.GenAIExpandParametersMode? mode)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Width = width;
            this.Height = height;
            this.Direction = direction;
            this.Count = count;
            this.Format = format;
            this.Mode = mode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenAIExpandParameters" /> class.
        /// </summary>
        public GenAIExpandParameters()
        {
        }
    }
}