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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.VideoUpscaleFpsResponse> VideoUpscaleFpsAsync(

            global::Picsart.VideoVideoParameters request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Video FPS Upscale<br/>
        /// Upscale your low FPS videos to 60FPS high-quality videos using Generative AI technology.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.AutoSDKHttpResponse<global::Picsart.VideoUpscaleFpsResponse>> VideoUpscaleFpsAsResponseAsync(

            global::Picsart.VideoVideoParameters request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Video FPS Upscale<br/>
        /// Upscale your low FPS videos to 60FPS high-quality videos using Generative AI technology.
        /// </summary>
        /// <param name="videoUrl">
        /// Source video URL.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.VideoUpscaleFpsResponse> VideoUpscaleFpsAsync(
            string? videoUrl = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}