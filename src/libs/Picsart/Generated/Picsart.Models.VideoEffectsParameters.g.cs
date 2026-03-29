
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoEffectsParameters
    {
        /// <summary>
        /// Choose an effect from the dropdown menu. The list of effects are as follows<br/>
        ///   * apr1<br/>
        ///   * apr2<br/>
        ///   * apr3<br/>
        ///   * brnz1<br/>
        ///   * brnz2<br/>
        ///   * brnz3<br/>
        ///   * brnz4<br/>
        ///   * cyber1<br/>
        ///   * cyber2<br/>
        ///   * cyber3<br/>
        ///   * icy1<br/>
        ///   * icy2<br/>
        ///   * icy3<br/>
        ///   * icy4<br/>
        ///   * mnch1<br/>
        ///   * mnch2<br/>
        ///   * mnch3<br/>
        ///   * noise<br/>
        ///   * ntrl1<br/>
        ///   * ntrl2<br/>
        ///   * ntrl3<br/>
        ///   * pixelize<br/>
        ///   * saturation<br/>
        ///   * sft1<br/>
        ///   * sft2<br/>
        ///   * sft3<br/>
        ///   * sft4<br/>
        ///   * tl1<br/>
        ///   * tl2<br/>
        ///   * sharpen<br/>
        ///   * vignette<br/>
        ///   * Focal Zoom<br/>
        ///   * Lens Blur<br/>
        ///   * Motion Blur<br/>
        ///   * Radial Blur<br/>
        ///   * Smart Blur<br/>
        ///   * Blur<br/>
        ///   * Black And White<br/>
        ///   * stenciler1<br/>
        ///   * stenciler3<br/>
        ///   * stenciler4<br/>
        ///   * stenciler6<br/>
        ///   * stenciler7<br/>
        ///   * DTN1<br/>
        ///   * DTN2<br/>
        ///   * DTN3<br/>
        ///   * DTN4<br/>
        ///   * DTN5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effect_name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.VideoEffectsParametersEffectNameJsonConverter))]
        public global::Picsart.VideoEffectsParametersEffectName? EffectName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoEffectsParameters" /> class.
        /// </summary>
        /// <param name="effectName">
        /// Choose an effect from the dropdown menu. The list of effects are as follows<br/>
        ///   * apr1<br/>
        ///   * apr2<br/>
        ///   * apr3<br/>
        ///   * brnz1<br/>
        ///   * brnz2<br/>
        ///   * brnz3<br/>
        ///   * brnz4<br/>
        ///   * cyber1<br/>
        ///   * cyber2<br/>
        ///   * cyber3<br/>
        ///   * icy1<br/>
        ///   * icy2<br/>
        ///   * icy3<br/>
        ///   * icy4<br/>
        ///   * mnch1<br/>
        ///   * mnch2<br/>
        ///   * mnch3<br/>
        ///   * noise<br/>
        ///   * ntrl1<br/>
        ///   * ntrl2<br/>
        ///   * ntrl3<br/>
        ///   * pixelize<br/>
        ///   * saturation<br/>
        ///   * sft1<br/>
        ///   * sft2<br/>
        ///   * sft3<br/>
        ///   * sft4<br/>
        ///   * tl1<br/>
        ///   * tl2<br/>
        ///   * sharpen<br/>
        ///   * vignette<br/>
        ///   * Focal Zoom<br/>
        ///   * Lens Blur<br/>
        ///   * Motion Blur<br/>
        ///   * Radial Blur<br/>
        ///   * Smart Blur<br/>
        ///   * Blur<br/>
        ///   * Black And White<br/>
        ///   * stenciler1<br/>
        ///   * stenciler3<br/>
        ///   * stenciler4<br/>
        ///   * stenciler6<br/>
        ///   * stenciler7<br/>
        ///   * DTN1<br/>
        ///   * DTN2<br/>
        ///   * DTN3<br/>
        ///   * DTN4<br/>
        ///   * DTN5
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoEffectsParameters(
            global::Picsart.VideoEffectsParametersEffectName? effectName)
        {
            this.EffectName = effectName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoEffectsParameters" /> class.
        /// </summary>
        public VideoEffectsParameters()
        {
        }
    }
}