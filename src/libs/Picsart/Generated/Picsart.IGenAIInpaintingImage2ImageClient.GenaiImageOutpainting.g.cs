#nullable enable

namespace Picsart
{
    public partial interface IGenAIInpaintingImage2ImageClient
    {
        /// <summary>
        /// Outpaint Image<br/>
        /// The **Outpainting** service enables outpainting (image2image), allowing users to extend or replace specific parts of an image. This is a reversed form of the Inpainting service (drawing outside of the mask, not inside).<br/>
        /// It supports two operational modes:<br/>
        ///   * Single Image Mode: Upload one RGBA image. The API enhances the outer area with content based on the prompt parameter.<br/>
        ///   * Mask Mode: Provide an RGBA image along with a mask of the same size. The API applies this mask to paint beyond the masked region, using content determined by the prompt parameter.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.GenaiImageOutpaintingResponse> GenaiImageOutpaintingAsync(

            global::Picsart.AllOf<global::Picsart.GenAIImageParameters, global::Picsart.GenAIMaskParameters, global::Picsart.GenAIInpaintingParameters> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Outpaint Image<br/>
        /// The **Outpainting** service enables outpainting (image2image), allowing users to extend or replace specific parts of an image. This is a reversed form of the Inpainting service (drawing outside of the mask, not inside).<br/>
        /// It supports two operational modes:<br/>
        ///   * Single Image Mode: Upload one RGBA image. The API enhances the outer area with content based on the prompt parameter.<br/>
        ///   * Mask Mode: Provide an RGBA image along with a mask of the same size. The API applies this mask to paint beyond the masked region, using content determined by the prompt parameter.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.GenaiImageOutpaintingResponse> GenaiImageOutpaintingAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}