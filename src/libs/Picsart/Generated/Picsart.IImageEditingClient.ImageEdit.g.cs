#nullable enable

namespace Picsart
{
    public partial interface IImageEditingClient
    {
        /// <summary>
        /// Basic Editing<br/>
        /// The *Edit* service applies basic image editing to an input image. The basic editing operations are resize, crop, flip, rotate and perspective manipulation.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageEditResponse> ImageEditAsync(

            global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageEditParameters> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Basic Editing<br/>
        /// The *Edit* service applies basic image editing to an input image. The basic editing operations are resize, crop, flip, rotate and perspective manipulation.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.AutoSDKHttpResponse<global::Picsart.ImageEditResponse>> ImageEditAsResponseAsync(

            global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageEditParameters> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Basic Editing<br/>
        /// The *Edit* service applies basic image editing to an input image. The basic editing operations are resize, crop, flip, rotate and perspective manipulation.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageEditResponse> ImageEditAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}