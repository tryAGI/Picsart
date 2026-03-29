
#nullable enable

namespace Picsart
{
    /// <summary>
    /// Choose a mask flip option. The choices are as follows.<br/>
    ///   * left<br/>
    ///   * right<br/>
    ///   * mirror horizontal<br/>
    ///   * mirror vertical<br/>
    ///   * turnaround
    /// </summary>
    public enum ImageMasksParametersMaskFlip
    {
        /// <summary>
        /// 
        /// </summary>
        Left,
        /// <summary>
        /// 
        /// </summary>
        MirrorHorizontal,
        /// <summary>
        /// 
        /// </summary>
        MirrorVertical,
        /// <summary>
        /// 
        /// </summary>
        Right,
        /// <summary>
        /// 
        /// </summary>
        Turnaround,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageMasksParametersMaskFlipExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageMasksParametersMaskFlip value)
        {
            return value switch
            {
                ImageMasksParametersMaskFlip.Left => "left",
                ImageMasksParametersMaskFlip.MirrorHorizontal => "mirror horizontal",
                ImageMasksParametersMaskFlip.MirrorVertical => "mirror vertical",
                ImageMasksParametersMaskFlip.Right => "right",
                ImageMasksParametersMaskFlip.Turnaround => "turnaround",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageMasksParametersMaskFlip? ToEnum(string value)
        {
            return value switch
            {
                "left" => ImageMasksParametersMaskFlip.Left,
                "mirror horizontal" => ImageMasksParametersMaskFlip.MirrorHorizontal,
                "mirror vertical" => ImageMasksParametersMaskFlip.MirrorVertical,
                "right" => ImageMasksParametersMaskFlip.Right,
                "turnaround" => ImageMasksParametersMaskFlip.Turnaround,
                _ => null,
            };
        }
    }
}