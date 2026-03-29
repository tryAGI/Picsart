
#nullable enable

namespace Picsart
{
    /// <summary>
    /// The type of segmentation to perform. Must be one of the following values:<br/>
    ///   * hair<br/>
    ///   * skin<br/>
    ///   * lips<br/>
    ///   * teeth<br/>
    ///   * eyes<br/>
    ///   * clothes<br/>
    ///   * glasses<br/>
    ///   * background<br/>
    ///   * foreground<br/>
    ///   * sky
    /// </summary>
    public enum ImageMultiMattingSegmentationParametersSegmentationClass
    {
        /// <summary>
        /// 
        /// </summary>
        Background,
        /// <summary>
        /// 
        /// </summary>
        Clothes,
        /// <summary>
        /// 
        /// </summary>
        Eyes,
        /// <summary>
        /// 
        /// </summary>
        Foreground,
        /// <summary>
        /// 
        /// </summary>
        Glasses,
        /// <summary>
        /// 
        /// </summary>
        Hair,
        /// <summary>
        /// 
        /// </summary>
        Lips,
        /// <summary>
        /// 
        /// </summary>
        Skin,
        /// <summary>
        /// 
        /// </summary>
        Sky,
        /// <summary>
        /// 
        /// </summary>
        Teeth,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageMultiMattingSegmentationParametersSegmentationClassExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageMultiMattingSegmentationParametersSegmentationClass value)
        {
            return value switch
            {
                ImageMultiMattingSegmentationParametersSegmentationClass.Background => "background",
                ImageMultiMattingSegmentationParametersSegmentationClass.Clothes => "clothes",
                ImageMultiMattingSegmentationParametersSegmentationClass.Eyes => "eyes",
                ImageMultiMattingSegmentationParametersSegmentationClass.Foreground => "foreground",
                ImageMultiMattingSegmentationParametersSegmentationClass.Glasses => "glasses",
                ImageMultiMattingSegmentationParametersSegmentationClass.Hair => "hair",
                ImageMultiMattingSegmentationParametersSegmentationClass.Lips => "lips",
                ImageMultiMattingSegmentationParametersSegmentationClass.Skin => "skin",
                ImageMultiMattingSegmentationParametersSegmentationClass.Sky => "sky",
                ImageMultiMattingSegmentationParametersSegmentationClass.Teeth => "teeth",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageMultiMattingSegmentationParametersSegmentationClass? ToEnum(string value)
        {
            return value switch
            {
                "background" => ImageMultiMattingSegmentationParametersSegmentationClass.Background,
                "clothes" => ImageMultiMattingSegmentationParametersSegmentationClass.Clothes,
                "eyes" => ImageMultiMattingSegmentationParametersSegmentationClass.Eyes,
                "foreground" => ImageMultiMattingSegmentationParametersSegmentationClass.Foreground,
                "glasses" => ImageMultiMattingSegmentationParametersSegmentationClass.Glasses,
                "hair" => ImageMultiMattingSegmentationParametersSegmentationClass.Hair,
                "lips" => ImageMultiMattingSegmentationParametersSegmentationClass.Lips,
                "skin" => ImageMultiMattingSegmentationParametersSegmentationClass.Skin,
                "sky" => ImageMultiMattingSegmentationParametersSegmentationClass.Sky,
                "teeth" => ImageMultiMattingSegmentationParametersSegmentationClass.Teeth,
                _ => null,
            };
        }
    }
}