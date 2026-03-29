#nullable enable

namespace Picsart
{
    public partial interface IVideoMetadataClient
    {
        /// <summary>
        /// Get Video Thumbnail<br/>
        /// Extracts (reads) Video Thumbnail.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.VideoGetThumbnailResponse> VideoGetThumbnailAsync(

            global::Picsart.AllOf<global::Picsart.VideoVideoParameters, global::Picsart.VideoVideoGetThumbnailParameters> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Video Thumbnail<br/>
        /// Extracts (reads) Video Thumbnail.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.VideoGetThumbnailResponse> VideoGetThumbnailAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}