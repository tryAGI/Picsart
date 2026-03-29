
#nullable enable

namespace Picsart
{
    /// <summary>
    /// A universal parameter to configure the shadow. The default value is "disabled" and it will make sure that the shadow is not rendered. The "custom" value allows to define custom position for the shadow, when this value is chosen, the shadow_offset_x and the shadow_offset_y will get applied. Other values are shadow directions with preset shadow setup (10px).<br/>
    /// Default Value: disabled
    /// </summary>
    public enum ImageRemoveBackgroundParametersJSONShadow
    {
        /// <summary>
        /// 
        /// </summary>
        Bottom,
        /// <summary>
        /// 
        /// </summary>
        BottomLeft,
        /// <summary>
        /// 
        /// </summary>
        BottomRight,
        /// <summary>
        /// 
        /// </summary>
        Custom,
        /// <summary>
        /// 
        /// </summary>
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        Left,
        /// <summary>
        /// 
        /// </summary>
        Right,
        /// <summary>
        /// 
        /// </summary>
        Top,
        /// <summary>
        /// 
        /// </summary>
        TopLeft,
        /// <summary>
        /// 
        /// </summary>
        TopRight,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageRemoveBackgroundParametersJSONShadowExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageRemoveBackgroundParametersJSONShadow value)
        {
            return value switch
            {
                ImageRemoveBackgroundParametersJSONShadow.Bottom => "bottom",
                ImageRemoveBackgroundParametersJSONShadow.BottomLeft => "bottom-left",
                ImageRemoveBackgroundParametersJSONShadow.BottomRight => "bottom-right",
                ImageRemoveBackgroundParametersJSONShadow.Custom => "custom",
                ImageRemoveBackgroundParametersJSONShadow.Disabled => "disabled",
                ImageRemoveBackgroundParametersJSONShadow.Left => "left",
                ImageRemoveBackgroundParametersJSONShadow.Right => "right",
                ImageRemoveBackgroundParametersJSONShadow.Top => "top",
                ImageRemoveBackgroundParametersJSONShadow.TopLeft => "top-left",
                ImageRemoveBackgroundParametersJSONShadow.TopRight => "top-right",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageRemoveBackgroundParametersJSONShadow? ToEnum(string value)
        {
            return value switch
            {
                "bottom" => ImageRemoveBackgroundParametersJSONShadow.Bottom,
                "bottom-left" => ImageRemoveBackgroundParametersJSONShadow.BottomLeft,
                "bottom-right" => ImageRemoveBackgroundParametersJSONShadow.BottomRight,
                "custom" => ImageRemoveBackgroundParametersJSONShadow.Custom,
                "disabled" => ImageRemoveBackgroundParametersJSONShadow.Disabled,
                "left" => ImageRemoveBackgroundParametersJSONShadow.Left,
                "right" => ImageRemoveBackgroundParametersJSONShadow.Right,
                "top" => ImageRemoveBackgroundParametersJSONShadow.Top,
                "top-left" => ImageRemoveBackgroundParametersJSONShadow.TopLeft,
                "top-right" => ImageRemoveBackgroundParametersJSONShadow.TopRight,
                _ => null,
            };
        }
    }
}