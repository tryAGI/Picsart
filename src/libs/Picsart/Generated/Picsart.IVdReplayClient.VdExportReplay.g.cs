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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.VdExportReplayResponse> VdExportReplayAsync(

            global::Picsart.AllOf<global::Picsart.VDFileParameters, global::Picsart.VDExportReplayParameters> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Export Replay<br/>
        /// Export your Replays with async API in background to optimize for performance and improve your user experience. Now you can export Print-Ready PDF only, but later more formats will be added to the support list. Feel free to reach out to our support team if you need updates to this API.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.VdExportReplayResponse> VdExportReplayAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}