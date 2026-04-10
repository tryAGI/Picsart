#nullable enable

namespace Picsart
{
    public partial interface IVideoUtilitiesClient
    {
        /// <summary>
        /// Get the Audio result<br/>
        /// Use the video editing transaction ID to get the result audio file URL.
        /// </summary>
        /// <param name="transactionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.VideoGetaudioresultResponse> VideoGetaudioresultAsync(
            string transactionId,
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the Audio result<br/>
        /// Use the video editing transaction ID to get the result audio file URL.
        /// </summary>
        /// <param name="transactionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.AutoSDKHttpResponse<global::Picsart.VideoGetaudioresultResponse>> VideoGetaudioresultAsResponseAsync(
            string transactionId,
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}