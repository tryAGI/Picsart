#nullable enable

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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageTaggingResponse> ImageTaggingAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}