
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoCropParameters
    {
        /// <summary>
        /// Width of the outcome video. If the new width is larger than the original width, the blurry mirror effect should be applied to the additional part. The measurement unit is px. The default value is the original width. Value must be at least 16 px.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public int? Width { get; set; }

        /// <summary>
        /// Height of the output video. If the new height is larger than the original height, the blurry mirror effect should be applied to the additional part. The measurement unit is px. The default value is the original height. Value must be at least 16 px.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public int? Height { get; set; }

        /// <summary>
        /// The starting x location of the crop in px as measured from the left edge.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_x")]
        public int? StartX { get; set; }

        /// <summary>
        /// The starting y location of the crop in px as measured from the bottom edge.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_y")]
        public int? StartY { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoCropParameters" /> class.
        /// </summary>
        /// <param name="width">
        /// Width of the outcome video. If the new width is larger than the original width, the blurry mirror effect should be applied to the additional part. The measurement unit is px. The default value is the original width. Value must be at least 16 px.
        /// </param>
        /// <param name="height">
        /// Height of the output video. If the new height is larger than the original height, the blurry mirror effect should be applied to the additional part. The measurement unit is px. The default value is the original height. Value must be at least 16 px.
        /// </param>
        /// <param name="startX">
        /// The starting x location of the crop in px as measured from the left edge.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="startY">
        /// The starting y location of the crop in px as measured from the bottom edge.<br/>
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoCropParameters(
            int? width,
            int? height,
            int? startX,
            int? startY)
        {
            this.Width = width;
            this.Height = height;
            this.StartX = startX;
            this.StartY = startY;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoCropParameters" /> class.
        /// </summary>
        public VideoCropParameters()
        {
        }
    }
}