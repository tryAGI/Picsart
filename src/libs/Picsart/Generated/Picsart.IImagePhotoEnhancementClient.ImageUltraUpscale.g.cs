#nullable enable

namespace Picsart
{
    public partial interface IImagePhotoEnhancementClient
    {
        /// <summary>
        /// Ultra Upscale<br/>
        /// *Upscale Ultra* is a new upscaling technique which does upscaling with noise suppression. It works well on images with faces, small resolution images, stickers and objects with geometric shapes and clear edges. Upscale ultra increases the quality and resolution of low quality photos by leveraging predictive and generative AI technology in order to "complete" missing pixels for a best in class smoothing and enhancement effect. It works especially good on small resolution images with faces.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageUltraUpscaleResponse> ImageUltraUpscaleAsync(

            global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageUpscaleUltraParameters> request,
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Ultra Upscale<br/>
        /// *Upscale Ultra* is a new upscaling technique which does upscaling with noise suppression. It works well on images with faces, small resolution images, stickers and objects with geometric shapes and clear edges. Upscale ultra increases the quality and resolution of low quality photos by leveraging predictive and generative AI technology in order to "complete" missing pixels for a best in class smoothing and enhancement effect. It works especially good on small resolution images with faces.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.AutoSDKHttpResponse<global::Picsart.ImageUltraUpscaleResponse>> ImageUltraUpscaleAsResponseAsync(

            global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageUpscaleUltraParameters> request,
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Ultra Upscale<br/>
        /// *Upscale Ultra* is a new upscaling technique which does upscaling with noise suppression. It works well on images with faces, small resolution images, stickers and objects with geometric shapes and clear edges. Upscale ultra increases the quality and resolution of low quality photos by leveraging predictive and generative AI technology in order to "complete" missing pixels for a best in class smoothing and enhancement effect. It works especially good on small resolution images with faces.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageUltraUpscaleResponse> ImageUltraUpscaleAsync(
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}