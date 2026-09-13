
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIText2SpeechParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIText2SpeechParametersLanguage), TypeInfoPropertyName = "GenAIText2SpeechParametersLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIText2SpeechModels))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIText2SpeechModelsModel), TypeInfoPropertyName = "GenAIText2SpeechModelsModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIText2SoundParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIText2SoundModels))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIText2SoundModelsModel), TypeInfoPropertyName = "GenAIText2SoundModelsModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.GenAIText2SpeechParameters, global::Picsart.GenAIText2SpeechModels>), TypeInfoPropertyName = "AllOfGenAIText2SpeechParametersGenAIText2SpeechModels2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.GenAIText2SoundParameters, global::Picsart.GenAIText2SoundModels>), TypeInfoPropertyName = "AllOfGenAIText2SoundParametersGenAIText2SoundModels2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiText2speechResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiText2speechResponseStatus), TypeInfoPropertyName = "GenaiText2speechResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiText2soundResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiText2soundResponseStatus), TypeInfoPropertyName = "GenaiText2soundResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiText2audioGetresultResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiText2audioGetresultResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiText2audioGetresultResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiText2audioGetresultResponseStatus), TypeInfoPropertyName = "GenaiText2audioGetresultResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIText2SpeechParametersLanguage?), TypeInfoPropertyName = "NullableGenAIText2SpeechParametersLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIText2SpeechModelsModel?), TypeInfoPropertyName = "NullableGenAIText2SpeechModelsModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIText2SoundModelsModel?), TypeInfoPropertyName = "NullableGenAIText2SoundModelsModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.GenAIText2SpeechParameters, global::Picsart.GenAIText2SpeechModels>?), TypeInfoPropertyName = "NullableAllOfGenAIText2SpeechParametersGenAIText2SpeechModels2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.GenAIText2SoundParameters, global::Picsart.GenAIText2SoundModels>?), TypeInfoPropertyName = "NullableAllOfGenAIText2SoundParametersGenAIText2SoundModels2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiText2speechResponseStatus?), TypeInfoPropertyName = "NullableGenaiText2speechResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiText2soundResponseStatus?), TypeInfoPropertyName = "NullableGenaiText2soundResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiText2audioGetresultResponseStatus?), TypeInfoPropertyName = "NullableGenaiText2audioGetresultResponseStatus2")]
    internal sealed partial class GenAIText2AudioSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GenAIText2AudioSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static GenAIText2AudioSourceGenerationContext Default { get; } = new(DefaultOptions);

        private GenAIText2AudioSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.GenAIText2SpeechParameters, global::Picsart.GenAIText2SpeechModels>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.GenAIText2SoundParameters, global::Picsart.GenAIText2SoundModels>());
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
                    typeToConvert == typeof(global::Picsart.GenAIText2SpeechParametersLanguage)

                    || typeToConvert == typeof(global::Picsart.GenAIText2SpeechParametersLanguage?)

                    || typeToConvert == typeof(global::Picsart.GenAIText2SpeechModelsModel)

                    || typeToConvert == typeof(global::Picsart.GenAIText2SpeechModelsModel?)

                    || typeToConvert == typeof(global::Picsart.GenAIText2SoundModelsModel)

                    || typeToConvert == typeof(global::Picsart.GenAIText2SoundModelsModel?)

                    || typeToConvert == typeof(global::Picsart.GenaiText2speechResponseStatus)

                    || typeToConvert == typeof(global::Picsart.GenaiText2speechResponseStatus?)

                    || typeToConvert == typeof(global::Picsart.GenaiText2soundResponseStatus)

                    || typeToConvert == typeof(global::Picsart.GenaiText2soundResponseStatus?)

                    || typeToConvert == typeof(global::Picsart.GenaiText2audioGetresultResponseStatus)

                    || typeToConvert == typeof(global::Picsart.GenaiText2audioGetresultResponseStatus?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
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
                    0 => new GenAIText2AudioSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}