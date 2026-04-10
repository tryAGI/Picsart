#nullable enable

namespace Picsart
{
    public partial interface IVideoEffectsClient
    {
        /// <summary>
        /// Video Effects<br/>
        /// Apply up to 24 different effects to a video.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.VideoApplyEffectResponse> VideoApplyEffectAsync(

            global::Picsart.AllOf<global::Picsart.VideoVideoParameters, global::Picsart.VideoEffectsParameters, global::Picsart.VideoExportParameters> request,
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Video Effects<br/>
        /// Apply up to 24 different effects to a video.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.AutoSDKHttpResponse<global::Picsart.VideoApplyEffectResponse>> VideoApplyEffectAsResponseAsync(

            global::Picsart.AllOf<global::Picsart.VideoVideoParameters, global::Picsart.VideoEffectsParameters, global::Picsart.VideoExportParameters> request,
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Video Effects<br/>
        /// Apply up to 24 different effects to a video.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.VideoApplyEffectResponse> VideoApplyEffectAsync(
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}