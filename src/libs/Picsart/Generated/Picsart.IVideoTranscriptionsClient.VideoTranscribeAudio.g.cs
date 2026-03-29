#nullable enable

namespace Picsart
{
    public partial interface IVideoTranscriptionsClient
    {
        /// <summary>
        /// Transcribe Audio<br/>
        /// Transcribe your audio or video files. The input file can have one of the following mime types:<br/>
        ///   * audio/flac<br/>
        ///   * audio/mpeg<br/>
        ///   * audio/x-m4a<br/>
        ///   * audio/ogg<br/>
        ///   * audio/x-wav<br/>
        ///   * video/mp4<br/>
        ///   * video/mpeg<br/>
        ///   * video/webm<br/>
        /// Note, that the maximum audio/video file size supported is 25mb.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.VideoTranscribeAudioResponse> VideoTranscribeAudioAsync(

            global::Picsart.AllOf<global::Picsart.VideoTranscribeFileParameters, global::Picsart.VideoTranscribeParameters> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Transcribe Audio<br/>
        /// Transcribe your audio or video files. The input file can have one of the following mime types:<br/>
        ///   * audio/flac<br/>
        ///   * audio/mpeg<br/>
        ///   * audio/x-m4a<br/>
        ///   * audio/ogg<br/>
        ///   * audio/x-wav<br/>
        ///   * video/mp4<br/>
        ///   * video/mpeg<br/>
        ///   * video/webm<br/>
        /// Note, that the maximum audio/video file size supported is 25mb.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.VideoTranscribeAudioResponse> VideoTranscribeAudioAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}