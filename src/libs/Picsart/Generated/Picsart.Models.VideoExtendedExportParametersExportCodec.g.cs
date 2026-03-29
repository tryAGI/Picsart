
#nullable enable

namespace Picsart
{
    /// <summary>
    /// The video codec. Use "default" to keep the video codec the same.<br/>
    /// Default Value: default
    /// </summary>
    public enum VideoExtendedExportParametersExportCodec
    {
        /// <summary>
        /// 
        /// </summary>
        Hevc,
        /// <summary>
        /// 
        /// </summary>
        Mpeg4,
        /// <summary>
        /// 
        /// </summary>
        Av1,
        /// <summary>
        /// 
        /// </summary>
        Cinepak,
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        Ffv1,
        /// <summary>
        /// 
        /// </summary>
        Gif,
        /// <summary>
        /// 
        /// </summary>
        H264,
        /// <summary>
        /// 
        /// </summary>
        Theora,
        /// <summary>
        /// 
        /// </summary>
        Vc2,
        /// <summary>
        /// 
        /// </summary>
        Vp8,
        /// <summary>
        /// 
        /// </summary>
        Vp9,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoExtendedExportParametersExportCodecExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoExtendedExportParametersExportCodec value)
        {
            return value switch
            {
                VideoExtendedExportParametersExportCodec.Hevc => "HEVC",
                VideoExtendedExportParametersExportCodec.Mpeg4 => "MPEG4",
                VideoExtendedExportParametersExportCodec.Av1 => "av1",
                VideoExtendedExportParametersExportCodec.Cinepak => "cinepak",
                VideoExtendedExportParametersExportCodec.Default => "default",
                VideoExtendedExportParametersExportCodec.Ffv1 => "ffv1",
                VideoExtendedExportParametersExportCodec.Gif => "gif",
                VideoExtendedExportParametersExportCodec.H264 => "h264",
                VideoExtendedExportParametersExportCodec.Theora => "theora",
                VideoExtendedExportParametersExportCodec.Vc2 => "vc2",
                VideoExtendedExportParametersExportCodec.Vp8 => "vp8",
                VideoExtendedExportParametersExportCodec.Vp9 => "vp9",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoExtendedExportParametersExportCodec? ToEnum(string value)
        {
            return value switch
            {
                "HEVC" => VideoExtendedExportParametersExportCodec.Hevc,
                "MPEG4" => VideoExtendedExportParametersExportCodec.Mpeg4,
                "av1" => VideoExtendedExportParametersExportCodec.Av1,
                "cinepak" => VideoExtendedExportParametersExportCodec.Cinepak,
                "default" => VideoExtendedExportParametersExportCodec.Default,
                "ffv1" => VideoExtendedExportParametersExportCodec.Ffv1,
                "gif" => VideoExtendedExportParametersExportCodec.Gif,
                "h264" => VideoExtendedExportParametersExportCodec.H264,
                "theora" => VideoExtendedExportParametersExportCodec.Theora,
                "vc2" => VideoExtendedExportParametersExportCodec.Vc2,
                "vp8" => VideoExtendedExportParametersExportCodec.Vp8,
                "vp9" => VideoExtendedExportParametersExportCodec.Vp9,
                _ => null,
            };
        }
    }
}