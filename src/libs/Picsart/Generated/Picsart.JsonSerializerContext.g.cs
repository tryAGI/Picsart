
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
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageExportParametersFormat?), TypeInfoPropertyName = "NullableImageExportParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageUpscaleParametersFormat?), TypeInfoPropertyName = "NullableImageUpscaleParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageEffectsParametersEffectName?), TypeInfoPropertyName = "NullableImageEffectsParametersEffectName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageEffectsParametersFormat?), TypeInfoPropertyName = "NullableImageEffectsParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageLaserEngravingEffectParametersFormat?), TypeInfoPropertyName = "NullableImageLaserEngravingEffectParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageAIEffectsParametersEffectName?), TypeInfoPropertyName = "NullableImageAIEffectsParametersEffectName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageAIEffectsParametersFormat?), TypeInfoPropertyName = "NullableImageAIEffectsParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageEffectsPreviewsParametersEffectName?), TypeInfoPropertyName = "NullableImageEffectsPreviewsParametersEffectName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageEffectsPreviewsParametersFormat?), TypeInfoPropertyName = "NullableImageEffectsPreviewsParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageAdjustParametersFormat?), TypeInfoPropertyName = "NullableImageAdjustParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageSelectiveBlurParametersFormat?), TypeInfoPropertyName = "NullableImageSelectiveBlurParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageSmartCropParametersRatio?), TypeInfoPropertyName = "NullableImageSmartCropParametersRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageSmartCropParametersFormat?), TypeInfoPropertyName = "NullableImageSmartCropParametersFormat2")]
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
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageZoomParametersAnchorPoint?), TypeInfoPropertyName = "NullableImageZoomParametersAnchorPoint2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageZoomParametersFormat?), TypeInfoPropertyName = "NullableImageZoomParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageColorTransferParametersFormat?), TypeInfoPropertyName = "NullableImageColorTransferParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageStyleTransferParametersLevel?), TypeInfoPropertyName = "NullableImageStyleTransferParametersLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageStyleTransferParametersFormat?), TypeInfoPropertyName = "NullableImageStyleTransferParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageRemoveBackgroundParametersOutputType?), TypeInfoPropertyName = "NullableImageRemoveBackgroundParametersOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageRemoveBackgroundParametersScale?), TypeInfoPropertyName = "NullableImageRemoveBackgroundParametersScale2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageRemoveBackgroundParametersShadow?), TypeInfoPropertyName = "NullableImageRemoveBackgroundParametersShadow2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageRemoveBackgroundParametersModel?), TypeInfoPropertyName = "NullableImageRemoveBackgroundParametersModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageRemoveBackgroundParametersFormat?), TypeInfoPropertyName = "NullableImageRemoveBackgroundParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageRemoveBackgroundParametersJSONOutputType?), TypeInfoPropertyName = "NullableImageRemoveBackgroundParametersJSONOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageRemoveBackgroundParametersJSONScale?), TypeInfoPropertyName = "NullableImageRemoveBackgroundParametersJSONScale2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageRemoveBackgroundParametersJSONShadow?), TypeInfoPropertyName = "NullableImageRemoveBackgroundParametersJSONShadow2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageRemoveBackgroundParametersJSONModel?), TypeInfoPropertyName = "NullableImageRemoveBackgroundParametersJSONModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageRemoveBackgroundParametersJSONFormat?), TypeInfoPropertyName = "NullableImageRemoveBackgroundParametersJSONFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageMultiMattingSegmentationParametersSegmentationClass?), TypeInfoPropertyName = "NullableImageMultiMattingSegmentationParametersSegmentationClass2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageMasksParametersFormat?), TypeInfoPropertyName = "NullableImageMasksParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageMasksParametersBlend?), TypeInfoPropertyName = "NullableImageMasksParametersBlend2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageMasksParametersMask?), TypeInfoPropertyName = "NullableImageMasksParametersMask2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageMasksParametersMaskFlip?), TypeInfoPropertyName = "NullableImageMasksParametersMaskFlip2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageMasksPreviewParametersFormat?), TypeInfoPropertyName = "NullableImageMasksPreviewParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageMasksPreviewParametersBlend?), TypeInfoPropertyName = "NullableImageMasksPreviewParametersBlend2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageMasksPreviewParametersMaskItem?), TypeInfoPropertyName = "NullableImageMasksPreviewParametersMaskItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageMasksPreviewParametersMaskFlip?), TypeInfoPropertyName = "NullableImageMasksPreviewParametersMaskFlip2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageTextureParametersFormat?), TypeInfoPropertyName = "NullableImageTextureParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageTextureParametersPattern?), TypeInfoPropertyName = "NullableImageTextureParametersPattern2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageUpscaleUltraParametersProductType?), TypeInfoPropertyName = "NullableImageUpscaleUltraParametersProductType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageUpscaleUltraParametersImageType?), TypeInfoPropertyName = "NullableImageUpscaleUltraParametersImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageUpscaleUltraParametersMode?), TypeInfoPropertyName = "NullableImageUpscaleUltraParametersMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageUpscaleUltraParametersFormat?), TypeInfoPropertyName = "NullableImageUpscaleUltraParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageUpscaleEnhanceParametersFormat?), TypeInfoPropertyName = "NullableImageUpscaleEnhanceParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageSurfacemapParametersFormat?), TypeInfoPropertyName = "NullableImageSurfacemapParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageFaceEnhanceParametersFormat?), TypeInfoPropertyName = "NullableImageFaceEnhanceParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageEditParametersFormat?), TypeInfoPropertyName = "NullableImageEditParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageEditParametersMode?), TypeInfoPropertyName = "NullableImageEditParametersMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageEditParametersCropAnchor?), TypeInfoPropertyName = "NullableImageEditParametersCropAnchor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageEditParametersFlip?), TypeInfoPropertyName = "NullableImageEditParametersFlip2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageOverlayParametersBlendMode?), TypeInfoPropertyName = "NullableImageOverlayParametersBlendMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageOverlayParametersFormat?), TypeInfoPropertyName = "NullableImageOverlayParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageWatermarkParametersAnchorPoint?), TypeInfoPropertyName = "NullableImageWatermarkParametersAnchorPoint2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoExportParametersExportFormat?), TypeInfoPropertyName = "NullableVideoExportParametersExportFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoExtendedExportParametersExportFormat?), TypeInfoPropertyName = "NullableVideoExtendedExportParametersExportFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoExtendedExportParametersExportQuality?), TypeInfoPropertyName = "NullableVideoExtendedExportParametersExportQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoExtendedExportParametersExportCodec?), TypeInfoPropertyName = "NullableVideoExtendedExportParametersExportCodec2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoExtendedExportParametersExportAudioCodec?), TypeInfoPropertyName = "NullableVideoExtendedExportParametersExportAudioCodec2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoExtendedExportParametersExportColorSpace?), TypeInfoPropertyName = "NullableVideoExtendedExportParametersExportColorSpace2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoTranscribeParametersLanguage?), TypeInfoPropertyName = "NullableVideoTranscribeParametersLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoTranscribeParametersFormat?), TypeInfoPropertyName = "NullableVideoTranscribeParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoTranscribeParametersGranularity?), TypeInfoPropertyName = "NullableVideoTranscribeParametersGranularity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoExtractAudioParametersFormat?), TypeInfoPropertyName = "NullableVideoExtractAudioParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoEffectsParametersEffectName?), TypeInfoPropertyName = "NullableVideoEffectsParametersEffectName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoVideoGetThumbnailParametersSource?), TypeInfoPropertyName = "NullableVideoVideoGetThumbnailParametersSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoTransitionTransition?), TypeInfoPropertyName = "NullableVideoTransitionTransition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.VideoConcatVideoParameters, global::Picsart.VideoConcatImageParameters, global::Picsart.VideoTransition>?), TypeInfoPropertyName = "NullableAllOfVideoConcatVideoParametersVideoConcatImageParametersVideoTransition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoConcatImageParametersScale?), TypeInfoPropertyName = "NullableVideoConcatImageParametersScale2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoConcatSegmentsParametersTrimSegmentTransition?), TypeInfoPropertyName = "NullableVideoConcatSegmentsParametersTrimSegmentTransition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoWatermarkParametersAnchorPoint?), TypeInfoPropertyName = "NullableVideoWatermarkParametersAnchorPoint2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIText2TextModelsModel?), TypeInfoPropertyName = "NullableGenAIText2TextModelsModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIText2VideoParametersQuality?), TypeInfoPropertyName = "NullableGenAIText2VideoParametersQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIText2SpeechParametersLanguage?), TypeInfoPropertyName = "NullableGenAIText2SpeechParametersLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIText2SpeechModelsModel?), TypeInfoPropertyName = "NullableGenAIText2SpeechModelsModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIText2SoundModelsModel?), TypeInfoPropertyName = "NullableGenAIText2SoundModelsModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIText2ImageModelsModel?), TypeInfoPropertyName = "NullableGenAIText2ImageModelsModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIText2StickerModelsModel?), TypeInfoPropertyName = "NullableGenAIText2StickerModelsModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAILogoModelsModel?), TypeInfoPropertyName = "NullableGenAILogoModelsModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIText2VideoModelsModel?), TypeInfoPropertyName = "NullableGenAIText2VideoModelsModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIImage2VideoModelsModel?), TypeInfoPropertyName = "NullableGenAIImage2VideoModelsModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAILaserEngravingParametersFormat?), TypeInfoPropertyName = "NullableGenAILaserEngravingParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAILaserEngravingModelsModel?), TypeInfoPropertyName = "NullableGenAILaserEngravingModelsModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAILogoParametersColorTone?), TypeInfoPropertyName = "NullableGenAILogoParametersColorTone2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIInpaintingParametersFormat?), TypeInfoPropertyName = "NullableGenAIInpaintingParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIInpaintingParametersMode?), TypeInfoPropertyName = "NullableGenAIInpaintingParametersMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIRemoveObjectParametersFormat?), TypeInfoPropertyName = "NullableGenAIRemoveObjectParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIRemoveObjectParametersMode?), TypeInfoPropertyName = "NullableGenAIRemoveObjectParametersMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIExpandParametersDirection?), TypeInfoPropertyName = "NullableGenAIExpandParametersDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIExpandParametersFormat?), TypeInfoPropertyName = "NullableGenAIExpandParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIExpandParametersMode?), TypeInfoPropertyName = "NullableGenAIExpandParametersMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIBleedParametersFormat?), TypeInfoPropertyName = "NullableGenAIBleedParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VDExportReplayParametersFormat?), TypeInfoPropertyName = "NullableVDExportReplayParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VDExportVariableDataContentParametersFormat?), TypeInfoPropertyName = "NullableVDExportVariableDataContentParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageRemoveBackgroundParameters>?), TypeInfoPropertyName = "NullableAllOfImageImageParametersImageRemoveBackgroundParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageUpscaleParameters>?), TypeInfoPropertyName = "NullableAllOfImageImageParametersImageUpscaleParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageUpscaleUltraParameters>?), TypeInfoPropertyName = "NullableAllOfImageImageParametersImageUpscaleUltraParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageUpscaleEnhanceParameters>?), TypeInfoPropertyName = "NullableAllOfImageImageParametersImageUpscaleEnhanceParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageFaceEnhanceParameters>?), TypeInfoPropertyName = "NullableAllOfImageImageParametersImageFaceEnhanceParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageEffectsParameters>?), TypeInfoPropertyName = "NullableAllOfImageImageParametersImageEffectsParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageEffectsPreviewsParameters>?), TypeInfoPropertyName = "NullableAllOfImageImageParametersImageEffectsPreviewsParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageLaserEngravingEffectParameters>?), TypeInfoPropertyName = "NullableAllOfImageImageParametersImageLaserEngravingEffectParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageAIEffectsParameters>?), TypeInfoPropertyName = "NullableAllOfImageImageParametersImageAIEffectsParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageAdjustParameters>?), TypeInfoPropertyName = "NullableAllOfImageImageParametersImageAdjustParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageSelectiveBlurParameters>?), TypeInfoPropertyName = "NullableAllOfImageImageParametersImageSelectiveBlurParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageColorTransferParameters>?), TypeInfoPropertyName = "NullableAllOfImageImageParametersImageColorTransferParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageStyleTransferParameters>?), TypeInfoPropertyName = "NullableAllOfImageImageParametersImageStyleTransferParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageMasksPreviewParameters>?), TypeInfoPropertyName = "NullableAllOfImageImageParametersImageMasksPreviewParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageMasksParameters>?), TypeInfoPropertyName = "NullableAllOfImageImageParametersImageMasksParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageTextureParameters>?), TypeInfoPropertyName = "NullableAllOfImageImageParametersImageTextureParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageVectorizerParameters>?), TypeInfoPropertyName = "NullableAllOfImageImageParametersImageVectorizerParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageSurfacemapParameters>?), TypeInfoPropertyName = "NullableAllOfImageImageParametersImageSurfacemapParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageWatermarkParameters, global::Picsart.ImageExportParameters>?), TypeInfoPropertyName = "NullableAllOfImageImageParametersImageWatermarkParametersImageExportParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageEditParameters>?), TypeInfoPropertyName = "NullableAllOfImageImageParametersImageEditParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageSmartCropParameters>?), TypeInfoPropertyName = "NullableAllOfImageImageParametersImageSmartCropParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageOverlayParameters>?), TypeInfoPropertyName = "NullableAllOfImageImageParametersImageOverlayParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageZoomParameters>?), TypeInfoPropertyName = "NullableAllOfImageImageParametersImageZoomParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageMultiMattingSegmentationParameters>?), TypeInfoPropertyName = "NullableAllOfImageImageParametersImageMultiMattingSegmentationParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.VideoVideoParameters, global::Picsart.VideoRemoveBackgroundParameters>?), TypeInfoPropertyName = "NullableAllOfVideoVideoParametersVideoRemoveBackgroundParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.VideoVideoParameters, global::Picsart.VideoAdjustParameters, global::Picsart.VideoExportParameters>?), TypeInfoPropertyName = "NullableAllOfVideoVideoParametersVideoAdjustParametersVideoExportParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.VideoVideoParameters, global::Picsart.VideoEffectsParameters, global::Picsart.VideoExportParameters>?), TypeInfoPropertyName = "NullableAllOfVideoVideoParametersVideoEffectsParametersVideoExportParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.VideoVideoParameters, global::Picsart.VideoEditParameters, global::Picsart.VideoExtendedExportParameters>?), TypeInfoPropertyName = "NullableAllOfVideoVideoParametersVideoEditParametersVideoExtendedExportParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.VideoVideoParameters, global::Picsart.VideoTrimParameters, global::Picsart.VideoExportParameters>?), TypeInfoPropertyName = "NullableAllOfVideoVideoParametersVideoTrimParametersVideoExportParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.VideoVideoParameters, global::Picsart.VideoCropParameters, global::Picsart.VideoExportParameters>?), TypeInfoPropertyName = "NullableAllOfVideoVideoParametersVideoCropParametersVideoExportParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.VideoConcatParameters, global::Picsart.VideoExportParameters>?), TypeInfoPropertyName = "NullableAllOfVideoConcatParametersVideoExportParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.VideoVideoParameters, global::Picsart.VideoConcatSegmentsParameters, global::Picsart.VideoExportParameters>?), TypeInfoPropertyName = "NullableAllOfVideoVideoParametersVideoConcatSegmentsParametersVideoExportParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.VideoVideoParameters, global::Picsart.VideoFitParameters>?), TypeInfoPropertyName = "NullableAllOfVideoVideoParametersVideoFitParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.VideoVideoParameters, global::Picsart.VideoVideoGetThumbnailParameters>?), TypeInfoPropertyName = "NullableAllOfVideoVideoParametersVideoVideoGetThumbnailParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.VideoVideoParameters, global::Picsart.VideoImageParameters>?), TypeInfoPropertyName = "NullableAllOfVideoVideoParametersVideoImageParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.VideoVideoParameters, global::Picsart.VideoAdjustAudioParameters, global::Picsart.VideoExportParameters>?), TypeInfoPropertyName = "NullableAllOfVideoVideoParametersVideoAdjustAudioParametersVideoExportParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.VideoVideoParameters, global::Picsart.VideoExtractAudioParameters>?), TypeInfoPropertyName = "NullableAllOfVideoVideoParametersVideoExtractAudioParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.VideoTranscribeFileParameters, global::Picsart.VideoTranscribeParameters>?), TypeInfoPropertyName = "NullableAllOfVideoTranscribeFileParametersVideoTranscribeParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.VideoVideoParameters, global::Picsart.VideoWatermarkParameters>?), TypeInfoPropertyName = "NullableAllOfVideoVideoParametersVideoWatermarkParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.GenAIText2TextCompletionsParameters, global::Picsart.GenAIText2TextModels>?), TypeInfoPropertyName = "NullableAllOfGenAIText2TextCompletionsParametersGenAIText2TextModels2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.GenAIText2ImageParameters, global::Picsart.GenAIText2ImageModels>?), TypeInfoPropertyName = "NullableAllOfGenAIText2ImageParametersGenAIText2ImageModels2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.GenAIText2ImageParameters, global::Picsart.GenAIText2StickerModels>?), TypeInfoPropertyName = "NullableAllOfGenAIText2ImageParametersGenAIText2StickerModels2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.GenAIText2ImageParameters, global::Picsart.GenAILaserEngravingParameters, global::Picsart.GenAILaserEngravingModels>?), TypeInfoPropertyName = "NullableAllOfGenAIText2ImageParametersGenAILaserEngravingParametersGenAILaserEngravingModels2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.GenAILogoParameters, global::Picsart.GenAILogoModels>?), TypeInfoPropertyName = "NullableAllOfGenAILogoParametersGenAILogoModels2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.GenAIImageParameters, global::Picsart.GenAIMaskParameters, global::Picsart.GenAIInpaintingParameters>?), TypeInfoPropertyName = "NullableAllOfGenAIImageParametersGenAIMaskParametersGenAIInpaintingParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.GenAIImageParameters, global::Picsart.GenAIMaskParameters, global::Picsart.GenAIRemoveObjectParameters>?), TypeInfoPropertyName = "NullableAllOfGenAIImageParametersGenAIMaskParametersGenAIRemoveObjectParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.GenAIImageParameters, global::Picsart.GenAIInpaintingParameters>?), TypeInfoPropertyName = "NullableAllOfGenAIImageParametersGenAIInpaintingParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.GenAIImageParameters, global::Picsart.GenAIExpandParameters>?), TypeInfoPropertyName = "NullableAllOfGenAIImageParametersGenAIExpandParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.GenAIImageParameters, global::Picsart.GenAIBleedParameters>?), TypeInfoPropertyName = "NullableAllOfGenAIImageParametersGenAIBleedParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.GenAIText2VideoParameters, global::Picsart.GenAIText2VideoModels>?), TypeInfoPropertyName = "NullableAllOfGenAIText2VideoParametersGenAIText2VideoModels2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.GenAIImageParameters, global::Picsart.GenAIText2VideoParameters, global::Picsart.GenAIImage2VideoModels>?), TypeInfoPropertyName = "NullableAllOfGenAIImageParametersGenAIText2VideoParametersGenAIImage2VideoModels2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.GenAIText2SpeechParameters, global::Picsart.GenAIText2SpeechModels>?), TypeInfoPropertyName = "NullableAllOfGenAIText2SpeechParametersGenAIText2SpeechModels2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.GenAIText2SoundParameters, global::Picsart.GenAIText2SoundModels>?), TypeInfoPropertyName = "NullableAllOfGenAIText2SoundParametersGenAIText2SoundModels2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.VDFileParameters, global::Picsart.VDExportReplayParameters>?), TypeInfoPropertyName = "NullableAllOfVDFileParametersVDExportReplayParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.VDTemplateParameters, global::Picsart.VDDataFileParameters, global::Picsart.VDExportVariableDataContentParameters>?), TypeInfoPropertyName = "NullableAllOfVDTemplateParametersVDDataFileParametersVDExportVariableDataContentParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageCarsClassifierResponseDataClass?), TypeInfoPropertyName = "NullableImageCarsClassifierResponseDataClass2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoUpscaleFpsResponseStatus?), TypeInfoPropertyName = "NullableVideoUpscaleFpsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoUpscaleFpsGetresultResponseStatus?), TypeInfoPropertyName = "NullableVideoUpscaleFpsGetresultResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoUpscaleFpsGetresultResponseStatus2?), TypeInfoPropertyName = "NullableVideoUpscaleFpsGetresultResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoRemoveBackgroundResponseStatus?), TypeInfoPropertyName = "NullableVideoRemoveBackgroundResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoAdjustResponseStatus?), TypeInfoPropertyName = "NullableVideoAdjustResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoApplyEffectResponseStatus?), TypeInfoPropertyName = "NullableVideoApplyEffectResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoEditResponseStatus?), TypeInfoPropertyName = "NullableVideoEditResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoTrimResponseStatus?), TypeInfoPropertyName = "NullableVideoTrimResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoCropResponseStatus?), TypeInfoPropertyName = "NullableVideoCropResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoConcatResponseStatus?), TypeInfoPropertyName = "NullableVideoConcatResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoConcatHighlightsResponseStatus?), TypeInfoPropertyName = "NullableVideoConcatHighlightsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoFitResponseStatus?), TypeInfoPropertyName = "NullableVideoFitResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoMetadataResponseStatus?), TypeInfoPropertyName = "NullableVideoMetadataResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoGetThumbnailResponseStatus?), TypeInfoPropertyName = "NullableVideoGetThumbnailResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoSetThumbnailResponseStatus?), TypeInfoPropertyName = "NullableVideoSetThumbnailResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoSetThumbnailGetresultResponseStatus?), TypeInfoPropertyName = "NullableVideoSetThumbnailGetresultResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoSetThumbnailGetresultResponseStatus2?), TypeInfoPropertyName = "NullableVideoSetThumbnailGetresultResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoEncodeCtvResponseStatus?), TypeInfoPropertyName = "NullableVideoEncodeCtvResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoAdjustAudioResponseStatus?), TypeInfoPropertyName = "NullableVideoAdjustAudioResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoExtractAudioResponseStatus?), TypeInfoPropertyName = "NullableVideoExtractAudioResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoTranscribeAudioResponseStatus?), TypeInfoPropertyName = "NullableVideoTranscribeAudioResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoTranscribeAudioGetresultResponseStatus?), TypeInfoPropertyName = "NullableVideoTranscribeAudioGetresultResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoTranscribeAudioGetresultResponseStatus2?), TypeInfoPropertyName = "NullableVideoTranscribeAudioGetresultResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoAddWatermarkResponseStatus?), TypeInfoPropertyName = "NullableVideoAddWatermarkResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoGetresultResponseStatus?), TypeInfoPropertyName = "NullableVideoGetresultResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoGetresultResponseStatus2?), TypeInfoPropertyName = "NullableVideoGetresultResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoGetaudioresultResponseStatus?), TypeInfoPropertyName = "NullableVideoGetaudioresultResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoGetaudioresultResponseStatus2?), TypeInfoPropertyName = "NullableVideoGetaudioresultResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoUploadResponseStatus?), TypeInfoPropertyName = "NullableVideoUploadResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiText2imageResponseStatus?), TypeInfoPropertyName = "NullableGenaiText2imageResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiText2imageGetresultResponseStatus?), TypeInfoPropertyName = "NullableGenaiText2imageGetresultResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiText2stickerResponseStatus?), TypeInfoPropertyName = "NullableGenaiText2stickerResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiText2stickerLaserEngravingResponseStatus?), TypeInfoPropertyName = "NullableGenaiText2stickerLaserEngravingResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiText2stickerGetresultResponseStatus?), TypeInfoPropertyName = "NullableGenaiText2stickerGetresultResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiGenerateLogoResponseStatus?), TypeInfoPropertyName = "NullableGenaiGenerateLogoResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiGenerateLogoGetresultResponseStatus?), TypeInfoPropertyName = "NullableGenaiGenerateLogoGetresultResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiText2videoResponseStatus?), TypeInfoPropertyName = "NullableGenaiText2videoResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiImage2videoResponseStatus?), TypeInfoPropertyName = "NullableGenaiImage2videoResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiText2videoGetresultResponseStatus?), TypeInfoPropertyName = "NullableGenaiText2videoGetresultResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiText2speechResponseStatus?), TypeInfoPropertyName = "NullableGenaiText2speechResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiText2soundResponseStatus?), TypeInfoPropertyName = "NullableGenaiText2soundResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiText2audioGetresultResponseStatus?), TypeInfoPropertyName = "NullableGenaiText2audioGetresultResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VdDescribeVariableDataContentResponseDataTagType?), TypeInfoPropertyName = "NullableVdDescribeVariableDataContentResponseDataTagType2")]
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
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

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

            options.Converters.Add(new LazyEnumJsonConverterFactory());

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Picsart.ImageExportParametersFormat)

                    || typeToConvert == typeof(global::Picsart.ImageExportParametersFormat?)

                    || typeToConvert == typeof(global::Picsart.ImageUpscaleParametersFormat)

                    || typeToConvert == typeof(global::Picsart.ImageUpscaleParametersFormat?)

                    || typeToConvert == typeof(global::Picsart.ImageEffectsParametersEffectName)

                    || typeToConvert == typeof(global::Picsart.ImageEffectsParametersEffectName?)

                    || typeToConvert == typeof(global::Picsart.ImageEffectsParametersFormat)

                    || typeToConvert == typeof(global::Picsart.ImageEffectsParametersFormat?)

                    || typeToConvert == typeof(global::Picsart.ImageLaserEngravingEffectParametersFormat)

                    || typeToConvert == typeof(global::Picsart.ImageLaserEngravingEffectParametersFormat?)

                    || typeToConvert == typeof(global::Picsart.ImageAIEffectsParametersEffectName)

                    || typeToConvert == typeof(global::Picsart.ImageAIEffectsParametersEffectName?)

                    || typeToConvert == typeof(global::Picsart.ImageAIEffectsParametersFormat)

                    || typeToConvert == typeof(global::Picsart.ImageAIEffectsParametersFormat?)

                    || typeToConvert == typeof(global::Picsart.ImageEffectsPreviewsParametersEffectName)

                    || typeToConvert == typeof(global::Picsart.ImageEffectsPreviewsParametersEffectName?)

                    || typeToConvert == typeof(global::Picsart.ImageEffectsPreviewsParametersFormat)

                    || typeToConvert == typeof(global::Picsart.ImageEffectsPreviewsParametersFormat?)

                    || typeToConvert == typeof(global::Picsart.ImageAdjustParametersFormat)

                    || typeToConvert == typeof(global::Picsart.ImageAdjustParametersFormat?)

                    || typeToConvert == typeof(global::Picsart.ImageSelectiveBlurParametersFormat)

                    || typeToConvert == typeof(global::Picsart.ImageSelectiveBlurParametersFormat?)

                    || typeToConvert == typeof(global::Picsart.ImageSmartCropParametersRatio)

                    || typeToConvert == typeof(global::Picsart.ImageSmartCropParametersRatio?)

                    || typeToConvert == typeof(global::Picsart.ImageSmartCropParametersFormat)

                    || typeToConvert == typeof(global::Picsart.ImageSmartCropParametersFormat?)

                    || typeToConvert == typeof(global::Picsart.ImageZoomParametersAnchorPoint)

                    || typeToConvert == typeof(global::Picsart.ImageZoomParametersAnchorPoint?)

                    || typeToConvert == typeof(global::Picsart.ImageZoomParametersFormat)

                    || typeToConvert == typeof(global::Picsart.ImageZoomParametersFormat?)

                    || typeToConvert == typeof(global::Picsart.ImageColorTransferParametersFormat)

                    || typeToConvert == typeof(global::Picsart.ImageColorTransferParametersFormat?)

                    || typeToConvert == typeof(global::Picsart.ImageStyleTransferParametersLevel)

                    || typeToConvert == typeof(global::Picsart.ImageStyleTransferParametersLevel?)

                    || typeToConvert == typeof(global::Picsart.ImageStyleTransferParametersFormat)

                    || typeToConvert == typeof(global::Picsart.ImageStyleTransferParametersFormat?)

                    || typeToConvert == typeof(global::Picsart.ImageRemoveBackgroundParametersOutputType)

                    || typeToConvert == typeof(global::Picsart.ImageRemoveBackgroundParametersOutputType?)

                    || typeToConvert == typeof(global::Picsart.ImageRemoveBackgroundParametersScale)

                    || typeToConvert == typeof(global::Picsart.ImageRemoveBackgroundParametersScale?)

                    || typeToConvert == typeof(global::Picsart.ImageRemoveBackgroundParametersShadow)

                    || typeToConvert == typeof(global::Picsart.ImageRemoveBackgroundParametersShadow?)

                    || typeToConvert == typeof(global::Picsart.ImageRemoveBackgroundParametersModel)

                    || typeToConvert == typeof(global::Picsart.ImageRemoveBackgroundParametersModel?)

                    || typeToConvert == typeof(global::Picsart.ImageRemoveBackgroundParametersFormat)

                    || typeToConvert == typeof(global::Picsart.ImageRemoveBackgroundParametersFormat?)

                    || typeToConvert == typeof(global::Picsart.ImageRemoveBackgroundParametersJSONOutputType)

                    || typeToConvert == typeof(global::Picsart.ImageRemoveBackgroundParametersJSONOutputType?)

                    || typeToConvert == typeof(global::Picsart.ImageRemoveBackgroundParametersJSONScale)

                    || typeToConvert == typeof(global::Picsart.ImageRemoveBackgroundParametersJSONScale?)

                    || typeToConvert == typeof(global::Picsart.ImageRemoveBackgroundParametersJSONShadow)

                    || typeToConvert == typeof(global::Picsart.ImageRemoveBackgroundParametersJSONShadow?)

                    || typeToConvert == typeof(global::Picsart.ImageRemoveBackgroundParametersJSONModel)

                    || typeToConvert == typeof(global::Picsart.ImageRemoveBackgroundParametersJSONModel?)

                    || typeToConvert == typeof(global::Picsart.ImageRemoveBackgroundParametersJSONFormat)

                    || typeToConvert == typeof(global::Picsart.ImageRemoveBackgroundParametersJSONFormat?)

                    || typeToConvert == typeof(global::Picsart.ImageMultiMattingSegmentationParametersSegmentationClass)

                    || typeToConvert == typeof(global::Picsart.ImageMultiMattingSegmentationParametersSegmentationClass?)

                    || typeToConvert == typeof(global::Picsart.ImageMasksParametersFormat)

                    || typeToConvert == typeof(global::Picsart.ImageMasksParametersFormat?)

                    || typeToConvert == typeof(global::Picsart.ImageMasksParametersBlend)

                    || typeToConvert == typeof(global::Picsart.ImageMasksParametersBlend?)

                    || typeToConvert == typeof(global::Picsart.ImageMasksParametersMask)

                    || typeToConvert == typeof(global::Picsart.ImageMasksParametersMask?)

                    || typeToConvert == typeof(global::Picsart.ImageMasksParametersMaskFlip)

                    || typeToConvert == typeof(global::Picsart.ImageMasksParametersMaskFlip?)

                    || typeToConvert == typeof(global::Picsart.ImageMasksPreviewParametersFormat)

                    || typeToConvert == typeof(global::Picsart.ImageMasksPreviewParametersFormat?)

                    || typeToConvert == typeof(global::Picsart.ImageMasksPreviewParametersBlend)

                    || typeToConvert == typeof(global::Picsart.ImageMasksPreviewParametersBlend?)

                    || typeToConvert == typeof(global::Picsart.ImageMasksPreviewParametersMaskItem)

                    || typeToConvert == typeof(global::Picsart.ImageMasksPreviewParametersMaskItem?)

                    || typeToConvert == typeof(global::Picsart.ImageMasksPreviewParametersMaskFlip)

                    || typeToConvert == typeof(global::Picsart.ImageMasksPreviewParametersMaskFlip?)

                    || typeToConvert == typeof(global::Picsart.ImageTextureParametersFormat)

                    || typeToConvert == typeof(global::Picsart.ImageTextureParametersFormat?)

                    || typeToConvert == typeof(global::Picsart.ImageTextureParametersPattern)

                    || typeToConvert == typeof(global::Picsart.ImageTextureParametersPattern?)

                    || typeToConvert == typeof(global::Picsart.ImageUpscaleUltraParametersProductType)

                    || typeToConvert == typeof(global::Picsart.ImageUpscaleUltraParametersProductType?)

                    || typeToConvert == typeof(global::Picsart.ImageUpscaleUltraParametersImageType)

                    || typeToConvert == typeof(global::Picsart.ImageUpscaleUltraParametersImageType?)

                    || typeToConvert == typeof(global::Picsart.ImageUpscaleUltraParametersMode)

                    || typeToConvert == typeof(global::Picsart.ImageUpscaleUltraParametersMode?)

                    || typeToConvert == typeof(global::Picsart.ImageUpscaleUltraParametersFormat)

                    || typeToConvert == typeof(global::Picsart.ImageUpscaleUltraParametersFormat?)

                    || typeToConvert == typeof(global::Picsart.ImageUpscaleEnhanceParametersFormat)

                    || typeToConvert == typeof(global::Picsart.ImageUpscaleEnhanceParametersFormat?)

                    || typeToConvert == typeof(global::Picsart.ImageSurfacemapParametersFormat)

                    || typeToConvert == typeof(global::Picsart.ImageSurfacemapParametersFormat?)

                    || typeToConvert == typeof(global::Picsart.ImageFaceEnhanceParametersFormat)

                    || typeToConvert == typeof(global::Picsart.ImageFaceEnhanceParametersFormat?)

                    || typeToConvert == typeof(global::Picsart.ImageEditParametersFormat)

                    || typeToConvert == typeof(global::Picsart.ImageEditParametersFormat?)

                    || typeToConvert == typeof(global::Picsart.ImageEditParametersMode)

                    || typeToConvert == typeof(global::Picsart.ImageEditParametersMode?)

                    || typeToConvert == typeof(global::Picsart.ImageEditParametersCropAnchor)

                    || typeToConvert == typeof(global::Picsart.ImageEditParametersCropAnchor?)

                    || typeToConvert == typeof(global::Picsart.ImageEditParametersFlip)

                    || typeToConvert == typeof(global::Picsart.ImageEditParametersFlip?)

                    || typeToConvert == typeof(global::Picsart.ImageOverlayParametersBlendMode)

                    || typeToConvert == typeof(global::Picsart.ImageOverlayParametersBlendMode?)

                    || typeToConvert == typeof(global::Picsart.ImageOverlayParametersFormat)

                    || typeToConvert == typeof(global::Picsart.ImageOverlayParametersFormat?)

                    || typeToConvert == typeof(global::Picsart.ImageWatermarkParametersAnchorPoint)

                    || typeToConvert == typeof(global::Picsart.ImageWatermarkParametersAnchorPoint?)

                    || typeToConvert == typeof(global::Picsart.VideoExportParametersExportFormat)

                    || typeToConvert == typeof(global::Picsart.VideoExportParametersExportFormat?)

                    || typeToConvert == typeof(global::Picsart.VideoExtendedExportParametersExportFormat)

                    || typeToConvert == typeof(global::Picsart.VideoExtendedExportParametersExportFormat?)

                    || typeToConvert == typeof(global::Picsart.VideoExtendedExportParametersExportQuality)

                    || typeToConvert == typeof(global::Picsart.VideoExtendedExportParametersExportQuality?)

                    || typeToConvert == typeof(global::Picsart.VideoExtendedExportParametersExportCodec)

                    || typeToConvert == typeof(global::Picsart.VideoExtendedExportParametersExportCodec?)

                    || typeToConvert == typeof(global::Picsart.VideoExtendedExportParametersExportAudioCodec)

                    || typeToConvert == typeof(global::Picsart.VideoExtendedExportParametersExportAudioCodec?)

                    || typeToConvert == typeof(global::Picsart.VideoExtendedExportParametersExportColorSpace)

                    || typeToConvert == typeof(global::Picsart.VideoExtendedExportParametersExportColorSpace?)

                    || typeToConvert == typeof(global::Picsart.VideoTranscribeParametersLanguage)

                    || typeToConvert == typeof(global::Picsart.VideoTranscribeParametersLanguage?)

                    || typeToConvert == typeof(global::Picsart.VideoTranscribeParametersFormat)

                    || typeToConvert == typeof(global::Picsart.VideoTranscribeParametersFormat?)

                    || typeToConvert == typeof(global::Picsart.VideoTranscribeParametersGranularity)

                    || typeToConvert == typeof(global::Picsart.VideoTranscribeParametersGranularity?)

                    || typeToConvert == typeof(global::Picsart.VideoExtractAudioParametersFormat)

                    || typeToConvert == typeof(global::Picsart.VideoExtractAudioParametersFormat?)

                    || typeToConvert == typeof(global::Picsart.VideoEffectsParametersEffectName)

                    || typeToConvert == typeof(global::Picsart.VideoEffectsParametersEffectName?)

                    || typeToConvert == typeof(global::Picsart.VideoVideoGetThumbnailParametersSource)

                    || typeToConvert == typeof(global::Picsart.VideoVideoGetThumbnailParametersSource?)

                    || typeToConvert == typeof(global::Picsart.VideoTransitionTransition)

                    || typeToConvert == typeof(global::Picsart.VideoTransitionTransition?)

                    || typeToConvert == typeof(global::Picsart.VideoConcatImageParametersScale)

                    || typeToConvert == typeof(global::Picsart.VideoConcatImageParametersScale?)

                    || typeToConvert == typeof(global::Picsart.VideoConcatSegmentsParametersTrimSegmentTransition)

                    || typeToConvert == typeof(global::Picsart.VideoConcatSegmentsParametersTrimSegmentTransition?)

                    || typeToConvert == typeof(global::Picsart.VideoWatermarkParametersAnchorPoint)

                    || typeToConvert == typeof(global::Picsart.VideoWatermarkParametersAnchorPoint?)

                    || typeToConvert == typeof(global::Picsart.GenAIText2TextModelsModel)

                    || typeToConvert == typeof(global::Picsart.GenAIText2TextModelsModel?)

                    || typeToConvert == typeof(global::Picsart.GenAIText2VideoParametersQuality)

                    || typeToConvert == typeof(global::Picsart.GenAIText2VideoParametersQuality?)

                    || typeToConvert == typeof(global::Picsart.GenAIText2SpeechParametersLanguage)

                    || typeToConvert == typeof(global::Picsart.GenAIText2SpeechParametersLanguage?)

                    || typeToConvert == typeof(global::Picsart.GenAIText2SpeechModelsModel)

                    || typeToConvert == typeof(global::Picsart.GenAIText2SpeechModelsModel?)

                    || typeToConvert == typeof(global::Picsart.GenAIText2SoundModelsModel)

                    || typeToConvert == typeof(global::Picsart.GenAIText2SoundModelsModel?)

                    || typeToConvert == typeof(global::Picsart.GenAIText2ImageModelsModel)

                    || typeToConvert == typeof(global::Picsart.GenAIText2ImageModelsModel?)

                    || typeToConvert == typeof(global::Picsart.GenAIText2StickerModelsModel)

                    || typeToConvert == typeof(global::Picsart.GenAIText2StickerModelsModel?)

                    || typeToConvert == typeof(global::Picsart.GenAILogoModelsModel)

                    || typeToConvert == typeof(global::Picsart.GenAILogoModelsModel?)

                    || typeToConvert == typeof(global::Picsart.GenAIText2VideoModelsModel)

                    || typeToConvert == typeof(global::Picsart.GenAIText2VideoModelsModel?)

                    || typeToConvert == typeof(global::Picsart.GenAIImage2VideoModelsModel)

                    || typeToConvert == typeof(global::Picsart.GenAIImage2VideoModelsModel?)

                    || typeToConvert == typeof(global::Picsart.GenAILaserEngravingParametersFormat)

                    || typeToConvert == typeof(global::Picsart.GenAILaserEngravingParametersFormat?)

                    || typeToConvert == typeof(global::Picsart.GenAILaserEngravingModelsModel)

                    || typeToConvert == typeof(global::Picsart.GenAILaserEngravingModelsModel?)

                    || typeToConvert == typeof(global::Picsart.GenAILogoParametersColorTone)

                    || typeToConvert == typeof(global::Picsart.GenAILogoParametersColorTone?)

                    || typeToConvert == typeof(global::Picsart.GenAIInpaintingParametersFormat)

                    || typeToConvert == typeof(global::Picsart.GenAIInpaintingParametersFormat?)

                    || typeToConvert == typeof(global::Picsart.GenAIInpaintingParametersMode)

                    || typeToConvert == typeof(global::Picsart.GenAIInpaintingParametersMode?)

                    || typeToConvert == typeof(global::Picsart.GenAIRemoveObjectParametersFormat)

                    || typeToConvert == typeof(global::Picsart.GenAIRemoveObjectParametersFormat?)

                    || typeToConvert == typeof(global::Picsart.GenAIRemoveObjectParametersMode)

                    || typeToConvert == typeof(global::Picsart.GenAIRemoveObjectParametersMode?)

                    || typeToConvert == typeof(global::Picsart.GenAIExpandParametersDirection)

                    || typeToConvert == typeof(global::Picsart.GenAIExpandParametersDirection?)

                    || typeToConvert == typeof(global::Picsart.GenAIExpandParametersFormat)

                    || typeToConvert == typeof(global::Picsart.GenAIExpandParametersFormat?)

                    || typeToConvert == typeof(global::Picsart.GenAIExpandParametersMode)

                    || typeToConvert == typeof(global::Picsart.GenAIExpandParametersMode?)

                    || typeToConvert == typeof(global::Picsart.GenAIBleedParametersFormat)

                    || typeToConvert == typeof(global::Picsart.GenAIBleedParametersFormat?)

                    || typeToConvert == typeof(global::Picsart.VDExportReplayParametersFormat)

                    || typeToConvert == typeof(global::Picsart.VDExportReplayParametersFormat?)

                    || typeToConvert == typeof(global::Picsart.VDExportVariableDataContentParametersFormat)

                    || typeToConvert == typeof(global::Picsart.VDExportVariableDataContentParametersFormat?)

                    || typeToConvert == typeof(global::Picsart.ImageCarsClassifierResponseDataClass)

                    || typeToConvert == typeof(global::Picsart.ImageCarsClassifierResponseDataClass?)

                    || typeToConvert == typeof(global::Picsart.VideoUpscaleFpsResponseStatus)

                    || typeToConvert == typeof(global::Picsart.VideoUpscaleFpsResponseStatus?)

                    || typeToConvert == typeof(global::Picsart.VideoUpscaleFpsGetresultResponseStatus)

                    || typeToConvert == typeof(global::Picsart.VideoUpscaleFpsGetresultResponseStatus?)

                    || typeToConvert == typeof(global::Picsart.VideoUpscaleFpsGetresultResponseStatus2)

                    || typeToConvert == typeof(global::Picsart.VideoUpscaleFpsGetresultResponseStatus2?)

                    || typeToConvert == typeof(global::Picsart.VideoRemoveBackgroundResponseStatus)

                    || typeToConvert == typeof(global::Picsart.VideoRemoveBackgroundResponseStatus?)

                    || typeToConvert == typeof(global::Picsart.VideoAdjustResponseStatus)

                    || typeToConvert == typeof(global::Picsart.VideoAdjustResponseStatus?)

                    || typeToConvert == typeof(global::Picsart.VideoApplyEffectResponseStatus)

                    || typeToConvert == typeof(global::Picsart.VideoApplyEffectResponseStatus?)

                    || typeToConvert == typeof(global::Picsart.VideoEditResponseStatus)

                    || typeToConvert == typeof(global::Picsart.VideoEditResponseStatus?)

                    || typeToConvert == typeof(global::Picsart.VideoTrimResponseStatus)

                    || typeToConvert == typeof(global::Picsart.VideoTrimResponseStatus?)

                    || typeToConvert == typeof(global::Picsart.VideoCropResponseStatus)

                    || typeToConvert == typeof(global::Picsart.VideoCropResponseStatus?)

                    || typeToConvert == typeof(global::Picsart.VideoConcatResponseStatus)

                    || typeToConvert == typeof(global::Picsart.VideoConcatResponseStatus?)

                    || typeToConvert == typeof(global::Picsart.VideoConcatHighlightsResponseStatus)

                    || typeToConvert == typeof(global::Picsart.VideoConcatHighlightsResponseStatus?)

                    || typeToConvert == typeof(global::Picsart.VideoFitResponseStatus)

                    || typeToConvert == typeof(global::Picsart.VideoFitResponseStatus?)

                    || typeToConvert == typeof(global::Picsart.VideoMetadataResponseStatus)

                    || typeToConvert == typeof(global::Picsart.VideoMetadataResponseStatus?)

                    || typeToConvert == typeof(global::Picsart.VideoGetThumbnailResponseStatus)

                    || typeToConvert == typeof(global::Picsart.VideoGetThumbnailResponseStatus?)

                    || typeToConvert == typeof(global::Picsart.VideoSetThumbnailResponseStatus)

                    || typeToConvert == typeof(global::Picsart.VideoSetThumbnailResponseStatus?)

                    || typeToConvert == typeof(global::Picsart.VideoSetThumbnailGetresultResponseStatus)

                    || typeToConvert == typeof(global::Picsart.VideoSetThumbnailGetresultResponseStatus?)

                    || typeToConvert == typeof(global::Picsart.VideoSetThumbnailGetresultResponseStatus2)

                    || typeToConvert == typeof(global::Picsart.VideoSetThumbnailGetresultResponseStatus2?)

                    || typeToConvert == typeof(global::Picsart.VideoEncodeCtvResponseStatus)

                    || typeToConvert == typeof(global::Picsart.VideoEncodeCtvResponseStatus?)

                    || typeToConvert == typeof(global::Picsart.VideoAdjustAudioResponseStatus)

                    || typeToConvert == typeof(global::Picsart.VideoAdjustAudioResponseStatus?)

                    || typeToConvert == typeof(global::Picsart.VideoExtractAudioResponseStatus)

                    || typeToConvert == typeof(global::Picsart.VideoExtractAudioResponseStatus?)

                    || typeToConvert == typeof(global::Picsart.VideoTranscribeAudioResponseStatus)

                    || typeToConvert == typeof(global::Picsart.VideoTranscribeAudioResponseStatus?)

                    || typeToConvert == typeof(global::Picsart.VideoTranscribeAudioGetresultResponseStatus)

                    || typeToConvert == typeof(global::Picsart.VideoTranscribeAudioGetresultResponseStatus?)

                    || typeToConvert == typeof(global::Picsart.VideoTranscribeAudioGetresultResponseStatus2)

                    || typeToConvert == typeof(global::Picsart.VideoTranscribeAudioGetresultResponseStatus2?)

                    || typeToConvert == typeof(global::Picsart.VideoAddWatermarkResponseStatus)

                    || typeToConvert == typeof(global::Picsart.VideoAddWatermarkResponseStatus?)

                    || typeToConvert == typeof(global::Picsart.VideoGetresultResponseStatus)

                    || typeToConvert == typeof(global::Picsart.VideoGetresultResponseStatus?)

                    || typeToConvert == typeof(global::Picsart.VideoGetresultResponseStatus2)

                    || typeToConvert == typeof(global::Picsart.VideoGetresultResponseStatus2?)

                    || typeToConvert == typeof(global::Picsart.VideoGetaudioresultResponseStatus)

                    || typeToConvert == typeof(global::Picsart.VideoGetaudioresultResponseStatus?)

                    || typeToConvert == typeof(global::Picsart.VideoGetaudioresultResponseStatus2)

                    || typeToConvert == typeof(global::Picsart.VideoGetaudioresultResponseStatus2?)

                    || typeToConvert == typeof(global::Picsart.VideoUploadResponseStatus)

                    || typeToConvert == typeof(global::Picsart.VideoUploadResponseStatus?)

                    || typeToConvert == typeof(global::Picsart.GenaiText2imageResponseStatus)

                    || typeToConvert == typeof(global::Picsart.GenaiText2imageResponseStatus?)

                    || typeToConvert == typeof(global::Picsart.GenaiText2imageGetresultResponseStatus)

                    || typeToConvert == typeof(global::Picsart.GenaiText2imageGetresultResponseStatus?)

                    || typeToConvert == typeof(global::Picsart.GenaiText2stickerResponseStatus)

                    || typeToConvert == typeof(global::Picsart.GenaiText2stickerResponseStatus?)

                    || typeToConvert == typeof(global::Picsart.GenaiText2stickerLaserEngravingResponseStatus)

                    || typeToConvert == typeof(global::Picsart.GenaiText2stickerLaserEngravingResponseStatus?)

                    || typeToConvert == typeof(global::Picsart.GenaiText2stickerGetresultResponseStatus)

                    || typeToConvert == typeof(global::Picsart.GenaiText2stickerGetresultResponseStatus?)

                    || typeToConvert == typeof(global::Picsart.GenaiGenerateLogoResponseStatus)

                    || typeToConvert == typeof(global::Picsart.GenaiGenerateLogoResponseStatus?)

                    || typeToConvert == typeof(global::Picsart.GenaiGenerateLogoGetresultResponseStatus)

                    || typeToConvert == typeof(global::Picsart.GenaiGenerateLogoGetresultResponseStatus?)

                    || typeToConvert == typeof(global::Picsart.GenaiText2videoResponseStatus)

                    || typeToConvert == typeof(global::Picsart.GenaiText2videoResponseStatus?)

                    || typeToConvert == typeof(global::Picsart.GenaiImage2videoResponseStatus)

                    || typeToConvert == typeof(global::Picsart.GenaiImage2videoResponseStatus?)

                    || typeToConvert == typeof(global::Picsart.GenaiText2videoGetresultResponseStatus)

                    || typeToConvert == typeof(global::Picsart.GenaiText2videoGetresultResponseStatus?)

                    || typeToConvert == typeof(global::Picsart.GenaiText2speechResponseStatus)

                    || typeToConvert == typeof(global::Picsart.GenaiText2speechResponseStatus?)

                    || typeToConvert == typeof(global::Picsart.GenaiText2soundResponseStatus)

                    || typeToConvert == typeof(global::Picsart.GenaiText2soundResponseStatus?)

                    || typeToConvert == typeof(global::Picsart.GenaiText2audioGetresultResponseStatus)

                    || typeToConvert == typeof(global::Picsart.GenaiText2audioGetresultResponseStatus?)

                    || typeToConvert == typeof(global::Picsart.VdDescribeVariableDataContentResponseDataTagType)

                    || typeToConvert == typeof(global::Picsart.VdDescribeVariableDataContentResponseDataTagType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Picsart.ImageExportParametersFormat))
                {
                    return new global::Picsart.JsonConverters.ImageExportParametersFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageExportParametersFormat?))
                {
                    return new global::Picsart.JsonConverters.ImageExportParametersFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageUpscaleParametersFormat))
                {
                    return new global::Picsart.JsonConverters.ImageUpscaleParametersFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageUpscaleParametersFormat?))
                {
                    return new global::Picsart.JsonConverters.ImageUpscaleParametersFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageEffectsParametersEffectName))
                {
                    return new global::Picsart.JsonConverters.ImageEffectsParametersEffectNameJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageEffectsParametersEffectName?))
                {
                    return new global::Picsart.JsonConverters.ImageEffectsParametersEffectNameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageEffectsParametersFormat))
                {
                    return new global::Picsart.JsonConverters.ImageEffectsParametersFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageEffectsParametersFormat?))
                {
                    return new global::Picsart.JsonConverters.ImageEffectsParametersFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageLaserEngravingEffectParametersFormat))
                {
                    return new global::Picsart.JsonConverters.ImageLaserEngravingEffectParametersFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageLaserEngravingEffectParametersFormat?))
                {
                    return new global::Picsart.JsonConverters.ImageLaserEngravingEffectParametersFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageAIEffectsParametersEffectName))
                {
                    return new global::Picsart.JsonConverters.ImageAIEffectsParametersEffectNameJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageAIEffectsParametersEffectName?))
                {
                    return new global::Picsart.JsonConverters.ImageAIEffectsParametersEffectNameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageAIEffectsParametersFormat))
                {
                    return new global::Picsart.JsonConverters.ImageAIEffectsParametersFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageAIEffectsParametersFormat?))
                {
                    return new global::Picsart.JsonConverters.ImageAIEffectsParametersFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageEffectsPreviewsParametersEffectName))
                {
                    return new global::Picsart.JsonConverters.ImageEffectsPreviewsParametersEffectNameJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageEffectsPreviewsParametersEffectName?))
                {
                    return new global::Picsart.JsonConverters.ImageEffectsPreviewsParametersEffectNameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageEffectsPreviewsParametersFormat))
                {
                    return new global::Picsart.JsonConverters.ImageEffectsPreviewsParametersFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageEffectsPreviewsParametersFormat?))
                {
                    return new global::Picsart.JsonConverters.ImageEffectsPreviewsParametersFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageAdjustParametersFormat))
                {
                    return new global::Picsart.JsonConverters.ImageAdjustParametersFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageAdjustParametersFormat?))
                {
                    return new global::Picsart.JsonConverters.ImageAdjustParametersFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageSelectiveBlurParametersFormat))
                {
                    return new global::Picsart.JsonConverters.ImageSelectiveBlurParametersFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageSelectiveBlurParametersFormat?))
                {
                    return new global::Picsart.JsonConverters.ImageSelectiveBlurParametersFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageSmartCropParametersRatio))
                {
                    return new global::Picsart.JsonConverters.ImageSmartCropParametersRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageSmartCropParametersRatio?))
                {
                    return new global::Picsart.JsonConverters.ImageSmartCropParametersRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageSmartCropParametersFormat))
                {
                    return new global::Picsart.JsonConverters.ImageSmartCropParametersFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageSmartCropParametersFormat?))
                {
                    return new global::Picsart.JsonConverters.ImageSmartCropParametersFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageZoomParametersAnchorPoint))
                {
                    return new global::Picsart.JsonConverters.ImageZoomParametersAnchorPointJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageZoomParametersAnchorPoint?))
                {
                    return new global::Picsart.JsonConverters.ImageZoomParametersAnchorPointNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageZoomParametersFormat))
                {
                    return new global::Picsart.JsonConverters.ImageZoomParametersFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageZoomParametersFormat?))
                {
                    return new global::Picsart.JsonConverters.ImageZoomParametersFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageColorTransferParametersFormat))
                {
                    return new global::Picsart.JsonConverters.ImageColorTransferParametersFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageColorTransferParametersFormat?))
                {
                    return new global::Picsart.JsonConverters.ImageColorTransferParametersFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageStyleTransferParametersLevel))
                {
                    return new global::Picsart.JsonConverters.ImageStyleTransferParametersLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageStyleTransferParametersLevel?))
                {
                    return new global::Picsart.JsonConverters.ImageStyleTransferParametersLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageStyleTransferParametersFormat))
                {
                    return new global::Picsart.JsonConverters.ImageStyleTransferParametersFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageStyleTransferParametersFormat?))
                {
                    return new global::Picsart.JsonConverters.ImageStyleTransferParametersFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageRemoveBackgroundParametersOutputType))
                {
                    return new global::Picsart.JsonConverters.ImageRemoveBackgroundParametersOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageRemoveBackgroundParametersOutputType?))
                {
                    return new global::Picsart.JsonConverters.ImageRemoveBackgroundParametersOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageRemoveBackgroundParametersScale))
                {
                    return new global::Picsart.JsonConverters.ImageRemoveBackgroundParametersScaleJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageRemoveBackgroundParametersScale?))
                {
                    return new global::Picsart.JsonConverters.ImageRemoveBackgroundParametersScaleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageRemoveBackgroundParametersShadow))
                {
                    return new global::Picsart.JsonConverters.ImageRemoveBackgroundParametersShadowJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageRemoveBackgroundParametersShadow?))
                {
                    return new global::Picsart.JsonConverters.ImageRemoveBackgroundParametersShadowNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageRemoveBackgroundParametersModel))
                {
                    return new global::Picsart.JsonConverters.ImageRemoveBackgroundParametersModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageRemoveBackgroundParametersModel?))
                {
                    return new global::Picsart.JsonConverters.ImageRemoveBackgroundParametersModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageRemoveBackgroundParametersFormat))
                {
                    return new global::Picsart.JsonConverters.ImageRemoveBackgroundParametersFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageRemoveBackgroundParametersFormat?))
                {
                    return new global::Picsart.JsonConverters.ImageRemoveBackgroundParametersFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageRemoveBackgroundParametersJSONOutputType))
                {
                    return new global::Picsart.JsonConverters.ImageRemoveBackgroundParametersJSONOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageRemoveBackgroundParametersJSONOutputType?))
                {
                    return new global::Picsart.JsonConverters.ImageRemoveBackgroundParametersJSONOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageRemoveBackgroundParametersJSONScale))
                {
                    return new global::Picsart.JsonConverters.ImageRemoveBackgroundParametersJSONScaleJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageRemoveBackgroundParametersJSONScale?))
                {
                    return new global::Picsart.JsonConverters.ImageRemoveBackgroundParametersJSONScaleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageRemoveBackgroundParametersJSONShadow))
                {
                    return new global::Picsart.JsonConverters.ImageRemoveBackgroundParametersJSONShadowJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageRemoveBackgroundParametersJSONShadow?))
                {
                    return new global::Picsart.JsonConverters.ImageRemoveBackgroundParametersJSONShadowNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageRemoveBackgroundParametersJSONModel))
                {
                    return new global::Picsart.JsonConverters.ImageRemoveBackgroundParametersJSONModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageRemoveBackgroundParametersJSONModel?))
                {
                    return new global::Picsart.JsonConverters.ImageRemoveBackgroundParametersJSONModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageRemoveBackgroundParametersJSONFormat))
                {
                    return new global::Picsart.JsonConverters.ImageRemoveBackgroundParametersJSONFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageRemoveBackgroundParametersJSONFormat?))
                {
                    return new global::Picsart.JsonConverters.ImageRemoveBackgroundParametersJSONFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageMultiMattingSegmentationParametersSegmentationClass))
                {
                    return new global::Picsart.JsonConverters.ImageMultiMattingSegmentationParametersSegmentationClassJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageMultiMattingSegmentationParametersSegmentationClass?))
                {
                    return new global::Picsart.JsonConverters.ImageMultiMattingSegmentationParametersSegmentationClassNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageMasksParametersFormat))
                {
                    return new global::Picsart.JsonConverters.ImageMasksParametersFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageMasksParametersFormat?))
                {
                    return new global::Picsart.JsonConverters.ImageMasksParametersFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageMasksParametersBlend))
                {
                    return new global::Picsart.JsonConverters.ImageMasksParametersBlendJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageMasksParametersBlend?))
                {
                    return new global::Picsart.JsonConverters.ImageMasksParametersBlendNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageMasksParametersMask))
                {
                    return new global::Picsart.JsonConverters.ImageMasksParametersMaskJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageMasksParametersMask?))
                {
                    return new global::Picsart.JsonConverters.ImageMasksParametersMaskNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageMasksParametersMaskFlip))
                {
                    return new global::Picsart.JsonConverters.ImageMasksParametersMaskFlipJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageMasksParametersMaskFlip?))
                {
                    return new global::Picsart.JsonConverters.ImageMasksParametersMaskFlipNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageMasksPreviewParametersFormat))
                {
                    return new global::Picsart.JsonConverters.ImageMasksPreviewParametersFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageMasksPreviewParametersFormat?))
                {
                    return new global::Picsart.JsonConverters.ImageMasksPreviewParametersFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageMasksPreviewParametersBlend))
                {
                    return new global::Picsart.JsonConverters.ImageMasksPreviewParametersBlendJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageMasksPreviewParametersBlend?))
                {
                    return new global::Picsart.JsonConverters.ImageMasksPreviewParametersBlendNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageMasksPreviewParametersMaskItem))
                {
                    return new global::Picsart.JsonConverters.ImageMasksPreviewParametersMaskItemJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageMasksPreviewParametersMaskItem?))
                {
                    return new global::Picsart.JsonConverters.ImageMasksPreviewParametersMaskItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageMasksPreviewParametersMaskFlip))
                {
                    return new global::Picsart.JsonConverters.ImageMasksPreviewParametersMaskFlipJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageMasksPreviewParametersMaskFlip?))
                {
                    return new global::Picsart.JsonConverters.ImageMasksPreviewParametersMaskFlipNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageTextureParametersFormat))
                {
                    return new global::Picsart.JsonConverters.ImageTextureParametersFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageTextureParametersFormat?))
                {
                    return new global::Picsart.JsonConverters.ImageTextureParametersFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageTextureParametersPattern))
                {
                    return new global::Picsart.JsonConverters.ImageTextureParametersPatternJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageTextureParametersPattern?))
                {
                    return new global::Picsart.JsonConverters.ImageTextureParametersPatternNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageUpscaleUltraParametersProductType))
                {
                    return new global::Picsart.JsonConverters.ImageUpscaleUltraParametersProductTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageUpscaleUltraParametersProductType?))
                {
                    return new global::Picsart.JsonConverters.ImageUpscaleUltraParametersProductTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageUpscaleUltraParametersImageType))
                {
                    return new global::Picsart.JsonConverters.ImageUpscaleUltraParametersImageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageUpscaleUltraParametersImageType?))
                {
                    return new global::Picsart.JsonConverters.ImageUpscaleUltraParametersImageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageUpscaleUltraParametersMode))
                {
                    return new global::Picsart.JsonConverters.ImageUpscaleUltraParametersModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageUpscaleUltraParametersMode?))
                {
                    return new global::Picsart.JsonConverters.ImageUpscaleUltraParametersModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageUpscaleUltraParametersFormat))
                {
                    return new global::Picsart.JsonConverters.ImageUpscaleUltraParametersFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageUpscaleUltraParametersFormat?))
                {
                    return new global::Picsart.JsonConverters.ImageUpscaleUltraParametersFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageUpscaleEnhanceParametersFormat))
                {
                    return new global::Picsart.JsonConverters.ImageUpscaleEnhanceParametersFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageUpscaleEnhanceParametersFormat?))
                {
                    return new global::Picsart.JsonConverters.ImageUpscaleEnhanceParametersFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageSurfacemapParametersFormat))
                {
                    return new global::Picsart.JsonConverters.ImageSurfacemapParametersFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageSurfacemapParametersFormat?))
                {
                    return new global::Picsart.JsonConverters.ImageSurfacemapParametersFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageFaceEnhanceParametersFormat))
                {
                    return new global::Picsart.JsonConverters.ImageFaceEnhanceParametersFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageFaceEnhanceParametersFormat?))
                {
                    return new global::Picsart.JsonConverters.ImageFaceEnhanceParametersFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageEditParametersFormat))
                {
                    return new global::Picsart.JsonConverters.ImageEditParametersFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageEditParametersFormat?))
                {
                    return new global::Picsart.JsonConverters.ImageEditParametersFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageEditParametersMode))
                {
                    return new global::Picsart.JsonConverters.ImageEditParametersModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageEditParametersMode?))
                {
                    return new global::Picsart.JsonConverters.ImageEditParametersModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageEditParametersCropAnchor))
                {
                    return new global::Picsart.JsonConverters.ImageEditParametersCropAnchorJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageEditParametersCropAnchor?))
                {
                    return new global::Picsart.JsonConverters.ImageEditParametersCropAnchorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageEditParametersFlip))
                {
                    return new global::Picsart.JsonConverters.ImageEditParametersFlipJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageEditParametersFlip?))
                {
                    return new global::Picsart.JsonConverters.ImageEditParametersFlipNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageOverlayParametersBlendMode))
                {
                    return new global::Picsart.JsonConverters.ImageOverlayParametersBlendModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageOverlayParametersBlendMode?))
                {
                    return new global::Picsart.JsonConverters.ImageOverlayParametersBlendModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageOverlayParametersFormat))
                {
                    return new global::Picsart.JsonConverters.ImageOverlayParametersFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageOverlayParametersFormat?))
                {
                    return new global::Picsart.JsonConverters.ImageOverlayParametersFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageWatermarkParametersAnchorPoint))
                {
                    return new global::Picsart.JsonConverters.ImageWatermarkParametersAnchorPointJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageWatermarkParametersAnchorPoint?))
                {
                    return new global::Picsart.JsonConverters.ImageWatermarkParametersAnchorPointNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoExportParametersExportFormat))
                {
                    return new global::Picsart.JsonConverters.VideoExportParametersExportFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoExportParametersExportFormat?))
                {
                    return new global::Picsart.JsonConverters.VideoExportParametersExportFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoExtendedExportParametersExportFormat))
                {
                    return new global::Picsart.JsonConverters.VideoExtendedExportParametersExportFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoExtendedExportParametersExportFormat?))
                {
                    return new global::Picsart.JsonConverters.VideoExtendedExportParametersExportFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoExtendedExportParametersExportQuality))
                {
                    return new global::Picsart.JsonConverters.VideoExtendedExportParametersExportQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoExtendedExportParametersExportQuality?))
                {
                    return new global::Picsart.JsonConverters.VideoExtendedExportParametersExportQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoExtendedExportParametersExportCodec))
                {
                    return new global::Picsart.JsonConverters.VideoExtendedExportParametersExportCodecJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoExtendedExportParametersExportCodec?))
                {
                    return new global::Picsart.JsonConverters.VideoExtendedExportParametersExportCodecNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoExtendedExportParametersExportAudioCodec))
                {
                    return new global::Picsart.JsonConverters.VideoExtendedExportParametersExportAudioCodecJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoExtendedExportParametersExportAudioCodec?))
                {
                    return new global::Picsart.JsonConverters.VideoExtendedExportParametersExportAudioCodecNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoExtendedExportParametersExportColorSpace))
                {
                    return new global::Picsart.JsonConverters.VideoExtendedExportParametersExportColorSpaceJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoExtendedExportParametersExportColorSpace?))
                {
                    return new global::Picsart.JsonConverters.VideoExtendedExportParametersExportColorSpaceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoTranscribeParametersLanguage))
                {
                    return new global::Picsart.JsonConverters.VideoTranscribeParametersLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoTranscribeParametersLanguage?))
                {
                    return new global::Picsart.JsonConverters.VideoTranscribeParametersLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoTranscribeParametersFormat))
                {
                    return new global::Picsart.JsonConverters.VideoTranscribeParametersFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoTranscribeParametersFormat?))
                {
                    return new global::Picsart.JsonConverters.VideoTranscribeParametersFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoTranscribeParametersGranularity))
                {
                    return new global::Picsart.JsonConverters.VideoTranscribeParametersGranularityJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoTranscribeParametersGranularity?))
                {
                    return new global::Picsart.JsonConverters.VideoTranscribeParametersGranularityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoExtractAudioParametersFormat))
                {
                    return new global::Picsart.JsonConverters.VideoExtractAudioParametersFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoExtractAudioParametersFormat?))
                {
                    return new global::Picsart.JsonConverters.VideoExtractAudioParametersFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoEffectsParametersEffectName))
                {
                    return new global::Picsart.JsonConverters.VideoEffectsParametersEffectNameJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoEffectsParametersEffectName?))
                {
                    return new global::Picsart.JsonConverters.VideoEffectsParametersEffectNameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoVideoGetThumbnailParametersSource))
                {
                    return new global::Picsart.JsonConverters.VideoVideoGetThumbnailParametersSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoVideoGetThumbnailParametersSource?))
                {
                    return new global::Picsart.JsonConverters.VideoVideoGetThumbnailParametersSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoTransitionTransition))
                {
                    return new global::Picsart.JsonConverters.VideoTransitionTransitionJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoTransitionTransition?))
                {
                    return new global::Picsart.JsonConverters.VideoTransitionTransitionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoConcatImageParametersScale))
                {
                    return new global::Picsart.JsonConverters.VideoConcatImageParametersScaleJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoConcatImageParametersScale?))
                {
                    return new global::Picsart.JsonConverters.VideoConcatImageParametersScaleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoConcatSegmentsParametersTrimSegmentTransition))
                {
                    return new global::Picsart.JsonConverters.VideoConcatSegmentsParametersTrimSegmentTransitionJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoConcatSegmentsParametersTrimSegmentTransition?))
                {
                    return new global::Picsart.JsonConverters.VideoConcatSegmentsParametersTrimSegmentTransitionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoWatermarkParametersAnchorPoint))
                {
                    return new global::Picsart.JsonConverters.VideoWatermarkParametersAnchorPointJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoWatermarkParametersAnchorPoint?))
                {
                    return new global::Picsart.JsonConverters.VideoWatermarkParametersAnchorPointNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenAIText2TextModelsModel))
                {
                    return new global::Picsart.JsonConverters.GenAIText2TextModelsModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenAIText2TextModelsModel?))
                {
                    return new global::Picsart.JsonConverters.GenAIText2TextModelsModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenAIText2VideoParametersQuality))
                {
                    return new global::Picsart.JsonConverters.GenAIText2VideoParametersQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenAIText2VideoParametersQuality?))
                {
                    return new global::Picsart.JsonConverters.GenAIText2VideoParametersQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenAIText2SpeechParametersLanguage))
                {
                    return new global::Picsart.JsonConverters.GenAIText2SpeechParametersLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenAIText2SpeechParametersLanguage?))
                {
                    return new global::Picsart.JsonConverters.GenAIText2SpeechParametersLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenAIText2SpeechModelsModel))
                {
                    return new global::Picsart.JsonConverters.GenAIText2SpeechModelsModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenAIText2SpeechModelsModel?))
                {
                    return new global::Picsart.JsonConverters.GenAIText2SpeechModelsModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenAIText2SoundModelsModel))
                {
                    return new global::Picsart.JsonConverters.GenAIText2SoundModelsModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenAIText2SoundModelsModel?))
                {
                    return new global::Picsart.JsonConverters.GenAIText2SoundModelsModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenAIText2ImageModelsModel))
                {
                    return new global::Picsart.JsonConverters.GenAIText2ImageModelsModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenAIText2ImageModelsModel?))
                {
                    return new global::Picsart.JsonConverters.GenAIText2ImageModelsModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenAIText2StickerModelsModel))
                {
                    return new global::Picsart.JsonConverters.GenAIText2StickerModelsModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenAIText2StickerModelsModel?))
                {
                    return new global::Picsart.JsonConverters.GenAIText2StickerModelsModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenAILogoModelsModel))
                {
                    return new global::Picsart.JsonConverters.GenAILogoModelsModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenAILogoModelsModel?))
                {
                    return new global::Picsart.JsonConverters.GenAILogoModelsModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenAIText2VideoModelsModel))
                {
                    return new global::Picsart.JsonConverters.GenAIText2VideoModelsModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenAIText2VideoModelsModel?))
                {
                    return new global::Picsart.JsonConverters.GenAIText2VideoModelsModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenAIImage2VideoModelsModel))
                {
                    return new global::Picsart.JsonConverters.GenAIImage2VideoModelsModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenAIImage2VideoModelsModel?))
                {
                    return new global::Picsart.JsonConverters.GenAIImage2VideoModelsModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenAILaserEngravingParametersFormat))
                {
                    return new global::Picsart.JsonConverters.GenAILaserEngravingParametersFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenAILaserEngravingParametersFormat?))
                {
                    return new global::Picsart.JsonConverters.GenAILaserEngravingParametersFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenAILaserEngravingModelsModel))
                {
                    return new global::Picsart.JsonConverters.GenAILaserEngravingModelsModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenAILaserEngravingModelsModel?))
                {
                    return new global::Picsart.JsonConverters.GenAILaserEngravingModelsModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenAILogoParametersColorTone))
                {
                    return new global::Picsart.JsonConverters.GenAILogoParametersColorToneJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenAILogoParametersColorTone?))
                {
                    return new global::Picsart.JsonConverters.GenAILogoParametersColorToneNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenAIInpaintingParametersFormat))
                {
                    return new global::Picsart.JsonConverters.GenAIInpaintingParametersFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenAIInpaintingParametersFormat?))
                {
                    return new global::Picsart.JsonConverters.GenAIInpaintingParametersFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenAIInpaintingParametersMode))
                {
                    return new global::Picsart.JsonConverters.GenAIInpaintingParametersModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenAIInpaintingParametersMode?))
                {
                    return new global::Picsart.JsonConverters.GenAIInpaintingParametersModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenAIRemoveObjectParametersFormat))
                {
                    return new global::Picsart.JsonConverters.GenAIRemoveObjectParametersFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenAIRemoveObjectParametersFormat?))
                {
                    return new global::Picsart.JsonConverters.GenAIRemoveObjectParametersFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenAIRemoveObjectParametersMode))
                {
                    return new global::Picsart.JsonConverters.GenAIRemoveObjectParametersModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenAIRemoveObjectParametersMode?))
                {
                    return new global::Picsart.JsonConverters.GenAIRemoveObjectParametersModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenAIExpandParametersDirection))
                {
                    return new global::Picsart.JsonConverters.GenAIExpandParametersDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenAIExpandParametersDirection?))
                {
                    return new global::Picsart.JsonConverters.GenAIExpandParametersDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenAIExpandParametersFormat))
                {
                    return new global::Picsart.JsonConverters.GenAIExpandParametersFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenAIExpandParametersFormat?))
                {
                    return new global::Picsart.JsonConverters.GenAIExpandParametersFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenAIExpandParametersMode))
                {
                    return new global::Picsart.JsonConverters.GenAIExpandParametersModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenAIExpandParametersMode?))
                {
                    return new global::Picsart.JsonConverters.GenAIExpandParametersModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenAIBleedParametersFormat))
                {
                    return new global::Picsart.JsonConverters.GenAIBleedParametersFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenAIBleedParametersFormat?))
                {
                    return new global::Picsart.JsonConverters.GenAIBleedParametersFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VDExportReplayParametersFormat))
                {
                    return new global::Picsart.JsonConverters.VDExportReplayParametersFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VDExportReplayParametersFormat?))
                {
                    return new global::Picsart.JsonConverters.VDExportReplayParametersFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VDExportVariableDataContentParametersFormat))
                {
                    return new global::Picsart.JsonConverters.VDExportVariableDataContentParametersFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VDExportVariableDataContentParametersFormat?))
                {
                    return new global::Picsart.JsonConverters.VDExportVariableDataContentParametersFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageCarsClassifierResponseDataClass))
                {
                    return new global::Picsart.JsonConverters.ImageCarsClassifierResponseDataClassJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageCarsClassifierResponseDataClass?))
                {
                    return new global::Picsart.JsonConverters.ImageCarsClassifierResponseDataClassNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoUpscaleFpsResponseStatus))
                {
                    return new global::Picsart.JsonConverters.VideoUpscaleFpsResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoUpscaleFpsResponseStatus?))
                {
                    return new global::Picsart.JsonConverters.VideoUpscaleFpsResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoUpscaleFpsGetresultResponseStatus))
                {
                    return new global::Picsart.JsonConverters.VideoUpscaleFpsGetresultResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoUpscaleFpsGetresultResponseStatus?))
                {
                    return new global::Picsart.JsonConverters.VideoUpscaleFpsGetresultResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoUpscaleFpsGetresultResponseStatus2))
                {
                    return new global::Picsart.JsonConverters.VideoUpscaleFpsGetresultResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoUpscaleFpsGetresultResponseStatus2?))
                {
                    return new global::Picsart.JsonConverters.VideoUpscaleFpsGetresultResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoRemoveBackgroundResponseStatus))
                {
                    return new global::Picsart.JsonConverters.VideoRemoveBackgroundResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoRemoveBackgroundResponseStatus?))
                {
                    return new global::Picsart.JsonConverters.VideoRemoveBackgroundResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoAdjustResponseStatus))
                {
                    return new global::Picsart.JsonConverters.VideoAdjustResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoAdjustResponseStatus?))
                {
                    return new global::Picsart.JsonConverters.VideoAdjustResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoApplyEffectResponseStatus))
                {
                    return new global::Picsart.JsonConverters.VideoApplyEffectResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoApplyEffectResponseStatus?))
                {
                    return new global::Picsart.JsonConverters.VideoApplyEffectResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoEditResponseStatus))
                {
                    return new global::Picsart.JsonConverters.VideoEditResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoEditResponseStatus?))
                {
                    return new global::Picsart.JsonConverters.VideoEditResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoTrimResponseStatus))
                {
                    return new global::Picsart.JsonConverters.VideoTrimResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoTrimResponseStatus?))
                {
                    return new global::Picsart.JsonConverters.VideoTrimResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoCropResponseStatus))
                {
                    return new global::Picsart.JsonConverters.VideoCropResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoCropResponseStatus?))
                {
                    return new global::Picsart.JsonConverters.VideoCropResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoConcatResponseStatus))
                {
                    return new global::Picsart.JsonConverters.VideoConcatResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoConcatResponseStatus?))
                {
                    return new global::Picsart.JsonConverters.VideoConcatResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoConcatHighlightsResponseStatus))
                {
                    return new global::Picsart.JsonConverters.VideoConcatHighlightsResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoConcatHighlightsResponseStatus?))
                {
                    return new global::Picsart.JsonConverters.VideoConcatHighlightsResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoFitResponseStatus))
                {
                    return new global::Picsart.JsonConverters.VideoFitResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoFitResponseStatus?))
                {
                    return new global::Picsart.JsonConverters.VideoFitResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoMetadataResponseStatus))
                {
                    return new global::Picsart.JsonConverters.VideoMetadataResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoMetadataResponseStatus?))
                {
                    return new global::Picsart.JsonConverters.VideoMetadataResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoGetThumbnailResponseStatus))
                {
                    return new global::Picsart.JsonConverters.VideoGetThumbnailResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoGetThumbnailResponseStatus?))
                {
                    return new global::Picsart.JsonConverters.VideoGetThumbnailResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoSetThumbnailResponseStatus))
                {
                    return new global::Picsart.JsonConverters.VideoSetThumbnailResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoSetThumbnailResponseStatus?))
                {
                    return new global::Picsart.JsonConverters.VideoSetThumbnailResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoSetThumbnailGetresultResponseStatus))
                {
                    return new global::Picsart.JsonConverters.VideoSetThumbnailGetresultResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoSetThumbnailGetresultResponseStatus?))
                {
                    return new global::Picsart.JsonConverters.VideoSetThumbnailGetresultResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoSetThumbnailGetresultResponseStatus2))
                {
                    return new global::Picsart.JsonConverters.VideoSetThumbnailGetresultResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoSetThumbnailGetresultResponseStatus2?))
                {
                    return new global::Picsart.JsonConverters.VideoSetThumbnailGetresultResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoEncodeCtvResponseStatus))
                {
                    return new global::Picsart.JsonConverters.VideoEncodeCtvResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoEncodeCtvResponseStatus?))
                {
                    return new global::Picsart.JsonConverters.VideoEncodeCtvResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoAdjustAudioResponseStatus))
                {
                    return new global::Picsart.JsonConverters.VideoAdjustAudioResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoAdjustAudioResponseStatus?))
                {
                    return new global::Picsart.JsonConverters.VideoAdjustAudioResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoExtractAudioResponseStatus))
                {
                    return new global::Picsart.JsonConverters.VideoExtractAudioResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoExtractAudioResponseStatus?))
                {
                    return new global::Picsart.JsonConverters.VideoExtractAudioResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoTranscribeAudioResponseStatus))
                {
                    return new global::Picsart.JsonConverters.VideoTranscribeAudioResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoTranscribeAudioResponseStatus?))
                {
                    return new global::Picsart.JsonConverters.VideoTranscribeAudioResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoTranscribeAudioGetresultResponseStatus))
                {
                    return new global::Picsart.JsonConverters.VideoTranscribeAudioGetresultResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoTranscribeAudioGetresultResponseStatus?))
                {
                    return new global::Picsart.JsonConverters.VideoTranscribeAudioGetresultResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoTranscribeAudioGetresultResponseStatus2))
                {
                    return new global::Picsart.JsonConverters.VideoTranscribeAudioGetresultResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoTranscribeAudioGetresultResponseStatus2?))
                {
                    return new global::Picsart.JsonConverters.VideoTranscribeAudioGetresultResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoAddWatermarkResponseStatus))
                {
                    return new global::Picsart.JsonConverters.VideoAddWatermarkResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoAddWatermarkResponseStatus?))
                {
                    return new global::Picsart.JsonConverters.VideoAddWatermarkResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoGetresultResponseStatus))
                {
                    return new global::Picsart.JsonConverters.VideoGetresultResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoGetresultResponseStatus?))
                {
                    return new global::Picsart.JsonConverters.VideoGetresultResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoGetresultResponseStatus2))
                {
                    return new global::Picsart.JsonConverters.VideoGetresultResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoGetresultResponseStatus2?))
                {
                    return new global::Picsart.JsonConverters.VideoGetresultResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoGetaudioresultResponseStatus))
                {
                    return new global::Picsart.JsonConverters.VideoGetaudioresultResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoGetaudioresultResponseStatus?))
                {
                    return new global::Picsart.JsonConverters.VideoGetaudioresultResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoGetaudioresultResponseStatus2))
                {
                    return new global::Picsart.JsonConverters.VideoGetaudioresultResponseStatus2JsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoGetaudioresultResponseStatus2?))
                {
                    return new global::Picsart.JsonConverters.VideoGetaudioresultResponseStatus2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoUploadResponseStatus))
                {
                    return new global::Picsart.JsonConverters.VideoUploadResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoUploadResponseStatus?))
                {
                    return new global::Picsart.JsonConverters.VideoUploadResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenaiText2imageResponseStatus))
                {
                    return new global::Picsart.JsonConverters.GenaiText2imageResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenaiText2imageResponseStatus?))
                {
                    return new global::Picsart.JsonConverters.GenaiText2imageResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenaiText2imageGetresultResponseStatus))
                {
                    return new global::Picsart.JsonConverters.GenaiText2imageGetresultResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenaiText2imageGetresultResponseStatus?))
                {
                    return new global::Picsart.JsonConverters.GenaiText2imageGetresultResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenaiText2stickerResponseStatus))
                {
                    return new global::Picsart.JsonConverters.GenaiText2stickerResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenaiText2stickerResponseStatus?))
                {
                    return new global::Picsart.JsonConverters.GenaiText2stickerResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenaiText2stickerLaserEngravingResponseStatus))
                {
                    return new global::Picsart.JsonConverters.GenaiText2stickerLaserEngravingResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenaiText2stickerLaserEngravingResponseStatus?))
                {
                    return new global::Picsart.JsonConverters.GenaiText2stickerLaserEngravingResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenaiText2stickerGetresultResponseStatus))
                {
                    return new global::Picsart.JsonConverters.GenaiText2stickerGetresultResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenaiText2stickerGetresultResponseStatus?))
                {
                    return new global::Picsart.JsonConverters.GenaiText2stickerGetresultResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenaiGenerateLogoResponseStatus))
                {
                    return new global::Picsart.JsonConverters.GenaiGenerateLogoResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenaiGenerateLogoResponseStatus?))
                {
                    return new global::Picsart.JsonConverters.GenaiGenerateLogoResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenaiGenerateLogoGetresultResponseStatus))
                {
                    return new global::Picsart.JsonConverters.GenaiGenerateLogoGetresultResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenaiGenerateLogoGetresultResponseStatus?))
                {
                    return new global::Picsart.JsonConverters.GenaiGenerateLogoGetresultResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenaiText2videoResponseStatus))
                {
                    return new global::Picsart.JsonConverters.GenaiText2videoResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenaiText2videoResponseStatus?))
                {
                    return new global::Picsart.JsonConverters.GenaiText2videoResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenaiImage2videoResponseStatus))
                {
                    return new global::Picsart.JsonConverters.GenaiImage2videoResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenaiImage2videoResponseStatus?))
                {
                    return new global::Picsart.JsonConverters.GenaiImage2videoResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenaiText2videoGetresultResponseStatus))
                {
                    return new global::Picsart.JsonConverters.GenaiText2videoGetresultResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenaiText2videoGetresultResponseStatus?))
                {
                    return new global::Picsart.JsonConverters.GenaiText2videoGetresultResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenaiText2speechResponseStatus))
                {
                    return new global::Picsart.JsonConverters.GenaiText2speechResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenaiText2speechResponseStatus?))
                {
                    return new global::Picsart.JsonConverters.GenaiText2speechResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenaiText2soundResponseStatus))
                {
                    return new global::Picsart.JsonConverters.GenaiText2soundResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenaiText2soundResponseStatus?))
                {
                    return new global::Picsart.JsonConverters.GenaiText2soundResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenaiText2audioGetresultResponseStatus))
                {
                    return new global::Picsart.JsonConverters.GenaiText2audioGetresultResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenaiText2audioGetresultResponseStatus?))
                {
                    return new global::Picsart.JsonConverters.GenaiText2audioGetresultResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VdDescribeVariableDataContentResponseDataTagType))
                {
                    return new global::Picsart.JsonConverters.VdDescribeVariableDataContentResponseDataTagTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VdDescribeVariableDataContentResponseDataTagType?))
                {
                    return new global::Picsart.JsonConverters.VdDescribeVariableDataContentResponseDataTagTypeNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[2];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new SourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => new SourceGenerationContextChunk1(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}