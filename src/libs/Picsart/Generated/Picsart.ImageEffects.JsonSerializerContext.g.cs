
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageImageParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageColorTransferParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageColorTransferParametersFormat), TypeInfoPropertyName = "ImageColorTransferParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageStyleTransferParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageStyleTransferParametersLevel), TypeInfoPropertyName = "ImageStyleTransferParametersLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageStyleTransferParametersFormat), TypeInfoPropertyName = "ImageStyleTransferParametersFormat2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.Image401Error))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageEffectsParametersEffectName?), TypeInfoPropertyName = "NullableImageEffectsParametersEffectName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageEffectsParametersFormat?), TypeInfoPropertyName = "NullableImageEffectsParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageLaserEngravingEffectParametersFormat?), TypeInfoPropertyName = "NullableImageLaserEngravingEffectParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageAIEffectsParametersEffectName?), TypeInfoPropertyName = "NullableImageAIEffectsParametersEffectName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageAIEffectsParametersFormat?), TypeInfoPropertyName = "NullableImageAIEffectsParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageEffectsPreviewsParametersEffectName?), TypeInfoPropertyName = "NullableImageEffectsPreviewsParametersEffectName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageEffectsPreviewsParametersFormat?), TypeInfoPropertyName = "NullableImageEffectsPreviewsParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageAdjustParametersFormat?), TypeInfoPropertyName = "NullableImageAdjustParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageSelectiveBlurParametersFormat?), TypeInfoPropertyName = "NullableImageSelectiveBlurParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageColorTransferParametersFormat?), TypeInfoPropertyName = "NullableImageColorTransferParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageStyleTransferParametersLevel?), TypeInfoPropertyName = "NullableImageStyleTransferParametersLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageStyleTransferParametersFormat?), TypeInfoPropertyName = "NullableImageStyleTransferParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageMasksParametersFormat?), TypeInfoPropertyName = "NullableImageMasksParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageMasksParametersBlend?), TypeInfoPropertyName = "NullableImageMasksParametersBlend2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageMasksParametersMask?), TypeInfoPropertyName = "NullableImageMasksParametersMask2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageMasksParametersMaskFlip?), TypeInfoPropertyName = "NullableImageMasksParametersMaskFlip2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageMasksPreviewParametersFormat?), TypeInfoPropertyName = "NullableImageMasksPreviewParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageMasksPreviewParametersBlend?), TypeInfoPropertyName = "NullableImageMasksPreviewParametersBlend2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageMasksPreviewParametersMaskItem?), TypeInfoPropertyName = "NullableImageMasksPreviewParametersMaskItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageMasksPreviewParametersMaskFlip?), TypeInfoPropertyName = "NullableImageMasksPreviewParametersMaskFlip2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Picsart.ImageEffectsPreviewsParametersEffectName>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Picsart.ImageMasksPreviewParametersMaskItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Picsart.ImageListEffectNamesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Picsart.ImageCreateEffectPreviewsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Picsart.ImageListAiEffectNamesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Picsart.ImageCreateMaskPreviewsResponseDataItem>))]
    internal sealed partial class ImageEffectsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ImageEffectsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ImageEffectsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ImageEffectsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
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
            options.Converters.Add(new global::Picsart.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Picsart.ImageEffectsParametersEffectName)

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

                    || typeToConvert == typeof(global::Picsart.ImageColorTransferParametersFormat)

                    || typeToConvert == typeof(global::Picsart.ImageColorTransferParametersFormat?)

                    || typeToConvert == typeof(global::Picsart.ImageStyleTransferParametersLevel)

                    || typeToConvert == typeof(global::Picsart.ImageStyleTransferParametersLevel?)

                    || typeToConvert == typeof(global::Picsart.ImageStyleTransferParametersFormat)

                    || typeToConvert == typeof(global::Picsart.ImageStyleTransferParametersFormat?)

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

                    || typeToConvert == typeof(global::Picsart.ImageMasksPreviewParametersMaskFlip?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
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
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

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
                    0 => new ImageEffectsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}