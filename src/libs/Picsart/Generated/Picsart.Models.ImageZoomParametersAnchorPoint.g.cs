
#nullable enable

namespace Picsart
{
    /// <summary>
    /// Anchor point for zooming. Determines which part of the image to focus on. Expect longer response times when 'ai' is used.<br/>
    /// Default Value: center-middle
    /// </summary>
    public enum ImageZoomParametersAnchorPoint
    {
        /// <summary>
        /// 
        /// </summary>
        Ai,
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
    public static class ImageZoomParametersAnchorPointExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageZoomParametersAnchorPoint value)
        {
            return value switch
            {
                ImageZoomParametersAnchorPoint.Ai => "ai",
                ImageZoomParametersAnchorPoint.CenterBottom => "center-bottom",
                ImageZoomParametersAnchorPoint.CenterMiddle => "center-middle",
                ImageZoomParametersAnchorPoint.CenterTop => "center-top",
                ImageZoomParametersAnchorPoint.LeftBottom => "left-bottom",
                ImageZoomParametersAnchorPoint.LeftMiddle => "left-middle",
                ImageZoomParametersAnchorPoint.LeftTop => "left-top",
                ImageZoomParametersAnchorPoint.RightBottom => "right-bottom",
                ImageZoomParametersAnchorPoint.RightMiddle => "right-middle",
                ImageZoomParametersAnchorPoint.RightTop => "right-top",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageZoomParametersAnchorPoint? ToEnum(string value)
        {
            return value switch
            {
                "ai" => ImageZoomParametersAnchorPoint.Ai,
                "center-bottom" => ImageZoomParametersAnchorPoint.CenterBottom,
                "center-middle" => ImageZoomParametersAnchorPoint.CenterMiddle,
                "center-top" => ImageZoomParametersAnchorPoint.CenterTop,
                "left-bottom" => ImageZoomParametersAnchorPoint.LeftBottom,
                "left-middle" => ImageZoomParametersAnchorPoint.LeftMiddle,
                "left-top" => ImageZoomParametersAnchorPoint.LeftTop,
                "right-bottom" => ImageZoomParametersAnchorPoint.RightBottom,
                "right-middle" => ImageZoomParametersAnchorPoint.RightMiddle,
                "right-top" => ImageZoomParametersAnchorPoint.RightTop,
                _ => null,
            };
        }
    }
}