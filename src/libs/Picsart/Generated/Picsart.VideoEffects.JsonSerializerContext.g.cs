
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoVideoParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoExportParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoExportParametersExport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoExportParametersExportFormat), TypeInfoPropertyName = "VideoExportParametersExportFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoAdjustParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoEffectsParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoEffectsParametersEffectName), TypeInfoPropertyName = "VideoEffectsParametersEffectName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.Video401Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.VideoVideoParameters, global::Picsart.VideoAdjustParameters, global::Picsart.VideoExportParameters>), TypeInfoPropertyName = "AllOfVideoVideoParametersVideoAdjustParametersVideoExportParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.VideoVideoParameters, global::Picsart.VideoEffectsParameters, global::Picsart.VideoExportParameters>), TypeInfoPropertyName = "AllOfVideoVideoParametersVideoEffectsParametersVideoExportParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoAdjustResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoAdjustResponseStatus), TypeInfoPropertyName = "VideoAdjustResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoApplyEffectResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoApplyEffectResponseStatus), TypeInfoPropertyName = "VideoApplyEffectResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoExportParametersExportFormat?), TypeInfoPropertyName = "NullableVideoExportParametersExportFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoEffectsParametersEffectName?), TypeInfoPropertyName = "NullableVideoEffectsParametersEffectName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.VideoVideoParameters, global::Picsart.VideoAdjustParameters, global::Picsart.VideoExportParameters>?), TypeInfoPropertyName = "NullableAllOfVideoVideoParametersVideoAdjustParametersVideoExportParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.VideoVideoParameters, global::Picsart.VideoEffectsParameters, global::Picsart.VideoExportParameters>?), TypeInfoPropertyName = "NullableAllOfVideoVideoParametersVideoEffectsParametersVideoExportParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoAdjustResponseStatus?), TypeInfoPropertyName = "NullableVideoAdjustResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.VideoApplyEffectResponseStatus?), TypeInfoPropertyName = "NullableVideoApplyEffectResponseStatus2")]
    internal sealed partial class VideoEffectsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VideoEffectsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static VideoEffectsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private VideoEffectsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.VideoVideoParameters, global::Picsart.VideoAdjustParameters, global::Picsart.VideoExportParameters>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.VideoVideoParameters, global::Picsart.VideoEffectsParameters, global::Picsart.VideoExportParameters>());
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

                    || typeToConvert == typeof(global::Picsart.VideoEffectsParametersEffectName)

                    || typeToConvert == typeof(global::Picsart.VideoEffectsParametersEffectName?)

                    || typeToConvert == typeof(global::Picsart.VideoAdjustResponseStatus)

                    || typeToConvert == typeof(global::Picsart.VideoAdjustResponseStatus?)

                    || typeToConvert == typeof(global::Picsart.VideoApplyEffectResponseStatus)

                    || typeToConvert == typeof(global::Picsart.VideoApplyEffectResponseStatus?);
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

                if (typeToConvert == typeof(global::Picsart.VideoEffectsParametersEffectName))
                {
                    return new global::Picsart.JsonConverters.VideoEffectsParametersEffectNameJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.VideoEffectsParametersEffectName?))
                {
                    return new global::Picsart.JsonConverters.VideoEffectsParametersEffectNameNullableJsonConverter();
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
                    0 => new VideoEffectsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}