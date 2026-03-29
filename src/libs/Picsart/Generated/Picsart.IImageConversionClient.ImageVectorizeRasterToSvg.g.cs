#nullable enable

namespace Picsart
{
    public partial interface IImageConversionClient
    {
        /// <summary>
        /// Image Vectorizer<br/>
        /// With the *vectorizer* tool you can instantly turn your raster image into high quality vector graphic as it converts a PNG image to a SVG image. Using geometric figures, like curves and lines, the vectorizer converts the pixel information of raster input into vector image, which can be enlarged and edited without quality loss.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageVectorizeRasterToSvgResponse> ImageVectorizeRasterToSvgAsync(

            global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageVectorizerParameters> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Image Vectorizer<br/>
        /// With the *vectorizer* tool you can instantly turn your raster image into high quality vector graphic as it converts a PNG image to a SVG image. Using geometric figures, like curves and lines, the vectorizer converts the pixel information of raster input into vector image, which can be enlarged and edited without quality loss.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageVectorizeRasterToSvgResponse> ImageVectorizeRasterToSvgAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}