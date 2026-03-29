
#nullable enable

namespace Picsart
{
    /// <summary>
    /// Default Value: auto
    /// </summary>
    public enum VideoVideoGetThumbnailParametersSource
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Container,
        /// <summary>
        /// 
        /// </summary>
        Timestamp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoVideoGetThumbnailParametersSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoVideoGetThumbnailParametersSource value)
        {
            return value switch
            {
                VideoVideoGetThumbnailParametersSource.Auto => "auto",
                VideoVideoGetThumbnailParametersSource.Container => "container",
                VideoVideoGetThumbnailParametersSource.Timestamp => "timestamp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoVideoGetThumbnailParametersSource? ToEnum(string value)
        {
            return value switch
            {
                "auto" => VideoVideoGetThumbnailParametersSource.Auto,
                "container" => VideoVideoGetThumbnailParametersSource.Container,
                "timestamp" => VideoVideoGetThumbnailParametersSource.Timestamp,
                _ => null,
            };
        }
    }
}