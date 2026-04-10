#nullable enable

namespace Picsart
{
    public partial interface IImageEffectsClient
    {
        /// <summary>
        /// Laser Engraving Effect<br/>
        /// Apply a laser engraving effect to your stickers.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageApplyLaserEngravingEffectResponse> ImageApplyLaserEngravingEffectAsync(

            global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageLaserEngravingEffectParameters> request,
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Laser Engraving Effect<br/>
        /// Apply a laser engraving effect to your stickers.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.AutoSDKHttpResponse<global::Picsart.ImageApplyLaserEngravingEffectResponse>> ImageApplyLaserEngravingEffectAsResponseAsync(

            global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageLaserEngravingEffectParameters> request,
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Laser Engraving Effect<br/>
        /// Apply a laser engraving effect to your stickers.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageApplyLaserEngravingEffectResponse> ImageApplyLaserEngravingEffectAsync(
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}