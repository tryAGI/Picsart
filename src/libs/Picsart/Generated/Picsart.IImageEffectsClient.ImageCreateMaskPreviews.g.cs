#nullable enable

namespace Picsart
{
    public partial interface IImageEffectsClient
    {
        /// <summary>
        /// Mask Previews<br/>
        /// The *masks previews* service applies mask effects to a given input image and returns a preview (i.e., thumbnail) of the effect.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageCreateMaskPreviewsResponse> ImageCreateMaskPreviewsAsync(

            global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageMasksPreviewParameters> request,
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Mask Previews<br/>
        /// The *masks previews* service applies mask effects to a given input image and returns a preview (i.e., thumbnail) of the effect.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.AutoSDKHttpResponse<global::Picsart.ImageCreateMaskPreviewsResponse>> ImageCreateMaskPreviewsAsResponseAsync(

            global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageMasksPreviewParameters> request,
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Mask Previews<br/>
        /// The *masks previews* service applies mask effects to a given input image and returns a preview (i.e., thumbnail) of the effect.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageCreateMaskPreviewsResponse> ImageCreateMaskPreviewsAsync(
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}