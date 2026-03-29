#nullable enable

namespace Picsart
{
    public partial interface IImageEffectsClient
    {
        /// <summary>
        /// AI Effects<br/>
        /// With the *AI Effects* service you can apply up to 40+ different AI effects to an image.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageApplyAiEffectResponse> ImageApplyAiEffectAsync(

            global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageAIEffectsParameters> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// AI Effects<br/>
        /// With the *AI Effects* service you can apply up to 40+ different AI effects to an image.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageApplyAiEffectResponse> ImageApplyAiEffectAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}