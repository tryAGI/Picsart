#nullable enable

namespace Picsart
{
    public partial interface IVdVariableDataContentClient
    {
        /// <summary>
        /// Get the Export Variable Data Content result<br/>
        /// Use this method, along with transaction_id, to retrieve the export variable data content's finished results (e.g. list of PDF file URLs).
        /// </summary>
        /// <param name="transactionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.VdExportVariableDataContentGetresultResponse> VdExportVariableDataContentGetresultAsync(
            string transactionId,
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the Export Variable Data Content result<br/>
        /// Use this method, along with transaction_id, to retrieve the export variable data content's finished results (e.g. list of PDF file URLs).
        /// </summary>
        /// <param name="transactionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.AutoSDKHttpResponse<global::Picsart.VdExportVariableDataContentGetresultResponse>> VdExportVariableDataContentGetresultAsResponseAsync(
            string transactionId,
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}