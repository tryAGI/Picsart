
#nullable enable

namespace Picsart
{
    /// <summary>
    /// Choose a pattern for the background texture. Default is hex.<br/>
    /// Default Value: hex
    /// </summary>
    public enum ImageTextureParametersPattern
    {
        /// <summary>
        /// 
        /// </summary>
        Diamond,
        /// <summary>
        /// 
        /// </summary>
        Hex,
        /// <summary>
        /// 
        /// </summary>
        Hex2,
        /// <summary>
        /// 
        /// </summary>
        Mirror,
        /// <summary>
        /// 
        /// </summary>
        Tile,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageTextureParametersPatternExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageTextureParametersPattern value)
        {
            return value switch
            {
                ImageTextureParametersPattern.Diamond => "diamond",
                ImageTextureParametersPattern.Hex => "hex",
                ImageTextureParametersPattern.Hex2 => "hex2",
                ImageTextureParametersPattern.Mirror => "mirror",
                ImageTextureParametersPattern.Tile => "tile",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageTextureParametersPattern? ToEnum(string value)
        {
            return value switch
            {
                "diamond" => ImageTextureParametersPattern.Diamond,
                "hex" => ImageTextureParametersPattern.Hex,
                "hex2" => ImageTextureParametersPattern.Hex2,
                "mirror" => ImageTextureParametersPattern.Mirror,
                "tile" => ImageTextureParametersPattern.Tile,
                _ => null,
            };
        }
    }
}