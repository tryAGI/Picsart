
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VdDescribeVariableDataContentResponseDataTag
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.VdDescribeVariableDataContentResponseDataTagTypeJsonConverter))]
        public global::Picsart.VdDescribeVariableDataContentResponseDataTagType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag")]
        public string? Tag { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VdDescribeVariableDataContentResponseDataTag" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="tag"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VdDescribeVariableDataContentResponseDataTag(
            global::Picsart.VdDescribeVariableDataContentResponseDataTagType? type,
            string? tag)
        {
            this.Type = type;
            this.Tag = tag;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VdDescribeVariableDataContentResponseDataTag" /> class.
        /// </summary>
        public VdDescribeVariableDataContentResponseDataTag()
        {
        }
    }
}