
#nullable enable

namespace Picsart
{
    /// <summary>
    /// The transition between segments.<br/>
    /// Default Value: none
    /// </summary>
    public enum VideoConcatSegmentsParametersTrimSegmentTransition
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
    public static class VideoConcatSegmentsParametersTrimSegmentTransitionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoConcatSegmentsParametersTrimSegmentTransition value)
        {
            return value switch
            {
                VideoConcatSegmentsParametersTrimSegmentTransition.Fade => "fade",
                VideoConcatSegmentsParametersTrimSegmentTransition.FlyInFromBottom => "fly_in_from_bottom",
                VideoConcatSegmentsParametersTrimSegmentTransition.FlyInFromLeft => "fly_in_from_left",
                VideoConcatSegmentsParametersTrimSegmentTransition.FlyInFromRight => "fly_in_from_right",
                VideoConcatSegmentsParametersTrimSegmentTransition.FlyInFromTop => "fly_in_from_top",
                VideoConcatSegmentsParametersTrimSegmentTransition.FlyOutToBottom => "fly_out_to_bottom",
                VideoConcatSegmentsParametersTrimSegmentTransition.FlyOutToLeft => "fly_out_to_left",
                VideoConcatSegmentsParametersTrimSegmentTransition.FlyOutToRight => "fly_out_to_right",
                VideoConcatSegmentsParametersTrimSegmentTransition.FlyOutToTop => "fly_out_to_top",
                VideoConcatSegmentsParametersTrimSegmentTransition.None => "none",
                VideoConcatSegmentsParametersTrimSegmentTransition.Spin => "spin",
                VideoConcatSegmentsParametersTrimSegmentTransition.ZoomIn => "zoom_in",
                VideoConcatSegmentsParametersTrimSegmentTransition.ZoomOut => "zoom_out",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoConcatSegmentsParametersTrimSegmentTransition? ToEnum(string value)
        {
            return value switch
            {
                "fade" => VideoConcatSegmentsParametersTrimSegmentTransition.Fade,
                "fly_in_from_bottom" => VideoConcatSegmentsParametersTrimSegmentTransition.FlyInFromBottom,
                "fly_in_from_left" => VideoConcatSegmentsParametersTrimSegmentTransition.FlyInFromLeft,
                "fly_in_from_right" => VideoConcatSegmentsParametersTrimSegmentTransition.FlyInFromRight,
                "fly_in_from_top" => VideoConcatSegmentsParametersTrimSegmentTransition.FlyInFromTop,
                "fly_out_to_bottom" => VideoConcatSegmentsParametersTrimSegmentTransition.FlyOutToBottom,
                "fly_out_to_left" => VideoConcatSegmentsParametersTrimSegmentTransition.FlyOutToLeft,
                "fly_out_to_right" => VideoConcatSegmentsParametersTrimSegmentTransition.FlyOutToRight,
                "fly_out_to_top" => VideoConcatSegmentsParametersTrimSegmentTransition.FlyOutToTop,
                "none" => VideoConcatSegmentsParametersTrimSegmentTransition.None,
                "spin" => VideoConcatSegmentsParametersTrimSegmentTransition.Spin,
                "zoom_in" => VideoConcatSegmentsParametersTrimSegmentTransition.ZoomIn,
                "zoom_out" => VideoConcatSegmentsParametersTrimSegmentTransition.ZoomOut,
                _ => null,
            };
        }
    }
}