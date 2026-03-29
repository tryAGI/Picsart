#nullable enable

namespace Picsart.JsonConverters
{
    /// <inheritdoc />
    public sealed class GenAIImage2VideoModelsModelNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Picsart.GenAIImage2VideoModelsModel?>
    {
        /// <inheritdoc />
        public override global::Picsart.GenAIImage2VideoModelsModel? Read(
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
                        return global::Picsart.GenAIImage2VideoModelsModelExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Picsart.GenAIImage2VideoModelsModel)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Picsart.GenAIImage2VideoModelsModel?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Picsart.GenAIImage2VideoModelsModel? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Picsart.GenAIImage2VideoModelsModelExtensions.ToValueString(value.Value));
            }
        }
    }
}
