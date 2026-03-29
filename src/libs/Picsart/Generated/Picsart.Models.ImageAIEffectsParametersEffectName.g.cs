
#nullable enable

namespace Picsart
{
    /// <summary>
    /// Choose an effect from the dropdown menu. The list of effects are as follows<br/>
    ///   * winterblues<br/>
    ///   * wispy<br/>
    ///   * geode<br/>
    ///   * 744<br/>
    ///   * sketchy<br/>
    ///   * dystopia<br/>
    ///   * libtest2<br/>
    ///   * pastel<br/>
    ///   * moonlight<br/>
    ///   * rainbow<br/>
    ///   * money<br/>
    ///   * popsketch<br/>
    ///   * hintofyellow<br/>
    ///   * badlands<br/>
    ///   * letitsnow<br/>
    ///   * flora<br/>
    ///   * staygold<br/>
    ///   * holidayparty<br/>
    ///   * galaxy<br/>
    ///   * crushedmarble<br/>
    ///   * pow<br/>
    ///   * shades_of_gray<br/>
    ///   * haze<br/>
    ///   * shamrock<br/>
    ///   * 815<br/>
    ///   * flare<br/>
    ///   * prettyinpink<br/>
    ///   * rosegold<br/>
    ///   * wonderland<br/>
    ///   * whiteice<br/>
    ///   * nightcore<br/>
    ///   * pleinair34_120<br/>
    ///   * soul<br/>
    ///   * rosequartz<br/>
    ///   * animation<br/>
    ///   * feast<br/>
    ///   * undead<br/>
    ///   * highlight<br/>
    ///   * neopop<br/>
    ///   * midnight<br/>
    ///   * colorbright<br/>
    ///   * cartoon1<br/>
    ///   * cartoon2
    /// </summary>
    public enum ImageAIEffectsParametersEffectName
    {
        /// <summary>
        /// 
        /// </summary>
        x744,
        /// <summary>
        /// 
        /// </summary>
        x815,
        /// <summary>
        /// 
        /// </summary>
        Animation,
        /// <summary>
        /// 
        /// </summary>
        Badlands,
        /// <summary>
        /// 
        /// </summary>
        Cartoon1,
        /// <summary>
        /// 
        /// </summary>
        Cartoon2,
        /// <summary>
        /// 
        /// </summary>
        Colorbright,
        /// <summary>
        /// 
        /// </summary>
        Crushedmarble,
        /// <summary>
        /// 
        /// </summary>
        Dystopia,
        /// <summary>
        /// 
        /// </summary>
        Feast,
        /// <summary>
        /// 
        /// </summary>
        Flare,
        /// <summary>
        /// 
        /// </summary>
        Flora,
        /// <summary>
        /// 
        /// </summary>
        Galaxy,
        /// <summary>
        /// 
        /// </summary>
        Geode,
        /// <summary>
        /// 
        /// </summary>
        Haze,
        /// <summary>
        /// 
        /// </summary>
        Highlight,
        /// <summary>
        /// 
        /// </summary>
        Hintofyellow,
        /// <summary>
        /// 
        /// </summary>
        Holidayparty,
        /// <summary>
        /// 
        /// </summary>
        Letitsnow,
        /// <summary>
        /// 
        /// </summary>
        Libtest2,
        /// <summary>
        /// 
        /// </summary>
        Midnight,
        /// <summary>
        /// 
        /// </summary>
        Money,
        /// <summary>
        /// 
        /// </summary>
        Moonlight,
        /// <summary>
        /// 
        /// </summary>
        Neopop,
        /// <summary>
        /// 
        /// </summary>
        Nightcore,
        /// <summary>
        /// 
        /// </summary>
        Pastel,
        /// <summary>
        /// 
        /// </summary>
        Pleinair34120,
        /// <summary>
        /// 
        /// </summary>
        Popsketch,
        /// <summary>
        /// 
        /// </summary>
        Pow,
        /// <summary>
        /// 
        /// </summary>
        Prettyinpink,
        /// <summary>
        /// 
        /// </summary>
        Rainbow,
        /// <summary>
        /// 
        /// </summary>
        Rosegold,
        /// <summary>
        /// 
        /// </summary>
        Rosequartz,
        /// <summary>
        /// 
        /// </summary>
        ShadesOfGray,
        /// <summary>
        /// 
        /// </summary>
        Shamrock,
        /// <summary>
        /// 
        /// </summary>
        Sketchy,
        /// <summary>
        /// 
        /// </summary>
        Soul,
        /// <summary>
        /// 
        /// </summary>
        Staygold,
        /// <summary>
        /// 
        /// </summary>
        Undead,
        /// <summary>
        /// 
        /// </summary>
        Whiteice,
        /// <summary>
        /// 
        /// </summary>
        Winterblues,
        /// <summary>
        /// 
        /// </summary>
        Wispy,
        /// <summary>
        /// 
        /// </summary>
        Wonderland,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageAIEffectsParametersEffectNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageAIEffectsParametersEffectName value)
        {
            return value switch
            {
                ImageAIEffectsParametersEffectName.x744 => "744",
                ImageAIEffectsParametersEffectName.x815 => "815",
                ImageAIEffectsParametersEffectName.Animation => "animation",
                ImageAIEffectsParametersEffectName.Badlands => "badlands",
                ImageAIEffectsParametersEffectName.Cartoon1 => "cartoon1",
                ImageAIEffectsParametersEffectName.Cartoon2 => "cartoon2",
                ImageAIEffectsParametersEffectName.Colorbright => "colorbright",
                ImageAIEffectsParametersEffectName.Crushedmarble => "crushedmarble",
                ImageAIEffectsParametersEffectName.Dystopia => "dystopia",
                ImageAIEffectsParametersEffectName.Feast => "feast",
                ImageAIEffectsParametersEffectName.Flare => "flare",
                ImageAIEffectsParametersEffectName.Flora => "flora",
                ImageAIEffectsParametersEffectName.Galaxy => "galaxy",
                ImageAIEffectsParametersEffectName.Geode => "geode",
                ImageAIEffectsParametersEffectName.Haze => "haze",
                ImageAIEffectsParametersEffectName.Highlight => "highlight",
                ImageAIEffectsParametersEffectName.Hintofyellow => "hintofyellow",
                ImageAIEffectsParametersEffectName.Holidayparty => "holidayparty",
                ImageAIEffectsParametersEffectName.Letitsnow => "letitsnow",
                ImageAIEffectsParametersEffectName.Libtest2 => "libtest2",
                ImageAIEffectsParametersEffectName.Midnight => "midnight",
                ImageAIEffectsParametersEffectName.Money => "money",
                ImageAIEffectsParametersEffectName.Moonlight => "moonlight",
                ImageAIEffectsParametersEffectName.Neopop => "neopop",
                ImageAIEffectsParametersEffectName.Nightcore => "nightcore",
                ImageAIEffectsParametersEffectName.Pastel => "pastel",
                ImageAIEffectsParametersEffectName.Pleinair34120 => "pleinair34_120",
                ImageAIEffectsParametersEffectName.Popsketch => "popsketch",
                ImageAIEffectsParametersEffectName.Pow => "pow",
                ImageAIEffectsParametersEffectName.Prettyinpink => "prettyinpink",
                ImageAIEffectsParametersEffectName.Rainbow => "rainbow",
                ImageAIEffectsParametersEffectName.Rosegold => "rosegold",
                ImageAIEffectsParametersEffectName.Rosequartz => "rosequartz",
                ImageAIEffectsParametersEffectName.ShadesOfGray => "shades_of_gray",
                ImageAIEffectsParametersEffectName.Shamrock => "shamrock",
                ImageAIEffectsParametersEffectName.Sketchy => "sketchy",
                ImageAIEffectsParametersEffectName.Soul => "soul",
                ImageAIEffectsParametersEffectName.Staygold => "staygold",
                ImageAIEffectsParametersEffectName.Undead => "undead",
                ImageAIEffectsParametersEffectName.Whiteice => "whiteice",
                ImageAIEffectsParametersEffectName.Winterblues => "winterblues",
                ImageAIEffectsParametersEffectName.Wispy => "wispy",
                ImageAIEffectsParametersEffectName.Wonderland => "wonderland",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageAIEffectsParametersEffectName? ToEnum(string value)
        {
            return value switch
            {
                "744" => ImageAIEffectsParametersEffectName.x744,
                "815" => ImageAIEffectsParametersEffectName.x815,
                "animation" => ImageAIEffectsParametersEffectName.Animation,
                "badlands" => ImageAIEffectsParametersEffectName.Badlands,
                "cartoon1" => ImageAIEffectsParametersEffectName.Cartoon1,
                "cartoon2" => ImageAIEffectsParametersEffectName.Cartoon2,
                "colorbright" => ImageAIEffectsParametersEffectName.Colorbright,
                "crushedmarble" => ImageAIEffectsParametersEffectName.Crushedmarble,
                "dystopia" => ImageAIEffectsParametersEffectName.Dystopia,
                "feast" => ImageAIEffectsParametersEffectName.Feast,
                "flare" => ImageAIEffectsParametersEffectName.Flare,
                "flora" => ImageAIEffectsParametersEffectName.Flora,
                "galaxy" => ImageAIEffectsParametersEffectName.Galaxy,
                "geode" => ImageAIEffectsParametersEffectName.Geode,
                "haze" => ImageAIEffectsParametersEffectName.Haze,
                "highlight" => ImageAIEffectsParametersEffectName.Highlight,
                "hintofyellow" => ImageAIEffectsParametersEffectName.Hintofyellow,
                "holidayparty" => ImageAIEffectsParametersEffectName.Holidayparty,
                "letitsnow" => ImageAIEffectsParametersEffectName.Letitsnow,
                "libtest2" => ImageAIEffectsParametersEffectName.Libtest2,
                "midnight" => ImageAIEffectsParametersEffectName.Midnight,
                "money" => ImageAIEffectsParametersEffectName.Money,
                "moonlight" => ImageAIEffectsParametersEffectName.Moonlight,
                "neopop" => ImageAIEffectsParametersEffectName.Neopop,
                "nightcore" => ImageAIEffectsParametersEffectName.Nightcore,
                "pastel" => ImageAIEffectsParametersEffectName.Pastel,
                "pleinair34_120" => ImageAIEffectsParametersEffectName.Pleinair34120,
                "popsketch" => ImageAIEffectsParametersEffectName.Popsketch,
                "pow" => ImageAIEffectsParametersEffectName.Pow,
                "prettyinpink" => ImageAIEffectsParametersEffectName.Prettyinpink,
                "rainbow" => ImageAIEffectsParametersEffectName.Rainbow,
                "rosegold" => ImageAIEffectsParametersEffectName.Rosegold,
                "rosequartz" => ImageAIEffectsParametersEffectName.Rosequartz,
                "shades_of_gray" => ImageAIEffectsParametersEffectName.ShadesOfGray,
                "shamrock" => ImageAIEffectsParametersEffectName.Shamrock,
                "sketchy" => ImageAIEffectsParametersEffectName.Sketchy,
                "soul" => ImageAIEffectsParametersEffectName.Soul,
                "staygold" => ImageAIEffectsParametersEffectName.Staygold,
                "undead" => ImageAIEffectsParametersEffectName.Undead,
                "whiteice" => ImageAIEffectsParametersEffectName.Whiteice,
                "winterblues" => ImageAIEffectsParametersEffectName.Winterblues,
                "wispy" => ImageAIEffectsParametersEffectName.Wispy,
                "wonderland" => ImageAIEffectsParametersEffectName.Wonderland,
                _ => null,
            };
        }
    }
}