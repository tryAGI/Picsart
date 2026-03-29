#nullable enable

namespace Picsart
{
    public partial interface IImageUtilitiesClient
    {
        /// <summary>
        /// Upload Image<br/>
        /// The *upload* service is used to upload an image when you want to apply several transformations to it.<br/>
        ///   By uploading an image first, you'll receive a transaction_id which you can use repeatedly for transformations and thereby avoid having to upload an image for each and every one.<br/>
        ///   If you're sure you only want to do a single transformation to an image, there's no benefit to using this service. Just jump right to that service.<br/>
        ///  **Limitations:** Supported source image formats are JPG, PNG, TIFF and WEBP.  <br/>
        ///  **Source Image:**<br/>
        ///    You can source the image by providing a file or a URL to an online image.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageUploadResponse> ImageUploadAsync(

            global::Picsart.ImageUploadParameters request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload Image<br/>
        /// The *upload* service is used to upload an image when you want to apply several transformations to it.<br/>
        ///   By uploading an image first, you'll receive a transaction_id which you can use repeatedly for transformations and thereby avoid having to upload an image for each and every one.<br/>
        ///   If you're sure you only want to do a single transformation to an image, there's no benefit to using this service. Just jump right to that service.<br/>
        ///  **Limitations:** Supported source image formats are JPG, PNG, TIFF and WEBP.  <br/>
        ///  **Source Image:**<br/>
        ///    You can source the image by providing a file or a URL to an online image.
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
        global::System.Threading.Tasks.Task<global::Picsart.ImageUploadResponse> ImageUploadAsync(
            byte[]? image = default,
            string? imagename = default,
            string? imageUrl = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}