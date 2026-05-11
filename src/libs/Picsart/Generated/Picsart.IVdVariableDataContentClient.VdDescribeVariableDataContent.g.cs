#nullable enable

namespace Picsart
{
    public partial interface IVdVariableDataContentClient
    {
        /// <summary>
        /// Describe Replay's Variable Data<br/>
        /// Describes the Replay. Lists all variable data fields and their types: image, text, etc.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.VdDescribeVariableDataContentResponse> VdDescribeVariableDataContentAsync(

            global::Picsart.VDTemplateParameters request,
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Describe Replay's Variable Data<br/>
        /// Describes the Replay. Lists all variable data fields and their types: image, text, etc.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.AutoSDKHttpResponse<global::Picsart.VdDescribeVariableDataContentResponse>> VdDescribeVariableDataContentAsResponseAsync(

            global::Picsart.VDTemplateParameters request,
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Describe Replay's Variable Data<br/>
        /// Describes the Replay. Lists all variable data fields and their types: image, text, etc.
        /// </summary>
        /// <param name="templateId">
        /// Source template ID from Picsart Inventory. (If this parameter is present, the other template source parameters must be empty.)
        /// </param>
        /// <param name="template">
        /// Source replay file (binary). (If this parameter is present, the other template source parameters must be empty.)
        /// </param>
        /// <param name="templatename">
        /// Source replay file (binary). (If this parameter is present, the other template source parameters must be empty.)
        /// </param>
        /// <param name="templateUrl">
        /// Source replay URL. (If this parameter is present, the other template source parameters must be empty.)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.VdDescribeVariableDataContentResponse> VdDescribeVariableDataContentAsync(
            string? templateId = default,
            byte[]? template = default,
            string? templatename = default,
            string? templateUrl = default,
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}