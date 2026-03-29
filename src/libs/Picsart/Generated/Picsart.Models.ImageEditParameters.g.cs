
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageEditParameters
    {
        /// <summary>
        /// Optionally select one of the image formats (JPG is chosen if left blank). Options are as follows:<br/>
        ///   * JPG<br/>
        ///   * PNG<br/>
        ///   * WEBP<br/>
        /// Default Value: JPG
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.ImageEditParametersFormatJsonConverter))]
        public global::Picsart.ImageEditParametersFormat? Format { get; set; }

        /// <summary>
        /// For *crop* mode, the outcome image will be center-cropped with the given size (width, height). For the *resize* mode, the smallest size will be fitted to preserve the original proportion of the image. When the outcome size is not provided with width and height, no cropping or resizing will be applied (see alternative options such as rotate, flip and perspective).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.ImageEditParametersModeJsonConverter))]
        public global::Picsart.ImageEditParametersMode? Mode { get; set; }

        /// <summary>
        /// When defined, this parameter overrides and applies the value for both width and height.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public int? Size { get; set; }

        /// <summary>
        /// Width of outcome image. If the provided width is larger than the original width of the file, the original size of the image will be selected. When crop size is defined, but the x,y starting position is not provided, the crop will be a center-crop (i.e., equally cutting from each side).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public int? Width { get; set; }

        /// <summary>
        /// Height of outcome image. If the provided height is larger than the original width of the file, the original size of the image will be selected. When crop size is defined, but the x,y starting position is not provided, the crop will be a center-crop (i.e, equally cutting from each side).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public int? Height { get; set; }

        /// <summary>
        /// crop_x, toghether with crop_y, define the anchor point of the crop. This point will be the center of the crop area. The top-left corner corresponds to (0,0) point and the bottom-right corner corresponds to (widht,height) point.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("crop_x")]
        public int? CropX { get; set; }

        /// <summary>
        /// crop_y, toghether with crop_x, define the anchor point of the crop. This point will be the center of the crop area. The top-left corner corresponds to (0,0) point and the bottom-right corner corresponds to (widht,height) point.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("crop_y")]
        public int? CropY { get; set; }

        /// <summary>
        /// By default when crop_anchor or crop_x,crop_y pair are not provided, the crop will be done around the center of the image. This parameter is an easier option to crop_x,crop_y pair where the respective corner of the image will be cropped. Options for crop anchor are as follows:<br/>
        ///   * center<br/>
        ///   * top-left<br/>
        ///   * top-right<br/>
        ///   * bottom-left<br/>
        ///   * bottom-right<br/>
        /// Default Value: center
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("crop_anchor")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.ImageEditParametersCropAnchorJsonConverter))]
        public global::Picsart.ImageEditParametersCropAnchor? CropAnchor { get; set; }

        /// <summary>
        /// Choose a way to flip the image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flip")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Picsart.JsonConverters.ImageEditParametersFlipJsonConverter))]
        public global::Picsart.ImageEditParametersFlip? Flip { get; set; }

        /// <summary>
        /// Enter a float value to rotate the image from -180 to +180. Default is 0.<br/>
        /// Default Value: 0.0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rotate")]
        public float? Rotate { get; set; }

        /// <summary>
        /// The horizontal perspective after edits.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("perspective_horizontal")]
        public int? PerspectiveHorizontal { get; set; }

        /// <summary>
        /// The vertical perspective after edits.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("perspective_vertical")]
        public int? PerspectiveVertical { get; set; }

        /// <summary>
        /// This refers to the level of accuracy of the image processing. The greater the quality (i.e., the larger the number), the larger the image file size. The default value is 90, which is a good compromise between quality and file size.<br/>
        /// Default Value: 90
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        public int? Quality { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageEditParameters" /> class.
        /// </summary>
        /// <param name="format">
        /// Optionally select one of the image formats (JPG is chosen if left blank). Options are as follows:<br/>
        ///   * JPG<br/>
        ///   * PNG<br/>
        ///   * WEBP<br/>
        /// Default Value: JPG
        /// </param>
        /// <param name="mode">
        /// For *crop* mode, the outcome image will be center-cropped with the given size (width, height). For the *resize* mode, the smallest size will be fitted to preserve the original proportion of the image. When the outcome size is not provided with width and height, no cropping or resizing will be applied (see alternative options such as rotate, flip and perspective).
        /// </param>
        /// <param name="size">
        /// When defined, this parameter overrides and applies the value for both width and height.
        /// </param>
        /// <param name="width">
        /// Width of outcome image. If the provided width is larger than the original width of the file, the original size of the image will be selected. When crop size is defined, but the x,y starting position is not provided, the crop will be a center-crop (i.e., equally cutting from each side).
        /// </param>
        /// <param name="height">
        /// Height of outcome image. If the provided height is larger than the original width of the file, the original size of the image will be selected. When crop size is defined, but the x,y starting position is not provided, the crop will be a center-crop (i.e, equally cutting from each side).
        /// </param>
        /// <param name="cropX">
        /// crop_x, toghether with crop_y, define the anchor point of the crop. This point will be the center of the crop area. The top-left corner corresponds to (0,0) point and the bottom-right corner corresponds to (widht,height) point.
        /// </param>
        /// <param name="cropY">
        /// crop_y, toghether with crop_x, define the anchor point of the crop. This point will be the center of the crop area. The top-left corner corresponds to (0,0) point and the bottom-right corner corresponds to (widht,height) point.
        /// </param>
        /// <param name="cropAnchor">
        /// By default when crop_anchor or crop_x,crop_y pair are not provided, the crop will be done around the center of the image. This parameter is an easier option to crop_x,crop_y pair where the respective corner of the image will be cropped. Options for crop anchor are as follows:<br/>
        ///   * center<br/>
        ///   * top-left<br/>
        ///   * top-right<br/>
        ///   * bottom-left<br/>
        ///   * bottom-right<br/>
        /// Default Value: center
        /// </param>
        /// <param name="flip">
        /// Choose a way to flip the image.
        /// </param>
        /// <param name="rotate">
        /// Enter a float value to rotate the image from -180 to +180. Default is 0.<br/>
        /// Default Value: 0.0
        /// </param>
        /// <param name="perspectiveHorizontal">
        /// The horizontal perspective after edits.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="perspectiveVertical">
        /// The vertical perspective after edits.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="quality">
        /// This refers to the level of accuracy of the image processing. The greater the quality (i.e., the larger the number), the larger the image file size. The default value is 90, which is a good compromise between quality and file size.<br/>
        /// Default Value: 90
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageEditParameters(
            global::Picsart.ImageEditParametersFormat? format,
            global::Picsart.ImageEditParametersMode? mode,
            int? size,
            int? width,
            int? height,
            int? cropX,
            int? cropY,
            global::Picsart.ImageEditParametersCropAnchor? cropAnchor,
            global::Picsart.ImageEditParametersFlip? flip,
            float? rotate,
            int? perspectiveHorizontal,
            int? perspectiveVertical,
            int? quality)
        {
            this.Format = format;
            this.Mode = mode;
            this.Size = size;
            this.Width = width;
            this.Height = height;
            this.CropX = cropX;
            this.CropY = cropY;
            this.CropAnchor = cropAnchor;
            this.Flip = flip;
            this.Rotate = rotate;
            this.PerspectiveHorizontal = perspectiveHorizontal;
            this.PerspectiveVertical = perspectiveVertical;
            this.Quality = quality;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageEditParameters" /> class.
        /// </summary>
        public ImageEditParameters()
        {
        }
    }
}