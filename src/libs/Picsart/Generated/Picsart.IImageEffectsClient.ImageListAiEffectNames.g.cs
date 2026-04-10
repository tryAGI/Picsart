#nullable enable

namespace Picsart
{
    public partial interface IImageEffectsClient
    {
        /// <summary>
        /// AI Effect Names<br/>
        /// This service retrieves the list of supported AI effects.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageListAiEffectNamesResponse> ImageListAiEffectNamesAsync(
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// AI Effect Names<br/>
        /// This service retrieves the list of supported AI effects.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.AutoSDKHttpResponse<global::Picsart.ImageListAiEffectNamesResponse>> ImageListAiEffectNamesAsResponseAsync(
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}