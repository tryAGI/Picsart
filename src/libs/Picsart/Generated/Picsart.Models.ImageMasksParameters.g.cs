
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageMasksParameters
    {
        /// <summary>
        /// Optionally select one of the image formats. Options are as follows:<br/>
        ///   * JPG<br/>
        ///   * PNG<br/>
        ///   * WEBP<br/>
        /// Default Value: PNG
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.ImageMasksParametersFormatJsonConverter))]
        public global::Picsart.ImageMasksParametersFormat? Format { get; set; }

        /// <summary>
        /// Select one of the appearance types from the list (_screen_ is chosen if left blank). The options are as follows:<br/>
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.ImageMasksParametersBlendJsonConverter))]
        public global::Picsart.ImageMasksParametersBlend? Blend { get; set; }

        /// <summary>
        /// Select one of the mask types from the list. The options are as follows:<br/>
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.ImageMasksParametersMaskJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Picsart.ImageMasksParametersMask Mask { get; set; }

        /// <summary>
        /// Enter an integer value from 0 to +100. The larger the number, the greater the opacity. Default is 100.<br/>
        /// Default Value: 100
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("opacity")]
        public int? Opacity { get; set; }

        /// <summary>
        /// Enter an integer value from -180 to +180. Default is 0.<br/>
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.ImageMasksParametersMaskFlipJsonConverter))]
        public global::Picsart.ImageMasksParametersMaskFlip? MaskFlip { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageMasksParameters" /> class.
        /// </summary>
        /// <param name="mask">
        /// Select one of the mask types from the list. The options are as follows:<br/>
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
        /// Optionally select one of the image formats. Options are as follows:<br/>
        ///   * JPG<br/>
        ///   * PNG<br/>
        ///   * WEBP<br/>
        /// Default Value: PNG
        /// </param>
        /// <param name="blend">
        /// Select one of the appearance types from the list (_screen_ is chosen if left blank). The options are as follows:<br/>
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
        /// Enter an integer value from 0 to +100. The larger the number, the greater the opacity. Default is 100.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="hue">
        /// Enter an integer value from -180 to +180. Default is 0.<br/>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageMasksParameters(
            global::Picsart.ImageMasksParametersMask mask,
            global::Picsart.ImageMasksParametersFormat? format,
            global::Picsart.ImageMasksParametersBlend? blend,
            int? opacity,
            int? hue,
            global::Picsart.ImageMasksParametersMaskFlip? maskFlip)
        {
            this.Format = format;
            this.Blend = blend;
            this.Mask = mask;
            this.Opacity = opacity;
            this.Hue = hue;
            this.MaskFlip = maskFlip;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageMasksParameters" /> class.
        /// </summary>
        public ImageMasksParameters()
        {
        }
    }
}