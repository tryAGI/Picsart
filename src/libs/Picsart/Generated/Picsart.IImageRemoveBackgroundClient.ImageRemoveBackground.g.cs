#nullable enable

namespace Picsart
{
    public partial interface IImageRemoveBackgroundClient
    {
        /// <summary>
        /// Remove &amp; Change Background<br/>
        /// Discover the magic of seamless background removal with our removebg service, powered by cutting-edge AI technology. Our sophisticated algorithm effortlessly identifies and isolates the foreground,  ensuring every detail from the delicate intricacies of jewelry to the finest strands of hair is captured with unparalleled precision.  Designed to excel across a vast array of use cases, our service guarantees immaculate cutouts,  whether for professional product photos, dynamic campaign graphics, or personal images meant for creative exploration.  Experience flawless edges and exceptional detail preservation every time, elevating your images beyond the ordinary. 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageRemoveBackgroundResponse> ImageRemoveBackgroundAsync(

            global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageRemoveBackgroundParameters> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove &amp; Change Background<br/>
        /// Discover the magic of seamless background removal with our removebg service, powered by cutting-edge AI technology. Our sophisticated algorithm effortlessly identifies and isolates the foreground,  ensuring every detail from the delicate intricacies of jewelry to the finest strands of hair is captured with unparalleled precision.  Designed to excel across a vast array of use cases, our service guarantees immaculate cutouts,  whether for professional product photos, dynamic campaign graphics, or personal images meant for creative exploration.  Experience flawless edges and exceptional detail preservation every time, elevating your images beyond the ordinary. 
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageRemoveBackgroundResponse> ImageRemoveBackgroundAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}