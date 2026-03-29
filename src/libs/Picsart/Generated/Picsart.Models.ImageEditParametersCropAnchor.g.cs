
#nullable enable

namespace Picsart
{
    /// <summary>
    /// By default when crop_anchor or crop_x,crop_y pair are not provided, the crop will be done around the center of the image. This parameter is an easier option to crop_x,crop_y pair where the respective corner of the image will be cropped. Options for crop anchor are as follows:<br/>
    ///   * center<br/>
    ///   * top-left<br/>
    ///   * top-right<br/>
    ///   * bottom-left<br/>
    ///   * bottom-right<br/>
    /// Default Value: center
    /// </summary>
    public enum ImageEditParametersCropAnchor
    {
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
        Center,
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
    public static class ImageEditParametersCropAnchorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageEditParametersCropAnchor value)
        {
            return value switch
            {
                ImageEditParametersCropAnchor.BottomLeft => "bottom-left",
                ImageEditParametersCropAnchor.BottomRight => "bottom-right",
                ImageEditParametersCropAnchor.Center => "center",
                ImageEditParametersCropAnchor.TopLeft => "top-left",
                ImageEditParametersCropAnchor.TopRight => "top-right",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageEditParametersCropAnchor? ToEnum(string value)
        {
            return value switch
            {
                "bottom-left" => ImageEditParametersCropAnchor.BottomLeft,
                "bottom-right" => ImageEditParametersCropAnchor.BottomRight,
                "center" => ImageEditParametersCropAnchor.Center,
                "top-left" => ImageEditParametersCropAnchor.TopLeft,
                "top-right" => ImageEditParametersCropAnchor.TopRight,
                _ => null,
            };
        }
    }
}