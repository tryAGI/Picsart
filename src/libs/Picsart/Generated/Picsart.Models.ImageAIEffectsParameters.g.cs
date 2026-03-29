
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageAIEffectsParameters
    {
        /// <summary>
        /// Choose an effect from the dropdown menu. The list of effects are as follows<br/>
        ///   * winterblues<br/>
        ///   * wispy<br/>
        ///   * geode<br/>
        ///   * 744<br/>
        ///   * sketchy<br/>
        ///   * dystopia<br/>
        ///   * libtest2<br/>
        ///   * pastel<br/>
        ///   * moonlight<br/>
        ///   * rainbow<br/>
        ///   * money<br/>
        ///   * popsketch<br/>
        ///   * hintofyellow<br/>
        ///   * badlands<br/>
        ///   * letitsnow<br/>
        ///   * flora<br/>
        ///   * staygold<br/>
        ///   * holidayparty<br/>
        ///   * galaxy<br/>
        ///   * crushedmarble<br/>
        ///   * pow<br/>
        ///   * shades_of_gray<br/>
        ///   * haze<br/>
        ///   * shamrock<br/>
        ///   * 815<br/>
        ///   * flare<br/>
        ///   * prettyinpink<br/>
        ///   * rosegold<br/>
        ///   * wonderland<br/>
        ///   * whiteice<br/>
        ///   * nightcore<br/>
        ///   * pleinair34_120<br/>
        ///   * soul<br/>
        ///   * rosequartz<br/>
        ///   * animation<br/>
        ///   * feast<br/>
        ///   * undead<br/>
        ///   * highlight<br/>
        ///   * neopop<br/>
        ///   * midnight<br/>
        ///   * colorbright<br/>
        ///   * cartoon1<br/>
        ///   * cartoon2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effect_name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.ImageAIEffectsParametersEffectNameJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Picsart.ImageAIEffectsParametersEffectName EffectName { get; set; }

        /// <summary>
        /// Optionally select one of the output image formats (JPG is chosen if left blank). Options are as follows:<br/>
        ///   * JPG<br/>
        ///   * PNG<br/>
        ///   * WEBP<br/>
        /// Default Value: JPG
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.ImageAIEffectsParametersFormatJsonConverter))]
        public global::Picsart.ImageAIEffectsParametersFormat? Format { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageAIEffectsParameters" /> class.
        /// </summary>
        /// <param name="effectName">
        /// Choose an effect from the dropdown menu. The list of effects are as follows<br/>
        ///   * winterblues<br/>
        ///   * wispy<br/>
        ///   * geode<br/>
        ///   * 744<br/>
        ///   * sketchy<br/>
        ///   * dystopia<br/>
        ///   * libtest2<br/>
        ///   * pastel<br/>
        ///   * moonlight<br/>
        ///   * rainbow<br/>
        ///   * money<br/>
        ///   * popsketch<br/>
        ///   * hintofyellow<br/>
        ///   * badlands<br/>
        ///   * letitsnow<br/>
        ///   * flora<br/>
        ///   * staygold<br/>
        ///   * holidayparty<br/>
        ///   * galaxy<br/>
        ///   * crushedmarble<br/>
        ///   * pow<br/>
        ///   * shades_of_gray<br/>
        ///   * haze<br/>
        ///   * shamrock<br/>
        ///   * 815<br/>
        ///   * flare<br/>
        ///   * prettyinpink<br/>
        ///   * rosegold<br/>
        ///   * wonderland<br/>
        ///   * whiteice<br/>
        ///   * nightcore<br/>
        ///   * pleinair34_120<br/>
        ///   * soul<br/>
        ///   * rosequartz<br/>
        ///   * animation<br/>
        ///   * feast<br/>
        ///   * undead<br/>
        ///   * highlight<br/>
        ///   * neopop<br/>
        ///   * midnight<br/>
        ///   * colorbright<br/>
        ///   * cartoon1<br/>
        ///   * cartoon2
        /// </param>
        /// <param name="format">
        /// Optionally select one of the output image formats (JPG is chosen if left blank). Options are as follows:<br/>
        ///   * JPG<br/>
        ///   * PNG<br/>
        ///   * WEBP<br/>
        /// Default Value: JPG
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageAIEffectsParameters(
            global::Picsart.ImageAIEffectsParametersEffectName effectName,
            global::Picsart.ImageAIEffectsParametersFormat? format)
        {
            this.EffectName = effectName;
            this.Format = format;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageAIEffectsParameters" /> class.
        /// </summary>
        public ImageAIEffectsParameters()
        {
        }
    }
}