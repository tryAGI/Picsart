#nullable enable

namespace Picsart
{
    public partial interface IGenAIText2VideoImage2VideoClient
    {
        /// <summary>
        /// Get the Video Generation result<br/>
        /// Use this method, along with inference id, to retrieve the generated video.
        /// </summary>
        /// <param name="inferenceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.GenaiText2videoGetresultResponse> GenaiText2videoGetresultAsync(
            string inferenceId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}