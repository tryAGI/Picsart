
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoVideoParameters))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoTrimParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoCropParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoEditParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoFitParameters))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.Video401Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.VideoVideoParameters, global::Picsart.VideoEditParameters, global::Picsart.VideoExtendedExportParameters>), TypeInfoPropertyName = "AllOfVideoVideoParametersVideoEditParametersVideoExtendedExportParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.VideoVideoParameters, global::Picsart.VideoTrimParameters, global::Picsart.VideoExportParameters>), TypeInfoPropertyName = "AllOfVideoVideoParametersVideoTrimParametersVideoExportParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.VideoVideoParameters, global::Picsart.VideoCropParameters, global::Picsart.VideoExportParameters>), TypeInfoPropertyName = "AllOfVideoVideoParametersVideoCropParametersVideoExportParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.VideoConcatParameters, global::Picsart.VideoExportParameters>), TypeInfoPropertyName = "AllOfVideoConcatParametersVideoExportParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.VideoVideoParameters, global::Picsart.VideoConcatSegmentsParameters, global::Picsart.VideoExportParameters>), TypeInfoPropertyName = "AllOfVideoVideoParametersVideoConcatSegmentsParametersVideoExportParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.VideoVideoParameters, global::Picsart.VideoFitParameters>), TypeInfoPropertyName = "AllOfVideoVideoParametersVideoFitParameters2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoExportParametersExportFormat?), TypeInfoPropertyName = "NullableVideoExportParametersExportFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoExtendedExportParametersExportFormat?), TypeInfoPropertyName = "NullableVideoExtendedExportParametersExportFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoExtendedExportParametersExportQuality?), TypeInfoPropertyName = "NullableVideoExtendedExportParametersExportQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoExtendedExportParametersExportCodec?), TypeInfoPropertyName = "NullableVideoExtendedExportParametersExportCodec2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoExtendedExportParametersExportAudioCodec?), TypeInfoPropertyName = "NullableVideoExtendedExportParametersExportAudioCodec2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoExtendedExportParametersExportColorSpace?), TypeInfoPropertyName = "NullableVideoExtendedExportParametersExportColorSpace2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoTransitionTransition?), TypeInfoPropertyName = "NullableVideoTransitionTransition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.VideoConcatVideoParameters, global::Picsart.VideoConcatImageParameters, global::Picsart.VideoTransition>?), TypeInfoPropertyName = "NullableAllOfVideoConcatVideoParametersVideoConcatImageParametersVideoTransition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoConcatImageParametersScale?), TypeInfoPropertyName = "NullableVideoConcatImageParametersScale2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoConcatSegmentsParametersTrimSegmentTransition?), TypeInfoPropertyName = "NullableVideoConcatSegmentsParametersTrimSegmentTransition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.VideoVideoParameters, global::Picsart.VideoEditParameters, global::Picsart.VideoExtendedExportParameters>?), TypeInfoPropertyName = "NullableAllOfVideoVideoParametersVideoEditParametersVideoExtendedExportParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.VideoVideoParameters, global::Picsart.VideoTrimParameters, global::Picsart.VideoExportParameters>?), TypeInfoPropertyName = "NullableAllOfVideoVideoParametersVideoTrimParametersVideoExportParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.VideoVideoParameters, global::Picsart.VideoCropParameters, global::Picsart.VideoExportParameters>?), TypeInfoPropertyName = "NullableAllOfVideoVideoParametersVideoCropParametersVideoExportParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.VideoConcatParameters, global::Picsart.VideoExportParameters>?), TypeInfoPropertyName = "NullableAllOfVideoConcatParametersVideoExportParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.VideoVideoParameters, global::Picsart.VideoConcatSegmentsParameters, global::Picsart.VideoExportParameters>?), TypeInfoPropertyName = "NullableAllOfVideoVideoParametersVideoConcatSegmentsParametersVideoExportParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.VideoVideoParameters, global::Picsart.VideoFitParameters>?), TypeInfoPropertyName = "NullableAllOfVideoVideoParametersVideoFitParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoEditResponseStatus?), TypeInfoPropertyName = "NullableVideoEditResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoTrimResponseStatus?), TypeInfoPropertyName = "NullableVideoTrimResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoCropResponseStatus?), TypeInfoPropertyName = "NullableVideoCropResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoConcatResponseStatus?), TypeInfoPropertyName = "NullableVideoConcatResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoConcatHighlightsResponseStatus?), TypeInfoPropertyName = "NullableVideoConcatHighlightsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoFitResponseStatus?), TypeInfoPropertyName = "NullableVideoFitResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Picsart.AllOf<global::Picsart.VideoConcatVideoParameters, global::Picsart.VideoConcatImageParameters, global::Picsart.VideoTransition>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Picsart.VideoConcatSegmentsParametersTrimSegment>))]
    internal sealed partial class VideoEditSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VideoEditSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static VideoEditSourceGenerationContext Default { get; } = new(DefaultOptions);

        private VideoEditSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.VideoConcatVideoParameters, global::Picsart.VideoConcatImageParameters, global::Picsart.VideoTransition>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.VideoVideoParameters, global::Picsart.VideoEditParameters, global::Picsart.VideoExtendedExportParameters>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.VideoVideoParameters, global::Picsart.VideoTrimParameters, global::Picsart.VideoExportParameters>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.VideoVideoParameters, global::Picsart.VideoCropParameters, global::Picsart.VideoExportParameters>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.VideoConcatParameters, global::Picsart.VideoExportParameters>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.VideoVideoParameters, global::Picsart.VideoConcatSegmentsParameters, global::Picsart.VideoExportParameters>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.VideoVideoParameters, global::Picsart.VideoFitParameters>());
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
                    typeToConvert == typeof(global::Picsart.VideoExportParametersExportFormat)

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

                    || typeToConvert == typeof(global::Picsart.VideoTransitionTransition)

                    || typeToConvert == typeof(global::Picsart.VideoTransitionTransition?)

                    || typeToConvert == typeof(global::Picsart.VideoConcatImageParametersScale)

                    || typeToConvert == typeof(global::Picsart.VideoConcatImageParametersScale?)

                    || typeToConvert == typeof(global::Picsart.VideoConcatSegmentsParametersTrimSegmentTransition)

                    || typeToConvert == typeof(global::Picsart.VideoConcatSegmentsParametersTrimSegmentTransition?)

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

                    || typeToConvert == typeof(global::Picsart.VideoFitResponseStatus?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
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
                    0 => new VideoEditSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}