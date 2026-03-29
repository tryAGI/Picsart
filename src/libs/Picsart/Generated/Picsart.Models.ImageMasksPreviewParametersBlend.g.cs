
#nullable enable

namespace Picsart
{
    /// <summary>
    /// Select one of the appearance types from the list (it will be _screen_ if left blank). The options are as follows.<br/>
    ///   * normal<br/>
    ///   * screen<br/>
    ///   * overlay<br/>
    ///   * multiply<br/>
    ///   * darken<br/>
    ///   * lighten<br/>
    ///   * add<br/>
    /// Default Value: screen
    /// </summary>
    public enum ImageMasksPreviewParametersBlend
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
    public static class ImageMasksPreviewParametersBlendExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageMasksPreviewParametersBlend value)
        {
            return value switch
            {
                ImageMasksPreviewParametersBlend.Add => "add",
                ImageMasksPreviewParametersBlend.Darken => "darken",
                ImageMasksPreviewParametersBlend.Lighten => "lighten",
                ImageMasksPreviewParametersBlend.Multiply => "multiply",
                ImageMasksPreviewParametersBlend.Normal => "normal",
                ImageMasksPreviewParametersBlend.Overlay => "overlay",
                ImageMasksPreviewParametersBlend.Screen => "screen",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageMasksPreviewParametersBlend? ToEnum(string value)
        {
            return value switch
            {
                "add" => ImageMasksPreviewParametersBlend.Add,
                "darken" => ImageMasksPreviewParametersBlend.Darken,
                "lighten" => ImageMasksPreviewParametersBlend.Lighten,
                "multiply" => ImageMasksPreviewParametersBlend.Multiply,
                "normal" => ImageMasksPreviewParametersBlend.Normal,
                "overlay" => ImageMasksPreviewParametersBlend.Overlay,
                "screen" => ImageMasksPreviewParametersBlend.Screen,
                _ => null,
            };
        }
    }
}