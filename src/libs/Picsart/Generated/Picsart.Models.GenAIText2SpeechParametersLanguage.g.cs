
#nullable enable

namespace Picsart
{
    /// <summary>
    /// The language to speak.<br/>
    /// Default Value: en
    /// </summary>
    public enum GenAIText2SpeechParametersLanguage
    {
        /// <summary>
        /// 
        /// </summary>
        En,
        /// <summary>
        /// 
        /// </summary>
        Fr,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenAIText2SpeechParametersLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenAIText2SpeechParametersLanguage value)
        {
            return value switch
            {
                GenAIText2SpeechParametersLanguage.En => "en",
                GenAIText2SpeechParametersLanguage.Fr => "fr",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenAIText2SpeechParametersLanguage? ToEnum(string value)
        {
            return value switch
            {
                "en" => GenAIText2SpeechParametersLanguage.En,
                "fr" => GenAIText2SpeechParametersLanguage.Fr,
                _ => null,
            };
        }
    }
}