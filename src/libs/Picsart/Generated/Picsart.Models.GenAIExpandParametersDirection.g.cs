
#nullable enable

namespace Picsart
{
    /// <summary>
    /// Use this parameter to define in which direction the source image should be expanded. Available values are:<br/>
    ///   * center: Add pixels and expand the image from all sides. The original image will remain in the center.<br/>
    ///   * top-left: Add pixels and expand to the top-left. The original image will remain the bottom-right corner.<br/>
    ///   * top-right: Add pixels and expand to the top-right. The original image will remain the bottom-left corner.<br/>
    ///   * bottom-left: Add pixels and expand to the bottom-left. The original image will remain the top-right corner.<br/>
    ///   * bottom-right:Add pixels and expand to the bottom-right. The original image will remain the top-left corner.<br/>
    /// Default Value: center
    /// </summary>
    public enum GenAIExpandParametersDirection
    {
        /// <summary>
        /// Add pixels and expand to the top-right. The original image will remain the bottom-left corner.
        /// </summary>
        BottomLeft,
        /// <summary>
        /// Add pixels and expand to the top-left. The original image will remain the bottom-right corner.
        /// </summary>
        BottomRight,
        /// <summary>
        /// Add pixels and expand the image from all sides. The original image will remain in the center.
        /// </summary>
        Center,
        /// <summary>
        /// Add pixels and expand to the top-left. The original image will remain the bottom-right corner.
        /// </summary>
        TopLeft,
        /// <summary>
        /// Add pixels and expand to the top-right. The original image will remain the bottom-left corner.
        /// </summary>
        TopRight,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenAIExpandParametersDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenAIExpandParametersDirection value)
        {
            return value switch
            {
                GenAIExpandParametersDirection.BottomLeft => "bottom-left",
                GenAIExpandParametersDirection.BottomRight => "bottom-right",
                GenAIExpandParametersDirection.Center => "center",
                GenAIExpandParametersDirection.TopLeft => "top-left",
                GenAIExpandParametersDirection.TopRight => "top-right",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenAIExpandParametersDirection? ToEnum(string value)
        {
            return value switch
            {
                "bottom-left" => GenAIExpandParametersDirection.BottomLeft,
                "bottom-right" => GenAIExpandParametersDirection.BottomRight,
                "center" => GenAIExpandParametersDirection.Center,
                "top-left" => GenAIExpandParametersDirection.TopLeft,
                "top-right" => GenAIExpandParametersDirection.TopRight,
                _ => null,
            };
        }
    }
}