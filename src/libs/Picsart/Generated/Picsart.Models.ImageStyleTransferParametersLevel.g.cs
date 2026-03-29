
#nullable enable

namespace Picsart
{
    /// <summary>
    /// Select a level from the dropdown menu. Smaller numbers preserve more from the original image, bigger numbers make the original image look closer to the reference image. The level options are as follows.<br/>
    ///   * l1<br/>
    ///   * l2<br/>
    ///   * l3<br/>
    ///   * l4<br/>
    ///   * l5<br/>
    /// Default Value: l1
    /// </summary>
    public enum ImageStyleTransferParametersLevel
    {
        /// <summary>
        /// 
        /// </summary>
        L1,
        /// <summary>
        /// 
        /// </summary>
        L2,
        /// <summary>
        /// 
        /// </summary>
        L3,
        /// <summary>
        /// 
        /// </summary>
        L4,
        /// <summary>
        /// 
        /// </summary>
        L5,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageStyleTransferParametersLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageStyleTransferParametersLevel value)
        {
            return value switch
            {
                ImageStyleTransferParametersLevel.L1 => "l1",
                ImageStyleTransferParametersLevel.L2 => "l2",
                ImageStyleTransferParametersLevel.L3 => "l3",
                ImageStyleTransferParametersLevel.L4 => "l4",
                ImageStyleTransferParametersLevel.L5 => "l5",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageStyleTransferParametersLevel? ToEnum(string value)
        {
            return value switch
            {
                "l1" => ImageStyleTransferParametersLevel.L1,
                "l2" => ImageStyleTransferParametersLevel.L2,
                "l3" => ImageStyleTransferParametersLevel.L3,
                "l4" => ImageStyleTransferParametersLevel.L4,
                "l5" => ImageStyleTransferParametersLevel.L5,
                _ => null,
            };
        }
    }
}