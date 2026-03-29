#nullable enable

namespace Picsart
{
    public partial interface IVideoAudioClient
    {
        /// <summary>
        /// Extract Audio<br/>
        /// Extract the input video's audio channel.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.VideoExtractAudioResponse> VideoExtractAudioAsync(

            global::Picsart.AllOf<global::Picsart.VideoVideoParameters, global::Picsart.VideoExtractAudioParameters> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Extract Audio<br/>
        /// Extract the input video's audio channel.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.VideoExtractAudioResponse> VideoExtractAudioAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}