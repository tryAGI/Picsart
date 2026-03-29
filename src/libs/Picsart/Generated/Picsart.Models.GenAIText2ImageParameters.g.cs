
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenAIText2ImageParameters
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
        /// Desired width used to determine the aspect ratio and resolution tier. The actual output width is determined by the AI provider based on the closest matching supported aspect ratio.<br/>
        /// Supported ratios vary by model (common: 1:1, 4:3, 3:4, 16:9, 9:16, 21:9).<br/>
        /// Default Value: 1024<br/>
        /// Example: 512
        /// </summary>
        /// <example>512</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public double? Width { get; set; }

        /// <summary>
        /// Desired height used to determine the aspect ratio and resolution tier. The actual output height is determined by the AI provider based on the closest matching supported aspect ratio.<br/>
        /// Supported ratios vary by model (common: 1:1, 4:3, 3:4, 16:9, 9:16, 21:9).<br/>
        /// Default Value: 1024<br/>
        /// Example: 512
        /// </summary>
        /// <example>512</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public double? Height { get; set; }

        /// <summary>
        /// The number of images to generate.<br/>
        /// Default Value: 2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        public double? Count { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenAIText2ImageParameters" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The prompt.
        /// </param>
        /// <param name="width">
        /// Desired width used to determine the aspect ratio and resolution tier. The actual output width is determined by the AI provider based on the closest matching supported aspect ratio.<br/>
        /// Supported ratios vary by model (common: 1:1, 4:3, 3:4, 16:9, 9:16, 21:9).<br/>
        /// Default Value: 1024<br/>
        /// Example: 512
        /// </param>
        /// <param name="height">
        /// Desired height used to determine the aspect ratio and resolution tier. The actual output height is determined by the AI provider based on the closest matching supported aspect ratio.<br/>
        /// Supported ratios vary by model (common: 1:1, 4:3, 3:4, 16:9, 9:16, 21:9).<br/>
        /// Default Value: 1024<br/>
        /// Example: 512
        /// </param>
        /// <param name="count">
        /// The number of images to generate.<br/>
        /// Default Value: 2
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenAIText2ImageParameters(
            string prompt,
            double? width,
            double? height,
            double? count)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Width = width;
            this.Height = height;
            this.Count = count;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenAIText2ImageParameters" /> class.
        /// </summary>
        public GenAIText2ImageParameters()
        {
        }
    }
}