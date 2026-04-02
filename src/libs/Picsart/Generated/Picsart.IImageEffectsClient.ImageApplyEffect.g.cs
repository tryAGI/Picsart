#nullable enable

namespace Picsart
{
    public partial interface IImageEffectsClient
    {
        /// <summary>
        /// Effects<br/>
        /// With the *effects* service you can apply up to 24 different effects to an image.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageApplyEffectResponse> ImageApplyEffectAsync(

            global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageEffectsParameters> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Effects<br/>
        /// With the *effects* service you can apply up to 24 different effects to an image.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.AutoSDKHttpResponse<global::Picsart.ImageApplyEffectResponse>> ImageApplyEffectAsResponseAsync(

            global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageEffectsParameters> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Effects<br/>
        /// With the *effects* service you can apply up to 24 different effects to an image.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageApplyEffectResponse> ImageApplyEffectAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}