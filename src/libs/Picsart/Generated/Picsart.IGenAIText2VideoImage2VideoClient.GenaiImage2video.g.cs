#nullable enable

namespace Picsart
{
    public partial interface IGenAIText2VideoImage2VideoClient
    {
        /// <summary>
        /// Image2Video<br/>
        /// The *Image2Video* service helps generate a video based on the text introduced as input by the user. Considering the time and cost to generate videos, only one video will be generated per request (unlike the image generation services).<br/>
        /// Note, that considering the big number of different models that are supported with this service, some limitations may apply. For example, some models (e.g. Grok Imagine Video / OpenAI Sora 2 / Sora 2 Pro / OVI) don't support the option to disable sound. With these models the result video will always be generated regardless to the provided input params.<br/>
        /// Similarly, note that different models do support different resolutions and output video quality parameters. In this case as well, the output video's resolutions and quality are not guaranteed to be exactly the same as provided input params. The service will provide what's "closer" to the original request. To make sure there are minimal deviations, we recommend doing test requests and checking the output video as well as doing research on original model's official documentation.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.GenaiImage2videoResponse> GenaiImage2videoAsync(

            global::Picsart.AllOf<global::Picsart.GenAIImageParameters, global::Picsart.GenAIText2VideoParameters, global::Picsart.GenAIImage2VideoModels> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Image2Video<br/>
        /// The *Image2Video* service helps generate a video based on the text introduced as input by the user. Considering the time and cost to generate videos, only one video will be generated per request (unlike the image generation services).<br/>
        /// Note, that considering the big number of different models that are supported with this service, some limitations may apply. For example, some models (e.g. Grok Imagine Video / OpenAI Sora 2 / Sora 2 Pro / OVI) don't support the option to disable sound. With these models the result video will always be generated regardless to the provided input params.<br/>
        /// Similarly, note that different models do support different resolutions and output video quality parameters. In this case as well, the output video's resolutions and quality are not guaranteed to be exactly the same as provided input params. The service will provide what's "closer" to the original request. To make sure there are minimal deviations, we recommend doing test requests and checking the output video as well as doing research on original model's official documentation.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.GenaiImage2videoResponse> GenaiImage2videoAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}