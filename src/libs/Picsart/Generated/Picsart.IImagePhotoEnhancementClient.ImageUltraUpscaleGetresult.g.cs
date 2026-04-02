#nullable enable

namespace Picsart
{
    public partial interface IImagePhotoEnhancementClient
    {
        /// <summary>
        /// Get the Ultra Upscale result<br/>
        /// Use this method, along with transaction_id, to retrieve the upscale ultra finished image if the transformation was done asynchronously.
        /// </summary>
        /// <param name="transactionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageUltraUpscaleGetresultResponse> ImageUltraUpscaleGetresultAsync(
            string transactionId,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the Ultra Upscale result<br/>
        /// Use this method, along with transaction_id, to retrieve the upscale ultra finished image if the transformation was done asynchronously.
        /// </summary>
        /// <param name="transactionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.AutoSDKHttpResponse<global::Picsart.ImageUltraUpscaleGetresultResponse>> ImageUltraUpscaleGetresultAsResponseAsync(
            string transactionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}