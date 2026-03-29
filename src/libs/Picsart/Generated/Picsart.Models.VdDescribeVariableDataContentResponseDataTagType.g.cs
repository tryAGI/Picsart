
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public enum VdDescribeVariableDataContentResponseDataTagType
    {
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VdDescribeVariableDataContentResponseDataTagTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VdDescribeVariableDataContentResponseDataTagType value)
        {
            return value switch
            {
                VdDescribeVariableDataContentResponseDataTagType.Image => "image",
                VdDescribeVariableDataContentResponseDataTagType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VdDescribeVariableDataContentResponseDataTagType? ToEnum(string value)
        {
            return value switch
            {
                "image" => VdDescribeVariableDataContentResponseDataTagType.Image,
                "text" => VdDescribeVariableDataContentResponseDataTagType.Text,
                _ => null,
            };
        }
    }
}