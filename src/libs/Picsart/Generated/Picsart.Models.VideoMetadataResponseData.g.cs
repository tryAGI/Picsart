
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoMetadataResponseData
    {
        /// <summary>
        /// Number of video streams in the file (including thumbnails)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_streams")]
        public int? VideoStreams { get; set; }

        /// <summary>
        /// Number of audio streams in the file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_streams")]
        public int? AudioStreams { get; set; }

        /// <summary>
        /// Overall bit rate of the file in bits per second
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bit_rate")]
        public int? BitRate { get; set; }

        /// <summary>
        /// File size in bytes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public int? Size { get; set; }

        /// <summary>
        /// Total duration of the file in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// Container format name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format_name")]
        public string? FormatName { get; set; }

        /// <summary>
        /// Video codec name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_codec_name")]
        public string? VideoCodecName { get; set; }

        /// <summary>
        /// Video width in pixels
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_width")]
        public int? VideoWidth { get; set; }

        /// <summary>
        /// Video height in pixels
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_height")]
        public int? VideoHeight { get; set; }

        /// <summary>
        /// Video stream duration in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_duration")]
        public double? VideoDuration { get; set; }

        /// <summary>
        /// Video stream bit rate in bits per second
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_bit_rate")]
        public int? VideoBitRate { get; set; }

        /// <summary>
        /// Video pixel format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_pix_fmt")]
        public string? VideoPixFmt { get; set; }

        /// <summary>
        /// Video frame rate (frames per second)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_fps")]
        public int? VideoFps { get; set; }

        /// <summary>
        /// Audio codec name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_codec_name")]
        public string? AudioCodecName { get; set; }

        /// <summary>
        /// Audio sample rate in Hz
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_sample_rate")]
        public int? AudioSampleRate { get; set; }

        /// <summary>
        /// Number of audio channels
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_channels")]
        public int? AudioChannels { get; set; }

        /// <summary>
        /// Audio channel layout
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_channel_layout")]
        public string? AudioChannelLayout { get; set; }

        /// <summary>
        /// Audio stream duration in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_duration")]
        public double? AudioDuration { get; set; }

        /// <summary>
        /// Audio stream bit rate in bits per second
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_bit_rate")]
        public int? AudioBitRate { get; set; }

        /// <summary>
        /// Thumbnail codec name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thumbnail_codec_name")]
        public string? ThumbnailCodecName { get; set; }

        /// <summary>
        /// Thumbnail width in pixels
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thumbnail_width")]
        public int? ThumbnailWidth { get; set; }

        /// <summary>
        /// Thumbnail height in pixels
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thumbnail_height")]
        public int? ThumbnailHeight { get; set; }

        /// <summary>
        /// Thumbnail pixel format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thumbnail_pix_fmt")]
        public string? ThumbnailPixFmt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoMetadataResponseData" /> class.
        /// </summary>
        /// <param name="videoStreams">
        /// Number of video streams in the file (including thumbnails)
        /// </param>
        /// <param name="audioStreams">
        /// Number of audio streams in the file
        /// </param>
        /// <param name="bitRate">
        /// Overall bit rate of the file in bits per second
        /// </param>
        /// <param name="size">
        /// File size in bytes
        /// </param>
        /// <param name="duration">
        /// Total duration of the file in seconds
        /// </param>
        /// <param name="formatName">
        /// Container format name
        /// </param>
        /// <param name="videoCodecName">
        /// Video codec name
        /// </param>
        /// <param name="videoWidth">
        /// Video width in pixels
        /// </param>
        /// <param name="videoHeight">
        /// Video height in pixels
        /// </param>
        /// <param name="videoDuration">
        /// Video stream duration in seconds
        /// </param>
        /// <param name="videoBitRate">
        /// Video stream bit rate in bits per second
        /// </param>
        /// <param name="videoPixFmt">
        /// Video pixel format
        /// </param>
        /// <param name="videoFps">
        /// Video frame rate (frames per second)
        /// </param>
        /// <param name="audioCodecName">
        /// Audio codec name
        /// </param>
        /// <param name="audioSampleRate">
        /// Audio sample rate in Hz
        /// </param>
        /// <param name="audioChannels">
        /// Number of audio channels
        /// </param>
        /// <param name="audioChannelLayout">
        /// Audio channel layout
        /// </param>
        /// <param name="audioDuration">
        /// Audio stream duration in seconds
        /// </param>
        /// <param name="audioBitRate">
        /// Audio stream bit rate in bits per second
        /// </param>
        /// <param name="thumbnailCodecName">
        /// Thumbnail codec name
        /// </param>
        /// <param name="thumbnailWidth">
        /// Thumbnail width in pixels
        /// </param>
        /// <param name="thumbnailHeight">
        /// Thumbnail height in pixels
        /// </param>
        /// <param name="thumbnailPixFmt">
        /// Thumbnail pixel format
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoMetadataResponseData(
            int? videoStreams,
            int? audioStreams,
            int? bitRate,
            int? size,
            double? duration,
            string? formatName,
            string? videoCodecName,
            int? videoWidth,
            int? videoHeight,
            double? videoDuration,
            int? videoBitRate,
            string? videoPixFmt,
            int? videoFps,
            string? audioCodecName,
            int? audioSampleRate,
            int? audioChannels,
            string? audioChannelLayout,
            double? audioDuration,
            int? audioBitRate,
            string? thumbnailCodecName,
            int? thumbnailWidth,
            int? thumbnailHeight,
            string? thumbnailPixFmt)
        {
            this.VideoStreams = videoStreams;
            this.AudioStreams = audioStreams;
            this.BitRate = bitRate;
            this.Size = size;
            this.Duration = duration;
            this.FormatName = formatName;
            this.VideoCodecName = videoCodecName;
            this.VideoWidth = videoWidth;
            this.VideoHeight = videoHeight;
            this.VideoDuration = videoDuration;
            this.VideoBitRate = videoBitRate;
            this.VideoPixFmt = videoPixFmt;
            this.VideoFps = videoFps;
            this.AudioCodecName = audioCodecName;
            this.AudioSampleRate = audioSampleRate;
            this.AudioChannels = audioChannels;
            this.AudioChannelLayout = audioChannelLayout;
            this.AudioDuration = audioDuration;
            this.AudioBitRate = audioBitRate;
            this.ThumbnailCodecName = thumbnailCodecName;
            this.ThumbnailWidth = thumbnailWidth;
            this.ThumbnailHeight = thumbnailHeight;
            this.ThumbnailPixFmt = thumbnailPixFmt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoMetadataResponseData" /> class.
        /// </summary>
        public VideoMetadataResponseData()
        {
        }
    }
}