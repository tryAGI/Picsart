
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoTranscribeFileParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoTranscribeParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoTranscribeParametersLanguage), TypeInfoPropertyName = "VideoTranscribeParametersLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoTranscribeParametersFormat), TypeInfoPropertyName = "VideoTranscribeParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoTranscribeParametersGranularity), TypeInfoPropertyName = "VideoTranscribeParametersGranularity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.Video401Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.VideoTranscribeFileParameters, global::Picsart.VideoTranscribeParameters>), TypeInfoPropertyName = "AllOfVideoTranscribeFileParametersVideoTranscribeParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoTranscribeAudioResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoTranscribeAudioResponseStatus), TypeInfoPropertyName = "VideoTranscribeAudioResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoTranscribeAudioGetresultResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoTranscribeAudioGetresultResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoTranscribeAudioGetresultResponseStatus), TypeInfoPropertyName = "VideoTranscribeAudioGetresultResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoTranscribeAudioGetresultResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoTranscribeAudioGetresultResponseStatus2), TypeInfoPropertyName = "VideoTranscribeAudioGetresultResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoTranscribeParametersLanguage?), TypeInfoPropertyName = "NullableVideoTranscribeParametersLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoTranscribeParametersFormat?), TypeInfoPropertyName = "NullableVideoTranscribeParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoTranscribeParametersGranularity?), TypeInfoPropertyName = "NullableVideoTranscribeParametersGranularity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.VideoTranscribeFileParameters, global::Picsart.VideoTranscribeParameters>?), TypeInfoPropertyName = "NullableAllOfVideoTranscribeFileParametersVideoTranscribeParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoTranscribeAudioResponseStatus?), TypeInfoPropertyName = "NullableVideoTranscribeAudioResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoTranscribeAudioGetresultResponseStatus?), TypeInfoPropertyName = "NullableVideoTranscribeAudioGetresultResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoTranscribeAudioGetresultResponseStatus2?), TypeInfoPropertyName = "NullableVideoTranscribeAudioGetresultResponseStatus22")]
    internal sealed partial class VideoTranscriptionsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VideoTranscriptionsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static VideoTranscriptionsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private VideoTranscriptionsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.VideoTranscribeFileParameters, global::Picsart.VideoTranscribeParameters>());
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
                    typeToConvert == typeof(global::Picsart.VideoTranscribeParametersLanguage)

                    || typeToConvert == typeof(global::Picsart.VideoTranscribeParametersLanguage?)

                    || typeToConvert == typeof(global::Picsart.VideoTranscribeParametersFormat)

                    || typeToConvert == typeof(global::Picsart.VideoTranscribeParametersFormat?)

                    || typeToConvert == typeof(global::Picsart.VideoTranscribeParametersGranularity)

                    || typeToConvert == typeof(global::Picsart.VideoTranscribeParametersGranularity?)

                    || typeToConvert == typeof(global::Picsart.VideoTranscribeAudioResponseStatus)

                    || typeToConvert == typeof(global::Picsart.VideoTranscribeAudioResponseStatus?)

                    || typeToConvert == typeof(global::Picsart.VideoTranscribeAudioGetresultResponseStatus)

                    || typeToConvert == typeof(global::Picsart.VideoTranscribeAudioGetresultResponseStatus?)

                    || typeToConvert == typeof(global::Picsart.VideoTranscribeAudioGetresultResponseStatus2)

                    || typeToConvert == typeof(global::Picsart.VideoTranscribeAudioGetresultResponseStatus2?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
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
                    0 => new VideoTranscriptionsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}