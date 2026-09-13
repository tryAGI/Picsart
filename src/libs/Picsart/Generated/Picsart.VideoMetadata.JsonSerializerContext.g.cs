
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoVideoParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoImageParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoVideoGetThumbnailParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoVideoGetThumbnailParametersSource), TypeInfoPropertyName = "VideoVideoGetThumbnailParametersSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.Video401Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.VideoVideoParameters, global::Picsart.VideoVideoGetThumbnailParameters>), TypeInfoPropertyName = "AllOfVideoVideoParametersVideoVideoGetThumbnailParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.VideoVideoParameters, global::Picsart.VideoImageParameters>), TypeInfoPropertyName = "AllOfVideoVideoParametersVideoImageParameters2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoVideoGetThumbnailParametersSource?), TypeInfoPropertyName = "NullableVideoVideoGetThumbnailParametersSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.VideoVideoParameters, global::Picsart.VideoVideoGetThumbnailParameters>?), TypeInfoPropertyName = "NullableAllOfVideoVideoParametersVideoVideoGetThumbnailParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.VideoVideoParameters, global::Picsart.VideoImageParameters>?), TypeInfoPropertyName = "NullableAllOfVideoVideoParametersVideoImageParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoMetadataResponseStatus?), TypeInfoPropertyName = "NullableVideoMetadataResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoGetThumbnailResponseStatus?), TypeInfoPropertyName = "NullableVideoGetThumbnailResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoSetThumbnailResponseStatus?), TypeInfoPropertyName = "NullableVideoSetThumbnailResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoSetThumbnailGetresultResponseStatus?), TypeInfoPropertyName = "NullableVideoSetThumbnailGetresultResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoSetThumbnailGetresultResponseStatus2?), TypeInfoPropertyName = "NullableVideoSetThumbnailGetresultResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Picsart.VideoGetThumbnailResponseDataItem>))]
    internal sealed partial class VideoMetadataSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VideoMetadataSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static VideoMetadataSourceGenerationContext Default { get; } = new(DefaultOptions);

        private VideoMetadataSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.VideoVideoParameters, global::Picsart.VideoVideoGetThumbnailParameters>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.VideoVideoParameters, global::Picsart.VideoImageParameters>());
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
                    typeToConvert == typeof(global::Picsart.VideoVideoGetThumbnailParametersSource)

                    || typeToConvert == typeof(global::Picsart.VideoVideoGetThumbnailParametersSource?)

                    || typeToConvert == typeof(global::Picsart.VideoMetadataResponseStatus)

                    || typeToConvert == typeof(global::Picsart.VideoMetadataResponseStatus?)

                    || typeToConvert == typeof(global::Picsart.VideoGetThumbnailResponseStatus)

                    || typeToConvert == typeof(global::Picsart.VideoGetThumbnailResponseStatus?)

                    || typeToConvert == typeof(global::Picsart.VideoSetThumbnailResponseStatus)

                    || typeToConvert == typeof(global::Picsart.VideoSetThumbnailResponseStatus?)

                    || typeToConvert == typeof(global::Picsart.VideoSetThumbnailGetresultResponseStatus)

                    || typeToConvert == typeof(global::Picsart.VideoSetThumbnailGetresultResponseStatus?)

                    || typeToConvert == typeof(global::Picsart.VideoSetThumbnailGetresultResponseStatus2)

                    || typeToConvert == typeof(global::Picsart.VideoSetThumbnailGetresultResponseStatus2?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Picsart.VideoVideoGetThumbnailParametersSource))
                {
                    return new global::Picsart.JsonConverters.VideoVideoGetThumbnailParametersSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoVideoGetThumbnailParametersSource?))
                {
                    return new global::Picsart.JsonConverters.VideoVideoGetThumbnailParametersSourceNullableJsonConverter();
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
                    0 => new VideoMetadataSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}