#nullable enable

namespace Picsart
{
    public partial interface IVideoWatermarkClient
    {
        /// <summary>
        /// Add Watermark<br/>
        /// Add watermark to your video.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.VideoAddWatermarkResponse> VideoAddWatermarkAsync(

            global::Picsart.AllOf<global::Picsart.VideoVideoParameters, global::Picsart.VideoWatermarkParameters> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Watermark<br/>
        /// Add watermark to your video.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.AutoSDKHttpResponse<global::Picsart.VideoAddWatermarkResponse>> VideoAddWatermarkAsResponseAsync(

            global::Picsart.AllOf<global::Picsart.VideoVideoParameters, global::Picsart.VideoWatermarkParameters> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Watermark<br/>
        /// Add watermark to your video.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.VideoAddWatermarkResponse> VideoAddWatermarkAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}