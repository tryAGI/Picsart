#nullable enable

namespace Picsart
{
    public partial interface IVideoEffectsClient
    {
        /// <summary>
        /// Adjust Video<br/>
        /// Adjusts the input video file with 14 different options.<br/>
        /// **Options:**<br/>
        ///   * Adjust audio and/or volume<br/>
        ///   * Adjust video volume<br/>
        ///   * Adjust brightness and/or contrast<br/>
        ///   * Adjust clarity and/or saturation<br/>
        ///   * Adjust speed and/or reverse the video<br/>
        ///   * Adjust hue and/or shadows<br/>
        ///   * Adjust highlights and/or temperature<br/>
        ///   * Adjust noise or sharpen the video<br/>
        ///   * Adjust vignette<br/>
        /// If you choose an adjustment setting value out of the allowed range, the default value of 0 is used instead.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.VideoAdjustResponse> VideoAdjustAsync(

            global::Picsart.AllOf<global::Picsart.VideoVideoParameters, global::Picsart.VideoAdjustParameters, global::Picsart.VideoExportParameters> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Adjust Video<br/>
        /// Adjusts the input video file with 14 different options.<br/>
        /// **Options:**<br/>
        ///   * Adjust audio and/or volume<br/>
        ///   * Adjust video volume<br/>
        ///   * Adjust brightness and/or contrast<br/>
        ///   * Adjust clarity and/or saturation<br/>
        ///   * Adjust speed and/or reverse the video<br/>
        ///   * Adjust hue and/or shadows<br/>
        ///   * Adjust highlights and/or temperature<br/>
        ///   * Adjust noise or sharpen the video<br/>
        ///   * Adjust vignette<br/>
        /// If you choose an adjustment setting value out of the allowed range, the default value of 0 is used instead.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.AutoSDKHttpResponse<global::Picsart.VideoAdjustResponse>> VideoAdjustAsResponseAsync(

            global::Picsart.AllOf<global::Picsart.VideoVideoParameters, global::Picsart.VideoAdjustParameters, global::Picsart.VideoExportParameters> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Adjust Video<br/>
        /// Adjusts the input video file with 14 different options.<br/>
        /// **Options:**<br/>
        ///   * Adjust audio and/or volume<br/>
        ///   * Adjust video volume<br/>
        ///   * Adjust brightness and/or contrast<br/>
        ///   * Adjust clarity and/or saturation<br/>
        ///   * Adjust speed and/or reverse the video<br/>
        ///   * Adjust hue and/or shadows<br/>
        ///   * Adjust highlights and/or temperature<br/>
        ///   * Adjust noise or sharpen the video<br/>
        ///   * Adjust vignette<br/>
        /// If you choose an adjustment setting value out of the allowed range, the default value of 0 is used instead.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.VideoAdjustResponse> VideoAdjustAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}