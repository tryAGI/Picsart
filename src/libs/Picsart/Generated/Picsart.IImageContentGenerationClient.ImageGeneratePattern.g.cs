#nullable enable

namespace Picsart
{
    public partial interface IImageContentGenerationClient
    {
        /// <summary>
        /// Pattern Generator<br/>
        /// The *pattern generator* tool generates a background texture pattern for the input image. You can create unlimited patterns from the same source image.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageGeneratePatternResponse> ImageGeneratePatternAsync(

            global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageTextureParameters> request,
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Pattern Generator<br/>
        /// The *pattern generator* tool generates a background texture pattern for the input image. You can create unlimited patterns from the same source image.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.AutoSDKHttpResponse<global::Picsart.ImageGeneratePatternResponse>> ImageGeneratePatternAsResponseAsync(

            global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageTextureParameters> request,
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Pattern Generator<br/>
        /// The *pattern generator* tool generates a background texture pattern for the input image. You can create unlimited patterns from the same source image.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageGeneratePatternResponse> ImageGeneratePatternAsync(
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}