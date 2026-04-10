#nullable enable

namespace Picsart
{
    public partial interface IGenAIText2TextClient
    {
        /// <summary>
        /// Text2Text Completions<br/>
        /// The *Text2Text Completion* service helps generate a text based on the text introduced as input by the user. It also takes the pain out of writing to give your social, marketing, and advertising copy a premium edge.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.GenaiText2textCompletionsResponse> GenaiText2textCompletionsAsync(

            global::Picsart.AllOf<global::Picsart.GenAIText2TextCompletionsParameters, global::Picsart.GenAIText2TextModels> request,
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Text2Text Completions<br/>
        /// The *Text2Text Completion* service helps generate a text based on the text introduced as input by the user. It also takes the pain out of writing to give your social, marketing, and advertising copy a premium edge.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.AutoSDKHttpResponse<global::Picsart.GenaiText2textCompletionsResponse>> GenaiText2textCompletionsAsResponseAsync(

            global::Picsart.AllOf<global::Picsart.GenAIText2TextCompletionsParameters, global::Picsart.GenAIText2TextModels> request,
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Text2Text Completions<br/>
        /// The *Text2Text Completion* service helps generate a text based on the text introduced as input by the user. It also takes the pain out of writing to give your social, marketing, and advertising copy a premium edge.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.GenaiText2textCompletionsResponse> GenaiText2textCompletionsAsync(
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}