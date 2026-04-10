#nullable enable

namespace Picsart
{
    public partial interface IVideoUtilitiesClient
    {
        /// <summary>
        /// Get the Video result<br/>
        /// Use the video editing transaction ID to get the result video URL. This method works for effects, adjust, trim, crop, resize, fit, concatenation, highlights services.
        /// </summary>
        /// <param name="transactionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.VideoGetresultResponse> VideoGetresultAsync(
            string transactionId,
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the Video result<br/>
        /// Use the video editing transaction ID to get the result video URL. This method works for effects, adjust, trim, crop, resize, fit, concatenation, highlights services.
        /// </summary>
        /// <param name="transactionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.AutoSDKHttpResponse<global::Picsart.VideoGetresultResponse>> VideoGetresultAsResponseAsync(
            string transactionId,
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}