
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoFitParameters
    {
        /// <summary>
        /// The value should be a single floating point number which represents the ratio of width and height. The formula is: parameter value = width / height. The default value is that of the original video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        public float? Ratio { get; set; }

        /// <summary>
        /// Width of the outcome video. If the new width is larger than the original width, the blurry mirror effect should be applied to the additional part. The measurement unit is px. The default value is the original width. Value must be at least 16 px.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public int? Width { get; set; }

        /// <summary>
        /// Height of the outcome video. If the new height is larger than the original height, the blurry mirror effect should be applied to the additional part. The measurement unit is px. The default value is the original height. Value must be at least 16 px.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public int? Height { get; set; }

        /// <summary>
        /// Can be a hexcolor code (e.g., #82d5fa, #fff) or a color name (e.g., blue). For semi-transparency, 4-/8-digit hexcodes are also supported (e.g., #18d4ff87). (If this parameter is present, the other bg_ parameters must be empty).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bg_color")]
        public string? BgColor { get; set; }

        /// <summary>
        /// Enter an integer value from 0 to 100.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bg_blur")]
        public int? BgBlur { get; set; }

        /// <summary>
        /// Background image URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bg_image_url")]
        public string? BgImageUrl { get; set; }

        /// <summary>
        /// Background video URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bg_video_url")]
        public string? BgVideoUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoFitParameters" /> class.
        /// </summary>
        /// <param name="ratio">
        /// The value should be a single floating point number which represents the ratio of width and height. The formula is: parameter value = width / height. The default value is that of the original video.
        /// </param>
        /// <param name="width">
        /// Width of the outcome video. If the new width is larger than the original width, the blurry mirror effect should be applied to the additional part. The measurement unit is px. The default value is the original width. Value must be at least 16 px.
        /// </param>
        /// <param name="height">
        /// Height of the outcome video. If the new height is larger than the original height, the blurry mirror effect should be applied to the additional part. The measurement unit is px. The default value is the original height. Value must be at least 16 px.
        /// </param>
        /// <param name="bgColor">
        /// Can be a hexcolor code (e.g., #82d5fa, #fff) or a color name (e.g., blue). For semi-transparency, 4-/8-digit hexcodes are also supported (e.g., #18d4ff87). (If this parameter is present, the other bg_ parameters must be empty).
        /// </param>
        /// <param name="bgBlur">
        /// Enter an integer value from 0 to 100.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="bgImageUrl">
        /// Background image URL.
        /// </param>
        /// <param name="bgVideoUrl">
        /// Background video URL.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoFitParameters(
            float? ratio,
            int? width,
            int? height,
            string? bgColor,
            int? bgBlur,
            string? bgImageUrl,
            string? bgVideoUrl)
        {
            this.Ratio = ratio;
            this.Width = width;
            this.Height = height;
            this.BgColor = bgColor;
            this.BgBlur = bgBlur;
            this.BgImageUrl = bgImageUrl;
            this.BgVideoUrl = bgVideoUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoFitParameters" /> class.
        /// </summary>
        public VideoFitParameters()
        {
        }
    }
}