
#nullable enable

namespace Picsart
{
    /// <summary>
    /// Select one of the appearance types from the list (_screen_ is chosen if left blank). The options are as follows:<br/>
    ///   * normal<br/>
    ///   * screen<br/>
    ///   * overlay<br/>
    ///   * multiply<br/>
    ///   * darken<br/>
    ///   * lighten<br/>
    ///   * add<br/>
    /// Default Value: screen
    /// </summary>
    public enum ImageMasksParametersBlend
    {
        /// <summary>
        /// 
        /// </summary>
        Add,
        /// <summary>
        /// 
        /// </summary>
        Darken,
        /// <summary>
        /// 
        /// </summary>
        Lighten,
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
        Screen,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageMasksParametersBlendExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageMasksParametersBlend value)
        {
            return value switch
            {
                ImageMasksParametersBlend.Add => "add",
                ImageMasksParametersBlend.Darken => "darken",
                ImageMasksParametersBlend.Lighten => "lighten",
                ImageMasksParametersBlend.Multiply => "multiply",
                ImageMasksParametersBlend.Normal => "normal",
                ImageMasksParametersBlend.Overlay => "overlay",
                ImageMasksParametersBlend.Screen => "screen",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageMasksParametersBlend? ToEnum(string value)
        {
            return value switch
            {
                "add" => ImageMasksParametersBlend.Add,
                "darken" => ImageMasksParametersBlend.Darken,
                "lighten" => ImageMasksParametersBlend.Lighten,
                "multiply" => ImageMasksParametersBlend.Multiply,
                "normal" => ImageMasksParametersBlend.Normal,
                "overlay" => ImageMasksParametersBlend.Overlay,
                "screen" => ImageMasksParametersBlend.Screen,
                _ => null,
            };
        }
    }
}