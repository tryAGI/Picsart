#nullable enable

namespace Picsart
{
    public partial interface IImagePhotoEnhancementClient
    {
        /// <summary>
        /// Face Enhancement<br/>
        /// With our *enhance face* tool, you can turn your old, blurry photos into clear portraits and selfies. ur AI technology will find faces, perform restoration and do color enhancement simultaneously. It will improve the skin texture and sharpen details while keeping a good balance of realness and fidelity with much less artifacts.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageFaceEnhanceResponse> ImageFaceEnhanceAsync(

            global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageFaceEnhanceParameters> request,
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Face Enhancement<br/>
        /// With our *enhance face* tool, you can turn your old, blurry photos into clear portraits and selfies. ur AI technology will find faces, perform restoration and do color enhancement simultaneously. It will improve the skin texture and sharpen details while keeping a good balance of realness and fidelity with much less artifacts.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.AutoSDKHttpResponse<global::Picsart.ImageFaceEnhanceResponse>> ImageFaceEnhanceAsResponseAsync(

            global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageFaceEnhanceParameters> request,
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Face Enhancement<br/>
        /// With our *enhance face* tool, you can turn your old, blurry photos into clear portraits and selfies. ur AI technology will find faces, perform restoration and do color enhancement simultaneously. It will improve the skin texture and sharpen details while keeping a good balance of realness and fidelity with much less artifacts.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageFaceEnhanceResponse> ImageFaceEnhanceAsync(
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}