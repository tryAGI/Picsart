#nullable enable

namespace Picsart
{
    public partial interface IGenAIText2ImageClient
    {
        /// <summary>
        /// Get the Text2Sticker result<br/>
        /// Get the generated stickers.
        /// </summary>
        /// <param name="inferenceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.GenaiText2stickerGetresultResponse> GenaiText2stickerGetresultAsync(
            string inferenceId,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the Text2Sticker result<br/>
        /// Get the generated stickers.
        /// </summary>
        /// <param name="inferenceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.AutoSDKHttpResponse<global::Picsart.GenaiText2stickerGetresultResponse>> GenaiText2stickerGetresultAsResponseAsync(
            string inferenceId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}