#nullable enable

namespace Picsart
{
    public partial interface IVideoEditClient
    {
        /// <summary>
        /// Edit Video<br/>
        /// Comprehensive editing with one operation. Apply effect, adjust, trim, crop, resize, change codecs, compression, framerates, etc.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.VideoEditResponse> VideoEditAsync(

            global::Picsart.AllOf<global::Picsart.VideoVideoParameters, global::Picsart.VideoEditParameters, global::Picsart.VideoExtendedExportParameters> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Edit Video<br/>
        /// Comprehensive editing with one operation. Apply effect, adjust, trim, crop, resize, change codecs, compression, framerates, etc.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.AutoSDKHttpResponse<global::Picsart.VideoEditResponse>> VideoEditAsResponseAsync(

            global::Picsart.AllOf<global::Picsart.VideoVideoParameters, global::Picsart.VideoEditParameters, global::Picsart.VideoExtendedExportParameters> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Edit Video<br/>
        /// Comprehensive editing with one operation. Apply effect, adjust, trim, crop, resize, change codecs, compression, framerates, etc.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.VideoEditResponse> VideoEditAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}