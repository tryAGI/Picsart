#nullable enable

namespace Picsart
{
    public partial interface IImageConversionClient
    {
        /// <summary>
        /// Get the Design Import Result<br/>
        /// Get the result of the Design Import. Use the inference identifier from the POST request to fetch the latest status and result here.
        /// </summary>
        /// <param name="transactionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageDesignImportGetresultResponse> ImageDesignImportGetresultAsync(
            string transactionId,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the Design Import Result<br/>
        /// Get the result of the Design Import. Use the inference identifier from the POST request to fetch the latest status and result here.
        /// </summary>
        /// <param name="transactionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.AutoSDKHttpResponse<global::Picsart.ImageDesignImportGetresultResponse>> ImageDesignImportGetresultAsResponseAsync(
            string transactionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}