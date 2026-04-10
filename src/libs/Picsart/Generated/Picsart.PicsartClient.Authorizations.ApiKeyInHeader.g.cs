
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

            for (var i = Authorizations.Count - 1; i >= 0; i--)
            {
                var __authorization = Authorizations[i];
                if (__authorization.Type == "ApiKey" &&
                    __authorization.Location == "Header" &&
                    __authorization.Name == "X-Picsart-API-Key")
                {
                    Authorizations.RemoveAt(i);
                }
            }

            Authorizations.Add(new global::Picsart.EndPointAuthorization
            {
                Type = "ApiKey",
                SchemeId = "ApikeyXPicsartApiKey",
                Location = "Header",
                Name = "X-Picsart-API-Key",
                Value = apiKey,
            });
        }
    }
}