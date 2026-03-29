
#nullable enable

namespace Picsart
{
    /// <summary>
    /// Use this query parameter to establish the processing mode. Acceptable values are sync, async and auto (sync is default):<br/>
    ///   * sync: issues a synchronous request, response is given when the result is ready.<br/>
    ///   * async: forces an asynchronous request, the response, which is instantaneous, contains a "transaction_id" which is used to poll for the result.<br/>
    ///   * REMOVED - auto: the processing mode decision is made by the service, which depends upon the expected processing time.<br/>
    /// Default Value: sync
    /// </summary>
    public enum GenAIInpaintingParametersMode
    {
        /// <summary>
        /// 
        /// </summary>
        Async,
        /// <summary>
        /// 
        /// </summary>
        Sync,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenAIInpaintingParametersModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenAIInpaintingParametersMode value)
        {
            return value switch
            {
                GenAIInpaintingParametersMode.Async => "async",
                GenAIInpaintingParametersMode.Sync => "sync",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenAIInpaintingParametersMode? ToEnum(string value)
        {
            return value switch
            {
                "async" => GenAIInpaintingParametersMode.Async,
                "sync" => GenAIInpaintingParametersMode.Sync,
                _ => null,
            };
        }
    }
}