#nullable enable

namespace Picsart.JsonConverters
{
    /// <inheritdoc />
    public sealed class VideoSetThumbnailResponseStatusNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Picsart.VideoSetThumbnailResponseStatus?>
    {
        /// <inheritdoc />
        public override global::Picsart.VideoSetThumbnailResponseStatus? Read(
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
                        return global::Picsart.VideoSetThumbnailResponseStatusExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Picsart.VideoSetThumbnailResponseStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Picsart.VideoSetThumbnailResponseStatus?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Picsart.VideoSetThumbnailResponseStatus? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Picsart.VideoSetThumbnailResponseStatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
