
#nullable enable

namespace Picsart
{
    /// <summary>
    /// 
    /// </summary>
    public enum ImageCarsClassifierResponseDataClass
    {
        /// <summary>
        /// 
        /// </summary>
        x34FrontLeft,
        /// <summary>
        /// 
        /// </summary>
        x34FrontRight,
        /// <summary>
        /// 
        /// </summary>
        x34RearLeft,
        /// <summary>
        /// 
        /// </summary>
        x34RearRight,
        /// <summary>
        /// 
        /// </summary>
        Detail,
        /// <summary>
        /// 
        /// </summary>
        Engine,
        /// <summary>
        /// 
        /// </summary>
        Front,
        /// <summary>
        /// 
        /// </summary>
        Interior,
        /// <summary>
        /// 
        /// </summary>
        LeftSide,
        /// <summary>
        /// 
        /// </summary>
        Rear,
        /// <summary>
        /// 
        /// </summary>
        RightSide,
        /// <summary>
        /// 
        /// </summary>
        Top,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageCarsClassifierResponseDataClassExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageCarsClassifierResponseDataClass value)
        {
            return value switch
            {
                ImageCarsClassifierResponseDataClass.x34FrontLeft => "34-front-left",
                ImageCarsClassifierResponseDataClass.x34FrontRight => "34-front-right",
                ImageCarsClassifierResponseDataClass.x34RearLeft => "34-rear-left",
                ImageCarsClassifierResponseDataClass.x34RearRight => "34-rear-right",
                ImageCarsClassifierResponseDataClass.Detail => "detail",
                ImageCarsClassifierResponseDataClass.Engine => "engine",
                ImageCarsClassifierResponseDataClass.Front => "front",
                ImageCarsClassifierResponseDataClass.Interior => "interior",
                ImageCarsClassifierResponseDataClass.LeftSide => "left-side",
                ImageCarsClassifierResponseDataClass.Rear => "rear",
                ImageCarsClassifierResponseDataClass.RightSide => "right-side",
                ImageCarsClassifierResponseDataClass.Top => "top",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageCarsClassifierResponseDataClass? ToEnum(string value)
        {
            return value switch
            {
                "34-front-left" => ImageCarsClassifierResponseDataClass.x34FrontLeft,
                "34-front-right" => ImageCarsClassifierResponseDataClass.x34FrontRight,
                "34-rear-left" => ImageCarsClassifierResponseDataClass.x34RearLeft,
                "34-rear-right" => ImageCarsClassifierResponseDataClass.x34RearRight,
                "detail" => ImageCarsClassifierResponseDataClass.Detail,
                "engine" => ImageCarsClassifierResponseDataClass.Engine,
                "front" => ImageCarsClassifierResponseDataClass.Front,
                "interior" => ImageCarsClassifierResponseDataClass.Interior,
                "left-side" => ImageCarsClassifierResponseDataClass.LeftSide,
                "rear" => ImageCarsClassifierResponseDataClass.Rear,
                "right-side" => ImageCarsClassifierResponseDataClass.RightSide,
                "top" => ImageCarsClassifierResponseDataClass.Top,
                _ => null,
            };
        }
    }
}