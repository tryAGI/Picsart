
#nullable enable

namespace Picsart
{
    /// <summary>
    /// Optionally enforce the ration of the result image. When both width and height parameters are provided, they should match this ratio.<br/>
    /// In case either width or height are provided, the other value will be calculated based on this ratio.
    /// </summary>
    public enum ImageSmartCropParametersRatio
    {
        /// <summary>
        /// 
        /// </summary>
        x16_9,
        /// <summary>
        /// 
        /// </summary>
        x1_1,
        /// <summary>
        /// 
        /// </summary>
        x21_9,
        /// <summary>
        /// 
        /// </summary>
        x2_3,
        /// <summary>
        /// 
        /// </summary>
        x3_2,
        /// <summary>
        /// 
        /// </summary>
        x4_3,
        /// <summary>
        /// 
        /// </summary>
        x4_5,
        /// <summary>
        /// 
        /// </summary>
        x5_4,
        /// <summary>
        /// 
        /// </summary>
        x9_16,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageSmartCropParametersRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageSmartCropParametersRatio value)
        {
            return value switch
            {
                ImageSmartCropParametersRatio.x16_9 => "16:9",
                ImageSmartCropParametersRatio.x1_1 => "1:1",
                ImageSmartCropParametersRatio.x21_9 => "21:9",
                ImageSmartCropParametersRatio.x2_3 => "2:3",
                ImageSmartCropParametersRatio.x3_2 => "3:2",
                ImageSmartCropParametersRatio.x4_3 => "4:3",
                ImageSmartCropParametersRatio.x4_5 => "4:5",
                ImageSmartCropParametersRatio.x5_4 => "5:4",
                ImageSmartCropParametersRatio.x9_16 => "9:16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageSmartCropParametersRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => ImageSmartCropParametersRatio.x16_9,
                "1:1" => ImageSmartCropParametersRatio.x1_1,
                "21:9" => ImageSmartCropParametersRatio.x21_9,
                "2:3" => ImageSmartCropParametersRatio.x2_3,
                "3:2" => ImageSmartCropParametersRatio.x3_2,
                "4:3" => ImageSmartCropParametersRatio.x4_3,
                "4:5" => ImageSmartCropParametersRatio.x4_5,
                "5:4" => ImageSmartCropParametersRatio.x5_4,
                "9:16" => ImageSmartCropParametersRatio.x9_16,
                _ => null,
            };
        }
    }
}