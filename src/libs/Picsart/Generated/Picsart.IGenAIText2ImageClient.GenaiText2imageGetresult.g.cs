#nullable enable

namespace Picsart
{
    public partial interface IGenAIText2ImageClient
    {
        /// <summary>
        /// Get the Text2Image result<br/>
        /// Get the generated images.
        /// </summary>
        /// <param name="inferenceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.GenaiText2imageGetresultResponse> GenaiText2imageGetresultAsync(
            string inferenceId,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the Text2Image result<br/>
        /// Get the generated images.
        /// </summary>
        /// <param name="inferenceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.AutoSDKHttpResponse<global::Picsart.GenaiText2imageGetresultResponse>> GenaiText2imageGetresultAsResponseAsync(
            string inferenceId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}