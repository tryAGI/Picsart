#nullable enable

namespace Picsart
{
    public partial interface IVideoEditClient
    {
        /// <summary>
        /// Concatenate Videos and Images<br/>
        /// Concatenate several videos clips and images with transitions into one timeline. Helpful when adding intro/outro- or creating slideshows.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.VideoConcatResponse> VideoConcatAsync(

            global::Picsart.AllOf<global::Picsart.VideoConcatParameters, global::Picsart.VideoExportParameters> request,
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Concatenate Videos and Images<br/>
        /// Concatenate several videos clips and images with transitions into one timeline. Helpful when adding intro/outro- or creating slideshows.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.AutoSDKHttpResponse<global::Picsart.VideoConcatResponse>> VideoConcatAsResponseAsync(

            global::Picsart.AllOf<global::Picsart.VideoConcatParameters, global::Picsart.VideoExportParameters> request,
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Concatenate Videos and Images<br/>
        /// Concatenate several videos clips and images with transitions into one timeline. Helpful when adding intro/outro- or creating slideshows.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.VideoConcatResponse> VideoConcatAsync(
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}