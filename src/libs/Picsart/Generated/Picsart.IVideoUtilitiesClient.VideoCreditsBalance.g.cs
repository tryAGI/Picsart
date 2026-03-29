#nullable enable

namespace Picsart
{
    public partial interface IVideoUtilitiesClient
    {
        /// <summary>
        /// Credits Balance<br/>
        /// Check your balance of credits.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.VideoCreditsBalanceResponse> VideoCreditsBalanceAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}