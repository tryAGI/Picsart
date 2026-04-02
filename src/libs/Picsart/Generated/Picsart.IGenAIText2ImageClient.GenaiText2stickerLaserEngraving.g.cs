#nullable enable

namespace Picsart
{
    public partial interface IGenAIText2ImageClient
    {
        /// <summary>
        /// Text2Sticker with Laser Engraving Effect<br/>
        /// This service generates stickers similar to the standard /text2sticker service, and in addition to that it adds a laser engraving effect.<br/>
        /// The result images can be as big as 1024x1024 pixels.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.GenaiText2stickerLaserEngravingResponse> GenaiText2stickerLaserEngravingAsync(

            global::Picsart.AllOf<global::Picsart.GenAIText2ImageParameters, global::Picsart.GenAILaserEngravingParameters, global::Picsart.GenAILaserEngravingModels> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Text2Sticker with Laser Engraving Effect<br/>
        /// This service generates stickers similar to the standard /text2sticker service, and in addition to that it adds a laser engraving effect.<br/>
        /// The result images can be as big as 1024x1024 pixels.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.AutoSDKHttpResponse<global::Picsart.GenaiText2stickerLaserEngravingResponse>> GenaiText2stickerLaserEngravingAsResponseAsync(

            global::Picsart.AllOf<global::Picsart.GenAIText2ImageParameters, global::Picsart.GenAILaserEngravingParameters, global::Picsart.GenAILaserEngravingModels> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Text2Sticker with Laser Engraving Effect<br/>
        /// This service generates stickers similar to the standard /text2sticker service, and in addition to that it adds a laser engraving effect.<br/>
        /// The result images can be as big as 1024x1024 pixels.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.GenaiText2stickerLaserEngravingResponse> GenaiText2stickerLaserEngravingAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}