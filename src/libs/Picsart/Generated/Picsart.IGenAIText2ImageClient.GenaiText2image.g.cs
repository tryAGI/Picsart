#nullable enable

namespace Picsart
{
    public partial interface IGenAIText2ImageClient
    {
        /// <summary>
        /// Text2Image<br/>
        /// The *Text2Image* service helps generate an image based on the text introduced as input by the user.<br/>
        /// The result images can be as big as 1024x1024 pixels.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.GenaiText2imageResponse> GenaiText2imageAsync(

            global::Picsart.AllOf<global::Picsart.GenAIText2ImageParameters, global::Picsart.GenAIText2ImageModels> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Text2Image<br/>
        /// The *Text2Image* service helps generate an image based on the text introduced as input by the user.<br/>
        /// The result images can be as big as 1024x1024 pixels.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.AutoSDKHttpResponse<global::Picsart.GenaiText2imageResponse>> GenaiText2imageAsResponseAsync(

            global::Picsart.AllOf<global::Picsart.GenAIText2ImageParameters, global::Picsart.GenAIText2ImageModels> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Text2Image<br/>
        /// The *Text2Image* service helps generate an image based on the text introduced as input by the user.<br/>
        /// The result images can be as big as 1024x1024 pixels.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.GenaiText2imageResponse> GenaiText2imageAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}