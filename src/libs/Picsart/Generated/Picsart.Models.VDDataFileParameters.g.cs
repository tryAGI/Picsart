
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VDDataFileParameters
    {
        /// <summary>
        /// Source data file as a string. Comma separated values only. The first line should always be the header line, with column names. Only the first 50 data rows will be processed. (If this parameter is present, the other data file source parameters must be empty.)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public string? Data { get; set; }

        /// <summary>
        /// Source data (CSV) file (binary, attachment). The first line should always be the header line, with column names. Only the first 50 data rows will be processed. (If this parameter is present, the other data file source parameters must be empty.)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_file")]
        public byte[]? DataFile { get; set; }

        /// <summary>
        /// Source data (CSV) file (binary, attachment). The first line should always be the header line, with column names. Only the first 50 data rows will be processed. (If this parameter is present, the other data file source parameters must be empty.)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_filename")]
        public string? DataFilename { get; set; }

        /// <summary>
        /// Source data (CSV) file URL. The first line should always be the header line, with column names. Only the first 50 data rows will be processed. (If this parameter is present, the other data file source parameters must be empty.)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_file_url")]
        public string? DataFileUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VDDataFileParameters" /> class.
        /// </summary>
        /// <param name="data">
        /// Source data file as a string. Comma separated values only. The first line should always be the header line, with column names. Only the first 50 data rows will be processed. (If this parameter is present, the other data file source parameters must be empty.)
        /// </param>
        /// <param name="dataFile">
        /// Source data (CSV) file (binary, attachment). The first line should always be the header line, with column names. Only the first 50 data rows will be processed. (If this parameter is present, the other data file source parameters must be empty.)
        /// </param>
        /// <param name="dataFilename">
        /// Source data (CSV) file (binary, attachment). The first line should always be the header line, with column names. Only the first 50 data rows will be processed. (If this parameter is present, the other data file source parameters must be empty.)
        /// </param>
        /// <param name="dataFileUrl">
        /// Source data (CSV) file URL. The first line should always be the header line, with column names. Only the first 50 data rows will be processed. (If this parameter is present, the other data file source parameters must be empty.)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VDDataFileParameters(
            string? data,
            byte[]? dataFile,
            string? dataFilename,
            string? dataFileUrl)
        {
            this.Data = data;
            this.DataFile = dataFile;
            this.DataFilename = dataFilename;
            this.DataFileUrl = dataFileUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VDDataFileParameters" /> class.
        /// </summary>
        public VDDataFileParameters()
        {
        }
    }
}