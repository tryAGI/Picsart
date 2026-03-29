namespace Picsart.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static PicsartClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("PICSART_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("PICSART_API_KEY environment variable is not found.");

        var client = new PicsartClient(apiKey);
        
        return client;
    }
}
