
#nullable enable

namespace Picsart
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
    public enum VideoEffectsParametersEffectName
    {
        /// <summary>
        /// 
        /// </summary>
        BlackAndWhite,
        /// <summary>
        /// 
        /// </summary>
        Blur,
        /// <summary>
        /// 
        /// </summary>
        Dtn1,
        /// <summary>
        /// 
        /// </summary>
        Dtn2,
        /// <summary>
        /// 
        /// </summary>
        Dtn3,
        /// <summary>
        /// 
        /// </summary>
        Dtn4,
        /// <summary>
        /// 
        /// </summary>
        Dtn5,
        /// <summary>
        /// 
        /// </summary>
        FocalZoom,
        /// <summary>
        /// 
        /// </summary>
        LensBlur,
        /// <summary>
        /// 
        /// </summary>
        MotionBlur,
        /// <summary>
        /// 
        /// </summary>
        RadialBlur,
        /// <summary>
        /// 
        /// </summary>
        SmartBlur,
        /// <summary>
        /// 
        /// </summary>
        Apr1,
        /// <summary>
        /// 
        /// </summary>
        Apr2,
        /// <summary>
        /// 
        /// </summary>
        Apr3,
        /// <summary>
        /// 
        /// </summary>
        Brnz1,
        /// <summary>
        /// 
        /// </summary>
        Brnz2,
        /// <summary>
        /// 
        /// </summary>
        Brnz3,
        /// <summary>
        /// 
        /// </summary>
        Brnz4,
        /// <summary>
        /// 
        /// </summary>
        Cyber1,
        /// <summary>
        /// 
        /// </summary>
        Cyber2,
        /// <summary>
        /// 
        /// </summary>
        Cyber3,
        /// <summary>
        /// 
        /// </summary>
        Icy1,
        /// <summary>
        /// 
        /// </summary>
        Icy2,
        /// <summary>
        /// 
        /// </summary>
        Icy3,
        /// <summary>
        /// 
        /// </summary>
        Icy4,
        /// <summary>
        /// 
        /// </summary>
        Mnch1,
        /// <summary>
        /// 
        /// </summary>
        Mnch2,
        /// <summary>
        /// 
        /// </summary>
        Mnch3,
        /// <summary>
        /// 
        /// </summary>
        Noise,
        /// <summary>
        /// 
        /// </summary>
        Ntrl1,
        /// <summary>
        /// 
        /// </summary>
        Ntrl2,
        /// <summary>
        /// 
        /// </summary>
        Ntrl3,
        /// <summary>
        /// 
        /// </summary>
        Pixelize,
        /// <summary>
        /// 
        /// </summary>
        Saturation,
        /// <summary>
        /// 
        /// </summary>
        Sft1,
        /// <summary>
        /// 
        /// </summary>
        Sft2,
        /// <summary>
        /// 
        /// </summary>
        Sft3,
        /// <summary>
        /// 
        /// </summary>
        Sft4,
        /// <summary>
        /// 
        /// </summary>
        Sharpen,
        /// <summary>
        /// 
        /// </summary>
        Stenciler1,
        /// <summary>
        /// 
        /// </summary>
        Stenciler3,
        /// <summary>
        /// 
        /// </summary>
        Stenciler4,
        /// <summary>
        /// 
        /// </summary>
        Stenciler6,
        /// <summary>
        /// 
        /// </summary>
        Stenciler7,
        /// <summary>
        /// 
        /// </summary>
        Tl1,
        /// <summary>
        /// 
        /// </summary>
        Tl2,
        /// <summary>
        /// 
        /// </summary>
        Vignette,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoEffectsParametersEffectNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoEffectsParametersEffectName value)
        {
            return value switch
            {
                VideoEffectsParametersEffectName.BlackAndWhite => "Black And White",
                VideoEffectsParametersEffectName.Blur => "Blur",
                VideoEffectsParametersEffectName.Dtn1 => "DTN1",
                VideoEffectsParametersEffectName.Dtn2 => "DTN2",
                VideoEffectsParametersEffectName.Dtn3 => "DTN3",
                VideoEffectsParametersEffectName.Dtn4 => "DTN4",
                VideoEffectsParametersEffectName.Dtn5 => "DTN5",
                VideoEffectsParametersEffectName.FocalZoom => "Focal Zoom",
                VideoEffectsParametersEffectName.LensBlur => "Lens Blur",
                VideoEffectsParametersEffectName.MotionBlur => "Motion Blur",
                VideoEffectsParametersEffectName.RadialBlur => "Radial Blur",
                VideoEffectsParametersEffectName.SmartBlur => "Smart Blur",
                VideoEffectsParametersEffectName.Apr1 => "apr1",
                VideoEffectsParametersEffectName.Apr2 => "apr2",
                VideoEffectsParametersEffectName.Apr3 => "apr3",
                VideoEffectsParametersEffectName.Brnz1 => "brnz1",
                VideoEffectsParametersEffectName.Brnz2 => "brnz2",
                VideoEffectsParametersEffectName.Brnz3 => "brnz3",
                VideoEffectsParametersEffectName.Brnz4 => "brnz4",
                VideoEffectsParametersEffectName.Cyber1 => "cyber1",
                VideoEffectsParametersEffectName.Cyber2 => "cyber2",
                VideoEffectsParametersEffectName.Cyber3 => "cyber3",
                VideoEffectsParametersEffectName.Icy1 => "icy1",
                VideoEffectsParametersEffectName.Icy2 => "icy2",
                VideoEffectsParametersEffectName.Icy3 => "icy3",
                VideoEffectsParametersEffectName.Icy4 => "icy4",
                VideoEffectsParametersEffectName.Mnch1 => "mnch1",
                VideoEffectsParametersEffectName.Mnch2 => "mnch2",
                VideoEffectsParametersEffectName.Mnch3 => "mnch3",
                VideoEffectsParametersEffectName.Noise => "noise",
                VideoEffectsParametersEffectName.Ntrl1 => "ntrl1",
                VideoEffectsParametersEffectName.Ntrl2 => "ntrl2",
                VideoEffectsParametersEffectName.Ntrl3 => "ntrl3",
                VideoEffectsParametersEffectName.Pixelize => "pixelize",
                VideoEffectsParametersEffectName.Saturation => "saturation",
                VideoEffectsParametersEffectName.Sft1 => "sft1",
                VideoEffectsParametersEffectName.Sft2 => "sft2",
                VideoEffectsParametersEffectName.Sft3 => "sft3",
                VideoEffectsParametersEffectName.Sft4 => "sft4",
                VideoEffectsParametersEffectName.Sharpen => "sharpen",
                VideoEffectsParametersEffectName.Stenciler1 => "stenciler1",
                VideoEffectsParametersEffectName.Stenciler3 => "stenciler3",
                VideoEffectsParametersEffectName.Stenciler4 => "stenciler4",
                VideoEffectsParametersEffectName.Stenciler6 => "stenciler6",
                VideoEffectsParametersEffectName.Stenciler7 => "stenciler7",
                VideoEffectsParametersEffectName.Tl1 => "tl1",
                VideoEffectsParametersEffectName.Tl2 => "tl2",
                VideoEffectsParametersEffectName.Vignette => "vignette",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoEffectsParametersEffectName? ToEnum(string value)
        {
            return value switch
            {
                "Black And White" => VideoEffectsParametersEffectName.BlackAndWhite,
                "Blur" => VideoEffectsParametersEffectName.Blur,
                "DTN1" => VideoEffectsParametersEffectName.Dtn1,
                "DTN2" => VideoEffectsParametersEffectName.Dtn2,
                "DTN3" => VideoEffectsParametersEffectName.Dtn3,
                "DTN4" => VideoEffectsParametersEffectName.Dtn4,
                "DTN5" => VideoEffectsParametersEffectName.Dtn5,
                "Focal Zoom" => VideoEffectsParametersEffectName.FocalZoom,
                "Lens Blur" => VideoEffectsParametersEffectName.LensBlur,
                "Motion Blur" => VideoEffectsParametersEffectName.MotionBlur,
                "Radial Blur" => VideoEffectsParametersEffectName.RadialBlur,
                "Smart Blur" => VideoEffectsParametersEffectName.SmartBlur,
                "apr1" => VideoEffectsParametersEffectName.Apr1,
                "apr2" => VideoEffectsParametersEffectName.Apr2,
                "apr3" => VideoEffectsParametersEffectName.Apr3,
                "brnz1" => VideoEffectsParametersEffectName.Brnz1,
                "brnz2" => VideoEffectsParametersEffectName.Brnz2,
                "brnz3" => VideoEffectsParametersEffectName.Brnz3,
                "brnz4" => VideoEffectsParametersEffectName.Brnz4,
                "cyber1" => VideoEffectsParametersEffectName.Cyber1,
                "cyber2" => VideoEffectsParametersEffectName.Cyber2,
                "cyber3" => VideoEffectsParametersEffectName.Cyber3,
                "icy1" => VideoEffectsParametersEffectName.Icy1,
                "icy2" => VideoEffectsParametersEffectName.Icy2,
                "icy3" => VideoEffectsParametersEffectName.Icy3,
                "icy4" => VideoEffectsParametersEffectName.Icy4,
                "mnch1" => VideoEffectsParametersEffectName.Mnch1,
                "mnch2" => VideoEffectsParametersEffectName.Mnch2,
                "mnch3" => VideoEffectsParametersEffectName.Mnch3,
                "noise" => VideoEffectsParametersEffectName.Noise,
                "ntrl1" => VideoEffectsParametersEffectName.Ntrl1,
                "ntrl2" => VideoEffectsParametersEffectName.Ntrl2,
                "ntrl3" => VideoEffectsParametersEffectName.Ntrl3,
                "pixelize" => VideoEffectsParametersEffectName.Pixelize,
                "saturation" => VideoEffectsParametersEffectName.Saturation,
                "sft1" => VideoEffectsParametersEffectName.Sft1,
                "sft2" => VideoEffectsParametersEffectName.Sft2,
                "sft3" => VideoEffectsParametersEffectName.Sft3,
                "sft4" => VideoEffectsParametersEffectName.Sft4,
                "sharpen" => VideoEffectsParametersEffectName.Sharpen,
                "stenciler1" => VideoEffectsParametersEffectName.Stenciler1,
                "stenciler3" => VideoEffectsParametersEffectName.Stenciler3,
                "stenciler4" => VideoEffectsParametersEffectName.Stenciler4,
                "stenciler6" => VideoEffectsParametersEffectName.Stenciler6,
                "stenciler7" => VideoEffectsParametersEffectName.Stenciler7,
                "tl1" => VideoEffectsParametersEffectName.Tl1,
                "tl2" => VideoEffectsParametersEffectName.Tl2,
                "vignette" => VideoEffectsParametersEffectName.Vignette,
                _ => null,
            };
        }
    }
}