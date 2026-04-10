#nullable enable

namespace Picsart
{
    public partial interface IImageClassificationClient
    {
        /// <summary>
        /// Image Segmentation<br/>
        /// Performs multi-matting segmentation on the input image, identifying and isolating specific classes like hair, clothes, or sky.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageSegmentationResponse> ImageSegmentationAsync(

            global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageMultiMattingSegmentationParameters> request,
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Image Segmentation<br/>
        /// Performs multi-matting segmentation on the input image, identifying and isolating specific classes like hair, clothes, or sky.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.AutoSDKHttpResponse<global::Picsart.ImageSegmentationResponse>> ImageSegmentationAsResponseAsync(

            global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageMultiMattingSegmentationParameters> request,
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Image Segmentation<br/>
        /// Performs multi-matting segmentation on the input image, identifying and isolating specific classes like hair, clothes, or sky.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageSegmentationResponse> ImageSegmentationAsync(
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}