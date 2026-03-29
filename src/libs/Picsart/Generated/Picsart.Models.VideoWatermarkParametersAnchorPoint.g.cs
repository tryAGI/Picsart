
#nullable enable

namespace Picsart
{
    /// <summary>
    /// Default Value: center-middle
    /// </summary>
    public enum VideoWatermarkParametersAnchorPoint
    {
        /// <summary>
        /// 
        /// </summary>
        CenterBottom,
        /// <summary>
        /// 
        /// </summary>
        CenterMiddle,
        /// <summary>
        /// 
        /// </summary>
        CenterTop,
        /// <summary>
        /// 
        /// </summary>
        LeftBottom,
        /// <summary>
        /// 
        /// </summary>
        LeftMiddle,
        /// <summary>
        /// 
        /// </summary>
        LeftTop,
        /// <summary>
        /// 
        /// </summary>
        Pattern,
        /// <summary>
        /// 
        /// </summary>
        RightBottom,
        /// <summary>
        /// 
        /// </summary>
        RightMiddle,
        /// <summary>
        /// 
        /// </summary>
        RightTop,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoWatermarkParametersAnchorPointExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoWatermarkParametersAnchorPoint value)
        {
            return value switch
            {
                VideoWatermarkParametersAnchorPoint.CenterBottom => "center-bottom",
                VideoWatermarkParametersAnchorPoint.CenterMiddle => "center-middle",
                VideoWatermarkParametersAnchorPoint.CenterTop => "center-top",
                VideoWatermarkParametersAnchorPoint.LeftBottom => "left-bottom",
                VideoWatermarkParametersAnchorPoint.LeftMiddle => "left-middle",
                VideoWatermarkParametersAnchorPoint.LeftTop => "left-top",
                VideoWatermarkParametersAnchorPoint.Pattern => "pattern",
                VideoWatermarkParametersAnchorPoint.RightBottom => "right-bottom",
                VideoWatermarkParametersAnchorPoint.RightMiddle => "right-middle",
                VideoWatermarkParametersAnchorPoint.RightTop => "right-top",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoWatermarkParametersAnchorPoint? ToEnum(string value)
        {
            return value switch
            {
                "center-bottom" => VideoWatermarkParametersAnchorPoint.CenterBottom,
                "center-middle" => VideoWatermarkParametersAnchorPoint.CenterMiddle,
                "center-top" => VideoWatermarkParametersAnchorPoint.CenterTop,
                "left-bottom" => VideoWatermarkParametersAnchorPoint.LeftBottom,
                "left-middle" => VideoWatermarkParametersAnchorPoint.LeftMiddle,
                "left-top" => VideoWatermarkParametersAnchorPoint.LeftTop,
                "pattern" => VideoWatermarkParametersAnchorPoint.Pattern,
                "right-bottom" => VideoWatermarkParametersAnchorPoint.RightBottom,
                "right-middle" => VideoWatermarkParametersAnchorPoint.RightMiddle,
                "right-top" => VideoWatermarkParametersAnchorPoint.RightTop,
                _ => null,
            };
        }
    }
}