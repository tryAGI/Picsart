#nullable enable

namespace Picsart
{
    public partial interface IVideoEditClient
    {
        /// <summary>
        /// Create a highlights video from the original one. This picks highlight clips and concatenates them into one output video.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.VideoConcatHighlightsResponse> VideoConcatHighlightsAsync(

            global::Picsart.AllOf<global::Picsart.VideoVideoParameters, global::Picsart.VideoConcatSegmentsParameters, global::Picsart.VideoExportParameters> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a highlights video from the original one. This picks highlight clips and concatenates them into one output video.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.VideoConcatHighlightsResponse> VideoConcatHighlightsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}