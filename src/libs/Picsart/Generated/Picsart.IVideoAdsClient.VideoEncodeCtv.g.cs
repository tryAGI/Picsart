#nullable enable

namespace Picsart
{
    public partial interface IVideoAdsClient
    {
        /// <summary>
        /// Make Video CTV-Compatible<br/>
        /// Converts your original video to meet &lt;a href="https://docs.picsart.io/docs/ctv-ads-format-requirements/"&gt;CTV requirements&lt;/a&gt;.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.VideoEncodeCtvResponse> VideoEncodeCtvAsync(

            global::Picsart.VideoVideoParameters request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Make Video CTV-Compatible<br/>
        /// Converts your original video to meet &lt;a href="https://docs.picsart.io/docs/ctv-ads-format-requirements/"&gt;CTV requirements&lt;/a&gt;.
        /// </summary>
        /// <param name="videoUrl">
        /// Source video URL.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.VideoEncodeCtvResponse> VideoEncodeCtvAsync(
            string? videoUrl = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}