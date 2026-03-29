
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenAILogoParameters
    {
        /// <summary>
        /// Simply add your brand or company name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("brand_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BrandName { get; set; }

        /// <summary>
        /// Describe your business, what it does. This information will be used to create logos that describe your brand.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("business_description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BusinessDescription { get; set; }

        /// <summary>
        /// Optionally select one of the color tones for the generated logos (Auto is default). Options are as follows:<br/>
        ///   * Auto<br/>
        ///   * Gray<br/>
        ///   * Blue<br/>
        ///   * Pink<br/>
        ///   * Orange<br/>
        ///   * Brown<br/>
        ///   * Yellow<br/>
        ///   * Green<br/>
        ///   * Purple<br/>
        ///   * Red<br/>
        /// Default Value: Auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color_tone")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.GenAILogoParametersColorToneJsonConverter))]
        public global::Picsart.GenAILogoParametersColorTone? ColorTone { get; set; }

        /// <summary>
        /// Describe your logo details. What elements and details it should include, and how you imagine it should look like.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logo_description")]
        public string? LogoDescription { get; set; }

        /// <summary>
        /// Use one of the reference parameters to give a logo example. The service will then use this along with business and logo description to create a similar logo. Reference logo image (binary). (If this parameter is present, the other reference logo parameters must be empty.)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_image")]
        public byte[]? ReferenceImage { get; set; }

        /// <summary>
        /// Use one of the reference parameters to give a logo example. The service will then use this along with business and logo description to create a similar logo. Reference logo image (binary). (If this parameter is present, the other reference logo parameters must be empty.)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_imagename")]
        public string? ReferenceImagename { get; set; }

        /// <summary>
        /// Reference logo URL. (If this parameter is present, the other reference logo parameters must be empty.)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_image_url")]
        public string? ReferenceImageUrl { get; set; }

        /// <summary>
        /// Deprecated. Reference logo image ID of an image previously uploaded to Picsart or result image ID from a different API. (If this parameter is present, the other reference logo parameters must be empty.)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_image_id")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? ReferenceImageId { get; set; }

        /// <summary>
        /// The number of logos to generate.<br/>
        /// Default Value: 2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        public double? Count { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenAILogoParameters" /> class.
        /// </summary>
        /// <param name="brandName">
        /// Simply add your brand or company name.
        /// </param>
        /// <param name="businessDescription">
        /// Describe your business, what it does. This information will be used to create logos that describe your brand.
        /// </param>
        /// <param name="colorTone">
        /// Optionally select one of the color tones for the generated logos (Auto is default). Options are as follows:<br/>
        ///   * Auto<br/>
        ///   * Gray<br/>
        ///   * Blue<br/>
        ///   * Pink<br/>
        ///   * Orange<br/>
        ///   * Brown<br/>
        ///   * Yellow<br/>
        ///   * Green<br/>
        ///   * Purple<br/>
        ///   * Red<br/>
        /// Default Value: Auto
        /// </param>
        /// <param name="logoDescription">
        /// Describe your logo details. What elements and details it should include, and how you imagine it should look like.
        /// </param>
        /// <param name="referenceImage">
        /// Use one of the reference parameters to give a logo example. The service will then use this along with business and logo description to create a similar logo. Reference logo image (binary). (If this parameter is present, the other reference logo parameters must be empty.)
        /// </param>
        /// <param name="referenceImagename">
        /// Use one of the reference parameters to give a logo example. The service will then use this along with business and logo description to create a similar logo. Reference logo image (binary). (If this parameter is present, the other reference logo parameters must be empty.)
        /// </param>
        /// <param name="referenceImageUrl">
        /// Reference logo URL. (If this parameter is present, the other reference logo parameters must be empty.)
        /// </param>
        /// <param name="count">
        /// The number of logos to generate.<br/>
        /// Default Value: 2
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenAILogoParameters(
            string brandName,
            string businessDescription,
            global::Picsart.GenAILogoParametersColorTone? colorTone,
            string? logoDescription,
            byte[]? referenceImage,
            string? referenceImagename,
            string? referenceImageUrl,
            double? count)
        {
            this.BrandName = brandName ?? throw new global::System.ArgumentNullException(nameof(brandName));
            this.BusinessDescription = businessDescription ?? throw new global::System.ArgumentNullException(nameof(businessDescription));
            this.ColorTone = colorTone;
            this.LogoDescription = logoDescription;
            this.ReferenceImage = referenceImage;
            this.ReferenceImagename = referenceImagename;
            this.ReferenceImageUrl = referenceImageUrl;
            this.Count = count;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenAILogoParameters" /> class.
        /// </summary>
        public GenAILogoParameters()
        {
        }
    }
}