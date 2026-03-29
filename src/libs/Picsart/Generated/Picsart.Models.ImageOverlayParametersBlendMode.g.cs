
#nullable enable

namespace Picsart
{
    /// <summary>
    /// The blend mode. Choose one of normal, darken, multiply, lighten, screen, color_dodge, overlay, soft_light, hard_light, hue, saturation, color, luminosity.  Defaults to normal.<br/>
    /// Default Value: normal
    /// </summary>
    public enum ImageOverlayParametersBlendMode
    {
        /// <summary>
        /// 
        /// </summary>
        Color,
        /// <summary>
        /// 
        /// </summary>
        ColorDodge,
        /// <summary>
        /// 
        /// </summary>
        Darken,
        /// <summary>
        /// 
        /// </summary>
        HardLight,
        /// <summary>
        /// 
        /// </summary>
        Hue,
        /// <summary>
        /// 
        /// </summary>
        Lighten,
        /// <summary>
        /// 
        /// </summary>
        Luminosity,
        /// <summary>
        /// 
        /// </summary>
        Multiply,
        /// <summary>
        /// 
        /// </summary>
        Normal,
        /// <summary>
        /// 
        /// </summary>
        Overlay,
        /// <summary>
        /// 
        /// </summary>
        Saturation,
        /// <summary>
        /// 
        /// </summary>
        Screen,
        /// <summary>
        /// 
        /// </summary>
        SoftLight,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageOverlayParametersBlendModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageOverlayParametersBlendMode value)
        {
            return value switch
            {
                ImageOverlayParametersBlendMode.Color => "color",
                ImageOverlayParametersBlendMode.ColorDodge => "color_dodge",
                ImageOverlayParametersBlendMode.Darken => "darken",
                ImageOverlayParametersBlendMode.HardLight => "hard_light",
                ImageOverlayParametersBlendMode.Hue => "hue",
                ImageOverlayParametersBlendMode.Lighten => "lighten",
                ImageOverlayParametersBlendMode.Luminosity => "luminosity",
                ImageOverlayParametersBlendMode.Multiply => "multiply",
                ImageOverlayParametersBlendMode.Normal => "normal",
                ImageOverlayParametersBlendMode.Overlay => "overlay",
                ImageOverlayParametersBlendMode.Saturation => "saturation",
                ImageOverlayParametersBlendMode.Screen => "screen",
                ImageOverlayParametersBlendMode.SoftLight => "soft_light",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageOverlayParametersBlendMode? ToEnum(string value)
        {
            return value switch
            {
                "color" => ImageOverlayParametersBlendMode.Color,
                "color_dodge" => ImageOverlayParametersBlendMode.ColorDodge,
                "darken" => ImageOverlayParametersBlendMode.Darken,
                "hard_light" => ImageOverlayParametersBlendMode.HardLight,
                "hue" => ImageOverlayParametersBlendMode.Hue,
                "lighten" => ImageOverlayParametersBlendMode.Lighten,
                "luminosity" => ImageOverlayParametersBlendMode.Luminosity,
                "multiply" => ImageOverlayParametersBlendMode.Multiply,
                "normal" => ImageOverlayParametersBlendMode.Normal,
                "overlay" => ImageOverlayParametersBlendMode.Overlay,
                "saturation" => ImageOverlayParametersBlendMode.Saturation,
                "screen" => ImageOverlayParametersBlendMode.Screen,
                "soft_light" => ImageOverlayParametersBlendMode.SoftLight,
                _ => null,
            };
        }
    }
}