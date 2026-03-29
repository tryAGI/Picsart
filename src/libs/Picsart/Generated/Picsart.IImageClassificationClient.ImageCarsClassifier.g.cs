#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Picsart
{
    public partial interface IImageClassificationClient
    {
        /// <summary>
        /// Classify the Car Image<br/>
        /// The car image *Classifier* service categorizes all provided images. The supported categories are exterior, interior, engine, undercarriage, other.<br/>
        /// It is mandatory that the provided input image is a car image. If the image is not a car image, the service will not generate an error, and the result may not be relevant.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageCarsClassifierResponse> ImageCarsClassifierAsync(

            global::Picsart.ImageImageParameters request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Classify the Car Image<br/>
        /// The car image *Classifier* service categorizes all provided images. The supported categories are exterior, interior, engine, undercarriage, other.<br/>
        /// It is mandatory that the provided input image is a car image. If the image is not a car image, the service will not generate an error, and the result may not be relevant.
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
        global::System.Threading.Tasks.Task<global::Picsart.ImageCarsClassifierResponse> ImageCarsClassifierAsync(
            byte[]? image = default,
            string? imagename = default,
            string? imageUrl = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}