#nullable enable

namespace Picsart
{
    public partial interface IGenAIText2AudioClient
    {
        /// <summary>
        /// Text2Sound<br/>
        /// The *Text2Sound* service helps generate an music/sound based on the prompt introduced as input by the user.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.GenaiText2soundResponse> GenaiText2soundAsync(

            global::Picsart.AllOf<global::Picsart.GenAIText2SoundParameters, global::Picsart.GenAIText2SoundModels> request,
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Text2Sound<br/>
        /// The *Text2Sound* service helps generate an music/sound based on the prompt introduced as input by the user.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.AutoSDKHttpResponse<global::Picsart.GenaiText2soundResponse>> GenaiText2soundAsResponseAsync(

            global::Picsart.AllOf<global::Picsart.GenAIText2SoundParameters, global::Picsart.GenAIText2SoundModels> request,
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Text2Sound<br/>
        /// The *Text2Sound* service helps generate an music/sound based on the prompt introduced as input by the user.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.GenaiText2soundResponse> GenaiText2soundAsync(
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}