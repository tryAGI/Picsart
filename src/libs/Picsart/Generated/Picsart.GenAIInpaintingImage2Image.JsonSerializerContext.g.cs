
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIImageParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIMaskParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIInpaintingParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIInpaintingParametersFormat), TypeInfoPropertyName = "GenAIInpaintingParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIInpaintingParametersMode), TypeInfoPropertyName = "GenAIInpaintingParametersMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIRemoveObjectParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIRemoveObjectParametersFormat), TypeInfoPropertyName = "GenAIRemoveObjectParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIRemoveObjectParametersMode), TypeInfoPropertyName = "GenAIRemoveObjectParametersMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIExpandParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIExpandParametersDirection), TypeInfoPropertyName = "GenAIExpandParametersDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIExpandParametersFormat), TypeInfoPropertyName = "GenAIExpandParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIExpandParametersMode), TypeInfoPropertyName = "GenAIExpandParametersMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIBleedParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIBleedParametersFormat), TypeInfoPropertyName = "GenAIBleedParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.GenAIImageParameters, global::Picsart.GenAIMaskParameters, global::Picsart.GenAIInpaintingParameters>), TypeInfoPropertyName = "AllOfGenAIImageParametersGenAIMaskParametersGenAIInpaintingParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.GenAIImageParameters, global::Picsart.GenAIMaskParameters, global::Picsart.GenAIRemoveObjectParameters>), TypeInfoPropertyName = "AllOfGenAIImageParametersGenAIMaskParametersGenAIRemoveObjectParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.GenAIImageParameters, global::Picsart.GenAIInpaintingParameters>), TypeInfoPropertyName = "AllOfGenAIImageParametersGenAIInpaintingParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.GenAIImageParameters, global::Picsart.GenAIExpandParameters>), TypeInfoPropertyName = "AllOfGenAIImageParametersGenAIExpandParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.GenAIImageParameters, global::Picsart.GenAIBleedParameters>), TypeInfoPropertyName = "AllOfGenAIImageParametersGenAIBleedParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiImageInpaintingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Picsart.GenaiImageInpaintingResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiImageInpaintingResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiImageInpaintingResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiImageOutpaintingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Picsart.GenaiImageOutpaintingResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiImageOutpaintingResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiImageOutpaintingResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiRemoveObjectResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiRemoveObjectResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiRemoveObjectResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiSmartBackgroundResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Picsart.GenaiSmartBackgroundResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiSmartBackgroundResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiSmartBackgroundResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiExpandImageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Picsart.GenaiExpandImageResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiExpandImageResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiExpandImageResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiGenerateImageBleedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiGenerateImageBleedResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiImageInpaintingGetresultResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Picsart.GenaiImageInpaintingGetresultResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiImageInpaintingGetresultResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenaiImageInpaintingGetresultResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIInpaintingParametersFormat?), TypeInfoPropertyName = "NullableGenAIInpaintingParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIInpaintingParametersMode?), TypeInfoPropertyName = "NullableGenAIInpaintingParametersMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIRemoveObjectParametersFormat?), TypeInfoPropertyName = "NullableGenAIRemoveObjectParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIRemoveObjectParametersMode?), TypeInfoPropertyName = "NullableGenAIRemoveObjectParametersMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIExpandParametersDirection?), TypeInfoPropertyName = "NullableGenAIExpandParametersDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIExpandParametersFormat?), TypeInfoPropertyName = "NullableGenAIExpandParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIExpandParametersMode?), TypeInfoPropertyName = "NullableGenAIExpandParametersMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.GenAIBleedParametersFormat?), TypeInfoPropertyName = "NullableGenAIBleedParametersFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.GenAIImageParameters, global::Picsart.GenAIMaskParameters, global::Picsart.GenAIInpaintingParameters>?), TypeInfoPropertyName = "NullableAllOfGenAIImageParametersGenAIMaskParametersGenAIInpaintingParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.GenAIImageParameters, global::Picsart.GenAIMaskParameters, global::Picsart.GenAIRemoveObjectParameters>?), TypeInfoPropertyName = "NullableAllOfGenAIImageParametersGenAIMaskParametersGenAIRemoveObjectParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.GenAIImageParameters, global::Picsart.GenAIInpaintingParameters>?), TypeInfoPropertyName = "NullableAllOfGenAIImageParametersGenAIInpaintingParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.GenAIImageParameters, global::Picsart.GenAIExpandParameters>?), TypeInfoPropertyName = "NullableAllOfGenAIImageParametersGenAIExpandParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Picsart.AllOf<global::Picsart.GenAIImageParameters, global::Picsart.GenAIBleedParameters>?), TypeInfoPropertyName = "NullableAllOfGenAIImageParametersGenAIBleedParameters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Picsart.GenaiImageInpaintingResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Picsart.GenaiImageOutpaintingResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Picsart.GenaiSmartBackgroundResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Picsart.GenaiExpandImageResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Picsart.GenaiImageInpaintingGetresultResponseDataItem>))]
    internal sealed partial class GenAIInpaintingImage2ImageSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GenAIInpaintingImage2ImageSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static GenAIInpaintingImage2ImageSourceGenerationContext Default { get; } = new(DefaultOptions);

        private GenAIInpaintingImage2ImageSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.GenAIImageParameters, global::Picsart.GenAIMaskParameters, global::Picsart.GenAIInpaintingParameters>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.GenAIImageParameters, global::Picsart.GenAIMaskParameters, global::Picsart.GenAIInpaintingParameters>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.GenAIImageParameters, global::Picsart.GenAIMaskParameters, global::Picsart.GenAIRemoveObjectParameters>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.GenAIImageParameters, global::Picsart.GenAIInpaintingParameters>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.GenAIImageParameters, global::Picsart.GenAIExpandParameters>());
            options.Converters.Add(new global::Picsart.JsonConverters.AllOfJsonConverter<global::Picsart.GenAIImageParameters, global::Picsart.GenAIBleedParameters>());
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
                    typeToConvert == typeof(global::Picsart.GenAIInpaintingParametersFormat)

                    || typeToConvert == typeof(global::Picsart.GenAIInpaintingParametersFormat?)

                    || typeToConvert == typeof(global::Picsart.GenAIInpaintingParametersMode)

                    || typeToConvert == typeof(global::Picsart.GenAIInpaintingParametersMode?)

                    || typeToConvert == typeof(global::Picsart.GenAIRemoveObjectParametersFormat)

                    || typeToConvert == typeof(global::Picsart.GenAIRemoveObjectParametersFormat?)

                    || typeToConvert == typeof(global::Picsart.GenAIRemoveObjectParametersMode)

                    || typeToConvert == typeof(global::Picsart.GenAIRemoveObjectParametersMode?)

                    || typeToConvert == typeof(global::Picsart.GenAIExpandParametersDirection)

                    || typeToConvert == typeof(global::Picsart.GenAIExpandParametersDirection?)

                    || typeToConvert == typeof(global::Picsart.GenAIExpandParametersFormat)

                    || typeToConvert == typeof(global::Picsart.GenAIExpandParametersFormat?)

                    || typeToConvert == typeof(global::Picsart.GenAIExpandParametersMode)

                    || typeToConvert == typeof(global::Picsart.GenAIExpandParametersMode?)

                    || typeToConvert == typeof(global::Picsart.GenAIBleedParametersFormat)

                    || typeToConvert == typeof(global::Picsart.GenAIBleedParametersFormat?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Picsart.GenAIInpaintingParametersFormat))
                {
                    return new global::Picsart.JsonConverters.GenAIInpaintingParametersFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenAIInpaintingParametersFormat?))
                {
                    return new global::Picsart.JsonConverters.GenAIInpaintingParametersFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenAIInpaintingParametersMode))
                {
                    return new global::Picsart.JsonConverters.GenAIInpaintingParametersModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenAIInpaintingParametersMode?))
                {
                    return new global::Picsart.JsonConverters.GenAIInpaintingParametersModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenAIRemoveObjectParametersFormat))
                {
                    return new global::Picsart.JsonConverters.GenAIRemoveObjectParametersFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenAIRemoveObjectParametersFormat?))
                {
                    return new global::Picsart.JsonConverters.GenAIRemoveObjectParametersFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenAIRemoveObjectParametersMode))
                {
                    return new global::Picsart.JsonConverters.GenAIRemoveObjectParametersModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenAIRemoveObjectParametersMode?))
                {
                    return new global::Picsart.JsonConverters.GenAIRemoveObjectParametersModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenAIExpandParametersDirection))
                {
                    return new global::Picsart.JsonConverters.GenAIExpandParametersDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenAIExpandParametersDirection?))
                {
                    return new global::Picsart.JsonConverters.GenAIExpandParametersDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenAIExpandParametersFormat))
                {
                    return new global::Picsart.JsonConverters.GenAIExpandParametersFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenAIExpandParametersFormat?))
                {
                    return new global::Picsart.JsonConverters.GenAIExpandParametersFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenAIExpandParametersMode))
                {
                    return new global::Picsart.JsonConverters.GenAIExpandParametersModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenAIExpandParametersMode?))
                {
                    return new global::Picsart.JsonConverters.GenAIExpandParametersModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenAIBleedParametersFormat))
                {
                    return new global::Picsart.JsonConverters.GenAIBleedParametersFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Picsart.GenAIBleedParametersFormat?))
                {
                    return new global::Picsart.JsonConverters.GenAIBleedParametersFormatNullableJsonConverter();
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
                    0 => new GenAIInpaintingImage2ImageSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}