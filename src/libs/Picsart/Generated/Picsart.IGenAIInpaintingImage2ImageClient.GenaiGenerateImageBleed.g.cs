#nullable enable

namespace Picsart
{
    public partial interface IGenAIInpaintingImage2ImageClient
    {
        /// <summary>
        /// Generate Bleed<br/>
        /// This service offers a groundbreaking functionality designed to enhance digital imagery by enabling users to enlarge any image. <br/>
        /// This service enlarges the original images and generates additional pixels around the original from all sides. This helps print original images without needing to cut part of it during the print production process. The generated bleed area is a continuation of the original image and will ensure a consistent and high cut quality.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.GenaiGenerateImageBleedResponse> GenaiGenerateImageBleedAsync(

            global::Picsart.AllOf<global::Picsart.GenAIImageParameters, global::Picsart.GenAIBleedParameters> request,
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate Bleed<br/>
        /// This service offers a groundbreaking functionality designed to enhance digital imagery by enabling users to enlarge any image. <br/>
        /// This service enlarges the original images and generates additional pixels around the original from all sides. This helps print original images without needing to cut part of it during the print production process. The generated bleed area is a continuation of the original image and will ensure a consistent and high cut quality.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.AutoSDKHttpResponse<global::Picsart.GenaiGenerateImageBleedResponse>> GenaiGenerateImageBleedAsResponseAsync(

            global::Picsart.AllOf<global::Picsart.GenAIImageParameters, global::Picsart.GenAIBleedParameters> request,
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate Bleed<br/>
        /// This service offers a groundbreaking functionality designed to enhance digital imagery by enabling users to enlarge any image. <br/>
        /// This service enlarges the original images and generates additional pixels around the original from all sides. This helps print original images without needing to cut part of it during the print production process. The generated bleed area is a continuation of the original image and will ensure a consistent and high cut quality.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.GenaiGenerateImageBleedResponse> GenaiGenerateImageBleedAsync(
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}