
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageRemoveBackgroundParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageRemoveBackgroundParametersOutputType), TypeInfoPropertyName = "ImageRemoveBackgroundParametersOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageRemoveBackgroundParametersScale), TypeInfoPropertyName = "ImageRemoveBackgroundParametersScale2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageRemoveBackgroundParametersShadow), TypeInfoPropertyName = "ImageRemoveBackgroundParametersShadow2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageRemoveBackgroundParametersModel), TypeInfoPropertyName = "ImageRemoveBackgroundParametersModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageRemoveBackgroundParametersFormat), TypeInfoPropertyName = "ImageRemoveBackgroundParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.Image401Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageRemoveBackgroundParameters>), TypeInfoPropertyName = "AllOfImageImageParametersImageRemoveBackgroundParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageRemoveBackgroundResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageRemoveBackgroundResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageRemoveBackgroundParametersOutputType?), TypeInfoPropertyName = "NullableImageRemoveBackgroundParametersOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageRemoveBackgroundParametersScale?), TypeInfoPropertyName = "NullableImageRemoveBackgroundParametersScale2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageRemoveBackgroundParametersShadow?), TypeInfoPropertyName = "NullableImageRemoveBackgroundParametersShadow2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageRemoveBackgroundParametersModel?), TypeInfoPropertyName = "NullableImageRemoveBackgroundParametersModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageRemoveBackgroundParametersFormat?), TypeInfoPropertyName = "NullableImageRemoveBackgroundParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageRemoveBackgroundParameters>?), TypeInfoPropertyName = "NullableAllOfImageImageParametersImageRemoveBackgroundParameters2")]
    internal sealed partial class ImageRemoveBackgroundSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ImageRemoveBackgroundSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ImageRemoveBackgroundSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ImageRemoveBackgroundSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageRemoveBackgroundParameters>());
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
                    typeToConvert == typeof(global::Picsart.ImageRemoveBackgroundParametersOutputType)

                    || typeToConvert == typeof(global::Picsart.ImageRemoveBackgroundParametersOutputType?)

                    || typeToConvert == typeof(global::Picsart.ImageRemoveBackgroundParametersScale)

                    || typeToConvert == typeof(global::Picsart.ImageRemoveBackgroundParametersScale?)

                    || typeToConvert == typeof(global::Picsart.ImageRemoveBackgroundParametersShadow)

                    || typeToConvert == typeof(global::Picsart.ImageRemoveBackgroundParametersShadow?)

                    || typeToConvert == typeof(global::Picsart.ImageRemoveBackgroundParametersModel)

                    || typeToConvert == typeof(global::Picsart.ImageRemoveBackgroundParametersModel?)

                    || typeToConvert == typeof(global::Picsart.ImageRemoveBackgroundParametersFormat)

                    || typeToConvert == typeof(global::Picsart.ImageRemoveBackgroundParametersFormat?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
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
                    0 => new ImageRemoveBackgroundSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}