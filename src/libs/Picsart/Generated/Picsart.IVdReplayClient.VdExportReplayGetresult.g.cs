#nullable enable

namespace Picsart
{
    public partial interface IVdReplayClient
    {
        /// <summary>
        /// Get the Export Replay result<br/>
        /// Use this method, along with transaction_id, to retrieve the export replay's finished result (e.g. PDF).
        /// </summary>
        /// <param name="transactionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.VdExportReplayGetresultResponse> VdExportReplayGetresultAsync(
            string transactionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}