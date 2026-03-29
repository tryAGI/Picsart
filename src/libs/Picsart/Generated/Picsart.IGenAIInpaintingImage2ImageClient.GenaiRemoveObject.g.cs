#nullable enable

namespace Picsart
{
    public partial interface IGenAIInpaintingImage2ImageClient
    {
        /// <summary>
        /// Remove Object from an Image<br/>
        /// This service allows to remove objects from the original image by providing a mask.<br/>
        /// Even though the same type of a result can also achieved via the &lt;a href="https://docs.picsart.io/reference/genai-image-inpainting"&gt;Inpainting&lt;/a&gt; service, this service uses a specially trained model to provide fine tuned results.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.GenaiRemoveObjectResponse> GenaiRemoveObjectAsync(

            global::Picsart.AllOf<global::Picsart.GenAIImageParameters, global::Picsart.GenAIMaskParameters, global::Picsart.GenAIRemoveObjectParameters> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove Object from an Image<br/>
        /// This service allows to remove objects from the original image by providing a mask.<br/>
        /// Even though the same type of a result can also achieved via the &lt;a href="https://docs.picsart.io/reference/genai-image-inpainting"&gt;Inpainting&lt;/a&gt; service, this service uses a specially trained model to provide fine tuned results.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.GenaiRemoveObjectResponse> GenaiRemoveObjectAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}