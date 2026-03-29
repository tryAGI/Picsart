
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenAIText2VideoParameters
    {
        /// <summary>
        /// The prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

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
        /// Video output quality/resolution.<br/>
        /// Default Value: 480p
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.GenAIText2VideoParametersQualityJsonConverter))]
        public global::Picsart.GenAIText2VideoParametersQuality? Quality { get; set; }

        /// <summary>
        /// Generate the video with audio or not.<br/>
        /// Some models (e.g. Grok Imagine Video / OpenAI Sora 2 / Sora 2 Pro / OVI) don't support the option to disable sound. With these models the result video will always be generated regardless to the provided input params.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public bool? Audio { get; set; }

        /// <summary>
        /// Desired video length in seconds. Mapped to the closest supported duration for the selected model.<br/>
        /// Default Value: 3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("length")]
        public double? Length { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenAIText2VideoParameters" /> class.
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
        /// <param name="quality">
        /// Video output quality/resolution.<br/>
        /// Default Value: 480p
        /// </param>
        /// <param name="audio">
        /// Generate the video with audio or not.<br/>
        /// Some models (e.g. Grok Imagine Video / OpenAI Sora 2 / Sora 2 Pro / OVI) don't support the option to disable sound. With these models the result video will always be generated regardless to the provided input params.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="length">
        /// Desired video length in seconds. Mapped to the closest supported duration for the selected model.<br/>
        /// Default Value: 3
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenAIText2VideoParameters(
            string prompt,
            double? width,
            double? height,
            global::Picsart.GenAIText2VideoParametersQuality? quality,
            bool? audio,
            double? length)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Width = width;
            this.Height = height;
            this.Quality = quality;
            this.Audio = audio;
            this.Length = length;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenAIText2VideoParameters" /> class.
        /// </summary>
        public GenAIText2VideoParameters()
        {
        }
    }
}