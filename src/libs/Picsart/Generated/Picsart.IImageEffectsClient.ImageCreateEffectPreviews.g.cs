#nullable enable

namespace Picsart
{
    public partial interface IImageEffectsClient
    {
        /// <summary>
        /// Effect Previews<br/>
        /// The *effects previews* service applies an effect to a given input image and returns a preview (i.e., thumbnail) of the effect.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageCreateEffectPreviewsResponse> ImageCreateEffectPreviewsAsync(

            global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageEffectsPreviewsParameters> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Effect Previews<br/>
        /// The *effects previews* service applies an effect to a given input image and returns a preview (i.e., thumbnail) of the effect.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.AutoSDKHttpResponse<global::Picsart.ImageCreateEffectPreviewsResponse>> ImageCreateEffectPreviewsAsResponseAsync(

            global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageEffectsPreviewsParameters> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Effect Previews<br/>
        /// The *effects previews* service applies an effect to a given input image and returns a preview (i.e., thumbnail) of the effect.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageCreateEffectPreviewsResponse> ImageCreateEffectPreviewsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}