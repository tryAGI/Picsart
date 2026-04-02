#nullable enable

namespace Picsart
{
    public partial interface IGenAIText2ImageClient
    {
        /// <summary>
        /// Get the Logo Generator result<br/>
        /// Get the results of your logo generation. Use the inference identifier from the [Logo Generator](https://docs.picsart.io/reference/genai-generate-logo).
        /// </summary>
        /// <param name="inferenceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.GenaiGenerateLogoGetresultResponse> GenaiGenerateLogoGetresultAsync(
            string inferenceId,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the Logo Generator result<br/>
        /// Get the results of your logo generation. Use the inference identifier from the [Logo Generator](https://docs.picsart.io/reference/genai-generate-logo).
        /// </summary>
        /// <param name="inferenceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.AutoSDKHttpResponse<global::Picsart.GenaiGenerateLogoGetresultResponse>> GenaiGenerateLogoGetresultAsResponseAsync(
            string inferenceId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}