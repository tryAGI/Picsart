
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VdDescribeVariableDataContentResponseData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<global::Picsart.VdDescribeVariableDataContentResponseDataTag>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aminated")]
        public bool? Aminated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VdDescribeVariableDataContentResponseData" /> class.
        /// </summary>
        /// <param name="tags"></param>
        /// <param name="aminated"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VdDescribeVariableDataContentResponseData(
            global::System.Collections.Generic.IList<global::Picsart.VdDescribeVariableDataContentResponseDataTag>? tags,
            bool? aminated)
        {
            this.Tags = tags;
            this.Aminated = aminated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VdDescribeVariableDataContentResponseData" /> class.
        /// </summary>
        public VdDescribeVariableDataContentResponseData()
        {
        }
    }
}