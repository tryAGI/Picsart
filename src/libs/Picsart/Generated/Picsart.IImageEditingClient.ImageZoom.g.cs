#nullable enable

namespace Picsart
{
    public partial interface IImageEditingClient
    {
        /// <summary>
        /// Zoom<br/>
        /// Zoom your images with 1-75 scale factors.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageZoomResponse> ImageZoomAsync(

            global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageZoomParameters> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Zoom<br/>
        /// Zoom your images with 1-75 scale factors.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.AutoSDKHttpResponse<global::Picsart.ImageZoomResponse>> ImageZoomAsResponseAsync(

            global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageZoomParameters> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Zoom<br/>
        /// Zoom your images with 1-75 scale factors.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageZoomResponse> ImageZoomAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}