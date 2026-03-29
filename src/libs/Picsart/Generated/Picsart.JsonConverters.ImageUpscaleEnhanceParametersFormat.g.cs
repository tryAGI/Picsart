#nullable enable

namespace Picsart.JsonConverters
{
    /// <inheritdoc />
    public sealed class ImageUpscaleEnhanceParametersFormatJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Picsart.ImageUpscaleEnhanceParametersFormat>
    {
        /// <inheritdoc />
        public override global::Picsart.ImageUpscaleEnhanceParametersFormat Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Picsart.ImageUpscaleEnhanceParametersFormatExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Picsart.ImageUpscaleEnhanceParametersFormat)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Picsart.ImageUpscaleEnhanceParametersFormat);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Picsart.ImageUpscaleEnhanceParametersFormat value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Picsart.ImageUpscaleEnhanceParametersFormatExtensions.ToValueString(value));
        }
    }
}
