#nullable enable

namespace Picsart
{
    public partial interface IImagePhotoEnhancementClient
    {
        /// <summary>
        /// Ultra Enhance<br/>
        /// *Ultra enhance* is a new upscaling technique with a generative model which provides high frequency detail. It works well on images without noise and preserves details in a superior way.<br/>
        /// **Limitations:** <br/>
        ///  **Minimums/Maximums:**<br/>
        ///    * Up to 64Mpx output images<br/>
        ///  **Examples:**<br/>
        ///    Examples of where ultra enhance can be utilized include the following:<br/>
        ///    * Low resolution images<br/>
        ///    * Images that need smoothing and realistic details <br/>
        ///    * To de-noise an image<br/>
        ///    * Works best with the Face Enhance service<br/>
        ///  **Source Image:**<br/>
        ///    If you plan to upscale enhance an image several times, we recommend you first upload the source image using the *Upload* method and then use the reference image ID. Otherwise, you can source the image by providing a file or a URL to an online image.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageUltraEnhanceResponse> ImageUltraEnhanceAsync(

            global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageUpscaleEnhanceParameters> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Ultra Enhance<br/>
        /// *Ultra enhance* is a new upscaling technique with a generative model which provides high frequency detail. It works well on images without noise and preserves details in a superior way.<br/>
        /// **Limitations:** <br/>
        ///  **Minimums/Maximums:**<br/>
        ///    * Up to 64Mpx output images<br/>
        ///  **Examples:**<br/>
        ///    Examples of where ultra enhance can be utilized include the following:<br/>
        ///    * Low resolution images<br/>
        ///    * Images that need smoothing and realistic details <br/>
        ///    * To de-noise an image<br/>
        ///    * Works best with the Face Enhance service<br/>
        ///  **Source Image:**<br/>
        ///    If you plan to upscale enhance an image several times, we recommend you first upload the source image using the *Upload* method and then use the reference image ID. Otherwise, you can source the image by providing a file or a URL to an online image.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageUltraEnhanceResponse> ImageUltraEnhanceAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}