
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoRemoveBackgroundParameters
    {
        /// <summary>
        /// Can be a hexcolor code (e.g., #82d5fa, #fff) or a color name (e.g., blue). For full transparency, use 'transparent' or '#00000000'. In this case, the export format .webm will be enforced and applied. For semi-transparency, 4-/8-digit hexcodes are also supported (e.g., #18d4ff87 or #00000066). The default is greenscreen's '#008800'. Use either bg_color or bg_image_url.<br/>
        /// Default Value: #008800
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bg_color")]
        public string? BgColor { get; set; }

        /// <summary>
        /// The background image URL. Use either bg_color or bg_image_url. When not provided the default value of the bg_color=#008800 will be applied to the background.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bg_image_url")]
        public string? BgImageUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoRemoveBackgroundParameters" /> class.
        /// </summary>
        /// <param name="bgColor">
        /// Can be a hexcolor code (e.g., #82d5fa, #fff) or a color name (e.g., blue). For full transparency, use 'transparent' or '#00000000'. In this case, the export format .webm will be enforced and applied. For semi-transparency, 4-/8-digit hexcodes are also supported (e.g., #18d4ff87 or #00000066). The default is greenscreen's '#008800'. Use either bg_color or bg_image_url.<br/>
        /// Default Value: #008800
        /// </param>
        /// <param name="bgImageUrl">
        /// The background image URL. Use either bg_color or bg_image_url. When not provided the default value of the bg_color=#008800 will be applied to the background.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoRemoveBackgroundParameters(
            string? bgColor,
            string? bgImageUrl)
        {
            this.BgColor = bgColor;
            this.BgImageUrl = bgImageUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoRemoveBackgroundParameters" /> class.
        /// </summary>
        public VideoRemoveBackgroundParameters()
        {
        }
    }
}