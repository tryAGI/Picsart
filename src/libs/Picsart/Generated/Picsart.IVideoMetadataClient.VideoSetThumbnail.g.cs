#nullable enable

namespace Picsart
{
    public partial interface IVideoMetadataClient
    {
        /// <summary>
        /// Set Video Thumbnail<br/>
        /// Update/Set the Video Thumbnail.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.VideoSetThumbnailResponse> VideoSetThumbnailAsync(

            global::Picsart.AllOf<global::Picsart.VideoVideoParameters, global::Picsart.VideoImageParameters> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set Video Thumbnail<br/>
        /// Update/Set the Video Thumbnail.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.VideoSetThumbnailResponse> VideoSetThumbnailAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}