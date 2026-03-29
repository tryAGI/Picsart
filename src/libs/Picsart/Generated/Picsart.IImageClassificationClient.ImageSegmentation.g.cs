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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageSegmentationResponse> ImageSegmentationAsync(

            global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageMultiMattingSegmentationParameters> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Image Segmentation<br/>
        /// Performs multi-matting segmentation on the input image, identifying and isolating specific classes like hair, clothes, or sky.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageSegmentationResponse> ImageSegmentationAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}