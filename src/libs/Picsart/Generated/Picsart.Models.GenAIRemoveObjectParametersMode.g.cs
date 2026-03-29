
#nullable enable

namespace Picsart
{
    /// <summary>
    /// Use this query parameter to establish the processing mode. Acceptable values are sync, async and auto (sync is default):<br/>
    ///   * sync: issues a synchronous request, response is given when the result is ready.<br/>
    ///   * async: forces an asynchronous request, the response, which is instantaneous, contains a "transaction_id" which is used to poll for the result.<br/>
    ///   * auto: the processing mode decision is made by the service, which depends upon the expected processing time.<br/>
    /// Default Value: sync
    /// </summary>
    public enum GenAIRemoveObjectParametersMode
    {
        /// <summary>
        /// 
        /// </summary>
        Async,
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Sync,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenAIRemoveObjectParametersModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenAIRemoveObjectParametersMode value)
        {
            return value switch
            {
                GenAIRemoveObjectParametersMode.Async => "async",
                GenAIRemoveObjectParametersMode.Auto => "auto",
                GenAIRemoveObjectParametersMode.Sync => "sync",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenAIRemoveObjectParametersMode? ToEnum(string value)
        {
            return value switch
            {
                "async" => GenAIRemoveObjectParametersMode.Async,
                "auto" => GenAIRemoveObjectParametersMode.Auto,
                "sync" => GenAIRemoveObjectParametersMode.Sync,
                _ => null,
            };
        }
    }
}