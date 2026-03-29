#nullable enable

namespace Picsart
{
    public partial interface IGenAIInpaintingImage2ImageClient
    {
        /// <summary>
        /// Get the results of the painting<br/>
        /// Inpaint, Outpaint, Smart Background and Expand services can work asynchronously and expose an inference identifier that can be used later to fetch te results.<br/>
        /// Use this service to check up on the result.
        /// </summary>
        /// <param name="inferenceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.GenaiImageInpaintingGetresultResponse> GenaiImageInpaintingGetresultAsync(
            string inferenceId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}