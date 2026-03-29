#nullable enable

namespace Picsart
{
    public partial interface IImageEffectsClient
    {
        /// <summary>
        /// Masks<br/>
        /// The *masks* service applies a mask to an image.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageApplyMaskResponse> ImageApplyMaskAsync(

            global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageMasksParameters> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Masks<br/>
        /// The *masks* service applies a mask to an image.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageApplyMaskResponse> ImageApplyMaskAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}