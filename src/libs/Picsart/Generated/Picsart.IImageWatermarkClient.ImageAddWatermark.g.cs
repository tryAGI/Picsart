#nullable enable

namespace Picsart
{
    public partial interface IImageWatermarkClient
    {
        /// <summary>
        /// Add Watermark<br/>
        /// Add watermark to your image.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageAddWatermarkResponse> ImageAddWatermarkAsync(

            global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageWatermarkParameters, global::Picsart.ImageExportParameters> request,
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Watermark<br/>
        /// Add watermark to your image.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.AutoSDKHttpResponse<global::Picsart.ImageAddWatermarkResponse>> ImageAddWatermarkAsResponseAsync(

            global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageWatermarkParameters, global::Picsart.ImageExportParameters> request,
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Watermark<br/>
        /// Add watermark to your image.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageAddWatermarkResponse> ImageAddWatermarkAsync(
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}