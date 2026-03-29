
#nullable enable

namespace Picsart
{
    /// <summary>
    /// Unified Picsart API combining Image Tools, Video Tools, GenAI, and Variable Data Content APIs.<br/>
    /// [Official documentation](https://docs.picsart.io/)<br/>
    /// [Developer Guidelines](https://picsart.io/terms)<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IPicsartClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::Picsart.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }

        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public GenAIInpaintingImage2ImageClient GenAIInpaintingImage2Image { get; }

        /// <summary>
        /// 
        /// </summary>
        public GenAIText2AudioClient GenAIText2Audio { get; }

        /// <summary>
        /// 
        /// </summary>
        public GenAIText2ImageClient GenAIText2Image { get; }

        /// <summary>
        /// 
        /// </summary>
        public GenAIText2TextClient GenAIText2Text { get; }

        /// <summary>
        /// 
        /// </summary>
        public GenAIText2VideoImage2VideoClient GenAIText2VideoImage2Video { get; }

        /// <summary>
        /// 
        /// </summary>
        public GenAIUtilitiesClient GenAIUtilities { get; }

        /// <summary>
        /// 
        /// </summary>
        public ImageClassificationClient ImageClassification { get; }

        /// <summary>
        /// 
        /// </summary>
        public ImageContentGenerationClient ImageContentGeneration { get; }

        /// <summary>
        /// 
        /// </summary>
        public ImageConversionClient ImageConversion { get; }

        /// <summary>
        /// 
        /// </summary>
        public ImageEditingClient ImageEditing { get; }

        /// <summary>
        /// 
        /// </summary>
        public ImageEffectsClient ImageEffects { get; }

        /// <summary>
        /// 
        /// </summary>
        public ImagePhotoEnhancementClient ImagePhotoEnhancement { get; }

        /// <summary>
        /// 
        /// </summary>
        public ImageRemoveBackgroundClient ImageRemoveBackground { get; }

        /// <summary>
        /// 
        /// </summary>
        public ImageSurfacemapClient ImageSurfacemap { get; }

        /// <summary>
        /// 
        /// </summary>
        public ImageUtilitiesClient ImageUtilities { get; }

        /// <summary>
        /// 
        /// </summary>
        public ImageWatermarkClient ImageWatermark { get; }

        /// <summary>
        /// 
        /// </summary>
        public VdReplayClient VdReplay { get; }

        /// <summary>
        /// 
        /// </summary>
        public VdUtilitiesClient VdUtilities { get; }

        /// <summary>
        /// 
        /// </summary>
        public VdVariableDataContentClient VdVariableDataContent { get; }

        /// <summary>
        /// 
        /// </summary>
        public VideoAdsClient VideoAds { get; }

        /// <summary>
        /// 
        /// </summary>
        public VideoAudioClient VideoAudio { get; }

        /// <summary>
        /// 
        /// </summary>
        public VideoEditClient VideoEdit { get; }

        /// <summary>
        /// 
        /// </summary>
        public VideoEffectsClient VideoEffects { get; }

        /// <summary>
        /// 
        /// </summary>
        public VideoMetadataClient VideoMetadata { get; }

        /// <summary>
        /// 
        /// </summary>
        public VideoRemoveBackgroundClient VideoRemoveBackground { get; }

        /// <summary>
        /// 
        /// </summary>
        public VideoTranscriptionsClient VideoTranscriptions { get; }

        /// <summary>
        /// 
        /// </summary>
        public VideoUtilitiesClient VideoUtilities { get; }

        /// <summary>
        /// 
        /// </summary>
        public VideoVideoEnhancementClient VideoVideoEnhancement { get; }

        /// <summary>
        /// 
        /// </summary>
        public VideoWatermarkClient VideoWatermark { get; }

    }
}