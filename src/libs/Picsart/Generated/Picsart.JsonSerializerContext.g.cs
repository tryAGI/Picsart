
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Picsart.JsonConverters.ImageExportParametersFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageExportParametersFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageUpscaleParametersFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageUpscaleParametersFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageEffectsParametersEffectNameJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageEffectsParametersEffectNameNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageEffectsParametersFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageEffectsParametersFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageLaserEngravingEffectParametersFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageLaserEngravingEffectParametersFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageAIEffectsParametersEffectNameJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageAIEffectsParametersEffectNameNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageAIEffectsParametersFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageAIEffectsParametersFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageEffectsPreviewsParametersEffectNameJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageEffectsPreviewsParametersEffectNameNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageEffectsPreviewsParametersFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageEffectsPreviewsParametersFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageAdjustParametersFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageAdjustParametersFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageSelectiveBlurParametersFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageSelectiveBlurParametersFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageSmartCropParametersRatioJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageSmartCropParametersRatioNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageSmartCropParametersFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageSmartCropParametersFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageZoomParametersAnchorPointJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageZoomParametersAnchorPointNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageZoomParametersFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageZoomParametersFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageColorTransferParametersFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageColorTransferParametersFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageStyleTransferParametersLevelJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageStyleTransferParametersLevelNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageStyleTransferParametersFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageStyleTransferParametersFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageRemoveBackgroundParametersOutputTypeJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageRemoveBackgroundParametersOutputTypeNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageRemoveBackgroundParametersScaleJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageRemoveBackgroundParametersScaleNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageRemoveBackgroundParametersShadowJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageRemoveBackgroundParametersShadowNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageRemoveBackgroundParametersModelJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageRemoveBackgroundParametersModelNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageRemoveBackgroundParametersFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageRemoveBackgroundParametersFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageRemoveBackgroundParametersJSONOutputTypeJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageRemoveBackgroundParametersJSONOutputTypeNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageRemoveBackgroundParametersJSONScaleJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageRemoveBackgroundParametersJSONScaleNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageRemoveBackgroundParametersJSONShadowJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageRemoveBackgroundParametersJSONShadowNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageRemoveBackgroundParametersJSONModelJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageRemoveBackgroundParametersJSONModelNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageRemoveBackgroundParametersJSONFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageRemoveBackgroundParametersJSONFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageMultiMattingSegmentationParametersSegmentationClassJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageMultiMattingSegmentationParametersSegmentationClassNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageMasksParametersFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageMasksParametersFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageMasksParametersBlendJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageMasksParametersBlendNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageMasksParametersMaskJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageMasksParametersMaskNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageMasksParametersMaskFlipJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageMasksParametersMaskFlipNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageMasksPreviewParametersFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageMasksPreviewParametersFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageMasksPreviewParametersBlendJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageMasksPreviewParametersBlendNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageMasksPreviewParametersMaskItemJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageMasksPreviewParametersMaskItemNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageMasksPreviewParametersMaskFlipJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageMasksPreviewParametersMaskFlipNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageTextureParametersFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageTextureParametersFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageTextureParametersPatternJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageTextureParametersPatternNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageUpscaleUltraParametersProductTypeJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageUpscaleUltraParametersProductTypeNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageUpscaleUltraParametersImageTypeJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageUpscaleUltraParametersImageTypeNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageUpscaleUltraParametersModeJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageUpscaleUltraParametersModeNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageUpscaleUltraParametersFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageUpscaleUltraParametersFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageUpscaleEnhanceParametersFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageUpscaleEnhanceParametersFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageSurfacemapParametersFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageSurfacemapParametersFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageFaceEnhanceParametersFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageFaceEnhanceParametersFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageEditParametersFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageEditParametersFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageEditParametersModeJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageEditParametersModeNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageEditParametersCropAnchorJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageEditParametersCropAnchorNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageEditParametersFlipJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageEditParametersFlipNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageOverlayParametersBlendModeJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageOverlayParametersBlendModeNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageOverlayParametersFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageOverlayParametersFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageWatermarkParametersAnchorPointJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageWatermarkParametersAnchorPointNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoExportParametersExportFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoExportParametersExportFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoExtendedExportParametersExportFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoExtendedExportParametersExportFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoExtendedExportParametersExportQualityJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoExtendedExportParametersExportQualityNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoExtendedExportParametersExportCodecJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoExtendedExportParametersExportCodecNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoExtendedExportParametersExportAudioCodecJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoExtendedExportParametersExportAudioCodecNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoExtendedExportParametersExportColorSpaceJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoExtendedExportParametersExportColorSpaceNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoTranscribeParametersLanguageJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoTranscribeParametersLanguageNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoTranscribeParametersFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoTranscribeParametersFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoTranscribeParametersGranularityJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoTranscribeParametersGranularityNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoExtractAudioParametersFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoExtractAudioParametersFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoEffectsParametersEffectNameJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoEffectsParametersEffectNameNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoVideoGetThumbnailParametersSourceJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoVideoGetThumbnailParametersSourceNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoTransitionTransitionJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoTransitionTransitionNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoConcatImageParametersScaleJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoConcatImageParametersScaleNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoConcatSegmentsParametersTrimSegmentTransitionJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoConcatSegmentsParametersTrimSegmentTransitionNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoWatermarkParametersAnchorPointJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoWatermarkParametersAnchorPointNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIText2TextModelsModelJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIText2TextModelsModelNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIText2VideoParametersQualityJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIText2VideoParametersQualityNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIText2SpeechParametersLanguageJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIText2SpeechParametersLanguageNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIText2SpeechModelsModelJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIText2SpeechModelsModelNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIText2SoundModelsModelJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIText2SoundModelsModelNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIText2ImageModelsModelJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIText2ImageModelsModelNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIText2StickerModelsModelJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIText2StickerModelsModelNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAILogoModelsModelJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAILogoModelsModelNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIText2VideoModelsModelJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIText2VideoModelsModelNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIImage2VideoModelsModelJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIImage2VideoModelsModelNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAILaserEngravingParametersFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAILaserEngravingParametersFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAILaserEngravingModelsModelJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAILaserEngravingModelsModelNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAILogoParametersColorToneJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAILogoParametersColorToneNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIInpaintingParametersFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIInpaintingParametersFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIInpaintingParametersModeJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIInpaintingParametersModeNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIRemoveObjectParametersFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIRemoveObjectParametersFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIRemoveObjectParametersModeJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIRemoveObjectParametersModeNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIExpandParametersDirectionJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIExpandParametersDirectionNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIExpandParametersFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIExpandParametersFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIExpandParametersModeJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIExpandParametersModeNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIBleedParametersFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIBleedParametersFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VDExportReplayParametersFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.VDExportReplayParametersFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VDExportVariableDataContentParametersFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.VDExportVariableDataContentParametersFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageCarsClassifierResponseDataClassJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageCarsClassifierResponseDataClassNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoUpscaleFpsResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoUpscaleFpsResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoUpscaleFpsGetresultResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoUpscaleFpsGetresultResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoUpscaleFpsGetresultResponseStatus2JsonConverter),

            typeof(global::Picsart.JsonConverters.VideoUpscaleFpsGetresultResponseStatus2NullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoRemoveBackgroundResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoRemoveBackgroundResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoAdjustResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoAdjustResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoApplyEffectResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoApplyEffectResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoEditResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoEditResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoTrimResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoTrimResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoCropResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoCropResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoConcatResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoConcatResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoConcatHighlightsResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoConcatHighlightsResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoFitResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoFitResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoMetadataResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoMetadataResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoGetThumbnailResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoGetThumbnailResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoSetThumbnailResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoSetThumbnailResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoSetThumbnailGetresultResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoSetThumbnailGetresultResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoSetThumbnailGetresultResponseStatus2JsonConverter),

            typeof(global::Picsart.JsonConverters.VideoSetThumbnailGetresultResponseStatus2NullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoEncodeCtvResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoEncodeCtvResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoAdjustAudioResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoAdjustAudioResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoExtractAudioResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoExtractAudioResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoTranscribeAudioResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoTranscribeAudioResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoTranscribeAudioGetresultResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoTranscribeAudioGetresultResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoTranscribeAudioGetresultResponseStatus2JsonConverter),

            typeof(global::Picsart.JsonConverters.VideoTranscribeAudioGetresultResponseStatus2NullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoAddWatermarkResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoAddWatermarkResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoGetresultResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoGetresultResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoGetresultResponseStatus2JsonConverter),

            typeof(global::Picsart.JsonConverters.VideoGetresultResponseStatus2NullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoGetaudioresultResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoGetaudioresultResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoGetaudioresultResponseStatus2JsonConverter),

            typeof(global::Picsart.JsonConverters.VideoGetaudioresultResponseStatus2NullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoUploadResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoUploadResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenaiText2imageResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.GenaiText2imageResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenaiText2imageGetresultResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.GenaiText2imageGetresultResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenaiText2stickerResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.GenaiText2stickerResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenaiText2stickerLaserEngravingResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.GenaiText2stickerLaserEngravingResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenaiText2stickerGetresultResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.GenaiText2stickerGetresultResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenaiGenerateLogoResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.GenaiGenerateLogoResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenaiGenerateLogoGetresultResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.GenaiGenerateLogoGetresultResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenaiText2videoResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.GenaiText2videoResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenaiImage2videoResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.GenaiImage2videoResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenaiText2videoGetresultResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.GenaiText2videoGetresultResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenaiText2speechResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.GenaiText2speechResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenaiText2soundResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.GenaiText2soundResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenaiText2audioGetresultResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.GenaiText2audioGetresultResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VdDescribeVariableDataContentResponseDataTagTypeJsonConverter),

            typeof(global::Picsart.JsonConverters.VdDescribeVariableDataContentResponseDataTagTypeNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.VideoConcatVideoParameters, global::Picsart.VideoConcatImageParameters, global::Picsart.VideoTransition>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageRemoveBackgroundParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageUpscaleParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageUpscaleUltraParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageUpscaleEnhanceParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageFaceEnhanceParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageEffectsParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageEffectsPreviewsParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageLaserEngravingEffectParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageAIEffectsParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageAdjustParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageSelectiveBlurParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageColorTransferParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageStyleTransferParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageMasksPreviewParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageMasksParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageTextureParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageTextureParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageVectorizerParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageSurfacemapParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageWatermarkParameters, global::Picsart.ImageExportParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageEditParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageSmartCropParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageOverlayParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageZoomParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageMultiMattingSegmentationParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.VideoVideoParameters, global::Picsart.VideoRemoveBackgroundParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.VideoVideoParameters, global::Picsart.VideoAdjustParameters, global::Picsart.VideoExportParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.VideoVideoParameters, global::Picsart.VideoEffectsParameters, global::Picsart.VideoExportParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.VideoVideoParameters, global::Picsart.VideoEditParameters, global::Picsart.VideoExtendedExportParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.VideoVideoParameters, global::Picsart.VideoTrimParameters, global::Picsart.VideoExportParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.VideoVideoParameters, global::Picsart.VideoCropParameters, global::Picsart.VideoExportParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.VideoConcatParameters, global::Picsart.VideoExportParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.VideoVideoParameters, global::Picsart.VideoConcatSegmentsParameters, global::Picsart.VideoExportParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.VideoVideoParameters, global::Picsart.VideoFitParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.VideoVideoParameters, global::Picsart.VideoVideoGetThumbnailParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.VideoVideoParameters, global::Picsart.VideoImageParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.VideoVideoParameters, global::Picsart.VideoAdjustAudioParameters, global::Picsart.VideoExportParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.VideoVideoParameters, global::Picsart.VideoExtractAudioParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.VideoTranscribeFileParameters, global::Picsart.VideoTranscribeParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.VideoVideoParameters, global::Picsart.VideoWatermarkParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.GenAIText2TextCompletionsParameters, global::Picsart.GenAIText2TextModels>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.GenAIText2ImageParameters, global::Picsart.GenAIText2ImageModels>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.GenAIText2ImageParameters, global::Picsart.GenAIText2StickerModels>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.GenAIText2ImageParameters, global::Picsart.GenAILaserEngravingParameters, global::Picsart.GenAILaserEngravingModels>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.GenAILogoParameters, global::Picsart.GenAILogoModels>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.GenAIImageParameters, global::Picsart.GenAIMaskParameters, global::Picsart.GenAIInpaintingParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.GenAIImageParameters, global::Picsart.GenAIMaskParameters, global::Picsart.GenAIInpaintingParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.GenAIImageParameters, global::Picsart.GenAIMaskParameters, global::Picsart.GenAIRemoveObjectParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.GenAIImageParameters, global::Picsart.GenAIInpaintingParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.GenAIImageParameters, global::Picsart.GenAIExpandParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.GenAIImageParameters, global::Picsart.GenAIBleedParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.GenAIText2VideoParameters, global::Picsart.GenAIText2VideoModels>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.GenAIImageParameters, global::Picsart.GenAIText2VideoParameters, global::Picsart.GenAIImage2VideoModels>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.GenAIText2SpeechParameters, global::Picsart.GenAIText2SpeechModels>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.GenAIText2SoundParameters, global::Picsart.GenAIText2SoundModels>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.VDFileParameters, global::Picsart.VDExportReplayParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.VDTemplateParameters, global::Picsart.VDDataFileParameters, global::Picsart.VDExportVariableDataContentParameters>),

            typeof(global::Picsart.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageUploadParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageImageParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageFileParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageImageParametersJSON))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageFileParametersJSON))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageExportParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageExportParametersFormat), TypeInfoPropertyName = "ImageExportParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageUpscaleParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageUpscaleParametersFormat), TypeInfoPropertyName = "ImageUpscaleParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageEffectsParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageEffectsParametersEffectName), TypeInfoPropertyName = "ImageEffectsParametersEffectName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageEffectsParametersFormat), TypeInfoPropertyName = "ImageEffectsParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageLaserEngravingEffectParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageLaserEngravingEffectParametersFormat), TypeInfoPropertyName = "ImageLaserEngravingEffectParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageAIEffectsParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageAIEffectsParametersEffectName), TypeInfoPropertyName = "ImageAIEffectsParametersEffectName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageAIEffectsParametersFormat), TypeInfoPropertyName = "ImageAIEffectsParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageEffectsPreviewsParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Picsart.ImageEffectsPreviewsParametersEffectName>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageEffectsPreviewsParametersEffectName), TypeInfoPropertyName = "ImageEffectsPreviewsParametersEffectName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageEffectsPreviewsParametersFormat), TypeInfoPropertyName = "ImageEffectsPreviewsParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageAdjustParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageAdjustParametersFormat), TypeInfoPropertyName = "ImageAdjustParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageSelectiveBlurParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageSelectiveBlurParametersFormat), TypeInfoPropertyName = "ImageSelectiveBlurParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageSmartCropParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageSmartCropParametersRatio), TypeInfoPropertyName = "ImageSmartCropParametersRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageSmartCropParametersFormat), TypeInfoPropertyName = "ImageSmartCropParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageZoomParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageZoomParametersAnchorPoint), TypeInfoPropertyName = "ImageZoomParametersAnchorPoint2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageZoomParametersFormat), TypeInfoPropertyName = "ImageZoomParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageColorTransferParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageColorTransferParametersFormat), TypeInfoPropertyName = "ImageColorTransferParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageStyleTransferParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageStyleTransferParametersLevel), TypeInfoPropertyName = "ImageStyleTransferParametersLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageStyleTransferParametersFormat), TypeInfoPropertyName = "ImageStyleTransferParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageRemoveBackgroundParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageRemoveBackgroundParametersOutputType), TypeInfoPropertyName = "ImageRemoveBackgroundParametersOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageRemoveBackgroundParametersScale), TypeInfoPropertyName = "ImageRemoveBackgroundParametersScale2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageRemoveBackgroundParametersShadow), TypeInfoPropertyName = "ImageRemoveBackgroundParametersShadow2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageRemoveBackgroundParametersModel), TypeInfoPropertyName = "ImageRemoveBackgroundParametersModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageRemoveBackgroundParametersFormat), TypeInfoPropertyName = "ImageRemoveBackgroundParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageRemoveBackgroundParametersJSON))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageRemoveBackgroundParametersJSONOutputType), TypeInfoPropertyName = "ImageRemoveBackgroundParametersJSONOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageRemoveBackgroundParametersJSONScale), TypeInfoPropertyName = "ImageRemoveBackgroundParametersJSONScale2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageRemoveBackgroundParametersJSONShadow), TypeInfoPropertyName = "ImageRemoveBackgroundParametersJSONShadow2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageRemoveBackgroundParametersJSONModel), TypeInfoPropertyName = "ImageRemoveBackgroundParametersJSONModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageRemoveBackgroundParametersJSONFormat), TypeInfoPropertyName = "ImageRemoveBackgroundParametersJSONFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageMultiMattingSegmentationParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageMultiMattingSegmentationParametersSegmentationClass), TypeInfoPropertyName = "ImageMultiMattingSegmentationParametersSegmentationClass2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageMasksParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageMasksParametersFormat), TypeInfoPropertyName = "ImageMasksParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageMasksParametersBlend), TypeInfoPropertyName = "ImageMasksParametersBlend2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageMasksParametersMask), TypeInfoPropertyName = "ImageMasksParametersMask2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageMasksParametersMaskFlip), TypeInfoPropertyName = "ImageMasksParametersMaskFlip2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageMasksPreviewParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageMasksPreviewParametersFormat), TypeInfoPropertyName = "ImageMasksPreviewParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageMasksPreviewParametersBlend), TypeInfoPropertyName = "ImageMasksPreviewParametersBlend2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Picsart.ImageMasksPreviewParametersMaskItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageMasksPreviewParametersMaskItem), TypeInfoPropertyName = "ImageMasksPreviewParametersMaskItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageMasksPreviewParametersMaskFlip), TypeInfoPropertyName = "ImageMasksPreviewParametersMaskFlip2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageTextureParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageTextureParametersFormat), TypeInfoPropertyName = "ImageTextureParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageTextureParametersPattern), TypeInfoPropertyName = "ImageTextureParametersPattern2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageVectorizerParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageUpscaleUltraParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageUpscaleUltraParametersProductType), TypeInfoPropertyName = "ImageUpscaleUltraParametersProductType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageUpscaleUltraParametersImageType), TypeInfoPropertyName = "ImageUpscaleUltraParametersImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageUpscaleUltraParametersMode), TypeInfoPropertyName = "ImageUpscaleUltraParametersMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageUpscaleUltraParametersFormat), TypeInfoPropertyName = "ImageUpscaleUltraParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageUpscaleEnhanceParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageUpscaleEnhanceParametersFormat), TypeInfoPropertyName = "ImageUpscaleEnhanceParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageSurfacemapParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageSurfacemapParametersFormat), TypeInfoPropertyName = "ImageSurfacemapParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageFaceEnhanceParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageFaceEnhanceParametersFormat), TypeInfoPropertyName = "ImageFaceEnhanceParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageEditParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageEditParametersFormat), TypeInfoPropertyName = "ImageEditParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageEditParametersMode), TypeInfoPropertyName = "ImageEditParametersMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageEditParametersCropAnchor), TypeInfoPropertyName = "ImageEditParametersCropAnchor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageEditParametersFlip), TypeInfoPropertyName = "ImageEditParametersFlip2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageOverlayParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageOverlayParametersBlendMode), TypeInfoPropertyName = "ImageOverlayParametersBlendMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageOverlayParametersFormat), TypeInfoPropertyName = "ImageOverlayParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageWatermarkParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageWatermarkParametersAnchorPoint), TypeInfoPropertyName = "ImageWatermarkParametersAnchorPoint2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.Image401Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoFileParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoTranscribeFileParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoVideoParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoImageParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoExportParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoExportParametersExport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoExportParametersExportFormat), TypeInfoPropertyName = "VideoExportParametersExportFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoExtendedExportParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoExtendedExportParametersExport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoExtendedExportParametersExportFormat), TypeInfoPropertyName = "VideoExtendedExportParametersExportFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoExtendedExportParametersExportQuality), TypeInfoPropertyName = "VideoExtendedExportParametersExportQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoExtendedExportParametersExportCodec), TypeInfoPropertyName = "VideoExtendedExportParametersExportCodec2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoExtendedExportParametersExportAudioCodec), TypeInfoPropertyName = "VideoExtendedExportParametersExportAudioCodec2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoExtendedExportParametersExportColorSpace), TypeInfoPropertyName = "VideoExtendedExportParametersExportColorSpace2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoRemoveBackgroundParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoTranscribeParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoTranscribeParametersLanguage), TypeInfoPropertyName = "VideoTranscribeParametersLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoTranscribeParametersFormat), TypeInfoPropertyName = "VideoTranscribeParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoTranscribeParametersGranularity), TypeInfoPropertyName = "VideoTranscribeParametersGranularity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoExtractAudioParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoExtractAudioParametersFormat), TypeInfoPropertyName = "VideoExtractAudioParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoAdjustParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoAdjustAudioParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoEffectsParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoEffectsParametersEffectName), TypeInfoPropertyName = "VideoEffectsParametersEffectName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoTrimParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoCropParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoEditParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoFitParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoVideoGetThumbnailParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoVideoGetThumbnailParametersSource), TypeInfoPropertyName = "VideoVideoGetThumbnailParametersSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoTransition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoTransitionTransition), TypeInfoPropertyName = "VideoTransitionTransition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoConcatParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Picsart.AllOf<global::Picsart.VideoConcatVideoParameters, global::Picsart.VideoConcatImageParameters, global::Picsart.VideoTransition>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.VideoConcatVideoParameters, global::Picsart.VideoConcatImageParameters, global::Picsart.VideoTransition>), TypeInfoPropertyName = "AllOfVideoConcatVideoParametersVideoConcatImageParametersVideoTransition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoConcatVideoParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoConcatImageParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoConcatImageParametersScale), TypeInfoPropertyName = "VideoConcatImageParametersScale2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoConcatSegmentsParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Picsart.VideoConcatSegmentsParametersTrimSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoConcatSegmentsParametersTrimSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoConcatSegmentsParametersTrimSegmentTransition), TypeInfoPropertyName = "VideoConcatSegmentsParametersTrimSegmentTransition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoWatermarkParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoWatermarkParametersAnchorPoint), TypeInfoPropertyName = "VideoWatermarkParametersAnchorPoint2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoUploadParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.Video401Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIText2TextCompletionsParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Picsart.GenAIText2TextCompletionsParametersMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIText2TextCompletionsParametersMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIText2TextModels))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIText2TextModelsModel), TypeInfoPropertyName = "GenAIText2TextModelsModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIText2ImageParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIText2VideoParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIText2VideoParametersQuality), TypeInfoPropertyName = "GenAIText2VideoParametersQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIText2SpeechParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIText2SpeechParametersLanguage), TypeInfoPropertyName = "GenAIText2SpeechParametersLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIText2SpeechModels))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIText2SpeechModelsModel), TypeInfoPropertyName = "GenAIText2SpeechModelsModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIText2SoundParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIText2SoundModels))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIText2SoundModelsModel), TypeInfoPropertyName = "GenAIText2SoundModelsModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIText2ImageModels))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIText2ImageModelsModel), TypeInfoPropertyName = "GenAIText2ImageModelsModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIText2StickerModels))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIText2StickerModelsModel), TypeInfoPropertyName = "GenAIText2StickerModelsModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAILogoModels))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAILogoModelsModel), TypeInfoPropertyName = "GenAILogoModelsModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIText2VideoModels))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIText2VideoModelsModel), TypeInfoPropertyName = "GenAIText2VideoModelsModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIImage2VideoModels))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIImage2VideoModelsModel), TypeInfoPropertyName = "GenAIImage2VideoModelsModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAILaserEngravingParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAILaserEngravingParametersFormat), TypeInfoPropertyName = "GenAILaserEngravingParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAILaserEngravingModels))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAILaserEngravingModelsModel), TypeInfoPropertyName = "GenAILaserEngravingModelsModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAILogoParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAILogoParametersColorTone), TypeInfoPropertyName = "GenAILogoParametersColorTone2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIImageParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIMaskParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIInpaintingParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIInpaintingParametersFormat), TypeInfoPropertyName = "GenAIInpaintingParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIInpaintingParametersMode), TypeInfoPropertyName = "GenAIInpaintingParametersMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIRemoveObjectParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIRemoveObjectParametersFormat), TypeInfoPropertyName = "GenAIRemoveObjectParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIRemoveObjectParametersMode), TypeInfoPropertyName = "GenAIRemoveObjectParametersMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIExpandParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIExpandParametersDirection), TypeInfoPropertyName = "GenAIExpandParametersDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIExpandParametersFormat), TypeInfoPropertyName = "GenAIExpandParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIExpandParametersMode), TypeInfoPropertyName = "GenAIExpandParametersMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIBleedParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIBleedParametersFormat), TypeInfoPropertyName = "GenAIBleedParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VDUploadParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VDImageParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VDFileParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VDDataFileParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VDTemplateParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VDExportReplayParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VDExportReplayParametersFormat), TypeInfoPropertyName = "VDExportReplayParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VDExportVariableDataContentParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VDExportVariableDataContentParametersFormat), TypeInfoPropertyName = "VDExportVariableDataContentParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VDError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.Vd401Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageRemoveBackgroundParameters>), TypeInfoPropertyName = "AllOfImageImageParametersImageRemoveBackgroundParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageUpscaleParameters>), TypeInfoPropertyName = "AllOfImageImageParametersImageUpscaleParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageUpscaleUltraParameters>), TypeInfoPropertyName = "AllOfImageImageParametersImageUpscaleUltraParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageUpscaleEnhanceParameters>), TypeInfoPropertyName = "AllOfImageImageParametersImageUpscaleEnhanceParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageFaceEnhanceParameters>), TypeInfoPropertyName = "AllOfImageImageParametersImageFaceEnhanceParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageEffectsParameters>), TypeInfoPropertyName = "AllOfImageImageParametersImageEffectsParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageEffectsPreviewsParameters>), TypeInfoPropertyName = "AllOfImageImageParametersImageEffectsPreviewsParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageLaserEngravingEffectParameters>), TypeInfoPropertyName = "AllOfImageImageParametersImageLaserEngravingEffectParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageAIEffectsParameters>), TypeInfoPropertyName = "AllOfImageImageParametersImageAIEffectsParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageAdjustParameters>), TypeInfoPropertyName = "AllOfImageImageParametersImageAdjustParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageSelectiveBlurParameters>), TypeInfoPropertyName = "AllOfImageImageParametersImageSelectiveBlurParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageColorTransferParameters>), TypeInfoPropertyName = "AllOfImageImageParametersImageColorTransferParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageStyleTransferParameters>), TypeInfoPropertyName = "AllOfImageImageParametersImageStyleTransferParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageMasksPreviewParameters>), TypeInfoPropertyName = "AllOfImageImageParametersImageMasksPreviewParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageMasksParameters>), TypeInfoPropertyName = "AllOfImageImageParametersImageMasksParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageTextureParameters>), TypeInfoPropertyName = "AllOfImageImageParametersImageTextureParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageVectorizerParameters>), TypeInfoPropertyName = "AllOfImageImageParametersImageVectorizerParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageSurfacemapParameters>), TypeInfoPropertyName = "AllOfImageImageParametersImageSurfacemapParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageWatermarkParameters, global::Picsart.ImageExportParameters>), TypeInfoPropertyName = "AllOfImageImageParametersImageWatermarkParametersImageExportParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageEditParameters>), TypeInfoPropertyName = "AllOfImageImageParametersImageEditParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageSmartCropParameters>), TypeInfoPropertyName = "AllOfImageImageParametersImageSmartCropParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageOverlayParameters>), TypeInfoPropertyName = "AllOfImageImageParametersImageOverlayParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageZoomParameters>), TypeInfoPropertyName = "AllOfImageImageParametersImageZoomParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageMultiMattingSegmentationParameters>), TypeInfoPropertyName = "AllOfImageImageParametersImageMultiMattingSegmentationParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.VideoVideoParameters, global::Picsart.VideoRemoveBackgroundParameters>), TypeInfoPropertyName = "AllOfVideoVideoParametersVideoRemoveBackgroundParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.VideoVideoParameters, global::Picsart.VideoAdjustParameters, global::Picsart.VideoExportParameters>), TypeInfoPropertyName = "AllOfVideoVideoParametersVideoAdjustParametersVideoExportParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.VideoVideoParameters, global::Picsart.VideoEffectsParameters, global::Picsart.VideoExportParameters>), TypeInfoPropertyName = "AllOfVideoVideoParametersVideoEffectsParametersVideoExportParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.VideoVideoParameters, global::Picsart.VideoEditParameters, global::Picsart.VideoExtendedExportParameters>), TypeInfoPropertyName = "AllOfVideoVideoParametersVideoEditParametersVideoExtendedExportParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.VideoVideoParameters, global::Picsart.VideoTrimParameters, global::Picsart.VideoExportParameters>), TypeInfoPropertyName = "AllOfVideoVideoParametersVideoTrimParametersVideoExportParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.VideoVideoParameters, global::Picsart.VideoCropParameters, global::Picsart.VideoExportParameters>), TypeInfoPropertyName = "AllOfVideoVideoParametersVideoCropParametersVideoExportParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.VideoConcatParameters, global::Picsart.VideoExportParameters>), TypeInfoPropertyName = "AllOfVideoConcatParametersVideoExportParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.VideoVideoParameters, global::Picsart.VideoConcatSegmentsParameters, global::Picsart.VideoExportParameters>), TypeInfoPropertyName = "AllOfVideoVideoParametersVideoConcatSegmentsParametersVideoExportParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.VideoVideoParameters, global::Picsart.VideoFitParameters>), TypeInfoPropertyName = "AllOfVideoVideoParametersVideoFitParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.VideoVideoParameters, global::Picsart.VideoVideoGetThumbnailParameters>), TypeInfoPropertyName = "AllOfVideoVideoParametersVideoVideoGetThumbnailParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.VideoVideoParameters, global::Picsart.VideoImageParameters>), TypeInfoPropertyName = "AllOfVideoVideoParametersVideoImageParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.VideoVideoParameters, global::Picsart.VideoAdjustAudioParameters, global::Picsart.VideoExportParameters>), TypeInfoPropertyName = "AllOfVideoVideoParametersVideoAdjustAudioParametersVideoExportParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.VideoVideoParameters, global::Picsart.VideoExtractAudioParameters>), TypeInfoPropertyName = "AllOfVideoVideoParametersVideoExtractAudioParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.VideoTranscribeFileParameters, global::Picsart.VideoTranscribeParameters>), TypeInfoPropertyName = "AllOfVideoTranscribeFileParametersVideoTranscribeParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.VideoVideoParameters, global::Picsart.VideoWatermarkParameters>), TypeInfoPropertyName = "AllOfVideoVideoParametersVideoWatermarkParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.GenAIText2TextCompletionsParameters, global::Picsart.GenAIText2TextModels>), TypeInfoPropertyName = "AllOfGenAIText2TextCompletionsParametersGenAIText2TextModels2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.GenAIText2ImageParameters, global::Picsart.GenAIText2ImageModels>), TypeInfoPropertyName = "AllOfGenAIText2ImageParametersGenAIText2ImageModels2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.GenAIText2ImageParameters, global::Picsart.GenAIText2StickerModels>), TypeInfoPropertyName = "AllOfGenAIText2ImageParametersGenAIText2StickerModels2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.GenAIText2ImageParameters, global::Picsart.GenAILaserEngravingParameters, global::Picsart.GenAILaserEngravingModels>), TypeInfoPropertyName = "AllOfGenAIText2ImageParametersGenAILaserEngravingParametersGenAILaserEngravingModels2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.GenAILogoParameters, global::Picsart.GenAILogoModels>), TypeInfoPropertyName = "AllOfGenAILogoParametersGenAILogoModels2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.GenAIImageParameters, global::Picsart.GenAIMaskParameters, global::Picsart.GenAIInpaintingParameters>), TypeInfoPropertyName = "AllOfGenAIImageParametersGenAIMaskParametersGenAIInpaintingParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.GenAIImageParameters, global::Picsart.GenAIMaskParameters, global::Picsart.GenAIRemoveObjectParameters>), TypeInfoPropertyName = "AllOfGenAIImageParametersGenAIMaskParametersGenAIRemoveObjectParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.GenAIImageParameters, global::Picsart.GenAIInpaintingParameters>), TypeInfoPropertyName = "AllOfGenAIImageParametersGenAIInpaintingParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.GenAIImageParameters, global::Picsart.GenAIExpandParameters>), TypeInfoPropertyName = "AllOfGenAIImageParametersGenAIExpandParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.GenAIImageParameters, global::Picsart.GenAIBleedParameters>), TypeInfoPropertyName = "AllOfGenAIImageParametersGenAIBleedParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.GenAIText2VideoParameters, global::Picsart.GenAIText2VideoModels>), TypeInfoPropertyName = "AllOfGenAIText2VideoParametersGenAIText2VideoModels2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.GenAIImageParameters, global::Picsart.GenAIText2VideoParameters, global::Picsart.GenAIImage2VideoModels>), TypeInfoPropertyName = "AllOfGenAIImageParametersGenAIText2VideoParametersGenAIImage2VideoModels2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.GenAIText2SpeechParameters, global::Picsart.GenAIText2SpeechModels>), TypeInfoPropertyName = "AllOfGenAIText2SpeechParametersGenAIText2SpeechModels2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.GenAIText2SoundParameters, global::Picsart.GenAIText2SoundModels>), TypeInfoPropertyName = "AllOfGenAIText2SoundParametersGenAIText2SoundModels2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.VDFileParameters, global::Picsart.VDExportReplayParameters>), TypeInfoPropertyName = "AllOfVDFileParametersVDExportReplayParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.VDTemplateParameters, global::Picsart.VDDataFileParameters, global::Picsart.VDExportVariableDataContentParameters>), TypeInfoPropertyName = "AllOfVDTemplateParametersVDDataFileParametersVDExportVariableDataContentParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageRemoveBackgroundResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageRemoveBackgroundResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageUpscaleResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageUpscaleResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageUltraUpscaleResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageUltraUpscaleResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageUltraUpscaleResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageUltraUpscaleGetresultResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageUltraUpscaleGetresultResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageUltraUpscaleGetresultResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageUltraEnhanceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageUltraEnhanceResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageFaceEnhanceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageFaceEnhanceResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageListEffectNamesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Picsart.ImageListEffectNamesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageListEffectNamesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageApplyEffectResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageApplyEffectResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageCreateEffectPreviewsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Picsart.ImageCreateEffectPreviewsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageCreateEffectPreviewsResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageApplyLaserEngravingEffectResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageApplyLaserEngravingEffectResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageListAiEffectNamesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Picsart.ImageListAiEffectNamesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageListAiEffectNamesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageApplyAiEffectResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageApplyAiEffectResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageAdjustResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageAdjustResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageSelectiveBlurResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageSelectiveBlurResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageTransferColorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageTransferColorResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageTransferStyleResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageTransferStyleResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageCreateMaskPreviewsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Picsart.ImageCreateMaskPreviewsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageCreateMaskPreviewsResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageApplyMaskResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageApplyMaskResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageGenerateTextureResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageGenerateTextureResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageGeneratePatternResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageGeneratePatternResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageVectorizeRasterToSvgResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageVectorizeRasterToSvgResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageDesignImportResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageDesignImportGetresultResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageDesignImportGetresultResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageDesignImportGetresultResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageSurfacemapResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageSurfacemapResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageAddWatermarkResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageAddWatermarkResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageUploadResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageUploadResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageCreditsBalanceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageEditResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageEditResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageSmartCropResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageSmartCropResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageBlendResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageBlendResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageZoomResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageZoomResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageSegmentationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageSegmentationResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageTaggingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageDescriberResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageDescriberResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageCarsClassifierResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageCarsClassifierResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageCarsClassifierResponseDataClass), TypeInfoPropertyName = "ImageCarsClassifierResponseDataClass2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageExtractColorsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoUpscaleFpsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoUpscaleFpsResponseStatus), TypeInfoPropertyName = "VideoUpscaleFpsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoUpscaleFpsGetresultResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoUpscaleFpsGetresultResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoUpscaleFpsGetresultResponseStatus), TypeInfoPropertyName = "VideoUpscaleFpsGetresultResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoUpscaleFpsGetresultResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoUpscaleFpsGetresultResponseStatus2), TypeInfoPropertyName = "VideoUpscaleFpsGetresultResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoRemoveBackgroundResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoRemoveBackgroundResponseStatus), TypeInfoPropertyName = "VideoRemoveBackgroundResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoAdjustResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoAdjustResponseStatus), TypeInfoPropertyName = "VideoAdjustResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoApplyEffectResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoApplyEffectResponseStatus), TypeInfoPropertyName = "VideoApplyEffectResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoEditResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoEditResponseStatus), TypeInfoPropertyName = "VideoEditResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoTrimResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoTrimResponseStatus), TypeInfoPropertyName = "VideoTrimResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoCropResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoCropResponseStatus), TypeInfoPropertyName = "VideoCropResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoConcatResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoConcatResponseStatus), TypeInfoPropertyName = "VideoConcatResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoConcatHighlightsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoConcatHighlightsResponseStatus), TypeInfoPropertyName = "VideoConcatHighlightsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoFitResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoFitResponseStatus), TypeInfoPropertyName = "VideoFitResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoMetadataResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoMetadataResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoMetadataResponseStatus), TypeInfoPropertyName = "VideoMetadataResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoGetThumbnailResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Picsart.VideoGetThumbnailResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoGetThumbnailResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoGetThumbnailResponseStatus), TypeInfoPropertyName = "VideoGetThumbnailResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoSetThumbnailResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoSetThumbnailResponseStatus), TypeInfoPropertyName = "VideoSetThumbnailResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoSetThumbnailGetresultResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoSetThumbnailGetresultResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoSetThumbnailGetresultResponseStatus), TypeInfoPropertyName = "VideoSetThumbnailGetresultResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoSetThumbnailGetresultResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoSetThumbnailGetresultResponseStatus2), TypeInfoPropertyName = "VideoSetThumbnailGetresultResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoEncodeCtvResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoEncodeCtvResponseStatus), TypeInfoPropertyName = "VideoEncodeCtvResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoAdjustAudioResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoAdjustAudioResponseStatus), TypeInfoPropertyName = "VideoAdjustAudioResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoExtractAudioResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoExtractAudioResponseStatus), TypeInfoPropertyName = "VideoExtractAudioResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoTranscribeAudioResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoTranscribeAudioResponseStatus), TypeInfoPropertyName = "VideoTranscribeAudioResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoTranscribeAudioGetresultResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoTranscribeAudioGetresultResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoTranscribeAudioGetresultResponseStatus), TypeInfoPropertyName = "VideoTranscribeAudioGetresultResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoTranscribeAudioGetresultResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoTranscribeAudioGetresultResponseStatus2), TypeInfoPropertyName = "VideoTranscribeAudioGetresultResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoAddWatermarkResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoAddWatermarkResponseStatus), TypeInfoPropertyName = "VideoAddWatermarkResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoGetresultResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoGetresultResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoGetresultResponseStatus), TypeInfoPropertyName = "VideoGetresultResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoGetresultResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoGetresultResponseStatus2), TypeInfoPropertyName = "VideoGetresultResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoGetaudioresultResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoGetaudioresultResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoGetaudioresultResponseStatus), TypeInfoPropertyName = "VideoGetaudioresultResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoGetaudioresultResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoGetaudioresultResponseStatus2), TypeInfoPropertyName = "VideoGetaudioresultResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoUploadResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoUploadResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoUploadResponseStatus), TypeInfoPropertyName = "VideoUploadResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoCreditsBalanceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiText2textCompletionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiText2imageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiText2imageResponseStatus), TypeInfoPropertyName = "GenaiText2imageResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiText2imageGetresultResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Picsart.GenaiText2imageGetresultResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiText2imageGetresultResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiText2imageGetresultResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiText2imageGetresultResponseStatus), TypeInfoPropertyName = "GenaiText2imageGetresultResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiText2stickerResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiText2stickerResponseStatus), TypeInfoPropertyName = "GenaiText2stickerResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiText2stickerLaserEngravingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiText2stickerLaserEngravingResponseStatus), TypeInfoPropertyName = "GenaiText2stickerLaserEngravingResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiText2stickerGetresultResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Picsart.GenaiText2stickerGetresultResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiText2stickerGetresultResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiText2stickerGetresultResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiText2stickerGetresultResponseStatus), TypeInfoPropertyName = "GenaiText2stickerGetresultResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiGenerateLogoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiGenerateLogoResponseStatus), TypeInfoPropertyName = "GenaiGenerateLogoResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiGenerateLogoGetresultResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Picsart.GenaiGenerateLogoGetresultResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiGenerateLogoGetresultResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiGenerateLogoGetresultResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiGenerateLogoGetresultResponseStatus), TypeInfoPropertyName = "GenaiGenerateLogoGetresultResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiImageInpaintingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Picsart.GenaiImageInpaintingResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiImageInpaintingResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiImageInpaintingResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiImageOutpaintingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Picsart.GenaiImageOutpaintingResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiImageOutpaintingResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiImageOutpaintingResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiRemoveObjectResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiRemoveObjectResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiRemoveObjectResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiSmartBackgroundResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Picsart.GenaiSmartBackgroundResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiSmartBackgroundResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiSmartBackgroundResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiExpandImageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Picsart.GenaiExpandImageResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiExpandImageResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiExpandImageResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiGenerateImageBleedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiGenerateImageBleedResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiImageInpaintingGetresultResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Picsart.GenaiImageInpaintingGetresultResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiImageInpaintingGetresultResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiImageInpaintingGetresultResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiText2videoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiText2videoResponseStatus), TypeInfoPropertyName = "GenaiText2videoResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiImage2videoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiImage2videoResponseStatus), TypeInfoPropertyName = "GenaiImage2videoResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiText2videoGetresultResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiText2videoGetresultResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiText2videoGetresultResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiText2videoGetresultResponseStatus), TypeInfoPropertyName = "GenaiText2videoGetresultResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiText2speechResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiText2speechResponseStatus), TypeInfoPropertyName = "GenaiText2speechResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiText2soundResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiText2soundResponseStatus), TypeInfoPropertyName = "GenaiText2soundResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiText2audioGetresultResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiText2audioGetresultResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiText2audioGetresultResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiText2audioGetresultResponseStatus), TypeInfoPropertyName = "GenaiText2audioGetresultResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiCreditsBalanceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VdExportReplayResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VdExportReplayGetresultResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VdExportReplayGetresultResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VdExportReplayGetresultResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VdDescribeVariableDataContentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VdDescribeVariableDataContentResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Picsart.VdDescribeVariableDataContentResponseDataTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VdDescribeVariableDataContentResponseDataTag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VdDescribeVariableDataContentResponseDataTagType), TypeInfoPropertyName = "VdDescribeVariableDataContentResponseDataTagType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VdExportVariableDataContentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VdExportVariableDataContentGetresultResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Picsart.VdExportVariableDataContentGetresultResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VdExportVariableDataContentGetresultResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VdExportVariableDataContentGetresultResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VdCreditsBalanceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Picsart.ImageEffectsPreviewsParametersEffectName>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Picsart.ImageMasksPreviewParametersMaskItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Picsart.AllOf<global::Picsart.VideoConcatVideoParameters, global::Picsart.VideoConcatImageParameters, global::Picsart.VideoTransition>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Picsart.VideoConcatSegmentsParametersTrimSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Picsart.GenAIText2TextCompletionsParametersMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Picsart.ImageListEffectNamesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Picsart.ImageCreateEffectPreviewsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Picsart.ImageListAiEffectNamesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Picsart.ImageCreateMaskPreviewsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Picsart.VideoGetThumbnailResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Picsart.GenaiText2imageGetresultResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Picsart.GenaiText2stickerGetresultResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Picsart.GenaiGenerateLogoGetresultResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Picsart.GenaiImageInpaintingResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Picsart.GenaiImageOutpaintingResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Picsart.GenaiSmartBackgroundResponseDataItem>))]
    internal sealed partial class SourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Picsart.JsonConverters.ImageExportParametersFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageExportParametersFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageUpscaleParametersFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageUpscaleParametersFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageEffectsParametersEffectNameJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageEffectsParametersEffectNameNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageEffectsParametersFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageEffectsParametersFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageLaserEngravingEffectParametersFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageLaserEngravingEffectParametersFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageAIEffectsParametersEffectNameJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageAIEffectsParametersEffectNameNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageAIEffectsParametersFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageAIEffectsParametersFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageEffectsPreviewsParametersEffectNameJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageEffectsPreviewsParametersEffectNameNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageEffectsPreviewsParametersFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageEffectsPreviewsParametersFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageAdjustParametersFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageAdjustParametersFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageSelectiveBlurParametersFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageSelectiveBlurParametersFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageSmartCropParametersRatioJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageSmartCropParametersRatioNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageSmartCropParametersFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageSmartCropParametersFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageZoomParametersAnchorPointJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageZoomParametersAnchorPointNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageZoomParametersFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageZoomParametersFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageColorTransferParametersFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageColorTransferParametersFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageStyleTransferParametersLevelJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageStyleTransferParametersLevelNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageStyleTransferParametersFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageStyleTransferParametersFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageRemoveBackgroundParametersOutputTypeJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageRemoveBackgroundParametersOutputTypeNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageRemoveBackgroundParametersScaleJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageRemoveBackgroundParametersScaleNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageRemoveBackgroundParametersShadowJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageRemoveBackgroundParametersShadowNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageRemoveBackgroundParametersModelJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageRemoveBackgroundParametersModelNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageRemoveBackgroundParametersFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageRemoveBackgroundParametersFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageRemoveBackgroundParametersJSONOutputTypeJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageRemoveBackgroundParametersJSONOutputTypeNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageRemoveBackgroundParametersJSONScaleJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageRemoveBackgroundParametersJSONScaleNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageRemoveBackgroundParametersJSONShadowJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageRemoveBackgroundParametersJSONShadowNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageRemoveBackgroundParametersJSONModelJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageRemoveBackgroundParametersJSONModelNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageRemoveBackgroundParametersJSONFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageRemoveBackgroundParametersJSONFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageMultiMattingSegmentationParametersSegmentationClassJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageMultiMattingSegmentationParametersSegmentationClassNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageMasksParametersFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageMasksParametersFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageMasksParametersBlendJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageMasksParametersBlendNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageMasksParametersMaskJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageMasksParametersMaskNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageMasksParametersMaskFlipJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageMasksParametersMaskFlipNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageMasksPreviewParametersFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageMasksPreviewParametersFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageMasksPreviewParametersBlendJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageMasksPreviewParametersBlendNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageMasksPreviewParametersMaskItemJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageMasksPreviewParametersMaskItemNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageMasksPreviewParametersMaskFlipJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageMasksPreviewParametersMaskFlipNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageTextureParametersFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageTextureParametersFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageTextureParametersPatternJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageTextureParametersPatternNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageUpscaleUltraParametersProductTypeJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageUpscaleUltraParametersProductTypeNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageUpscaleUltraParametersImageTypeJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageUpscaleUltraParametersImageTypeNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageUpscaleUltraParametersModeJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageUpscaleUltraParametersModeNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageUpscaleUltraParametersFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageUpscaleUltraParametersFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageUpscaleEnhanceParametersFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageUpscaleEnhanceParametersFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageSurfacemapParametersFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageSurfacemapParametersFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageFaceEnhanceParametersFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageFaceEnhanceParametersFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageEditParametersFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageEditParametersFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageEditParametersModeJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageEditParametersModeNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageEditParametersCropAnchorJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageEditParametersCropAnchorNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageEditParametersFlipJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageEditParametersFlipNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageOverlayParametersBlendModeJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageOverlayParametersBlendModeNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageOverlayParametersFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageOverlayParametersFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageWatermarkParametersAnchorPointJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageWatermarkParametersAnchorPointNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoExportParametersExportFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoExportParametersExportFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoExtendedExportParametersExportFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoExtendedExportParametersExportFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoExtendedExportParametersExportQualityJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoExtendedExportParametersExportQualityNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoExtendedExportParametersExportCodecJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoExtendedExportParametersExportCodecNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoExtendedExportParametersExportAudioCodecJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoExtendedExportParametersExportAudioCodecNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoExtendedExportParametersExportColorSpaceJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoExtendedExportParametersExportColorSpaceNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoTranscribeParametersLanguageJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoTranscribeParametersLanguageNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoTranscribeParametersFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoTranscribeParametersFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoTranscribeParametersGranularityJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoTranscribeParametersGranularityNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoExtractAudioParametersFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoExtractAudioParametersFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoEffectsParametersEffectNameJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoEffectsParametersEffectNameNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoVideoGetThumbnailParametersSourceJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoVideoGetThumbnailParametersSourceNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoTransitionTransitionJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoTransitionTransitionNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoConcatImageParametersScaleJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoConcatImageParametersScaleNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoConcatSegmentsParametersTrimSegmentTransitionJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoConcatSegmentsParametersTrimSegmentTransitionNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoWatermarkParametersAnchorPointJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoWatermarkParametersAnchorPointNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIText2TextModelsModelJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIText2TextModelsModelNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIText2VideoParametersQualityJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIText2VideoParametersQualityNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIText2SpeechParametersLanguageJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIText2SpeechParametersLanguageNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIText2SpeechModelsModelJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIText2SpeechModelsModelNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIText2SoundModelsModelJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIText2SoundModelsModelNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIText2ImageModelsModelJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIText2ImageModelsModelNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIText2StickerModelsModelJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIText2StickerModelsModelNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAILogoModelsModelJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAILogoModelsModelNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIText2VideoModelsModelJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIText2VideoModelsModelNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIImage2VideoModelsModelJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIImage2VideoModelsModelNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAILaserEngravingParametersFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAILaserEngravingParametersFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAILaserEngravingModelsModelJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAILaserEngravingModelsModelNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAILogoParametersColorToneJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAILogoParametersColorToneNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIInpaintingParametersFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIInpaintingParametersFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIInpaintingParametersModeJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIInpaintingParametersModeNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIRemoveObjectParametersFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIRemoveObjectParametersFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIRemoveObjectParametersModeJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIRemoveObjectParametersModeNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIExpandParametersDirectionJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIExpandParametersDirectionNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIExpandParametersFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIExpandParametersFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIExpandParametersModeJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIExpandParametersModeNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIBleedParametersFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.GenAIBleedParametersFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VDExportReplayParametersFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.VDExportReplayParametersFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VDExportVariableDataContentParametersFormatJsonConverter),

            typeof(global::Picsart.JsonConverters.VDExportVariableDataContentParametersFormatNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageCarsClassifierResponseDataClassJsonConverter),

            typeof(global::Picsart.JsonConverters.ImageCarsClassifierResponseDataClassNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoUpscaleFpsResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoUpscaleFpsResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoUpscaleFpsGetresultResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoUpscaleFpsGetresultResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoUpscaleFpsGetresultResponseStatus2JsonConverter),

            typeof(global::Picsart.JsonConverters.VideoUpscaleFpsGetresultResponseStatus2NullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoRemoveBackgroundResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoRemoveBackgroundResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoAdjustResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoAdjustResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoApplyEffectResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoApplyEffectResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoEditResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoEditResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoTrimResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoTrimResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoCropResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoCropResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoConcatResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoConcatResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoConcatHighlightsResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoConcatHighlightsResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoFitResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoFitResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoMetadataResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoMetadataResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoGetThumbnailResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoGetThumbnailResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoSetThumbnailResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoSetThumbnailResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoSetThumbnailGetresultResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoSetThumbnailGetresultResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoSetThumbnailGetresultResponseStatus2JsonConverter),

            typeof(global::Picsart.JsonConverters.VideoSetThumbnailGetresultResponseStatus2NullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoEncodeCtvResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoEncodeCtvResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoAdjustAudioResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoAdjustAudioResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoExtractAudioResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoExtractAudioResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoTranscribeAudioResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoTranscribeAudioResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoTranscribeAudioGetresultResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoTranscribeAudioGetresultResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoTranscribeAudioGetresultResponseStatus2JsonConverter),

            typeof(global::Picsart.JsonConverters.VideoTranscribeAudioGetresultResponseStatus2NullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoAddWatermarkResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoAddWatermarkResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoGetresultResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoGetresultResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoGetresultResponseStatus2JsonConverter),

            typeof(global::Picsart.JsonConverters.VideoGetresultResponseStatus2NullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoGetaudioresultResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoGetaudioresultResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoGetaudioresultResponseStatus2JsonConverter),

            typeof(global::Picsart.JsonConverters.VideoGetaudioresultResponseStatus2NullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoUploadResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.VideoUploadResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenaiText2imageResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.GenaiText2imageResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenaiText2imageGetresultResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.GenaiText2imageGetresultResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenaiText2stickerResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.GenaiText2stickerResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenaiText2stickerLaserEngravingResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.GenaiText2stickerLaserEngravingResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenaiText2stickerGetresultResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.GenaiText2stickerGetresultResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenaiGenerateLogoResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.GenaiGenerateLogoResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenaiGenerateLogoGetresultResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.GenaiGenerateLogoGetresultResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenaiText2videoResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.GenaiText2videoResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenaiImage2videoResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.GenaiImage2videoResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenaiText2videoGetresultResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.GenaiText2videoGetresultResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenaiText2speechResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.GenaiText2speechResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenaiText2soundResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.GenaiText2soundResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.GenaiText2audioGetresultResponseStatusJsonConverter),

            typeof(global::Picsart.JsonConverters.GenaiText2audioGetresultResponseStatusNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.VdDescribeVariableDataContentResponseDataTagTypeJsonConverter),

            typeof(global::Picsart.JsonConverters.VdDescribeVariableDataContentResponseDataTagTypeNullableJsonConverter),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.VideoConcatVideoParameters, global::Picsart.VideoConcatImageParameters, global::Picsart.VideoTransition>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageRemoveBackgroundParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageUpscaleParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageUpscaleUltraParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageUpscaleEnhanceParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageFaceEnhanceParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageEffectsParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageEffectsPreviewsParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageLaserEngravingEffectParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageAIEffectsParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageAdjustParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageSelectiveBlurParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageColorTransferParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageStyleTransferParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageMasksPreviewParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageMasksParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageTextureParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageTextureParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageVectorizerParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageSurfacemapParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageWatermarkParameters, global::Picsart.ImageExportParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageEditParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageSmartCropParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageOverlayParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageZoomParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageMultiMattingSegmentationParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.VideoVideoParameters, global::Picsart.VideoRemoveBackgroundParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.VideoVideoParameters, global::Picsart.VideoAdjustParameters, global::Picsart.VideoExportParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.VideoVideoParameters, global::Picsart.VideoEffectsParameters, global::Picsart.VideoExportParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.VideoVideoParameters, global::Picsart.VideoEditParameters, global::Picsart.VideoExtendedExportParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.VideoVideoParameters, global::Picsart.VideoTrimParameters, global::Picsart.VideoExportParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.VideoVideoParameters, global::Picsart.VideoCropParameters, global::Picsart.VideoExportParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.VideoConcatParameters, global::Picsart.VideoExportParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.VideoVideoParameters, global::Picsart.VideoConcatSegmentsParameters, global::Picsart.VideoExportParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.VideoVideoParameters, global::Picsart.VideoFitParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.VideoVideoParameters, global::Picsart.VideoVideoGetThumbnailParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.VideoVideoParameters, global::Picsart.VideoImageParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.VideoVideoParameters, global::Picsart.VideoAdjustAudioParameters, global::Picsart.VideoExportParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.VideoVideoParameters, global::Picsart.VideoExtractAudioParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.VideoTranscribeFileParameters, global::Picsart.VideoTranscribeParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.VideoVideoParameters, global::Picsart.VideoWatermarkParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.GenAIText2TextCompletionsParameters, global::Picsart.GenAIText2TextModels>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.GenAIText2ImageParameters, global::Picsart.GenAIText2ImageModels>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.GenAIText2ImageParameters, global::Picsart.GenAIText2StickerModels>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.GenAIText2ImageParameters, global::Picsart.GenAILaserEngravingParameters, global::Picsart.GenAILaserEngravingModels>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.GenAILogoParameters, global::Picsart.GenAILogoModels>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.GenAIImageParameters, global::Picsart.GenAIMaskParameters, global::Picsart.GenAIInpaintingParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.GenAIImageParameters, global::Picsart.GenAIMaskParameters, global::Picsart.GenAIInpaintingParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.GenAIImageParameters, global::Picsart.GenAIMaskParameters, global::Picsart.GenAIRemoveObjectParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.GenAIImageParameters, global::Picsart.GenAIInpaintingParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.GenAIImageParameters, global::Picsart.GenAIExpandParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.GenAIImageParameters, global::Picsart.GenAIBleedParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.GenAIText2VideoParameters, global::Picsart.GenAIText2VideoModels>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.GenAIImageParameters, global::Picsart.GenAIText2VideoParameters, global::Picsart.GenAIImage2VideoModels>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.GenAIText2SpeechParameters, global::Picsart.GenAIText2SpeechModels>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.GenAIText2SoundParameters, global::Picsart.GenAIText2SoundModels>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.VDFileParameters, global::Picsart.VDExportReplayParameters>),

            typeof(global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.VDTemplateParameters, global::Picsart.VDDataFileParameters, global::Picsart.VDExportVariableDataContentParameters>),

            typeof(global::Picsart.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Picsart.GenaiExpandImageResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Picsart.GenaiImageInpaintingGetresultResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Picsart.VdDescribeVariableDataContentResponseDataTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Picsart.VdExportVariableDataContentGetresultResponseDataItem>))]
    internal sealed partial class SourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = global::System.Text.Json.Serialization.Metadata.JsonTypeInfoResolver.Combine(
            SourceGenerationContextChunk0.Default,

            SourceGenerationContextChunk1.Default
            );

        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        /// 
        /// </summary>
        public static SourceGenerationContext Default { get; } = new(DefaultOptions);

        private SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            options.Converters.Add(new global::Picsart.JsonConverters.ImageExportParametersFormatJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageExportParametersFormatNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageUpscaleParametersFormatJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageUpscaleParametersFormatNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageEffectsParametersEffectNameJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageEffectsParametersEffectNameNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageEffectsParametersFormatJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageEffectsParametersFormatNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageLaserEngravingEffectParametersFormatJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageLaserEngravingEffectParametersFormatNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageAIEffectsParametersEffectNameJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageAIEffectsParametersEffectNameNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageAIEffectsParametersFormatJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageAIEffectsParametersFormatNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageEffectsPreviewsParametersEffectNameJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageEffectsPreviewsParametersEffectNameNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageEffectsPreviewsParametersFormatJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageEffectsPreviewsParametersFormatNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageAdjustParametersFormatJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageAdjustParametersFormatNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageSelectiveBlurParametersFormatJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageSelectiveBlurParametersFormatNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageSmartCropParametersRatioJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageSmartCropParametersRatioNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageSmartCropParametersFormatJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageSmartCropParametersFormatNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageZoomParametersAnchorPointJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageZoomParametersAnchorPointNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageZoomParametersFormatJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageZoomParametersFormatNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageColorTransferParametersFormatJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageColorTransferParametersFormatNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageStyleTransferParametersLevelJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageStyleTransferParametersLevelNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageStyleTransferParametersFormatJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageStyleTransferParametersFormatNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageRemoveBackgroundParametersOutputTypeJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageRemoveBackgroundParametersOutputTypeNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageRemoveBackgroundParametersScaleJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageRemoveBackgroundParametersScaleNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageRemoveBackgroundParametersShadowJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageRemoveBackgroundParametersShadowNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageRemoveBackgroundParametersModelJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageRemoveBackgroundParametersModelNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageRemoveBackgroundParametersFormatJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageRemoveBackgroundParametersFormatNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageRemoveBackgroundParametersJSONOutputTypeJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageRemoveBackgroundParametersJSONOutputTypeNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageRemoveBackgroundParametersJSONScaleJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageRemoveBackgroundParametersJSONScaleNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageRemoveBackgroundParametersJSONShadowJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageRemoveBackgroundParametersJSONShadowNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageRemoveBackgroundParametersJSONModelJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageRemoveBackgroundParametersJSONModelNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageRemoveBackgroundParametersJSONFormatJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageRemoveBackgroundParametersJSONFormatNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageMultiMattingSegmentationParametersSegmentationClassJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageMultiMattingSegmentationParametersSegmentationClassNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageMasksParametersFormatJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageMasksParametersFormatNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageMasksParametersBlendJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageMasksParametersBlendNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageMasksParametersMaskJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageMasksParametersMaskNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageMasksParametersMaskFlipJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageMasksParametersMaskFlipNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageMasksPreviewParametersFormatJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageMasksPreviewParametersFormatNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageMasksPreviewParametersBlendJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageMasksPreviewParametersBlendNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageMasksPreviewParametersMaskItemJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageMasksPreviewParametersMaskItemNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageMasksPreviewParametersMaskFlipJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageMasksPreviewParametersMaskFlipNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageTextureParametersFormatJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageTextureParametersFormatNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageTextureParametersPatternJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageTextureParametersPatternNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageUpscaleUltraParametersProductTypeJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageUpscaleUltraParametersProductTypeNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageUpscaleUltraParametersImageTypeJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageUpscaleUltraParametersImageTypeNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageUpscaleUltraParametersModeJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageUpscaleUltraParametersModeNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageUpscaleUltraParametersFormatJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageUpscaleUltraParametersFormatNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageUpscaleEnhanceParametersFormatJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageUpscaleEnhanceParametersFormatNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageSurfacemapParametersFormatJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageSurfacemapParametersFormatNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageFaceEnhanceParametersFormatJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageFaceEnhanceParametersFormatNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageEditParametersFormatJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageEditParametersFormatNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageEditParametersModeJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageEditParametersModeNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageEditParametersCropAnchorJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageEditParametersCropAnchorNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageEditParametersFlipJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageEditParametersFlipNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageOverlayParametersBlendModeJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageOverlayParametersBlendModeNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageOverlayParametersFormatJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageOverlayParametersFormatNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageWatermarkParametersAnchorPointJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageWatermarkParametersAnchorPointNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoExportParametersExportFormatJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoExportParametersExportFormatNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoExtendedExportParametersExportFormatJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoExtendedExportParametersExportFormatNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoExtendedExportParametersExportQualityJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoExtendedExportParametersExportQualityNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoExtendedExportParametersExportCodecJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoExtendedExportParametersExportCodecNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoExtendedExportParametersExportAudioCodecJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoExtendedExportParametersExportAudioCodecNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoExtendedExportParametersExportColorSpaceJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoExtendedExportParametersExportColorSpaceNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoTranscribeParametersLanguageJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoTranscribeParametersLanguageNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoTranscribeParametersFormatJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoTranscribeParametersFormatNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoTranscribeParametersGranularityJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoTranscribeParametersGranularityNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoExtractAudioParametersFormatJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoExtractAudioParametersFormatNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoEffectsParametersEffectNameJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoEffectsParametersEffectNameNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoVideoGetThumbnailParametersSourceJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoVideoGetThumbnailParametersSourceNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoTransitionTransitionJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoTransitionTransitionNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoConcatImageParametersScaleJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoConcatImageParametersScaleNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoConcatSegmentsParametersTrimSegmentTransitionJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoConcatSegmentsParametersTrimSegmentTransitionNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoWatermarkParametersAnchorPointJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoWatermarkParametersAnchorPointNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenAIText2TextModelsModelJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenAIText2TextModelsModelNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenAIText2VideoParametersQualityJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenAIText2VideoParametersQualityNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenAIText2SpeechParametersLanguageJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenAIText2SpeechParametersLanguageNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenAIText2SpeechModelsModelJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenAIText2SpeechModelsModelNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenAIText2SoundModelsModelJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenAIText2SoundModelsModelNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenAIText2ImageModelsModelJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenAIText2ImageModelsModelNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenAIText2StickerModelsModelJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenAIText2StickerModelsModelNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenAILogoModelsModelJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenAILogoModelsModelNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenAIText2VideoModelsModelJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenAIText2VideoModelsModelNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenAIImage2VideoModelsModelJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenAIImage2VideoModelsModelNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenAILaserEngravingParametersFormatJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenAILaserEngravingParametersFormatNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenAILaserEngravingModelsModelJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenAILaserEngravingModelsModelNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenAILogoParametersColorToneJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenAILogoParametersColorToneNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenAIInpaintingParametersFormatJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenAIInpaintingParametersFormatNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenAIInpaintingParametersModeJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenAIInpaintingParametersModeNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenAIRemoveObjectParametersFormatJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenAIRemoveObjectParametersFormatNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenAIRemoveObjectParametersModeJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenAIRemoveObjectParametersModeNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenAIExpandParametersDirectionJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenAIExpandParametersDirectionNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenAIExpandParametersFormatJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenAIExpandParametersFormatNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenAIExpandParametersModeJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenAIExpandParametersModeNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenAIBleedParametersFormatJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenAIBleedParametersFormatNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VDExportReplayParametersFormatJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VDExportReplayParametersFormatNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VDExportVariableDataContentParametersFormatJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VDExportVariableDataContentParametersFormatNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageCarsClassifierResponseDataClassJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.ImageCarsClassifierResponseDataClassNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoUpscaleFpsResponseStatusJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoUpscaleFpsResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoUpscaleFpsGetresultResponseStatusJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoUpscaleFpsGetresultResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoUpscaleFpsGetresultResponseStatus2JsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoUpscaleFpsGetresultResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoRemoveBackgroundResponseStatusJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoRemoveBackgroundResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoAdjustResponseStatusJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoAdjustResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoApplyEffectResponseStatusJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoApplyEffectResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoEditResponseStatusJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoEditResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoTrimResponseStatusJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoTrimResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoCropResponseStatusJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoCropResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoConcatResponseStatusJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoConcatResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoConcatHighlightsResponseStatusJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoConcatHighlightsResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoFitResponseStatusJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoFitResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoMetadataResponseStatusJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoMetadataResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoGetThumbnailResponseStatusJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoGetThumbnailResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoSetThumbnailResponseStatusJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoSetThumbnailResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoSetThumbnailGetresultResponseStatusJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoSetThumbnailGetresultResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoSetThumbnailGetresultResponseStatus2JsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoSetThumbnailGetresultResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoEncodeCtvResponseStatusJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoEncodeCtvResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoAdjustAudioResponseStatusJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoAdjustAudioResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoExtractAudioResponseStatusJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoExtractAudioResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoTranscribeAudioResponseStatusJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoTranscribeAudioResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoTranscribeAudioGetresultResponseStatusJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoTranscribeAudioGetresultResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoTranscribeAudioGetresultResponseStatus2JsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoTranscribeAudioGetresultResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoAddWatermarkResponseStatusJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoAddWatermarkResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoGetresultResponseStatusJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoGetresultResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoGetresultResponseStatus2JsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoGetresultResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoGetaudioresultResponseStatusJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoGetaudioresultResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoGetaudioresultResponseStatus2JsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoGetaudioresultResponseStatus2NullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoUploadResponseStatusJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VideoUploadResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenaiText2imageResponseStatusJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenaiText2imageResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenaiText2imageGetresultResponseStatusJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenaiText2imageGetresultResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenaiText2stickerResponseStatusJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenaiText2stickerResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenaiText2stickerLaserEngravingResponseStatusJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenaiText2stickerLaserEngravingResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenaiText2stickerGetresultResponseStatusJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenaiText2stickerGetresultResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenaiGenerateLogoResponseStatusJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenaiGenerateLogoResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenaiGenerateLogoGetresultResponseStatusJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenaiGenerateLogoGetresultResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenaiText2videoResponseStatusJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenaiText2videoResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenaiImage2videoResponseStatusJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenaiImage2videoResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenaiText2videoGetresultResponseStatusJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenaiText2videoGetresultResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenaiText2speechResponseStatusJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenaiText2speechResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenaiText2soundResponseStatusJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenaiText2soundResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenaiText2audioGetresultResponseStatusJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.GenaiText2audioGetresultResponseStatusNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VdDescribeVariableDataContentResponseDataTagTypeJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.VdDescribeVariableDataContentResponseDataTagTypeNullableJsonConverter());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.VideoConcatVideoParameters, global::Picsart.VideoConcatImageParameters, global::Picsart.VideoTransition>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageRemoveBackgroundParameters>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageUpscaleParameters>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageUpscaleUltraParameters>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageUpscaleEnhanceParameters>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageFaceEnhanceParameters>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageEffectsParameters>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageEffectsPreviewsParameters>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageLaserEngravingEffectParameters>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageAIEffectsParameters>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageAdjustParameters>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageSelectiveBlurParameters>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageColorTransferParameters>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageStyleTransferParameters>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageMasksPreviewParameters>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageMasksParameters>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageTextureParameters>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageTextureParameters>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageVectorizerParameters>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageSurfacemapParameters>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageWatermarkParameters, global::Picsart.ImageExportParameters>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageEditParameters>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageSmartCropParameters>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageOverlayParameters>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageZoomParameters>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageMultiMattingSegmentationParameters>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.VideoVideoParameters, global::Picsart.VideoRemoveBackgroundParameters>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.VideoVideoParameters, global::Picsart.VideoAdjustParameters, global::Picsart.VideoExportParameters>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.VideoVideoParameters, global::Picsart.VideoEffectsParameters, global::Picsart.VideoExportParameters>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.VideoVideoParameters, global::Picsart.VideoEditParameters, global::Picsart.VideoExtendedExportParameters>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.VideoVideoParameters, global::Picsart.VideoTrimParameters, global::Picsart.VideoExportParameters>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.VideoVideoParameters, global::Picsart.VideoCropParameters, global::Picsart.VideoExportParameters>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.VideoConcatParameters, global::Picsart.VideoExportParameters>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.VideoVideoParameters, global::Picsart.VideoConcatSegmentsParameters, global::Picsart.VideoExportParameters>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.VideoVideoParameters, global::Picsart.VideoFitParameters>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.VideoVideoParameters, global::Picsart.VideoVideoGetThumbnailParameters>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.VideoVideoParameters, global::Picsart.VideoImageParameters>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.VideoVideoParameters, global::Picsart.VideoAdjustAudioParameters, global::Picsart.VideoExportParameters>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.VideoVideoParameters, global::Picsart.VideoExtractAudioParameters>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.VideoTranscribeFileParameters, global::Picsart.VideoTranscribeParameters>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.VideoVideoParameters, global::Picsart.VideoWatermarkParameters>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.GenAIText2TextCompletionsParameters, global::Picsart.GenAIText2TextModels>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.GenAIText2ImageParameters, global::Picsart.GenAIText2ImageModels>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.GenAIText2ImageParameters, global::Picsart.GenAIText2StickerModels>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.GenAIText2ImageParameters, global::Picsart.GenAILaserEngravingParameters, global::Picsart.GenAILaserEngravingModels>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.GenAILogoParameters, global::Picsart.GenAILogoModels>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.GenAIImageParameters, global::Picsart.GenAIMaskParameters, global::Picsart.GenAIInpaintingParameters>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.GenAIImageParameters, global::Picsart.GenAIMaskParameters, global::Picsart.GenAIInpaintingParameters>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.GenAIImageParameters, global::Picsart.GenAIMaskParameters, global::Picsart.GenAIRemoveObjectParameters>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.GenAIImageParameters, global::Picsart.GenAIInpaintingParameters>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.GenAIImageParameters, global::Picsart.GenAIExpandParameters>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.GenAIImageParameters, global::Picsart.GenAIBleedParameters>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.GenAIText2VideoParameters, global::Picsart.GenAIText2VideoModels>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.GenAIImageParameters, global::Picsart.GenAIText2VideoParameters, global::Picsart.GenAIImage2VideoModels>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.GenAIText2SpeechParameters, global::Picsart.GenAIText2SpeechModels>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.GenAIText2SoundParameters, global::Picsart.GenAIText2SoundModels>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.VDFileParameters, global::Picsart.VDExportReplayParameters>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.VDTemplateParameters, global::Picsart.VDDataFileParameters, global::Picsart.VDExportVariableDataContentParameters>());
            options.Converters.Add(new global::Picsart.JsonConverters.UnixTimestampJsonConverter());

            return options;
        }
    }
}