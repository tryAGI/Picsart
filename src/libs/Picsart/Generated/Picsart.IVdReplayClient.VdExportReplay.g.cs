#nullable enable

namespace Picsart
{
    public partial interface IVdReplayClient
    {
        /// <summary>
        /// Export Replay<br/>
        /// Export your Replays with async API in background to optimize for performance and improve your user experience. Now you can export Print-Ready PDF only, but later more formats will be added to the support list. Feel free to reach out to our support team if you need updates to this API.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.VdExportReplayResponse> VdExportReplayAsync(

            global::Picsart.AllOf<global::Picsart.VDFileParameters, global::Picsart.VDExportReplayParameters> request,
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Export Replay<br/>
        /// Export your Replays with async API in background to optimize for performance and improve your user experience. Now you can export Print-Ready PDF only, but later more formats will be added to the support list. Feel free to reach out to our support team if you need updates to this API.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.AutoSDKHttpResponse<global::Picsart.VdExportReplayResponse>> VdExportReplayAsResponseAsync(

            global::Picsart.AllOf<global::Picsart.VDFileParameters, global::Picsart.VDExportReplayParameters> request,
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Export Replay<br/>
        /// Export your Replays with async API in background to optimize for performance and improve your user experience. Now you can export Print-Ready PDF only, but later more formats will be added to the support list. Feel free to reach out to our support team if you need updates to this API.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.VdExportReplayResponse> VdExportReplayAsync(
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}