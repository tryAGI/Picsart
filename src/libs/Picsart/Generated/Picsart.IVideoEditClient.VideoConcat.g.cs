#nullable enable

namespace Picsart
{
    public partial interface IVideoEditClient
    {
        /// <summary>
        /// Concatenate Videos and Images<br/>
        /// Concatenate several videos clips and images with transitions into one timeline. Helpful when adding intro/outro- or creating slideshows.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.VideoConcatResponse> VideoConcatAsync(

            global::Picsart.AllOf<global::Picsart.VideoConcatParameters, global::Picsart.VideoExportParameters> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Concatenate Videos and Images<br/>
        /// Concatenate several videos clips and images with transitions into one timeline. Helpful when adding intro/outro- or creating slideshows.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.VideoConcatResponse> VideoConcatAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}