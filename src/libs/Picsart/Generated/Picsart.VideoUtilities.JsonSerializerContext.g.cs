
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoUploadParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.Video401Error))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoGetresultResponseStatus?), TypeInfoPropertyName = "NullableVideoGetresultResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoGetresultResponseStatus2?), TypeInfoPropertyName = "NullableVideoGetresultResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoGetaudioresultResponseStatus?), TypeInfoPropertyName = "NullableVideoGetaudioresultResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoGetaudioresultResponseStatus2?), TypeInfoPropertyName = "NullableVideoGetaudioresultResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoUploadResponseStatus?), TypeInfoPropertyName = "NullableVideoUploadResponseStatus2")]
    internal sealed partial class VideoUtilitiesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VideoUtilitiesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static VideoUtilitiesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private VideoUtilitiesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Picsart.VideoGetresultResponseStatus)

                    || typeToConvert == typeof(global::Picsart.VideoGetresultResponseStatus?)

                    || typeToConvert == typeof(global::Picsart.VideoGetresultResponseStatus2)

                    || typeToConvert == typeof(global::Picsart.VideoGetresultResponseStatus2?)

                    || typeToConvert == typeof(global::Picsart.VideoGetaudioresultResponseStatus)

                    || typeToConvert == typeof(global::Picsart.VideoGetaudioresultResponseStatus?)

                    || typeToConvert == typeof(global::Picsart.VideoGetaudioresultResponseStatus2)

                    || typeToConvert == typeof(global::Picsart.VideoGetaudioresultResponseStatus2?)

                    || typeToConvert == typeof(global::Picsart.VideoUploadResponseStatus)

                    || typeToConvert == typeof(global::Picsart.VideoUploadResponseStatus?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
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
                    0 => new VideoUtilitiesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}