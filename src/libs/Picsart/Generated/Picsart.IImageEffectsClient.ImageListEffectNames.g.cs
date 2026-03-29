#nullable enable

namespace Picsart
{
    public partial interface IImageEffectsClient
    {
        /// <summary>
        /// Effect Names<br/>
        /// This service retrieves a list of supported effects.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageListEffectNamesResponse> ImageListEffectNamesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}