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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageDesignImportResponse> ImageDesignImportAsync(

            global::Picsart.ImageFileParameters request,
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageDesignImportResponse> ImageDesignImportAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}