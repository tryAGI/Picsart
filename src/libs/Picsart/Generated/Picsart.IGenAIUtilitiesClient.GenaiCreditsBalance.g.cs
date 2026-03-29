#nullable enable

namespace Picsart
{
    public partial interface IGenAIUtilitiesClient
    {
        /// <summary>
        /// Credits Balance<br/>
        /// Check your balance of credits.<br/>
        /// **Authorization:**<br/>
        ///     Requires an API key to be provided in the **X-Picsart-API-Key** request header.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.GenaiCreditsBalanceResponse> GenaiCreditsBalanceAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}