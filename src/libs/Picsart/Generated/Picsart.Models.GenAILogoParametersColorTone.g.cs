
#nullable enable

namespace Picsart
{
    /// <summary>
    /// Optionally select one of the color tones for the generated logos (Auto is default). Options are as follows:<br/>
    ///   * Auto<br/>
    ///   * Gray<br/>
    ///   * Blue<br/>
    ///   * Pink<br/>
    ///   * Orange<br/>
    ///   * Brown<br/>
    ///   * Yellow<br/>
    ///   * Green<br/>
    ///   * Purple<br/>
    ///   * Red<br/>
    /// Default Value: Auto
    /// </summary>
    public enum GenAILogoParametersColorTone
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Blue,
        /// <summary>
        /// 
        /// </summary>
        Brown,
        /// <summary>
        /// 
        /// </summary>
        Gray,
        /// <summary>
        /// 
        /// </summary>
        Green,
        /// <summary>
        /// 
        /// </summary>
        Orange,
        /// <summary>
        /// 
        /// </summary>
        Pink,
        /// <summary>
        /// 
        /// </summary>
        Purple,
        /// <summary>
        /// 
        /// </summary>
        Red,
        /// <summary>
        /// 
        /// </summary>
        Yellow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenAILogoParametersColorToneExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenAILogoParametersColorTone value)
        {
            return value switch
            {
                GenAILogoParametersColorTone.Auto => "Auto",
                GenAILogoParametersColorTone.Blue => "Blue",
                GenAILogoParametersColorTone.Brown => "Brown",
                GenAILogoParametersColorTone.Gray => "Gray",
                GenAILogoParametersColorTone.Green => "Green",
                GenAILogoParametersColorTone.Orange => "Orange",
                GenAILogoParametersColorTone.Pink => "Pink",
                GenAILogoParametersColorTone.Purple => "Purple",
                GenAILogoParametersColorTone.Red => "Red",
                GenAILogoParametersColorTone.Yellow => "Yellow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenAILogoParametersColorTone? ToEnum(string value)
        {
            return value switch
            {
                "Auto" => GenAILogoParametersColorTone.Auto,
                "Blue" => GenAILogoParametersColorTone.Blue,
                "Brown" => GenAILogoParametersColorTone.Brown,
                "Gray" => GenAILogoParametersColorTone.Gray,
                "Green" => GenAILogoParametersColorTone.Green,
                "Orange" => GenAILogoParametersColorTone.Orange,
                "Pink" => GenAILogoParametersColorTone.Pink,
                "Purple" => GenAILogoParametersColorTone.Purple,
                "Red" => GenAILogoParametersColorTone.Red,
                "Yellow" => GenAILogoParametersColorTone.Yellow,
                _ => null,
            };
        }
    }
}