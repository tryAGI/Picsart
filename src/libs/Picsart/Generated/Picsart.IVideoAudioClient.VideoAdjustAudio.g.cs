#nullable enable

namespace Picsart
{
    public partial interface IVideoAudioClient
    {
        /// <summary>
        /// Adjust Audio<br/>
        /// Adjusts the input video's audio volume, allows to add a new audio channel and control its volume.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.VideoAdjustAudioResponse> VideoAdjustAudioAsync(

            global::Picsart.AllOf<global::Picsart.VideoVideoParameters, global::Picsart.VideoAdjustAudioParameters, global::Picsart.VideoExportParameters> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Adjust Audio<br/>
        /// Adjusts the input video's audio volume, allows to add a new audio channel and control its volume.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.AutoSDKHttpResponse<global::Picsart.VideoAdjustAudioResponse>> VideoAdjustAudioAsResponseAsync(

            global::Picsart.AllOf<global::Picsart.VideoVideoParameters, global::Picsart.VideoAdjustAudioParameters, global::Picsart.VideoExportParameters> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Adjust Audio<br/>
        /// Adjusts the input video's audio volume, allows to add a new audio channel and control its volume.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.VideoAdjustAudioResponse> VideoAdjustAudioAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}