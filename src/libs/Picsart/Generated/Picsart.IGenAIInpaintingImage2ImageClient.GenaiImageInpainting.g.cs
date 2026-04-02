#nullable enable

namespace Picsart
{
    public partial interface IGenAIInpaintingImage2ImageClient
    {
        /// <summary>
        /// Inpaint Image<br/>
        /// The **Inpainting** service offers inpainting (image2Image) capabilities, enabling users to fill or replace areas within an image based on specified criteria. It operates in two modes: * Single Image Mode: Submit one RGBA image. The API fills the specified inner area with content based on the prompt parameter. * Mask Mode: Along with the RGBA image, provide a mask of identical size and format. The API uses this mask to identify areas for inpainting with content determined by the prompt parameter.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.GenaiImageInpaintingResponse> GenaiImageInpaintingAsync(

            global::Picsart.AllOf<global::Picsart.GenAIImageParameters, global::Picsart.GenAIMaskParameters, global::Picsart.GenAIInpaintingParameters> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Inpaint Image<br/>
        /// The **Inpainting** service offers inpainting (image2Image) capabilities, enabling users to fill or replace areas within an image based on specified criteria. It operates in two modes: * Single Image Mode: Submit one RGBA image. The API fills the specified inner area with content based on the prompt parameter. * Mask Mode: Along with the RGBA image, provide a mask of identical size and format. The API uses this mask to identify areas for inpainting with content determined by the prompt parameter.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.AutoSDKHttpResponse<global::Picsart.GenaiImageInpaintingResponse>> GenaiImageInpaintingAsResponseAsync(

            global::Picsart.AllOf<global::Picsart.GenAIImageParameters, global::Picsart.GenAIMaskParameters, global::Picsart.GenAIInpaintingParameters> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Inpaint Image<br/>
        /// The **Inpainting** service offers inpainting (image2Image) capabilities, enabling users to fill or replace areas within an image based on specified criteria. It operates in two modes: * Single Image Mode: Submit one RGBA image. The API fills the specified inner area with content based on the prompt parameter. * Mask Mode: Along with the RGBA image, provide a mask of identical size and format. The API uses this mask to identify areas for inpainting with content determined by the prompt parameter.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.GenaiImageInpaintingResponse> GenaiImageInpaintingAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}