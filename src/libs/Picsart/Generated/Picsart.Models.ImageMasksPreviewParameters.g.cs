
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageMasksPreviewParameters
    {
        /// <summary>
        /// Optionally select one of the image formats (JPG is chosen if left blank). Options are as follows:<br/>
        ///   * JPG<br/>
        ///   * PNG<br/>
        ///   * WEBP<br/>
        /// Default Value: PNG
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.ImageMasksPreviewParametersFormatJsonConverter))]
        public global::Picsart.ImageMasksPreviewParametersFormat? Format { get; set; }

        /// <summary>
        /// Select one of the appearance types from the list (it will be _screen_ if left blank). The options are as follows.<br/>
        ///   * normal<br/>
        ///   * screen<br/>
        ///   * overlay<br/>
        ///   * multiply<br/>
        ///   * darken<br/>
        ///   * lighten<br/>
        ///   * add<br/>
        /// Default Value: screen
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blend")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.ImageMasksPreviewParametersBlendJsonConverter))]
        public global::Picsart.ImageMasksPreviewParametersBlend? Blend { get; set; }

        /// <summary>
        /// Select up to 10 mask types from the list. The options are as follows<br/>
        ///   * lace1<br/>
        ///   * lace2<br/>
        ///   * lace3<br/>
        ///   * lace4<br/>
        ///   * shdw2<br/>
        ///   * shdw17<br/>
        ///   * rpl3<br/>
        ///   * rpl5<br/>
        ///   * prsm3<br/>
        ///   * prsm9<br/>
        ///   * prsm10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Picsart.ImageMasksPreviewParametersMaskItem> Mask { get; set; }

        /// <summary>
        /// Enter an integer value from 0 to +100. The larger the number, the greater the opacity.<br/>
        /// Default Value: 100
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("opacity")]
        public int? Opacity { get; set; }

        /// <summary>
        /// Enter an integer value from -180 to +180.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hue")]
        public int? Hue { get; set; }

        /// <summary>
        /// Choose a mask flip option. The choices are as follows.<br/>
        ///   * left<br/>
        ///   * right<br/>
        ///   * mirror horizontal<br/>
        ///   * mirror vertical<br/>
        ///   * turnaround
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask_flip")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.ImageMasksPreviewParametersMaskFlipJsonConverter))]
        public global::Picsart.ImageMasksPreviewParametersMaskFlip? MaskFlip { get; set; }

        /// <summary>
        /// Enter the max size for the width or height of the preview image. The max value is 240px. If left blank it's 120px.<br/>
        /// Default Value: 120
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview_size")]
        public int? PreviewSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageMasksPreviewParameters" /> class.
        /// </summary>
        /// <param name="mask">
        /// Select up to 10 mask types from the list. The options are as follows<br/>
        ///   * lace1<br/>
        ///   * lace2<br/>
        ///   * lace3<br/>
        ///   * lace4<br/>
        ///   * shdw2<br/>
        ///   * shdw17<br/>
        ///   * rpl3<br/>
        ///   * rpl5<br/>
        ///   * prsm3<br/>
        ///   * prsm9<br/>
        ///   * prsm10
        /// </param>
        /// <param name="format">
        /// Optionally select one of the image formats (JPG is chosen if left blank). Options are as follows:<br/>
        ///   * JPG<br/>
        ///   * PNG<br/>
        ///   * WEBP<br/>
        /// Default Value: PNG
        /// </param>
        /// <param name="blend">
        /// Select one of the appearance types from the list (it will be _screen_ if left blank). The options are as follows.<br/>
        ///   * normal<br/>
        ///   * screen<br/>
        ///   * overlay<br/>
        ///   * multiply<br/>
        ///   * darken<br/>
        ///   * lighten<br/>
        ///   * add<br/>
        /// Default Value: screen
        /// </param>
        /// <param name="opacity">
        /// Enter an integer value from 0 to +100. The larger the number, the greater the opacity.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="hue">
        /// Enter an integer value from -180 to +180.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="maskFlip">
        /// Choose a mask flip option. The choices are as follows.<br/>
        ///   * left<br/>
        ///   * right<br/>
        ///   * mirror horizontal<br/>
        ///   * mirror vertical<br/>
        ///   * turnaround
        /// </param>
        /// <param name="previewSize">
        /// Enter the max size for the width or height of the preview image. The max value is 240px. If left blank it's 120px.<br/>
        /// Default Value: 120
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageMasksPreviewParameters(
            global::System.Collections.Generic.IList<global::Picsart.ImageMasksPreviewParametersMaskItem> mask,
            global::Picsart.ImageMasksPreviewParametersFormat? format,
            global::Picsart.ImageMasksPreviewParametersBlend? blend,
            int? opacity,
            int? hue,
            global::Picsart.ImageMasksPreviewParametersMaskFlip? maskFlip,
            int? previewSize)
        {
            this.Format = format;
            this.Blend = blend;
            this.Mask = mask ?? throw new global::System.ArgumentNullException(nameof(mask));
            this.Opacity = opacity;
            this.Hue = hue;
            this.MaskFlip = maskFlip;
            this.PreviewSize = previewSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageMasksPreviewParameters" /> class.
        /// </summary>
        public ImageMasksPreviewParameters()
        {
        }
    }
}