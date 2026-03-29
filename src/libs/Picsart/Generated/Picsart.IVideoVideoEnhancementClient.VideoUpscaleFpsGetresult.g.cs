#nullable enable

namespace Picsart
{
    public partial interface IVideoVideoEnhancementClient
    {
        /// <summary>
        /// Get the Video FPS Upscale result<br/>
        /// Use this method, along with transaction_id, to retrieve the upscaled video.
        /// </summary>
        /// <param name="transactionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.VideoUpscaleFpsGetresultResponse> VideoUpscaleFpsGetresultAsync(
            string transactionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}