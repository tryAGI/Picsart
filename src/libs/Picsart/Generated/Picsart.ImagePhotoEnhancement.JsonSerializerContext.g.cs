
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageUpscaleParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageUpscaleParametersFormat), TypeInfoPropertyName = "ImageUpscaleParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageUpscaleUltraParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageUpscaleUltraParametersProductType), TypeInfoPropertyName = "ImageUpscaleUltraParametersProductType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageUpscaleUltraParametersImageType), TypeInfoPropertyName = "ImageUpscaleUltraParametersImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageUpscaleUltraParametersMode), TypeInfoPropertyName = "ImageUpscaleUltraParametersMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageUpscaleUltraParametersFormat), TypeInfoPropertyName = "ImageUpscaleUltraParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageUpscaleEnhanceParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageUpscaleEnhanceParametersFormat), TypeInfoPropertyName = "ImageUpscaleEnhanceParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageFaceEnhanceParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageFaceEnhanceParametersFormat), TypeInfoPropertyName = "ImageFaceEnhanceParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.Image401Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageUpscaleParameters>), TypeInfoPropertyName = "AllOfImageImageParametersImageUpscaleParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageUpscaleUltraParameters>), TypeInfoPropertyName = "AllOfImageImageParametersImageUpscaleUltraParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageUpscaleEnhanceParameters>), TypeInfoPropertyName = "AllOfImageImageParametersImageUpscaleEnhanceParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageFaceEnhanceParameters>), TypeInfoPropertyName = "AllOfImageImageParametersImageFaceEnhanceParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageUpscaleResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageUpscaleResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageUltraUpscaleResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageUltraUpscaleResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageUltraUpscaleResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageUltraUpscaleGetresultResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageUltraUpscaleGetresultResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageUltraUpscaleGetresultResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageUltraEnhanceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageUltraEnhanceResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageFaceEnhanceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageFaceEnhanceResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageUpscaleParametersFormat?), TypeInfoPropertyName = "NullableImageUpscaleParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageUpscaleUltraParametersProductType?), TypeInfoPropertyName = "NullableImageUpscaleUltraParametersProductType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageUpscaleUltraParametersImageType?), TypeInfoPropertyName = "NullableImageUpscaleUltraParametersImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageUpscaleUltraParametersMode?), TypeInfoPropertyName = "NullableImageUpscaleUltraParametersMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageUpscaleUltraParametersFormat?), TypeInfoPropertyName = "NullableImageUpscaleUltraParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageUpscaleEnhanceParametersFormat?), TypeInfoPropertyName = "NullableImageUpscaleEnhanceParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageFaceEnhanceParametersFormat?), TypeInfoPropertyName = "NullableImageFaceEnhanceParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageUpscaleParameters>?), TypeInfoPropertyName = "NullableAllOfImageImageParametersImageUpscaleParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageUpscaleUltraParameters>?), TypeInfoPropertyName = "NullableAllOfImageImageParametersImageUpscaleUltraParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageUpscaleEnhanceParameters>?), TypeInfoPropertyName = "NullableAllOfImageImageParametersImageUpscaleEnhanceParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageFaceEnhanceParameters>?), TypeInfoPropertyName = "NullableAllOfImageImageParametersImageFaceEnhanceParameters2")]
    internal sealed partial class ImagePhotoEnhancementSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ImagePhotoEnhancementSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ImagePhotoEnhancementSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ImagePhotoEnhancementSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageUpscaleParameters>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageUpscaleUltraParameters>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageUpscaleEnhanceParameters>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageFaceEnhanceParameters>());
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
                    typeToConvert == typeof(global::Picsart.ImageUpscaleParametersFormat)

                    || typeToConvert == typeof(global::Picsart.ImageUpscaleParametersFormat?)

                    || typeToConvert == typeof(global::Picsart.ImageUpscaleUltraParametersProductType)

                    || typeToConvert == typeof(global::Picsart.ImageUpscaleUltraParametersProductType?)

                    || typeToConvert == typeof(global::Picsart.ImageUpscaleUltraParametersImageType)

                    || typeToConvert == typeof(global::Picsart.ImageUpscaleUltraParametersImageType?)

                    || typeToConvert == typeof(global::Picsart.ImageUpscaleUltraParametersMode)

                    || typeToConvert == typeof(global::Picsart.ImageUpscaleUltraParametersMode?)

                    || typeToConvert == typeof(global::Picsart.ImageUpscaleUltraParametersFormat)

                    || typeToConvert == typeof(global::Picsart.ImageUpscaleUltraParametersFormat?)

                    || typeToConvert == typeof(global::Picsart.ImageUpscaleEnhanceParametersFormat)

                    || typeToConvert == typeof(global::Picsart.ImageUpscaleEnhanceParametersFormat?)

                    || typeToConvert == typeof(global::Picsart.ImageFaceEnhanceParametersFormat)

                    || typeToConvert == typeof(global::Picsart.ImageFaceEnhanceParametersFormat?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Picsart.ImageUpscaleParametersFormat))
                {
                    return new global::Picsart.JsonConverters.ImageUpscaleParametersFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageUpscaleParametersFormat?))
                {
                    return new global::Picsart.JsonConverters.ImageUpscaleParametersFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageUpscaleUltraParametersProductType))
                {
                    return new global::Picsart.JsonConverters.ImageUpscaleUltraParametersProductTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageUpscaleUltraParametersProductType?))
                {
                    return new global::Picsart.JsonConverters.ImageUpscaleUltraParametersProductTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageUpscaleUltraParametersImageType))
                {
                    return new global::Picsart.JsonConverters.ImageUpscaleUltraParametersImageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageUpscaleUltraParametersImageType?))
                {
                    return new global::Picsart.JsonConverters.ImageUpscaleUltraParametersImageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageUpscaleUltraParametersMode))
                {
                    return new global::Picsart.JsonConverters.ImageUpscaleUltraParametersModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageUpscaleUltraParametersMode?))
                {
                    return new global::Picsart.JsonConverters.ImageUpscaleUltraParametersModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageUpscaleUltraParametersFormat))
                {
                    return new global::Picsart.JsonConverters.ImageUpscaleUltraParametersFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageUpscaleUltraParametersFormat?))
                {
                    return new global::Picsart.JsonConverters.ImageUpscaleUltraParametersFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageUpscaleEnhanceParametersFormat))
                {
                    return new global::Picsart.JsonConverters.ImageUpscaleEnhanceParametersFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageUpscaleEnhanceParametersFormat?))
                {
                    return new global::Picsart.JsonConverters.ImageUpscaleEnhanceParametersFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageFaceEnhanceParametersFormat))
                {
                    return new global::Picsart.JsonConverters.ImageFaceEnhanceParametersFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageFaceEnhanceParametersFormat?))
                {
                    return new global::Picsart.JsonConverters.ImageFaceEnhanceParametersFormatNullableJsonConverter();
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
                    0 => new ImagePhotoEnhancementSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}