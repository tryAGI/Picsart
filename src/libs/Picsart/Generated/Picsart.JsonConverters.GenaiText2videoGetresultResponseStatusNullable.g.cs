#nullable enable

namespace Picsart.JsonConverters
{
    /// <inheritdoc />
    public sealed class GenaiText2videoGetresultResponseStatusNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Picsart.GenaiText2videoGetresultResponseStatus?>
    {
        /// <inheritdoc />
        public override global::Picsart.GenaiText2videoGetresultResponseStatus? Read(
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
                        return global::Picsart.GenaiText2videoGetresultResponseStatusExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Picsart.GenaiText2videoGetresultResponseStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Picsart.GenaiText2videoGetresultResponseStatus?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Picsart.GenaiText2videoGetresultResponseStatus? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Picsart.GenaiText2videoGetresultResponseStatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
