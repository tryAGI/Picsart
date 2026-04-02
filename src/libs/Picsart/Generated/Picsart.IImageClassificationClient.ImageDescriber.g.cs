#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Picsart
{
    public partial interface IImageClassificationClient
    {
        /// <summary>
        /// Describe Image<br/>
        /// The image *Describer* service helps generate a detailed text description for the provided image (image2text).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageDescriberResponse> ImageDescriberAsync(

            global::Picsart.ImageImageParameters request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Describe Image<br/>
        /// The image *Describer* service helps generate a detailed text description for the provided image (image2text).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.AutoSDKHttpResponse<global::Picsart.ImageDescriberResponse>> ImageDescriberAsResponseAsync(

            global::Picsart.ImageImageParameters request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Describe Image<br/>
        /// The image *Describer* service helps generate a detailed text description for the provided image (image2text).
        /// </summary>
        /// <param name="image">
        /// Source image file (binary). (If this parameter is present, the other image source parameters must be empty.)
        /// </param>
        /// <param name="imagename">
        /// Source image file (binary). (If this parameter is present, the other image source parameters must be empty.)
        /// </param>
        /// <param name="imageUrl">
        /// Source image URL. (If this parameter is present, the other image source parameters must be empty.)
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageDescriberResponse> ImageDescriberAsync(
            byte[]? image = default,
            string? imagename = default,
            string? imageUrl = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}