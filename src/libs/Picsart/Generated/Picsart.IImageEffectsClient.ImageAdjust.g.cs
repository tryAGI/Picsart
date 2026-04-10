#nullable enable

namespace Picsart
{
    public partial interface IImageEffectsClient
    {
        /// <summary>
        /// Adjust<br/>
        /// The *adjust* service applies adjustments to an input image. There are 11 different adjustments in all available. The adjust service can be used with all photo types.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageAdjustResponse> ImageAdjustAsync(

            global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageAdjustParameters> request,
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Adjust<br/>
        /// The *adjust* service applies adjustments to an input image. There are 11 different adjustments in all available. The adjust service can be used with all photo types.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.AutoSDKHttpResponse<global::Picsart.ImageAdjustResponse>> ImageAdjustAsResponseAsync(

            global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageAdjustParameters> request,
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Adjust<br/>
        /// The *adjust* service applies adjustments to an input image. There are 11 different adjustments in all available. The adjust service can be used with all photo types.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageAdjustResponse> ImageAdjustAsync(
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}