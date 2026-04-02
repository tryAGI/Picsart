#nullable enable

namespace Picsart
{
    public partial interface IVideoEditClient
    {
        /// <summary>
        /// Crop Video<br/>
        /// Crop the input video clip to the desired size.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.VideoCropResponse> VideoCropAsync(

            global::Picsart.AllOf<global::Picsart.VideoVideoParameters, global::Picsart.VideoCropParameters, global::Picsart.VideoExportParameters> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Crop Video<br/>
        /// Crop the input video clip to the desired size.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.AutoSDKHttpResponse<global::Picsart.VideoCropResponse>> VideoCropAsResponseAsync(

            global::Picsart.AllOf<global::Picsart.VideoVideoParameters, global::Picsart.VideoCropParameters, global::Picsart.VideoExportParameters> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Crop Video<br/>
        /// Crop the input video clip to the desired size.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.VideoCropResponse> VideoCropAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}