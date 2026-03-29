
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageEffectsPreviewsParameters
    {
        /// <summary>
        /// Select up to 10 effects. The list of effects are as follows:<br/>
        ///   * 1972<br/>
        ///   * apr1<br/>
        ///   * apr2<br/>
        ///   * apr3<br/>
        ///   * blur<br/>
        ///   * gblur<br/>
        ///   * lensblur<br/>
        ///   * motionblur<br/>
        ///   * smartblur<br/>
        ///   * pixelize<br/>
        ///   * brl1<br/>
        ///   * brnz1<br/>
        ///   * brnz2<br/>
        ///   * brnz3<br/>
        ///   * brnz4<br/>
        ///   * cyber1<br/>
        ///   * cyber2<br/>
        ///   * dodger<br/>
        ///   * fattal2<br/>
        ///   * food1<br/>
        ///   * food2<br/>
        ///   * icy1<br/>
        ///   * icy2<br/>
        ///   * icy3<br/>
        ///   * light1<br/>
        ///   * light2<br/>
        ///   * light3<br/>
        ///   * light4<br/>
        ///   * light5<br/>
        ///   * light6<br/>
        ///   * light7<br/>
        ///   * light8<br/>
        ///   * light9<br/>
        ///   * light10<br/>
        ///   * light11<br/>
        ///   * light12<br/>
        ///   * light13<br/>
        ///   * light14<br/>
        ///   * light15<br/>
        ///   * light16<br/>
        ///   * light17<br/>
        ///   * light18<br/>
        ///   * light19<br/>
        ///   * light20<br/>
        ///   * mnch1<br/>
        ///   * mnch2<br/>
        ///   * mnch3<br/>
        ///   * nature1<br/>
        ///   * nature2<br/>
        ///   * noise<br/>
        ///   * ntrl1<br/>
        ///   * ntrl2<br/>
        ///   * popart<br/>
        ///   * saturation<br/>
        ///   * sft1<br/>
        ///   * sft2<br/>
        ///   * sft3<br/>
        ///   * sft4<br/>
        ///   * shadow1<br/>
        ///   * shadow2<br/>
        ///   * sketch1<br/>
        ///   * sketch2<br/>
        ///   * sketch3<br/>
        ///   * sketcher1<br/>
        ///   * sketcher2<br/>
        ///   * spc1<br/>
        ///   * tl1<br/>
        ///   * tl2<br/>
        ///   * urban1<br/>
        ///   * urban2<br/>
        ///   * water1<br/>
        ///   * water2<br/>
        /// You can provide the values as a list, but also as a comma separated string, e.g. "apr1, apr2".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effect_names")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Picsart.ImageEffectsPreviewsParametersEffectName> EffectNames { get; set; }

        /// <summary>
        /// Enter the width of the preview image. The max value is 240px. The default is 120px.<br/>
        /// Default Value: 120
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview_size")]
        public int? PreviewSize { get; set; }

        /// <summary>
        /// Fade the effect. 0 means no fade and 100 means it's disabled. Note that some effects do not support fade:<br/>
        ///   * lensblur<br/>
        ///   * light1<br/>
        ///   * light10<br/>
        ///   * light11<br/>
        ///   * light12<br/>
        ///   * light13<br/>
        ///   * light14<br/>
        ///   * light15<br/>
        ///   * light16<br/>
        ///   * light17<br/>
        ///   * light18<br/>
        ///   * light19<br/>
        ///   * light2<br/>
        ///   * light20<br/>
        ///   * light3<br/>
        ///   * light4<br/>
        ///   * light5<br/>
        ///   * light6<br/>
        ///   * light7<br/>
        ///   * light8<br/>
        ///   * light9<br/>
        ///   * pixelize<br/>
        ///   * saturation<br/>
        ///   * shadow1<br/>
        ///   * shadow2<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fade")]
        public int? Fade { get; set; }

        /// <summary>
        /// Optionally select one of the image formats. Options are as follows:<br/>
        ///   * JPG<br/>
        ///   * PNG<br/>
        ///   * WEBP<br/>
        /// Default Value: JPG
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.ImageEffectsPreviewsParametersFormatJsonConverter))]
        public global::Picsart.ImageEffectsPreviewsParametersFormat? Format { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageEffectsPreviewsParameters" /> class.
        /// </summary>
        /// <param name="effectNames">
        /// Select up to 10 effects. The list of effects are as follows:<br/>
        ///   * 1972<br/>
        ///   * apr1<br/>
        ///   * apr2<br/>
        ///   * apr3<br/>
        ///   * blur<br/>
        ///   * gblur<br/>
        ///   * lensblur<br/>
        ///   * motionblur<br/>
        ///   * smartblur<br/>
        ///   * pixelize<br/>
        ///   * brl1<br/>
        ///   * brnz1<br/>
        ///   * brnz2<br/>
        ///   * brnz3<br/>
        ///   * brnz4<br/>
        ///   * cyber1<br/>
        ///   * cyber2<br/>
        ///   * dodger<br/>
        ///   * fattal2<br/>
        ///   * food1<br/>
        ///   * food2<br/>
        ///   * icy1<br/>
        ///   * icy2<br/>
        ///   * icy3<br/>
        ///   * light1<br/>
        ///   * light2<br/>
        ///   * light3<br/>
        ///   * light4<br/>
        ///   * light5<br/>
        ///   * light6<br/>
        ///   * light7<br/>
        ///   * light8<br/>
        ///   * light9<br/>
        ///   * light10<br/>
        ///   * light11<br/>
        ///   * light12<br/>
        ///   * light13<br/>
        ///   * light14<br/>
        ///   * light15<br/>
        ///   * light16<br/>
        ///   * light17<br/>
        ///   * light18<br/>
        ///   * light19<br/>
        ///   * light20<br/>
        ///   * mnch1<br/>
        ///   * mnch2<br/>
        ///   * mnch3<br/>
        ///   * nature1<br/>
        ///   * nature2<br/>
        ///   * noise<br/>
        ///   * ntrl1<br/>
        ///   * ntrl2<br/>
        ///   * popart<br/>
        ///   * saturation<br/>
        ///   * sft1<br/>
        ///   * sft2<br/>
        ///   * sft3<br/>
        ///   * sft4<br/>
        ///   * shadow1<br/>
        ///   * shadow2<br/>
        ///   * sketch1<br/>
        ///   * sketch2<br/>
        ///   * sketch3<br/>
        ///   * sketcher1<br/>
        ///   * sketcher2<br/>
        ///   * spc1<br/>
        ///   * tl1<br/>
        ///   * tl2<br/>
        ///   * urban1<br/>
        ///   * urban2<br/>
        ///   * water1<br/>
        ///   * water2<br/>
        /// You can provide the values as a list, but also as a comma separated string, e.g. "apr1, apr2".
        /// </param>
        /// <param name="previewSize">
        /// Enter the width of the preview image. The max value is 240px. The default is 120px.<br/>
        /// Default Value: 120
        /// </param>
        /// <param name="fade">
        /// Fade the effect. 0 means no fade and 100 means it's disabled. Note that some effects do not support fade:<br/>
        ///   * lensblur<br/>
        ///   * light1<br/>
        ///   * light10<br/>
        ///   * light11<br/>
        ///   * light12<br/>
        ///   * light13<br/>
        ///   * light14<br/>
        ///   * light15<br/>
        ///   * light16<br/>
        ///   * light17<br/>
        ///   * light18<br/>
        ///   * light19<br/>
        ///   * light2<br/>
        ///   * light20<br/>
        ///   * light3<br/>
        ///   * light4<br/>
        ///   * light5<br/>
        ///   * light6<br/>
        ///   * light7<br/>
        ///   * light8<br/>
        ///   * light9<br/>
        ///   * pixelize<br/>
        ///   * saturation<br/>
        ///   * shadow1<br/>
        ///   * shadow2<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="format">
        /// Optionally select one of the image formats. Options are as follows:<br/>
        ///   * JPG<br/>
        ///   * PNG<br/>
        ///   * WEBP<br/>
        /// Default Value: JPG
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageEffectsPreviewsParameters(
            global::System.Collections.Generic.IList<global::Picsart.ImageEffectsPreviewsParametersEffectName> effectNames,
            int? previewSize,
            int? fade,
            global::Picsart.ImageEffectsPreviewsParametersFormat? format)
        {
            this.EffectNames = effectNames ?? throw new global::System.ArgumentNullException(nameof(effectNames));
            this.PreviewSize = previewSize;
            this.Fade = fade;
            this.Format = format;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageEffectsPreviewsParameters" /> class.
        /// </summary>
        public ImageEffectsPreviewsParameters()
        {
        }
    }
}