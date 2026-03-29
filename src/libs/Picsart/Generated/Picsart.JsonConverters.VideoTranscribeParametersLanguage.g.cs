#nullable enable

namespace Picsart.JsonConverters
{
    /// <inheritdoc />
    public sealed class VideoTranscribeParametersLanguageJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Picsart.VideoTranscribeParametersLanguage>
    {
        /// <inheritdoc />
        public override global::Picsart.VideoTranscribeParametersLanguage Read(
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
                        return global::Picsart.VideoTranscribeParametersLanguageExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Picsart.VideoTranscribeParametersLanguage)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Picsart.VideoTranscribeParametersLanguage);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Picsart.VideoTranscribeParametersLanguage value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Picsart.VideoTranscribeParametersLanguageExtensions.ToValueString(value));
        }
    }
}
