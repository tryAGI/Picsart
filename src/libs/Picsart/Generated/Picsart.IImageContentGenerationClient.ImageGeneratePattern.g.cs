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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageGeneratePatternResponse> ImageGeneratePatternAsync(

            global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageTextureParameters> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Pattern Generator<br/>
        /// The *pattern generator* tool generates a background texture pattern for the input image. You can create unlimited patterns from the same source image.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageGeneratePatternResponse> ImageGeneratePatternAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}