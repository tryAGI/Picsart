#nullable enable

namespace Picsart
{
    public partial interface IGenAIInpaintingImage2ImageClient
    {
        /// <summary>
        /// Smart Background<br/>
        /// The **Smart Background** service elevates photo customization to new heights by offering an innovative solution for altering the backdrop of images. Unlike the traditional "Change Background" feature accessed via the /removebg endpoint, where users must provide a specific image to serve as the new background, **Smart Background** harnesses the power of AI to generate a completely new backdrop based on user descriptions.<br/>
        ///   <br/>
        /// In contrast, the /removebg endpoint's "Change Background" function requires a predetermined image to replace the original backdrop. While effective for straightforward substitutions, it lacks the flexibility and creative potential provided by "Smart Background," where the possibilities for your photo's new setting are limited only by your imagination. Whether you're looking to transport your subjects to exotic locales, whimsical landscapes, or bespoke scenarios, "Smart Background" offers a tailored, AI-generated solution for every photo.<br/>
        ///   <br/>
        /// With Smart Background, users have the unique opportunity to reimagine their photos by simply submitting an image along with a narrative of the desired background. Our advanced AI algorithms then work to seamlessly integrate a bespoke, contextually appropriate scene behind the subject of the photo. This not only allows for unparalleled personalization but also offers a creative freedom unmatched by conventional methods.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.GenaiSmartBackgroundResponse> GenaiSmartBackgroundAsync(

            global::Picsart.AllOf<global::Picsart.GenAIImageParameters, global::Picsart.GenAIInpaintingParameters> request,
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Smart Background<br/>
        /// The **Smart Background** service elevates photo customization to new heights by offering an innovative solution for altering the backdrop of images. Unlike the traditional "Change Background" feature accessed via the /removebg endpoint, where users must provide a specific image to serve as the new background, **Smart Background** harnesses the power of AI to generate a completely new backdrop based on user descriptions.<br/>
        ///   <br/>
        /// In contrast, the /removebg endpoint's "Change Background" function requires a predetermined image to replace the original backdrop. While effective for straightforward substitutions, it lacks the flexibility and creative potential provided by "Smart Background," where the possibilities for your photo's new setting are limited only by your imagination. Whether you're looking to transport your subjects to exotic locales, whimsical landscapes, or bespoke scenarios, "Smart Background" offers a tailored, AI-generated solution for every photo.<br/>
        ///   <br/>
        /// With Smart Background, users have the unique opportunity to reimagine their photos by simply submitting an image along with a narrative of the desired background. Our advanced AI algorithms then work to seamlessly integrate a bespoke, contextually appropriate scene behind the subject of the photo. This not only allows for unparalleled personalization but also offers a creative freedom unmatched by conventional methods.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.AutoSDKHttpResponse<global::Picsart.GenaiSmartBackgroundResponse>> GenaiSmartBackgroundAsResponseAsync(

            global::Picsart.AllOf<global::Picsart.GenAIImageParameters, global::Picsart.GenAIInpaintingParameters> request,
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Smart Background<br/>
        /// The **Smart Background** service elevates photo customization to new heights by offering an innovative solution for altering the backdrop of images. Unlike the traditional "Change Background" feature accessed via the /removebg endpoint, where users must provide a specific image to serve as the new background, **Smart Background** harnesses the power of AI to generate a completely new backdrop based on user descriptions.<br/>
        ///   <br/>
        /// In contrast, the /removebg endpoint's "Change Background" function requires a predetermined image to replace the original backdrop. While effective for straightforward substitutions, it lacks the flexibility and creative potential provided by "Smart Background," where the possibilities for your photo's new setting are limited only by your imagination. Whether you're looking to transport your subjects to exotic locales, whimsical landscapes, or bespoke scenarios, "Smart Background" offers a tailored, AI-generated solution for every photo.<br/>
        ///   <br/>
        /// With Smart Background, users have the unique opportunity to reimagine their photos by simply submitting an image along with a narrative of the desired background. Our advanced AI algorithms then work to seamlessly integrate a bespoke, contextually appropriate scene behind the subject of the photo. This not only allows for unparalleled personalization but also offers a creative freedom unmatched by conventional methods.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.GenaiSmartBackgroundResponse> GenaiSmartBackgroundAsync(
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}