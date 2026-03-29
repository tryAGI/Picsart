/*
order: 10
title: Client Creation
slug: client-creation

Basic example showing how to create a Picsart client.
*/

namespace Picsart.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void Example_ClientCreation()
    {
        //// Create a Picsart client using your API key.

        var apiKey =
            Environment.GetEnvironmentVariable("PICSART_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("PICSART_API_KEY environment variable is not found.");

        using var client = new PicsartClient(apiKey);

        //// The client provides access to all Picsart sub-APIs:
        //// - `client.ImageRemoveBackground` -- background removal
        //// - `client.ImagePhotoEnhancement` -- upscale, enhance, face enhancement
        //// - `client.ImageEffects` -- effects, masks, adjustments
        //// - `client.GenAIText2Image` -- text-to-image generation
        //// - `client.GenAIText2VideoImage2Video` -- text/image-to-video generation
        //// - `client.VideoEdit` -- video editing (trim, crop, concat)

        client.Should().NotBeNull();
        client.ImageRemoveBackground.Should().NotBeNull();
        client.ImagePhotoEnhancement.Should().NotBeNull();
        client.GenAIText2Image.Should().NotBeNull();
    }
}
