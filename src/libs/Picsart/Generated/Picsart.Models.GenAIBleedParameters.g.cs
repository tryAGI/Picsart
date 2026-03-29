
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenAIBleedParameters
    {
        /// <summary>
        /// The prompt. Only apply if you are confident the provided prompt is going to generate good results. Otherwise leave empty as the default prompt is already optimized for bleed generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// The negative prompt (don’t generate this type of images). Don't use the nagitve keywords such as 'no', e.g. don't use 'no distorted faces', use 'distorted faces'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("negative_prompt")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? NegativePrompt { get; set; }

        /// <summary>
        /// Specify the bleed of the output image in pixels.<br/>
        /// When specifying the value, take into account the DPI of the image. For example, for 300DPI and the 0.125inches bleed, the value should be 300*0.125=37/38.<br/>
        /// Default Value: 5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bleed_size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int BleedSize { get; set; }

        /// <summary>
        /// Optionally select one of the image formats (JPG is default). Options are as follows:<br/>
        ///   * JPG<br/>
        ///   * PNG<br/>
        ///   * WEBP<br/>
        /// Default Value: JPG
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.GenAIBleedParametersFormatJsonConverter))]
        public global::Picsart.GenAIBleedParametersFormat? Format { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenAIBleedParameters" /> class.
        /// </summary>
        /// <param name="bleedSize">
        /// Specify the bleed of the output image in pixels.<br/>
        /// When specifying the value, take into account the DPI of the image. For example, for 300DPI and the 0.125inches bleed, the value should be 300*0.125=37/38.<br/>
        /// Default Value: 5
        /// </param>
        /// <param name="prompt">
        /// The prompt. Only apply if you are confident the provided prompt is going to generate good results. Otherwise leave empty as the default prompt is already optimized for bleed generation.
        /// </param>
        /// <param name="format">
        /// Optionally select one of the image formats (JPG is default). Options are as follows:<br/>
        ///   * JPG<br/>
        ///   * PNG<br/>
        ///   * WEBP<br/>
        /// Default Value: JPG
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenAIBleedParameters(
            int bleedSize,
            string? prompt,
            global::Picsart.GenAIBleedParametersFormat? format)
        {
            this.Prompt = prompt;
            this.BleedSize = bleedSize;
            this.Format = format;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenAIBleedParameters" /> class.
        /// </summary>
        public GenAIBleedParameters()
        {
        }
    }
}