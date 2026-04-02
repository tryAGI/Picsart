#nullable enable

namespace Picsart
{
    public partial interface IImageEffectsClient
    {
        /// <summary>
        /// AI Effect Names<br/>
        /// This service retrieves the list of supported AI effects.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageListAiEffectNamesResponse> ImageListAiEffectNamesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// AI Effect Names<br/>
        /// This service retrieves the list of supported AI effects.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.AutoSDKHttpResponse<global::Picsart.ImageListAiEffectNamesResponse>> ImageListAiEffectNamesAsResponseAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}