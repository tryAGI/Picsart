#nullable enable

namespace Picsart
{
    public partial interface IVideoVideoEnhancementClient
    {
        /// <summary>
        /// Get the Video FPS Upscale result<br/>
        /// Use this method, along with transaction_id, to retrieve the upscaled video.
        /// </summary>
        /// <param name="transactionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.VideoUpscaleFpsGetresultResponse> VideoUpscaleFpsGetresultAsync(
            string transactionId,
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the Video FPS Upscale result<br/>
        /// Use this method, along with transaction_id, to retrieve the upscaled video.
        /// </summary>
        /// <param name="transactionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.AutoSDKHttpResponse<global::Picsart.VideoUpscaleFpsGetresultResponse>> VideoUpscaleFpsGetresultAsResponseAsync(
            string transactionId,
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}