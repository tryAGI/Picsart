
#nullable enable

namespace Picsart
{
    /// <summary>
    /// A universal parameter to configure the shadow. The default value is "disabled" and it will make sure that the shadow is not rendered. The "custom" value allows to define custom position for the shadow, when this value is chosen, the shadow_offset_x and the shadow_offset_y will get applied. Other values are shadow directions with preset shadow setup (10px).<br/>
    /// Default Value: disabled
    /// </summary>
    public enum ImageRemoveBackgroundParametersShadow
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
    public static class ImageRemoveBackgroundParametersShadowExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageRemoveBackgroundParametersShadow value)
        {
            return value switch
            {
                ImageRemoveBackgroundParametersShadow.Bottom => "bottom",
                ImageRemoveBackgroundParametersShadow.BottomLeft => "bottom-left",
                ImageRemoveBackgroundParametersShadow.BottomRight => "bottom-right",
                ImageRemoveBackgroundParametersShadow.Custom => "custom",
                ImageRemoveBackgroundParametersShadow.Disabled => "disabled",
                ImageRemoveBackgroundParametersShadow.Left => "left",
                ImageRemoveBackgroundParametersShadow.Right => "right",
                ImageRemoveBackgroundParametersShadow.Top => "top",
                ImageRemoveBackgroundParametersShadow.TopLeft => "top-left",
                ImageRemoveBackgroundParametersShadow.TopRight => "top-right",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageRemoveBackgroundParametersShadow? ToEnum(string value)
        {
            return value switch
            {
                "bottom" => ImageRemoveBackgroundParametersShadow.Bottom,
                "bottom-left" => ImageRemoveBackgroundParametersShadow.BottomLeft,
                "bottom-right" => ImageRemoveBackgroundParametersShadow.BottomRight,
                "custom" => ImageRemoveBackgroundParametersShadow.Custom,
                "disabled" => ImageRemoveBackgroundParametersShadow.Disabled,
                "left" => ImageRemoveBackgroundParametersShadow.Left,
                "right" => ImageRemoveBackgroundParametersShadow.Right,
                "top" => ImageRemoveBackgroundParametersShadow.Top,
                "top-left" => ImageRemoveBackgroundParametersShadow.TopLeft,
                "top-right" => ImageRemoveBackgroundParametersShadow.TopRight,
                _ => null,
            };
        }
    }
}