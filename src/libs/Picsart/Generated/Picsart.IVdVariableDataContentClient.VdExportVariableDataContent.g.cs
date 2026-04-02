#nullable enable

namespace Picsart
{
    public partial interface IVdVariableDataContentClient
    {
        /// <summary>
        /// Export Variable Data Content<br/>
        /// Export your Replays with async API in background to optimize for performance and improve your user experience.<br/>
        /// Customize the output with your data. Here you can provide a CSV file with up to 50 rows and map your data to the variables in the Replay file. For each row in the data file, this service will export a file of the requested type.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.VdExportVariableDataContentResponse> VdExportVariableDataContentAsync(

            global::Picsart.AllOf<global::Picsart.VDTemplateParameters, global::Picsart.VDDataFileParameters, global::Picsart.VDExportVariableDataContentParameters> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Export Variable Data Content<br/>
        /// Export your Replays with async API in background to optimize for performance and improve your user experience.<br/>
        /// Customize the output with your data. Here you can provide a CSV file with up to 50 rows and map your data to the variables in the Replay file. For each row in the data file, this service will export a file of the requested type.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.AutoSDKHttpResponse<global::Picsart.VdExportVariableDataContentResponse>> VdExportVariableDataContentAsResponseAsync(

            global::Picsart.AllOf<global::Picsart.VDTemplateParameters, global::Picsart.VDDataFileParameters, global::Picsart.VDExportVariableDataContentParameters> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Export Variable Data Content<br/>
        /// Export your Replays with async API in background to optimize for performance and improve your user experience.<br/>
        /// Customize the output with your data. Here you can provide a CSV file with up to 50 rows and map your data to the variables in the Replay file. For each row in the data file, this service will export a file of the requested type.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.VdExportVariableDataContentResponse> VdExportVariableDataContentAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}