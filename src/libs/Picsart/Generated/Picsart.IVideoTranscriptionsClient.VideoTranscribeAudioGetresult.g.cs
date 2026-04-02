#nullable enable

namespace Picsart
{
    public partial interface IVideoTranscriptionsClient
    {
        /// <summary>
        /// Get the Transcribe Audio result<br/>
        /// Use this method, along with transaction_id, to retrieve the audio transcription.
        /// </summary>
        /// <param name="transactionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.VideoTranscribeAudioGetresultResponse> VideoTranscribeAudioGetresultAsync(
            string transactionId,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the Transcribe Audio result<br/>
        /// Use this method, along with transaction_id, to retrieve the audio transcription.
        /// </summary>
        /// <param name="transactionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.AutoSDKHttpResponse<global::Picsart.VideoTranscribeAudioGetresultResponse>> VideoTranscribeAudioGetresultAsResponseAsync(
            string transactionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}