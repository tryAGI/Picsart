#nullable enable

namespace Picsart
{
    public partial interface IGenAIText2AudioClient
    {
        /// <summary>
        /// Get the Audio Generation result<br/>
        /// Use this method, along with inference id, to retrieve the generated speech or sound/music.
        /// </summary>
        /// <param name="inferenceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.GenaiText2audioGetresultResponse> GenaiText2audioGetresultAsync(
            string inferenceId,
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the Audio Generation result<br/>
        /// Use this method, along with inference id, to retrieve the generated speech or sound/music.
        /// </summary>
        /// <param name="inferenceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.AutoSDKHttpResponse<global::Picsart.GenaiText2audioGetresultResponse>> GenaiText2audioGetresultAsResponseAsync(
            string inferenceId,
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}