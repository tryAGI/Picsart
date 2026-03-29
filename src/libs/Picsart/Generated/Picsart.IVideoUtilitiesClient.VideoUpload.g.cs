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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.VideoUploadResponse> VideoUploadAsync(

            global::Picsart.VideoUploadParameters request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload files<br/>
        /// Upload resources such as videos, audios or images. The provided URL can be passed as inputs to video operation.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.VideoUploadResponse> VideoUploadAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}