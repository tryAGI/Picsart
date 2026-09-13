
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIText2ImageParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIText2ImageModels))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIText2ImageModelsModel), TypeInfoPropertyName = "GenAIText2ImageModelsModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIText2StickerModels))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIText2StickerModelsModel), TypeInfoPropertyName = "GenAIText2StickerModelsModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAILogoModels))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAILogoModelsModel), TypeInfoPropertyName = "GenAILogoModelsModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAILaserEngravingParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAILaserEngravingParametersFormat), TypeInfoPropertyName = "GenAILaserEngravingParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAILaserEngravingModels))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAILaserEngravingModelsModel), TypeInfoPropertyName = "GenAILaserEngravingModelsModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAILogoParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAILogoParametersColorTone), TypeInfoPropertyName = "GenAILogoParametersColorTone2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.GenAIText2ImageParameters, global::Picsart.GenAIText2ImageModels>), TypeInfoPropertyName = "AllOfGenAIText2ImageParametersGenAIText2ImageModels2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.GenAIText2ImageParameters, global::Picsart.GenAIText2StickerModels>), TypeInfoPropertyName = "AllOfGenAIText2ImageParametersGenAIText2StickerModels2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.GenAIText2ImageParameters, global::Picsart.GenAILaserEngravingParameters, global::Picsart.GenAILaserEngravingModels>), TypeInfoPropertyName = "AllOfGenAIText2ImageParametersGenAILaserEngravingParametersGenAILaserEngravingModels2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.GenAILogoParameters, global::Picsart.GenAILogoModels>), TypeInfoPropertyName = "AllOfGenAILogoParametersGenAILogoModels2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIText2ImageModelsModel?), TypeInfoPropertyName = "NullableGenAIText2ImageModelsModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIText2StickerModelsModel?), TypeInfoPropertyName = "NullableGenAIText2StickerModelsModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAILogoModelsModel?), TypeInfoPropertyName = "NullableGenAILogoModelsModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAILaserEngravingParametersFormat?), TypeInfoPropertyName = "NullableGenAILaserEngravingParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAILaserEngravingModelsModel?), TypeInfoPropertyName = "NullableGenAILaserEngravingModelsModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAILogoParametersColorTone?), TypeInfoPropertyName = "NullableGenAILogoParametersColorTone2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.GenAIText2ImageParameters, global::Picsart.GenAIText2ImageModels>?), TypeInfoPropertyName = "NullableAllOfGenAIText2ImageParametersGenAIText2ImageModels2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.GenAIText2ImageParameters, global::Picsart.GenAIText2StickerModels>?), TypeInfoPropertyName = "NullableAllOfGenAIText2ImageParametersGenAIText2StickerModels2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.GenAIText2ImageParameters, global::Picsart.GenAILaserEngravingParameters, global::Picsart.GenAILaserEngravingModels>?), TypeInfoPropertyName = "NullableAllOfGenAIText2ImageParametersGenAILaserEngravingParametersGenAILaserEngravingModels2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.GenAILogoParameters, global::Picsart.GenAILogoModels>?), TypeInfoPropertyName = "NullableAllOfGenAILogoParametersGenAILogoModels2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiText2imageResponseStatus?), TypeInfoPropertyName = "NullableGenaiText2imageResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiText2imageGetresultResponseStatus?), TypeInfoPropertyName = "NullableGenaiText2imageGetresultResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiText2stickerResponseStatus?), TypeInfoPropertyName = "NullableGenaiText2stickerResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiText2stickerLaserEngravingResponseStatus?), TypeInfoPropertyName = "NullableGenaiText2stickerLaserEngravingResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiText2stickerGetresultResponseStatus?), TypeInfoPropertyName = "NullableGenaiText2stickerGetresultResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiGenerateLogoResponseStatus?), TypeInfoPropertyName = "NullableGenaiGenerateLogoResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiGenerateLogoGetresultResponseStatus?), TypeInfoPropertyName = "NullableGenaiGenerateLogoGetresultResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Picsart.GenaiText2imageGetresultResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Picsart.GenaiText2stickerGetresultResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Picsart.GenaiGenerateLogoGetresultResponseDataItem>))]
    internal sealed partial class GenAIText2ImageSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GenAIText2ImageSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static GenAIText2ImageSourceGenerationContext Default { get; } = new(DefaultOptions);

        private GenAIText2ImageSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.GenAIText2ImageParameters, global::Picsart.GenAIText2ImageModels>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.GenAIText2ImageParameters, global::Picsart.GenAIText2StickerModels>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.GenAIText2ImageParameters, global::Picsart.GenAILaserEngravingParameters, global::Picsart.GenAILaserEngravingModels>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.GenAILogoParameters, global::Picsart.GenAILogoModels>());
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
                    typeToConvert == typeof(global::Picsart.GenAIText2ImageModelsModel)

                    || typeToConvert == typeof(global::Picsart.GenAIText2ImageModelsModel?)

                    || typeToConvert == typeof(global::Picsart.GenAIText2StickerModelsModel)

                    || typeToConvert == typeof(global::Picsart.GenAIText2StickerModelsModel?)

                    || typeToConvert == typeof(global::Picsart.GenAILogoModelsModel)

                    || typeToConvert == typeof(global::Picsart.GenAILogoModelsModel?)

                    || typeToConvert == typeof(global::Picsart.GenAILaserEngravingParametersFormat)

                    || typeToConvert == typeof(global::Picsart.GenAILaserEngravingParametersFormat?)

                    || typeToConvert == typeof(global::Picsart.GenAILaserEngravingModelsModel)

                    || typeToConvert == typeof(global::Picsart.GenAILaserEngravingModelsModel?)

                    || typeToConvert == typeof(global::Picsart.GenAILogoParametersColorTone)

                    || typeToConvert == typeof(global::Picsart.GenAILogoParametersColorTone?)

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

                    || typeToConvert == typeof(global::Picsart.GenaiGenerateLogoGetresultResponseStatus?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
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
                    0 => new GenAIText2ImageSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}