
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageCarsClassifierResponseData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("class")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.ImageCarsClassifierResponseDataClassJsonConverter))]
        public global::Picsart.ImageCarsClassifierResponseDataClass? Class { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vin")]
        public string? Vin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("odo")]
        public string? Odo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageCarsClassifierResponseData" /> class.
        /// </summary>
        /// <param name="class"></param>
        /// <param name="vin"></param>
        /// <param name="odo"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageCarsClassifierResponseData(
            global::Picsart.ImageCarsClassifierResponseDataClass? @class,
            string? vin,
            string? odo)
        {
            this.Class = @class;
            this.Vin = vin;
            this.Odo = odo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageCarsClassifierResponseData" /> class.
        /// </summary>
        public ImageCarsClassifierResponseData()
        {
        }
    }
}