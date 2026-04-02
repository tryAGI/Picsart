#nullable enable

namespace Picsart
{
    public partial interface IGenAIText2ImageClient
    {
        /// <summary>
        /// Text2Sticker<br/>
        /// The *Text2Sticker* service helps generate a sticker based on the text introduced as input by the user.<br/>
        /// The result images can be as big as 1024x1024 pixels.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.GenaiText2stickerResponse> GenaiText2stickerAsync(

            global::Picsart.AllOf<global::Picsart.GenAIText2ImageParameters, global::Picsart.GenAIText2StickerModels> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Text2Sticker<br/>
        /// The *Text2Sticker* service helps generate a sticker based on the text introduced as input by the user.<br/>
        /// The result images can be as big as 1024x1024 pixels.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.AutoSDKHttpResponse<global::Picsart.GenaiText2stickerResponse>> GenaiText2stickerAsResponseAsync(

            global::Picsart.AllOf<global::Picsart.GenAIText2ImageParameters, global::Picsart.GenAIText2StickerModels> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Text2Sticker<br/>
        /// The *Text2Sticker* service helps generate a sticker based on the text introduced as input by the user.<br/>
        /// The result images can be as big as 1024x1024 pixels.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.GenaiText2stickerResponse> GenaiText2stickerAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}