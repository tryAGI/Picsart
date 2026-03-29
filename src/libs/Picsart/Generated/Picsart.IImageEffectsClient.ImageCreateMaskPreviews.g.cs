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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageCreateMaskPreviewsResponse> ImageCreateMaskPreviewsAsync(

            global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageMasksPreviewParameters> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Mask Previews<br/>
        /// The *masks previews* service applies mask effects to a given input image and returns a preview (i.e., thumbnail) of the effect.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageCreateMaskPreviewsResponse> ImageCreateMaskPreviewsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}