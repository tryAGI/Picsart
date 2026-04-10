#nullable enable

namespace Picsart
{
    public partial interface IVideoVideoEnhancementClient
    {
        /// <summary>
        /// Video FPS Upscale<br/>
        /// Upscale your low FPS videos to 60FPS high-quality videos using Generative AI technology.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.VideoUpscaleFpsResponse> VideoUpscaleFpsAsync(

            global::Picsart.VideoVideoParameters request,
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Video FPS Upscale<br/>
        /// Upscale your low FPS videos to 60FPS high-quality videos using Generative AI technology.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.AutoSDKHttpResponse<global::Picsart.VideoUpscaleFpsResponse>> VideoUpscaleFpsAsResponseAsync(

            global::Picsart.VideoVideoParameters request,
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Video FPS Upscale<br/>
        /// Upscale your low FPS videos to 60FPS high-quality videos using Generative AI technology.
        /// </summary>
        /// <param name="videoUrl">
        /// Source video URL.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.VideoUpscaleFpsResponse> VideoUpscaleFpsAsync(
            string? videoUrl = default,
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}