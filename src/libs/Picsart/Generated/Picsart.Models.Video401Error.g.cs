
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Video401Error
    {
        /// <summary>
        /// Example: 401
        /// </summary>
        /// <example>401</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public int? Code { get; set; }

        /// <summary>
        /// Example: Unauthorized
        /// </summary>
        /// <example>Unauthorized</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Detail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Video401Error" /> class.
        /// </summary>
        /// <param name="detail"></param>
        /// <param name="code">
        /// Example: 401
        /// </param>
        /// <param name="message">
        /// Example: Unauthorized
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Video401Error(
            string detail,
            int? code,
            string? message)
        {
            this.Code = code;
            this.Message = message;
            this.Detail = detail ?? throw new global::System.ArgumentNullException(nameof(detail));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Video401Error" /> class.
        /// </summary>
        public Video401Error()
        {
        }
    }
}