
#nullable enable

namespace Picsart
{
    /// <summary>
    /// For *crop* mode, the outcome image will be center-cropped with the given size (width, height). For the *resize* mode, the smallest size will be fitted to preserve the original proportion of the image. When the outcome size is not provided with width and height, no cropping or resizing will be applied (see alternative options such as rotate, flip and perspective).
    /// </summary>
    public enum ImageEditParametersMode
    {
        /// <summary>
        /// 
        /// </summary>
        Crop,
        /// <summary>
        /// 
        /// </summary>
        Resize,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageEditParametersModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageEditParametersMode value)
        {
            return value switch
            {
                ImageEditParametersMode.Crop => "crop",
                ImageEditParametersMode.Resize => "resize",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageEditParametersMode? ToEnum(string value)
        {
            return value switch
            {
                "crop" => ImageEditParametersMode.Crop,
                "resize" => ImageEditParametersMode.Resize,
                _ => null,
            };
        }
    }
}