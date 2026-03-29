#nullable enable

namespace Picsart
{
    public partial interface IGenAIInpaintingImage2ImageClient
    {
        /// <summary>
        /// Expand Image<br/>
        /// The **Image Expansion** service offers a groundbreaking functionality designed to enhance digital imagery by enabling users to enlarge any image to specific width and height dimensions. This sophisticated feature not only allows generative resizing but also provides the capability to specify the direction of expansion, ensuring that users have complete control over the final appearance of their images.<br/>
        ///   <br/>
        /// This service is engineered to accommodate the need for larger image sizes without compromising on quality. The requirement that the specified width and height dimensions exceed the original image dimensions ensures that users can seamlessly scale their images up to meet various requirements, whether for professional presentations, digital marketing materials, web design, or personal use.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.GenaiExpandImageResponse> GenaiExpandImageAsync(

            global::Picsart.AllOf<global::Picsart.GenAIImageParameters, global::Picsart.GenAIExpandParameters> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Expand Image<br/>
        /// The **Image Expansion** service offers a groundbreaking functionality designed to enhance digital imagery by enabling users to enlarge any image to specific width and height dimensions. This sophisticated feature not only allows generative resizing but also provides the capability to specify the direction of expansion, ensuring that users have complete control over the final appearance of their images.<br/>
        ///   <br/>
        /// This service is engineered to accommodate the need for larger image sizes without compromising on quality. The requirement that the specified width and height dimensions exceed the original image dimensions ensures that users can seamlessly scale their images up to meet various requirements, whether for professional presentations, digital marketing materials, web design, or personal use.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.GenaiExpandImageResponse> GenaiExpandImageAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}