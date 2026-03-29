
#nullable enable

namespace Picsart
{
    /// <summary>
    /// Optionally select one of the languages in the 2-character format (ISO 639-1). Options are as follows:<br/>
    ///   * Afrikaans - af<br/>
    ///   * Arabic - ar<br/>
    ///   * Armenian - am<br/>
    ///   * Azerbaijani - az<br/>
    ///   * Belarusian - be<br/>
    ///   * Bosnian - bs<br/>
    ///   * Bulgarian - bg<br/>
    ///   * Catalan - ca<br/>
    ///   * Chinese - zh<br/>
    ///   * Croatian - hr<br/>
    ///   * Czech - cs<br/>
    ///   * Danish - da<br/>
    ///   * Dutch - nl<br/>
    ///   * English - en<br/>
    ///   * Estonian - et<br/>
    ///   * Finnish - fi<br/>
    ///   * French - fr<br/>
    ///   * Galician - gl<br/>
    ///   * German - de<br/>
    ///   * Greek - el<br/>
    ///   * Hebrew - he<br/>
    ///   * Hindi - hi<br/>
    ///   * Hungarian - hu<br/>
    ///   * Icelandic - is<br/>
    ///   * Indonesian - id<br/>
    ///   * Italian - it<br/>
    ///   * Japanese - ja<br/>
    ///   * Kannada - kn<br/>
    ///   * Kazakh - kk<br/>
    ///   * Korean - ko<br/>
    ///   * Latvian - lv<br/>
    ///   * Lithuanian - lt <br/>
    ///   * Macedonian - mk<br/>
    ///   * Malay - ms<br/>
    ///   * Marathi - mr<br/>
    ///   * Maori - mi<br/>
    ///   * Nepali - ne<br/>
    ///   * Norwegian - no<br/>
    ///   * Persian - fa<br/>
    ///   * Polish - pl<br/>
    ///   * Portuguese - pt<br/>
    ///   * Romanian - ro<br/>
    ///   * Russian - ru<br/>
    ///   * Serbian - sr<br/>
    ///   * Slovak - sk<br/>
    ///   * Slovenian - sl<br/>
    ///   * Spanish - es<br/>
    ///   * Swahili - sw<br/>
    ///   * Swedish - sv<br/>
    ///   * Tagalog - tl<br/>
    ///   * Tamil - ta<br/>
    ///   * Thai - th<br/>
    ///   * Turkish - tr<br/>
    ///   * Ukrainian - uk<br/>
    ///   * Urdu - ur<br/>
    ///   * Vietnamese - vi<br/>
    ///   * Welsh - cy<br/>
    /// Default Value: en
    /// </summary>
    public enum VideoTranscribeParametersLanguage
    {
        /// <summary>
        /// 
        /// </summary>
        Af,
        /// <summary>
        /// 
        /// </summary>
        Am,
        /// <summary>
        /// 
        /// </summary>
        Ar,
        /// <summary>
        /// 
        /// </summary>
        Az,
        /// <summary>
        /// 
        /// </summary>
        Be,
        /// <summary>
        /// 
        /// </summary>
        Bg,
        /// <summary>
        /// 
        /// </summary>
        Bs,
        /// <summary>
        /// 
        /// </summary>
        Ca,
        /// <summary>
        /// 
        /// </summary>
        Cs,
        /// <summary>
        /// 
        /// </summary>
        Cy,
        /// <summary>
        /// 
        /// </summary>
        Da,
        /// <summary>
        /// 
        /// </summary>
        De,
        /// <summary>
        /// 
        /// </summary>
        El,
        /// <summary>
        /// 
        /// </summary>
        En,
        /// <summary>
        /// 
        /// </summary>
        Es,
        /// <summary>
        /// 
        /// </summary>
        Et,
        /// <summary>
        /// 
        /// </summary>
        Fa,
        /// <summary>
        /// 
        /// </summary>
        False,
        /// <summary>
        /// 
        /// </summary>
        Fi,
        /// <summary>
        /// 
        /// </summary>
        Fr,
        /// <summary>
        /// 
        /// </summary>
        Gl,
        /// <summary>
        /// 
        /// </summary>
        He,
        /// <summary>
        /// 
        /// </summary>
        Hi,
        /// <summary>
        /// 
        /// </summary>
        Hr,
        /// <summary>
        /// 
        /// </summary>
        Hu,
        /// <summary>
        /// 
        /// </summary>
        Id,
        /// <summary>
        /// 
        /// </summary>
        Is,
        /// <summary>
        /// 
        /// </summary>
        It,
        /// <summary>
        /// 
        /// </summary>
        Ja,
        /// <summary>
        /// 
        /// </summary>
        Kk,
        /// <summary>
        /// 
        /// </summary>
        Kn,
        /// <summary>
        /// 
        /// </summary>
        Ko,
        /// <summary>
        /// 
        /// </summary>
        Lt,
        /// <summary>
        /// 
        /// </summary>
        Lv,
        /// <summary>
        /// 
        /// </summary>
        Mi,
        /// <summary>
        /// 
        /// </summary>
        Mk,
        /// <summary>
        /// 
        /// </summary>
        Mr,
        /// <summary>
        /// 
        /// </summary>
        Ms,
        /// <summary>
        /// 
        /// </summary>
        Ne,
        /// <summary>
        /// 
        /// </summary>
        Nl,
        /// <summary>
        /// 
        /// </summary>
        Pl,
        /// <summary>
        /// 
        /// </summary>
        Pt,
        /// <summary>
        /// 
        /// </summary>
        Ro,
        /// <summary>
        /// 
        /// </summary>
        Ru,
        /// <summary>
        /// 
        /// </summary>
        Sk,
        /// <summary>
        /// 
        /// </summary>
        Sl,
        /// <summary>
        /// 
        /// </summary>
        Sr,
        /// <summary>
        /// 
        /// </summary>
        Sv,
        /// <summary>
        /// 
        /// </summary>
        Sw,
        /// <summary>
        /// 
        /// </summary>
        Ta,
        /// <summary>
        /// 
        /// </summary>
        Th,
        /// <summary>
        /// 
        /// </summary>
        Tl,
        /// <summary>
        /// 
        /// </summary>
        Tr,
        /// <summary>
        /// 
        /// </summary>
        Uk,
        /// <summary>
        /// 
        /// </summary>
        Ur,
        /// <summary>
        /// 
        /// </summary>
        Vi,
        /// <summary>
        /// 
        /// </summary>
        Zh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoTranscribeParametersLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoTranscribeParametersLanguage value)
        {
            return value switch
            {
                VideoTranscribeParametersLanguage.Af => "af",
                VideoTranscribeParametersLanguage.Am => "am",
                VideoTranscribeParametersLanguage.Ar => "ar",
                VideoTranscribeParametersLanguage.Az => "az",
                VideoTranscribeParametersLanguage.Be => "be",
                VideoTranscribeParametersLanguage.Bg => "bg",
                VideoTranscribeParametersLanguage.Bs => "bs",
                VideoTranscribeParametersLanguage.Ca => "ca",
                VideoTranscribeParametersLanguage.Cs => "cs",
                VideoTranscribeParametersLanguage.Cy => "cy",
                VideoTranscribeParametersLanguage.Da => "da",
                VideoTranscribeParametersLanguage.De => "de",
                VideoTranscribeParametersLanguage.El => "el",
                VideoTranscribeParametersLanguage.En => "en",
                VideoTranscribeParametersLanguage.Es => "es",
                VideoTranscribeParametersLanguage.Et => "et",
                VideoTranscribeParametersLanguage.Fa => "fa",
                VideoTranscribeParametersLanguage.False => "false",
                VideoTranscribeParametersLanguage.Fi => "fi",
                VideoTranscribeParametersLanguage.Fr => "fr",
                VideoTranscribeParametersLanguage.Gl => "gl",
                VideoTranscribeParametersLanguage.He => "he",
                VideoTranscribeParametersLanguage.Hi => "hi",
                VideoTranscribeParametersLanguage.Hr => "hr",
                VideoTranscribeParametersLanguage.Hu => "hu",
                VideoTranscribeParametersLanguage.Id => "id",
                VideoTranscribeParametersLanguage.Is => "is",
                VideoTranscribeParametersLanguage.It => "it",
                VideoTranscribeParametersLanguage.Ja => "ja",
                VideoTranscribeParametersLanguage.Kk => "kk",
                VideoTranscribeParametersLanguage.Kn => "kn",
                VideoTranscribeParametersLanguage.Ko => "ko",
                VideoTranscribeParametersLanguage.Lt => "lt",
                VideoTranscribeParametersLanguage.Lv => "lv",
                VideoTranscribeParametersLanguage.Mi => "mi",
                VideoTranscribeParametersLanguage.Mk => "mk",
                VideoTranscribeParametersLanguage.Mr => "mr",
                VideoTranscribeParametersLanguage.Ms => "ms",
                VideoTranscribeParametersLanguage.Ne => "ne",
                VideoTranscribeParametersLanguage.Nl => "nl",
                VideoTranscribeParametersLanguage.Pl => "pl",
                VideoTranscribeParametersLanguage.Pt => "pt",
                VideoTranscribeParametersLanguage.Ro => "ro",
                VideoTranscribeParametersLanguage.Ru => "ru",
                VideoTranscribeParametersLanguage.Sk => "sk",
                VideoTranscribeParametersLanguage.Sl => "sl",
                VideoTranscribeParametersLanguage.Sr => "sr",
                VideoTranscribeParametersLanguage.Sv => "sv",
                VideoTranscribeParametersLanguage.Sw => "sw",
                VideoTranscribeParametersLanguage.Ta => "ta",
                VideoTranscribeParametersLanguage.Th => "th",
                VideoTranscribeParametersLanguage.Tl => "tl",
                VideoTranscribeParametersLanguage.Tr => "tr",
                VideoTranscribeParametersLanguage.Uk => "uk",
                VideoTranscribeParametersLanguage.Ur => "ur",
                VideoTranscribeParametersLanguage.Vi => "vi",
                VideoTranscribeParametersLanguage.Zh => "zh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoTranscribeParametersLanguage? ToEnum(string value)
        {
            return value switch
            {
                "af" => VideoTranscribeParametersLanguage.Af,
                "am" => VideoTranscribeParametersLanguage.Am,
                "ar" => VideoTranscribeParametersLanguage.Ar,
                "az" => VideoTranscribeParametersLanguage.Az,
                "be" => VideoTranscribeParametersLanguage.Be,
                "bg" => VideoTranscribeParametersLanguage.Bg,
                "bs" => VideoTranscribeParametersLanguage.Bs,
                "ca" => VideoTranscribeParametersLanguage.Ca,
                "cs" => VideoTranscribeParametersLanguage.Cs,
                "cy" => VideoTranscribeParametersLanguage.Cy,
                "da" => VideoTranscribeParametersLanguage.Da,
                "de" => VideoTranscribeParametersLanguage.De,
                "el" => VideoTranscribeParametersLanguage.El,
                "en" => VideoTranscribeParametersLanguage.En,
                "es" => VideoTranscribeParametersLanguage.Es,
                "et" => VideoTranscribeParametersLanguage.Et,
                "fa" => VideoTranscribeParametersLanguage.Fa,
                "false" => VideoTranscribeParametersLanguage.False,
                "fi" => VideoTranscribeParametersLanguage.Fi,
                "fr" => VideoTranscribeParametersLanguage.Fr,
                "gl" => VideoTranscribeParametersLanguage.Gl,
                "he" => VideoTranscribeParametersLanguage.He,
                "hi" => VideoTranscribeParametersLanguage.Hi,
                "hr" => VideoTranscribeParametersLanguage.Hr,
                "hu" => VideoTranscribeParametersLanguage.Hu,
                "id" => VideoTranscribeParametersLanguage.Id,
                "is" => VideoTranscribeParametersLanguage.Is,
                "it" => VideoTranscribeParametersLanguage.It,
                "ja" => VideoTranscribeParametersLanguage.Ja,
                "kk" => VideoTranscribeParametersLanguage.Kk,
                "kn" => VideoTranscribeParametersLanguage.Kn,
                "ko" => VideoTranscribeParametersLanguage.Ko,
                "lt" => VideoTranscribeParametersLanguage.Lt,
                "lv" => VideoTranscribeParametersLanguage.Lv,
                "mi" => VideoTranscribeParametersLanguage.Mi,
                "mk" => VideoTranscribeParametersLanguage.Mk,
                "mr" => VideoTranscribeParametersLanguage.Mr,
                "ms" => VideoTranscribeParametersLanguage.Ms,
                "ne" => VideoTranscribeParametersLanguage.Ne,
                "nl" => VideoTranscribeParametersLanguage.Nl,
                "pl" => VideoTranscribeParametersLanguage.Pl,
                "pt" => VideoTranscribeParametersLanguage.Pt,
                "ro" => VideoTranscribeParametersLanguage.Ro,
                "ru" => VideoTranscribeParametersLanguage.Ru,
                "sk" => VideoTranscribeParametersLanguage.Sk,
                "sl" => VideoTranscribeParametersLanguage.Sl,
                "sr" => VideoTranscribeParametersLanguage.Sr,
                "sv" => VideoTranscribeParametersLanguage.Sv,
                "sw" => VideoTranscribeParametersLanguage.Sw,
                "ta" => VideoTranscribeParametersLanguage.Ta,
                "th" => VideoTranscribeParametersLanguage.Th,
                "tl" => VideoTranscribeParametersLanguage.Tl,
                "tr" => VideoTranscribeParametersLanguage.Tr,
                "uk" => VideoTranscribeParametersLanguage.Uk,
                "ur" => VideoTranscribeParametersLanguage.Ur,
                "vi" => VideoTranscribeParametersLanguage.Vi,
                "zh" => VideoTranscribeParametersLanguage.Zh,
                _ => null,
            };
        }
    }
}