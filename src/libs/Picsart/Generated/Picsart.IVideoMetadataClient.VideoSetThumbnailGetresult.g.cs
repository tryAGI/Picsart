#nullable enable

namespace Picsart
{
    public partial interface IVideoMetadataClient
    {
        /// <summary>
        /// Get the Video with updated Thumbnail<br/>
        /// Use this method, along with transaction_id, to retrieve the updated video with the new thumbnail.
        /// </summary>
        /// <param name="transactionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.VideoSetThumbnailGetresultResponse> VideoSetThumbnailGetresultAsync(
            string transactionId,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the Video with updated Thumbnail<br/>
        /// Use this method, along with transaction_id, to retrieve the updated video with the new thumbnail.
        /// </summary>
        /// <param name="transactionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.AutoSDKHttpResponse<global::Picsart.VideoSetThumbnailGetresultResponse>> VideoSetThumbnailGetresultAsResponseAsync(
            string transactionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}