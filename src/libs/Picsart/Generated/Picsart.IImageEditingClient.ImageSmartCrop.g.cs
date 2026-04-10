#nullable enable

namespace Picsart
{
    public partial interface IImageEditingClient
    {
        /// <summary>
        /// Smart Crop<br/>
        /// Use AI to define the segment that should be cropped, e.g. foreground or product name (e.g. hat, gloves, boots, etc).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageSmartCropResponse> ImageSmartCropAsync(

            global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageSmartCropParameters> request,
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Smart Crop<br/>
        /// Use AI to define the segment that should be cropped, e.g. foreground or product name (e.g. hat, gloves, boots, etc).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.AutoSDKHttpResponse<global::Picsart.ImageSmartCropResponse>> ImageSmartCropAsResponseAsync(

            global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageSmartCropParameters> request,
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Smart Crop<br/>
        /// Use AI to define the segment that should be cropped, e.g. foreground or product name (e.g. hat, gloves, boots, etc).
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageSmartCropResponse> ImageSmartCropAsync(
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}