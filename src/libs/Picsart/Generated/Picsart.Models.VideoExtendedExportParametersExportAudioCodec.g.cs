
#nullable enable

namespace Picsart
{
    /// <summary>
    /// The audio codec. Use "default" to keep the video codec the same.<br/>
    /// Default Value: default
    /// </summary>
    public enum VideoExtendedExportParametersExportAudioCodec
    {
        /// <summary>
        /// 
        /// </summary>
        Pcm,
        /// <summary>
        /// 
        /// </summary>
        Aac,
        /// <summary>
        /// 
        /// </summary>
        Ac3,
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        Flac,
        /// <summary>
        /// 
        /// </summary>
        Mp3,
        /// <summary>
        /// 
        /// </summary>
        OggSpeex,
        /// <summary>
        /// 
        /// </summary>
        OggVorbis,
        /// <summary>
        /// 
        /// </summary>
        Opus,
        /// <summary>
        /// 
        /// </summary>
        Wav,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoExtendedExportParametersExportAudioCodecExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoExtendedExportParametersExportAudioCodec value)
        {
            return value switch
            {
                VideoExtendedExportParametersExportAudioCodec.Pcm => "PCM",
                VideoExtendedExportParametersExportAudioCodec.Aac => "aac",
                VideoExtendedExportParametersExportAudioCodec.Ac3 => "ac3",
                VideoExtendedExportParametersExportAudioCodec.Default => "default",
                VideoExtendedExportParametersExportAudioCodec.Flac => "flac",
                VideoExtendedExportParametersExportAudioCodec.Mp3 => "mp3",
                VideoExtendedExportParametersExportAudioCodec.OggSpeex => "ogg_speex",
                VideoExtendedExportParametersExportAudioCodec.OggVorbis => "ogg_vorbis",
                VideoExtendedExportParametersExportAudioCodec.Opus => "opus",
                VideoExtendedExportParametersExportAudioCodec.Wav => "wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoExtendedExportParametersExportAudioCodec? ToEnum(string value)
        {
            return value switch
            {
                "PCM" => VideoExtendedExportParametersExportAudioCodec.Pcm,
                "aac" => VideoExtendedExportParametersExportAudioCodec.Aac,
                "ac3" => VideoExtendedExportParametersExportAudioCodec.Ac3,
                "default" => VideoExtendedExportParametersExportAudioCodec.Default,
                "flac" => VideoExtendedExportParametersExportAudioCodec.Flac,
                "mp3" => VideoExtendedExportParametersExportAudioCodec.Mp3,
                "ogg_speex" => VideoExtendedExportParametersExportAudioCodec.OggSpeex,
                "ogg_vorbis" => VideoExtendedExportParametersExportAudioCodec.OggVorbis,
                "opus" => VideoExtendedExportParametersExportAudioCodec.Opus,
                "wav" => VideoExtendedExportParametersExportAudioCodec.Wav,
                _ => null,
            };
        }
    }
}