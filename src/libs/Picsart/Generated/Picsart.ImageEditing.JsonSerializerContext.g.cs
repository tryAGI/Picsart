
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageSmartCropParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageSmartCropParametersRatio), TypeInfoPropertyName = "ImageSmartCropParametersRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageSmartCropParametersFormat), TypeInfoPropertyName = "ImageSmartCropParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageZoomParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageZoomParametersAnchorPoint), TypeInfoPropertyName = "ImageZoomParametersAnchorPoint2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageZoomParametersFormat), TypeInfoPropertyName = "ImageZoomParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageEditParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageEditParametersFormat), TypeInfoPropertyName = "ImageEditParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageEditParametersMode), TypeInfoPropertyName = "ImageEditParametersMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageEditParametersCropAnchor), TypeInfoPropertyName = "ImageEditParametersCropAnchor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageEditParametersFlip), TypeInfoPropertyName = "ImageEditParametersFlip2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageOverlayParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageOverlayParametersBlendMode), TypeInfoPropertyName = "ImageOverlayParametersBlendMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageOverlayParametersFormat), TypeInfoPropertyName = "ImageOverlayParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.Image401Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageEditParameters>), TypeInfoPropertyName = "AllOfImageImageParametersImageEditParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageSmartCropParameters>), TypeInfoPropertyName = "AllOfImageImageParametersImageSmartCropParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageOverlayParameters>), TypeInfoPropertyName = "AllOfImageImageParametersImageOverlayParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageZoomParameters>), TypeInfoPropertyName = "AllOfImageImageParametersImageZoomParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageEditResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageEditResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageSmartCropResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageSmartCropResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageBlendResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageBlendResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageZoomResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageZoomResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageSmartCropParametersRatio?), TypeInfoPropertyName = "NullableImageSmartCropParametersRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageSmartCropParametersFormat?), TypeInfoPropertyName = "NullableImageSmartCropParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageZoomParametersAnchorPoint?), TypeInfoPropertyName = "NullableImageZoomParametersAnchorPoint2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageZoomParametersFormat?), TypeInfoPropertyName = "NullableImageZoomParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageEditParametersFormat?), TypeInfoPropertyName = "NullableImageEditParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageEditParametersMode?), TypeInfoPropertyName = "NullableImageEditParametersMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageEditParametersCropAnchor?), TypeInfoPropertyName = "NullableImageEditParametersCropAnchor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageEditParametersFlip?), TypeInfoPropertyName = "NullableImageEditParametersFlip2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageOverlayParametersBlendMode?), TypeInfoPropertyName = "NullableImageOverlayParametersBlendMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.ImageOverlayParametersFormat?), TypeInfoPropertyName = "NullableImageOverlayParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageEditParameters>?), TypeInfoPropertyName = "NullableAllOfImageImageParametersImageEditParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageSmartCropParameters>?), TypeInfoPropertyName = "NullableAllOfImageImageParametersImageSmartCropParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageOverlayParameters>?), TypeInfoPropertyName = "NullableAllOfImageImageParametersImageOverlayParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageZoomParameters>?), TypeInfoPropertyName = "NullableAllOfImageImageParametersImageZoomParameters2")]
    internal sealed partial class ImageEditingSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ImageEditingSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ImageEditingSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ImageEditingSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageEditParameters>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageSmartCropParameters>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageOverlayParameters>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.ImageImageParameters, global::Picsart.ImageZoomParameters>());
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
                    typeToConvert == typeof(global::Picsart.ImageSmartCropParametersRatio)

                    || typeToConvert == typeof(global::Picsart.ImageSmartCropParametersRatio?)

                    || typeToConvert == typeof(global::Picsart.ImageSmartCropParametersFormat)

                    || typeToConvert == typeof(global::Picsart.ImageSmartCropParametersFormat?)

                    || typeToConvert == typeof(global::Picsart.ImageZoomParametersAnchorPoint)

                    || typeToConvert == typeof(global::Picsart.ImageZoomParametersAnchorPoint?)

                    || typeToConvert == typeof(global::Picsart.ImageZoomParametersFormat)

                    || typeToConvert == typeof(global::Picsart.ImageZoomParametersFormat?)

                    || typeToConvert == typeof(global::Picsart.ImageEditParametersFormat)

                    || typeToConvert == typeof(global::Picsart.ImageEditParametersFormat?)

                    || typeToConvert == typeof(global::Picsart.ImageEditParametersMode)

                    || typeToConvert == typeof(global::Picsart.ImageEditParametersMode?)

                    || typeToConvert == typeof(global::Picsart.ImageEditParametersCropAnchor)

                    || typeToConvert == typeof(global::Picsart.ImageEditParametersCropAnchor?)

                    || typeToConvert == typeof(global::Picsart.ImageEditParametersFlip)

                    || typeToConvert == typeof(global::Picsart.ImageEditParametersFlip?)

                    || typeToConvert == typeof(global::Picsart.ImageOverlayParametersBlendMode)

                    || typeToConvert == typeof(global::Picsart.ImageOverlayParametersBlendMode?)

                    || typeToConvert == typeof(global::Picsart.ImageOverlayParametersFormat)

                    || typeToConvert == typeof(global::Picsart.ImageOverlayParametersFormat?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Picsart.ImageSmartCropParametersRatio))
                {
                    return new global::Picsart.JsonConverters.ImageSmartCropParametersRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageSmartCropParametersRatio?))
                {
                    return new global::Picsart.JsonConverters.ImageSmartCropParametersRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageSmartCropParametersFormat))
                {
                    return new global::Picsart.JsonConverters.ImageSmartCropParametersFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageSmartCropParametersFormat?))
                {
                    return new global::Picsart.JsonConverters.ImageSmartCropParametersFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageZoomParametersAnchorPoint))
                {
                    return new global::Picsart.JsonConverters.ImageZoomParametersAnchorPointJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageZoomParametersAnchorPoint?))
                {
                    return new global::Picsart.JsonConverters.ImageZoomParametersAnchorPointNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageZoomParametersFormat))
                {
                    return new global::Picsart.JsonConverters.ImageZoomParametersFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageZoomParametersFormat?))
                {
                    return new global::Picsart.JsonConverters.ImageZoomParametersFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageEditParametersFormat))
                {
                    return new global::Picsart.JsonConverters.ImageEditParametersFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageEditParametersFormat?))
                {
                    return new global::Picsart.JsonConverters.ImageEditParametersFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageEditParametersMode))
                {
                    return new global::Picsart.JsonConverters.ImageEditParametersModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageEditParametersMode?))
                {
                    return new global::Picsart.JsonConverters.ImageEditParametersModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageEditParametersCropAnchor))
                {
                    return new global::Picsart.JsonConverters.ImageEditParametersCropAnchorJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageEditParametersCropAnchor?))
                {
                    return new global::Picsart.JsonConverters.ImageEditParametersCropAnchorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageEditParametersFlip))
                {
                    return new global::Picsart.JsonConverters.ImageEditParametersFlipJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageEditParametersFlip?))
                {
                    return new global::Picsart.JsonConverters.ImageEditParametersFlipNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageOverlayParametersBlendMode))
                {
                    return new global::Picsart.JsonConverters.ImageOverlayParametersBlendModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageOverlayParametersBlendMode?))
                {
                    return new global::Picsart.JsonConverters.ImageOverlayParametersBlendModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageOverlayParametersFormat))
                {
                    return new global::Picsart.JsonConverters.ImageOverlayParametersFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.ImageOverlayParametersFormat?))
                {
                    return new global::Picsart.JsonConverters.ImageOverlayParametersFormatNullableJsonConverter();
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
                    0 => new ImageEditingSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}