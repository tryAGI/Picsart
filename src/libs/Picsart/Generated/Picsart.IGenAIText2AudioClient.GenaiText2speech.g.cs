#nullable enable

namespace Picsart
{
    public partial interface IGenAIText2AudioClient
    {
        /// <summary>
        /// Text2Speech<br/>
        /// The *Text2Speech* service helps generate an audio based on the text introduced as input by the user. The audio will speak the text provided.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.GenaiText2speechResponse> GenaiText2speechAsync(

            global::Picsart.AllOf<global::Picsart.GenAIText2SpeechParameters, global::Picsart.GenAIText2SpeechModels> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Text2Speech<br/>
        /// The *Text2Speech* service helps generate an audio based on the text introduced as input by the user. The audio will speak the text provided.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.GenaiText2speechResponse> GenaiText2speechAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}