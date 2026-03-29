
#nullable enable

namespace Picsart
{
    public sealed partial class PicsartClient
    {
        /// <inheritdoc/>
        public void AuthorizeUsingApiKeyInHeader(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            Authorizations.Clear();
            Authorizations.Add(new global::Picsart.EndPointAuthorization
            {
                Type = "ApiKey",
                Location = "Header",
                Name = "X-Picsart-API-Key",
                Value = apiKey,
            });
        }
    }
}