#nullable enable

namespace Picsart
{
    public partial interface IImageConversionClient
    {
        /// <summary>
        /// Design Import (beta)<br/>
        /// With the *Design Import* tool you can instantly turn your design files (AI, SVG) into a Replay file (Picsart's proprietary project file format) that can be consumed by the [Photo and Video Editor SDK](https://docs.picsart.io/docs/photo-video-editor-overview).<br/>
        ///   <br/>
        /// Use this to import your existing designs and make them resuable in Picsart.<br/>
        /// **Suported Formats:** Examples of where the vectorizer can be used include:<br/>
        ///   * AI (Adobe Illustrator)<br/>
        ///   * SVG (Scalable Vector Graphics)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageDesignImportResponse> ImageDesignImportAsync(

            global::Picsart.ImageFileParameters request,
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Design Import (beta)<br/>
        /// With the *Design Import* tool you can instantly turn your design files (AI, SVG) into a Replay file (Picsart's proprietary project file format) that can be consumed by the [Photo and Video Editor SDK](https://docs.picsart.io/docs/photo-video-editor-overview).<br/>
        ///   <br/>
        /// Use this to import your existing designs and make them resuable in Picsart.<br/>
        /// **Suported Formats:** Examples of where the vectorizer can be used include:<br/>
        ///   * AI (Adobe Illustrator)<br/>
        ///   * SVG (Scalable Vector Graphics)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.AutoSDKHttpResponse<global::Picsart.ImageDesignImportResponse>> ImageDesignImportAsResponseAsync(

            global::Picsart.ImageFileParameters request,
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Design Import (beta)<br/>
        /// With the *Design Import* tool you can instantly turn your design files (AI, SVG) into a Replay file (Picsart's proprietary project file format) that can be consumed by the [Photo and Video Editor SDK](https://docs.picsart.io/docs/photo-video-editor-overview).<br/>
        ///   <br/>
        /// Use this to import your existing designs and make them resuable in Picsart.<br/>
        /// **Suported Formats:** Examples of where the vectorizer can be used include:<br/>
        ///   * AI (Adobe Illustrator)<br/>
        ///   * SVG (Scalable Vector Graphics)
        /// </summary>
        /// <param name="file">
        /// Source file (binary). (If this parameter is present, the other source parameters must be empty.)
        /// </param>
        /// <param name="filename">
        /// Source file (binary). (If this parameter is present, the other source parameters must be empty.)
        /// </param>
        /// <param name="fileUrl">
        /// Source file URL. (If this parameter is present, the other source parameters must be empty.)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageDesignImportResponse> ImageDesignImportAsync(
            byte[]? file = default,
            string? filename = default,
            string? fileUrl = default,
            global::Picsart.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}