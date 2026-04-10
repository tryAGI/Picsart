#nullable enable

namespace Picsart
{
    public partial interface IGenAIInpaintingImage2ImageClient
    {
        /// <summary>
        /// Get the results of the painting<br/>
        /// Inpaint, Outpaint, Smart Background and Expand services can work asynchronously and expose an inference identifier that can be used later to fetch te results.<br/>
        /// Use this service to check up on the result.
        /// </summary>
        /// <param name="inferenceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.GenaiImageInpaintingGetresultResponse> GenaiImageInpaintingGetresultAsync(
            string inferenceId,
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the results of the painting<br/>
        /// Inpaint, Outpaint, Smart Background and Expand services can work asynchronously and expose an inference identifier that can be used later to fetch te results.<br/>
        /// Use this service to check up on the result.
        /// </summary>
        /// <param name="inferenceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.AutoSDKHttpResponse<global::Picsart.GenaiImageInpaintingGetresultResponse>> GenaiImageInpaintingGetresultAsResponseAsync(
            string inferenceId,
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}