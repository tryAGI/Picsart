#nullable enable

namespace Picsart
{
    public partial interface IImageSurfacemapClient
    {
        /// <summary>
        /// Surfacemap Image<br/>
        /// With the *surface map* tool you can "print" a sticker over an (target) image. Using a mask, the Surfacemap tool maps the sticker pixels using the texture and curves on the target image thus ultimately giving a live-print-preview effect.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageSurfacemapResponse> ImageSurfacemapAsync(

            global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageSurfacemapParameters> request,
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Surfacemap Image<br/>
        /// With the *surface map* tool you can "print" a sticker over an (target) image. Using a mask, the Surfacemap tool maps the sticker pixels using the texture and curves on the target image thus ultimately giving a live-print-preview effect.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.AutoSDKHttpResponse<global::Picsart.ImageSurfacemapResponse>> ImageSurfacemapAsResponseAsync(

            global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageSurfacemapParameters> request,
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Surfacemap Image<br/>
        /// With the *surface map* tool you can "print" a sticker over an (target) image. Using a mask, the Surfacemap tool maps the sticker pixels using the texture and curves on the target image thus ultimately giving a live-print-preview effect.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageSurfacemapResponse> ImageSurfacemapAsync(
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}