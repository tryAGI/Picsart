#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Picsart
{
    public partial interface IImageClassificationClient
    {
        /// <summary>
        /// Image Tagging<br/>
        /// This tagging service analyzes the image and suggests hashtags that are relevant to the content.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageTaggingResponse> ImageTaggingAsync(

            global::Picsart.ImageImageParameters request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Image Tagging<br/>
        /// This tagging service analyzes the image and suggests hashtags that are relevant to the content.
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
        global::System.Threading.Tasks.Task<global::Picsart.ImageTaggingResponse> ImageTaggingAsync(
            byte[]? image = default,
            string? imagename = default,
            string? imageUrl = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}