#nullable enable

namespace Picsart
{
    public partial interface IImageEffectsClient
    {
        /// <summary>
        /// Selective Blur<br/>
        /// Use AI to define the segment that should be blurred, e.g. foreground or background, faces or car plates.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageSelectiveBlurResponse> ImageSelectiveBlurAsync(

            global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageSelectiveBlurParameters> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Selective Blur<br/>
        /// Use AI to define the segment that should be blurred, e.g. foreground or background, faces or car plates.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageSelectiveBlurResponse> ImageSelectiveBlurAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}