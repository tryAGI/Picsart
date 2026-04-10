#nullable enable

namespace Picsart
{
    public partial interface IVideoEditClient
    {
        /// <summary>
        /// Fit Video<br/>
        /// Fit your original video to different ratios or width and height options. Apply fit when resizing and cropping is not an option.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.VideoFitResponse> VideoFitAsync(

            global::Picsart.AllOf<global::Picsart.VideoVideoParameters, global::Picsart.VideoFitParameters> request,
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Fit Video<br/>
        /// Fit your original video to different ratios or width and height options. Apply fit when resizing and cropping is not an option.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.AutoSDKHttpResponse<global::Picsart.VideoFitResponse>> VideoFitAsResponseAsync(

            global::Picsart.AllOf<global::Picsart.VideoVideoParameters, global::Picsart.VideoFitParameters> request,
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Fit Video<br/>
        /// Fit your original video to different ratios or width and height options. Apply fit when resizing and cropping is not an option.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.VideoFitResponse> VideoFitAsync(
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}