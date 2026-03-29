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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.VdDescribeVariableDataContentResponse> VdDescribeVariableDataContentAsync(

            global::Picsart.VDTemplateParameters request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Describe Replay's Variable Data<br/>
        /// Describes the Replay. Lists all variable data fields and their types: image, text, etc.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.VdDescribeVariableDataContentResponse> VdDescribeVariableDataContentAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}