#nullable enable

namespace Picsart
{
    public partial interface IVideoRemoveBackgroundClient
    {
        /// <summary>
        /// Remove &amp; Change Background from Videos<br/>
        /// Remove Background from videos, or replace with custom backdrops.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.VideoRemoveBackgroundResponse> VideoRemoveBackgroundAsync(

            global::Picsart.AllOf<global::Picsart.VideoVideoParameters, global::Picsart.VideoRemoveBackgroundParameters> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove &amp; Change Background from Videos<br/>
        /// Remove Background from videos, or replace with custom backdrops.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.VideoRemoveBackgroundResponse> VideoRemoveBackgroundAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}