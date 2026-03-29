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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageAddWatermarkResponse> ImageAddWatermarkAsync(

            global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageWatermarkParameters, global::Picsart.ImageExportParameters> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Watermark<br/>
        /// Add watermark to your image.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageAddWatermarkResponse> ImageAddWatermarkAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}