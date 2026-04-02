#nullable enable

namespace Picsart
{
    public partial interface IVideoMetadataClient
    {
        /// <summary>
        /// Get Video Metadata<br/>
        /// Analysis the Video and provides the Metadata.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.VideoMetadataResponse> VideoMetadataAsync(

            global::Picsart.VideoVideoParameters request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Video Metadata<br/>
        /// Analysis the Video and provides the Metadata.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.AutoSDKHttpResponse<global::Picsart.VideoMetadataResponse>> VideoMetadataAsResponseAsync(

            global::Picsart.VideoVideoParameters request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Video Metadata<br/>
        /// Analysis the Video and provides the Metadata.
        /// </summary>
        /// <param name="videoUrl">
        /// Source video URL.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.VideoMetadataResponse> VideoMetadataAsync(
            string? videoUrl = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}