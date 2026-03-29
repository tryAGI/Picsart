
#nullable enable

namespace Picsart
{
    /// <summary>
    /// Default Value: center-middle
    /// </summary>
    public enum ImageWatermarkParametersAnchorPoint
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
    public static class ImageWatermarkParametersAnchorPointExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageWatermarkParametersAnchorPoint value)
        {
            return value switch
            {
                ImageWatermarkParametersAnchorPoint.CenterBottom => "center-bottom",
                ImageWatermarkParametersAnchorPoint.CenterMiddle => "center-middle",
                ImageWatermarkParametersAnchorPoint.CenterTop => "center-top",
                ImageWatermarkParametersAnchorPoint.LeftBottom => "left-bottom",
                ImageWatermarkParametersAnchorPoint.LeftMiddle => "left-middle",
                ImageWatermarkParametersAnchorPoint.LeftTop => "left-top",
                ImageWatermarkParametersAnchorPoint.Pattern => "pattern",
                ImageWatermarkParametersAnchorPoint.RightBottom => "right-bottom",
                ImageWatermarkParametersAnchorPoint.RightMiddle => "right-middle",
                ImageWatermarkParametersAnchorPoint.RightTop => "right-top",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageWatermarkParametersAnchorPoint? ToEnum(string value)
        {
            return value switch
            {
                "center-bottom" => ImageWatermarkParametersAnchorPoint.CenterBottom,
                "center-middle" => ImageWatermarkParametersAnchorPoint.CenterMiddle,
                "center-top" => ImageWatermarkParametersAnchorPoint.CenterTop,
                "left-bottom" => ImageWatermarkParametersAnchorPoint.LeftBottom,
                "left-middle" => ImageWatermarkParametersAnchorPoint.LeftMiddle,
                "left-top" => ImageWatermarkParametersAnchorPoint.LeftTop,
                "pattern" => ImageWatermarkParametersAnchorPoint.Pattern,
                "right-bottom" => ImageWatermarkParametersAnchorPoint.RightBottom,
                "right-middle" => ImageWatermarkParametersAnchorPoint.RightMiddle,
                "right-top" => ImageWatermarkParametersAnchorPoint.RightTop,
                _ => null,
            };
        }
    }
}