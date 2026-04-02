#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Picsart
{
    public partial interface IImageClassificationClient
    {
        /// <summary>
        /// Extract Image Colors<br/>
        /// Extract the key colors from an image to understand its visual style and palette.<br/>
        /// The service analyzes an image and returns up to five prominent colors, including dominant foreground and background tones.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageExtractColorsResponse> ImageExtractColorsAsync(

            global::Picsart.ImageImageParameters request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Extract Image Colors<br/>
        /// Extract the key colors from an image to understand its visual style and palette.<br/>
        /// The service analyzes an image and returns up to five prominent colors, including dominant foreground and background tones.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.AutoSDKHttpResponse<global::Picsart.ImageExtractColorsResponse>> ImageExtractColorsAsResponseAsync(

            global::Picsart.ImageImageParameters request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Extract Image Colors<br/>
        /// Extract the key colors from an image to understand its visual style and palette.<br/>
        /// The service analyzes an image and returns up to five prominent colors, including dominant foreground and background tones.
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
        global::System.Threading.Tasks.Task<global::Picsart.ImageExtractColorsResponse> ImageExtractColorsAsync(
            byte[]? image = default,
            string? imagename = default,
            string? imageUrl = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}