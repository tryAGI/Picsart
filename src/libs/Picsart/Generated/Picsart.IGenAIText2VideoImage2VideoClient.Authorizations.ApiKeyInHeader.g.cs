
#nullable enable

namespace Picsart
{
    public partial interface IGenAIText2VideoImage2VideoClient
    {
        /// <summary>
        /// Authorize using ApiKey authentication.
        /// </summary>
        /// <param name="apiKey"></param>

        public void AuthorizeUsingApiKeyInHeader(
            string apiKey);
    }
}