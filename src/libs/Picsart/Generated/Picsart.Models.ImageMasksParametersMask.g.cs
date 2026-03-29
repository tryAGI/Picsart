
#nullable enable

namespace Picsart
{
    /// <summary>
    /// Select one of the mask types from the list. The options are as follows:<br/>
    ///   * lace1<br/>
    ///   * lace2<br/>
    ///   * lace3<br/>
    ///   * lace4<br/>
    ///   * shdw2<br/>
    ///   * shdw17<br/>
    ///   * rpl3<br/>
    ///   * rpl5<br/>
    ///   * prsm3<br/>
    ///   * prsm9<br/>
    ///   * prsm10
    /// </summary>
    public enum ImageMasksParametersMask
    {
        /// <summary>
        /// 
        /// </summary>
        Lace1,
        /// <summary>
        /// 
        /// </summary>
        Lace2,
        /// <summary>
        /// 
        /// </summary>
        Lace3,
        /// <summary>
        /// 
        /// </summary>
        Lace4,
        /// <summary>
        /// 
        /// </summary>
        Prsm10,
        /// <summary>
        /// 
        /// </summary>
        Prsm3,
        /// <summary>
        /// 
        /// </summary>
        Prsm9,
        /// <summary>
        /// 
        /// </summary>
        Rpl3,
        /// <summary>
        /// 
        /// </summary>
        Rpl5,
        /// <summary>
        /// 
        /// </summary>
        Shdw17,
        /// <summary>
        /// 
        /// </summary>
        Shdw2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageMasksParametersMaskExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageMasksParametersMask value)
        {
            return value switch
            {
                ImageMasksParametersMask.Lace1 => "lace1",
                ImageMasksParametersMask.Lace2 => "lace2",
                ImageMasksParametersMask.Lace3 => "lace3",
                ImageMasksParametersMask.Lace4 => "lace4",
                ImageMasksParametersMask.Prsm10 => "prsm10",
                ImageMasksParametersMask.Prsm3 => "prsm3",
                ImageMasksParametersMask.Prsm9 => "prsm9",
                ImageMasksParametersMask.Rpl3 => "rpl3",
                ImageMasksParametersMask.Rpl5 => "rpl5",
                ImageMasksParametersMask.Shdw17 => "shdw17",
                ImageMasksParametersMask.Shdw2 => "shdw2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageMasksParametersMask? ToEnum(string value)
        {
            return value switch
            {
                "lace1" => ImageMasksParametersMask.Lace1,
                "lace2" => ImageMasksParametersMask.Lace2,
                "lace3" => ImageMasksParametersMask.Lace3,
                "lace4" => ImageMasksParametersMask.Lace4,
                "prsm10" => ImageMasksParametersMask.Prsm10,
                "prsm3" => ImageMasksParametersMask.Prsm3,
                "prsm9" => ImageMasksParametersMask.Prsm9,
                "rpl3" => ImageMasksParametersMask.Rpl3,
                "rpl5" => ImageMasksParametersMask.Rpl5,
                "shdw17" => ImageMasksParametersMask.Shdw17,
                "shdw2" => ImageMasksParametersMask.Shdw2,
                _ => null,
            };
        }
    }
}