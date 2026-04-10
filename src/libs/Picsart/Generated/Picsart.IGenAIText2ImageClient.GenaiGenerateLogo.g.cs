#nullable enable

namespace Picsart
{
    public partial interface IGenAIText2ImageClient
    {
        /// <summary>
        /// Logo Generator<br/>
        /// Generate logos using company info, general description. You can add additional information to guide on the details you want to get on the logo. It is also possible to provide an example logo to generate similar logos. 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.GenaiGenerateLogoResponse> GenaiGenerateLogoAsync(

            global::Picsart.AllOf<global::Picsart.GenAILogoParameters, global::Picsart.GenAILogoModels> request,
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Logo Generator<br/>
        /// Generate logos using company info, general description. You can add additional information to guide on the details you want to get on the logo. It is also possible to provide an example logo to generate similar logos. 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.AutoSDKHttpResponse<global::Picsart.GenaiGenerateLogoResponse>> GenaiGenerateLogoAsResponseAsync(

            global::Picsart.AllOf<global::Picsart.GenAILogoParameters, global::Picsart.GenAILogoModels> request,
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Logo Generator<br/>
        /// Generate logos using company info, general description. You can add additional information to guide on the details you want to get on the logo. It is also possible to provide an example logo to generate similar logos. 
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.GenaiGenerateLogoResponse> GenaiGenerateLogoAsync(
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}