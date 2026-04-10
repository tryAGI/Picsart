#nullable enable

namespace Picsart
{
    public partial interface IVideoUtilitiesClient
    {
        /// <summary>
        /// Upload files<br/>
        /// Upload resources such as videos, audios or images. The provided URL can be passed as inputs to video operation.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.VideoUploadResponse> VideoUploadAsync(

            global::Picsart.VideoUploadParameters request,
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload files<br/>
        /// Upload resources such as videos, audios or images. The provided URL can be passed as inputs to video operation.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.AutoSDKHttpResponse<global::Picsart.VideoUploadResponse>> VideoUploadAsResponseAsync(

            global::Picsart.VideoUploadParameters request,
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload files<br/>
        /// Upload resources such as videos, audios or images. The provided URL can be passed as inputs to video operation.
        /// </summary>
        /// <param name="file">
        /// Source file (binary).
        /// </param>
        /// <param name="filename">
        /// Source file (binary).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.VideoUploadResponse> VideoUploadAsync(
            byte[]? file = default,
            string? filename = default,
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}