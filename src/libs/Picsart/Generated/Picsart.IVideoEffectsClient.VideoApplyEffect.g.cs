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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.VideoApplyEffectResponse> VideoApplyEffectAsync(

            global::Picsart.AllOf<global::Picsart.VideoVideoParameters, global::Picsart.VideoEffectsParameters, global::Picsart.VideoExportParameters> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Video Effects<br/>
        /// Apply up to 24 different effects to a video.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.AutoSDKHttpResponse<global::Picsart.VideoApplyEffectResponse>> VideoApplyEffectAsResponseAsync(

            global::Picsart.AllOf<global::Picsart.VideoVideoParameters, global::Picsart.VideoEffectsParameters, global::Picsart.VideoExportParameters> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Video Effects<br/>
        /// Apply up to 24 different effects to a video.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.VideoApplyEffectResponse> VideoApplyEffectAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}