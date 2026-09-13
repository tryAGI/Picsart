
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIText2VideoParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIText2VideoParametersQuality), TypeInfoPropertyName = "GenAIText2VideoParametersQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIText2VideoModels))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIText2VideoModelsModel), TypeInfoPropertyName = "GenAIText2VideoModelsModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIImage2VideoModels))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIImage2VideoModelsModel), TypeInfoPropertyName = "GenAIImage2VideoModelsModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIImageParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.GenAIText2VideoParameters, global::Picsart.GenAIText2VideoModels>), TypeInfoPropertyName = "AllOfGenAIText2VideoParametersGenAIText2VideoModels2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.GenAIImageParameters, global::Picsart.GenAIText2VideoParameters, global::Picsart.GenAIImage2VideoModels>), TypeInfoPropertyName = "AllOfGenAIImageParametersGenAIText2VideoParametersGenAIImage2VideoModels2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiText2videoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiText2videoResponseStatus), TypeInfoPropertyName = "GenaiText2videoResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiImage2videoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiImage2videoResponseStatus), TypeInfoPropertyName = "GenaiImage2videoResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiText2videoGetresultResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiText2videoGetresultResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiText2videoGetresultResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiText2videoGetresultResponseStatus), TypeInfoPropertyName = "GenaiText2videoGetresultResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIText2VideoParametersQuality?), TypeInfoPropertyName = "NullableGenAIText2VideoParametersQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIText2VideoModelsModel?), TypeInfoPropertyName = "NullableGenAIText2VideoModelsModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIImage2VideoModelsModel?), TypeInfoPropertyName = "NullableGenAIImage2VideoModelsModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.GenAIText2VideoParameters, global::Picsart.GenAIText2VideoModels>?), TypeInfoPropertyName = "NullableAllOfGenAIText2VideoParametersGenAIText2VideoModels2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.GenAIImageParameters, global::Picsart.GenAIText2VideoParameters, global::Picsart.GenAIImage2VideoModels>?), TypeInfoPropertyName = "NullableAllOfGenAIImageParametersGenAIText2VideoParametersGenAIImage2VideoModels2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiText2videoResponseStatus?), TypeInfoPropertyName = "NullableGenaiText2videoResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiImage2videoResponseStatus?), TypeInfoPropertyName = "NullableGenaiImage2videoResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiText2videoGetresultResponseStatus?), TypeInfoPropertyName = "NullableGenaiText2videoGetresultResponseStatus2")]
    internal sealed partial class GenAIText2VideoImage2VideoSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GenAIText2VideoImage2VideoSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static GenAIText2VideoImage2VideoSourceGenerationContext Default { get; } = new(DefaultOptions);

        private GenAIText2VideoImage2VideoSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.GenAIText2VideoParameters, global::Picsart.GenAIText2VideoModels>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.GenAIImageParameters, global::Picsart.GenAIText2VideoParameters, global::Picsart.GenAIImage2VideoModels>());
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
                    typeToConvert == typeof(global::Picsart.GenAIText2VideoParametersQuality)

                    || typeToConvert == typeof(global::Picsart.GenAIText2VideoParametersQuality?)

                    || typeToConvert == typeof(global::Picsart.GenAIText2VideoModelsModel)

                    || typeToConvert == typeof(global::Picsart.GenAIText2VideoModelsModel?)

                    || typeToConvert == typeof(global::Picsart.GenAIImage2VideoModelsModel)

                    || typeToConvert == typeof(global::Picsart.GenAIImage2VideoModelsModel?)

                    || typeToConvert == typeof(global::Picsart.GenaiText2videoResponseStatus)

                    || typeToConvert == typeof(global::Picsart.GenaiText2videoResponseStatus?)

                    || typeToConvert == typeof(global::Picsart.GenaiImage2videoResponseStatus)

                    || typeToConvert == typeof(global::Picsart.GenaiImage2videoResponseStatus?)

                    || typeToConvert == typeof(global::Picsart.GenaiText2videoGetresultResponseStatus)

                    || typeToConvert == typeof(global::Picsart.GenaiText2videoGetresultResponseStatus?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Picsart.GenAIText2VideoParametersQuality))
                {
                    return new global::Picsart.JsonConverters.GenAIText2VideoParametersQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenAIText2VideoParametersQuality?))
                {
                    return new global::Picsart.JsonConverters.GenAIText2VideoParametersQualityNullableJsonConverter();
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
                    0 => new GenAIText2VideoImage2VideoSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}