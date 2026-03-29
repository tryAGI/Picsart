#nullable enable

namespace Picsart
{
    public partial interface IImagePhotoEnhancementClient
    {
        /// <summary>
        /// Upscale<br/>
        /// The *upscale* service increases the resolutions of an image by a given upscale factor, without increasing its file size. Upscale increases the quality and resolution of your photos by leveraging predictive and generative AI to add pixels to your image. It works especially well on images without noise.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageUpscaleResponse> ImageUpscaleAsync(

            global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageUpscaleParameters> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upscale<br/>
        /// The *upscale* service increases the resolutions of an image by a given upscale factor, without increasing its file size. Upscale increases the quality and resolution of your photos by leveraging predictive and generative AI to add pixels to your image. It works especially well on images without noise.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageUpscaleResponse> ImageUpscaleAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}