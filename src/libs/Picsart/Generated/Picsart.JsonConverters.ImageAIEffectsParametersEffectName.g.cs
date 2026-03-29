#nullable enable

namespace Picsart.JsonConverters
{
    /// <inheritdoc />
    public sealed class ImageAIEffectsParametersEffectNameJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Picsart.ImageAIEffectsParametersEffectName>
    {
        /// <inheritdoc />
        public override global::Picsart.ImageAIEffectsParametersEffectName Read(
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
                        return global::Picsart.ImageAIEffectsParametersEffectNameExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Picsart.ImageAIEffectsParametersEffectName)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Picsart.ImageAIEffectsParametersEffectName);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Picsart.ImageAIEffectsParametersEffectName value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Picsart.ImageAIEffectsParametersEffectNameExtensions.ToValueString(value));
        }
    }
}
