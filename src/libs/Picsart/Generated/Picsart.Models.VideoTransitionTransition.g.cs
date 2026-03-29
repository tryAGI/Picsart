
#nullable enable

namespace Picsart
{
    /// <summary>
    /// Default Value: none
    /// </summary>
    public enum VideoTransitionTransition
    {
        /// <summary>
        /// 
        /// </summary>
        Fade,
        /// <summary>
        /// 
        /// </summary>
        FlyInFromBottom,
        /// <summary>
        /// 
        /// </summary>
        FlyInFromLeft,
        /// <summary>
        /// 
        /// </summary>
        FlyInFromRight,
        /// <summary>
        /// 
        /// </summary>
        FlyInFromTop,
        /// <summary>
        /// 
        /// </summary>
        FlyOutToBottom,
        /// <summary>
        /// 
        /// </summary>
        FlyOutToLeft,
        /// <summary>
        /// 
        /// </summary>
        FlyOutToRight,
        /// <summary>
        /// 
        /// </summary>
        FlyOutToTop,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Spin,
        /// <summary>
        /// 
        /// </summary>
        ZoomIn,
        /// <summary>
        /// 
        /// </summary>
        ZoomOut,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoTransitionTransitionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoTransitionTransition value)
        {
            return value switch
            {
                VideoTransitionTransition.Fade => "fade",
                VideoTransitionTransition.FlyInFromBottom => "fly_in_from_bottom",
                VideoTransitionTransition.FlyInFromLeft => "fly_in_from_left",
                VideoTransitionTransition.FlyInFromRight => "fly_in_from_right",
                VideoTransitionTransition.FlyInFromTop => "fly_in_from_top",
                VideoTransitionTransition.FlyOutToBottom => "fly_out_to_bottom",
                VideoTransitionTransition.FlyOutToLeft => "fly_out_to_left",
                VideoTransitionTransition.FlyOutToRight => "fly_out_to_right",
                VideoTransitionTransition.FlyOutToTop => "fly_out_to_top",
                VideoTransitionTransition.None => "none",
                VideoTransitionTransition.Spin => "spin",
                VideoTransitionTransition.ZoomIn => "zoom_in",
                VideoTransitionTransition.ZoomOut => "zoom_out",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoTransitionTransition? ToEnum(string value)
        {
            return value switch
            {
                "fade" => VideoTransitionTransition.Fade,
                "fly_in_from_bottom" => VideoTransitionTransition.FlyInFromBottom,
                "fly_in_from_left" => VideoTransitionTransition.FlyInFromLeft,
                "fly_in_from_right" => VideoTransitionTransition.FlyInFromRight,
                "fly_in_from_top" => VideoTransitionTransition.FlyInFromTop,
                "fly_out_to_bottom" => VideoTransitionTransition.FlyOutToBottom,
                "fly_out_to_left" => VideoTransitionTransition.FlyOutToLeft,
                "fly_out_to_right" => VideoTransitionTransition.FlyOutToRight,
                "fly_out_to_top" => VideoTransitionTransition.FlyOutToTop,
                "none" => VideoTransitionTransition.None,
                "spin" => VideoTransitionTransition.Spin,
                "zoom_in" => VideoTransitionTransition.ZoomIn,
                "zoom_out" => VideoTransitionTransition.ZoomOut,
                _ => null,
            };
        }
    }
}