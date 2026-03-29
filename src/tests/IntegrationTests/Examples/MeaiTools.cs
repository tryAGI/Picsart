/*
order: 20
title: MEAI Tools
slug: meai-tools

Example showing how to create MEAI AIFunction tools from the Picsart client.
*/

using Microsoft.Extensions.AI;

namespace Picsart.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void Example_MeaiTools()
    {
        //// Create AIFunction tools from the Picsart client for use with any `IChatClient`.

        var apiKey =
            Environment.GetEnvironmentVariable("PICSART_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("PICSART_API_KEY environment variable is not found.");

        using var client = new PicsartClient(apiKey);

        //// Create individual tools for specific capabilities:
        var removeBackgroundTool = client.AsRemoveBackgroundTool();
        var upscaleTool = client.AsUpscaleTool();
        var textToImageTool = client.AsTextToImageTool();
        var listEffectsTool = client.AsListEffectsTool();
        var getBalanceTool = client.AsGetBalanceTool();

        //// These tools can be added to ChatOptions.Tools for any IChatClient:
        //// ```csharp
        //// var options = new ChatOptions
        //// {
        ////     Tools = [removeBackgroundTool, upscaleTool, textToImageTool],
        //// };
        //// ```

        removeBackgroundTool.Should().NotBeNull();
        removeBackgroundTool.Name.Should().Be("PicsartRemoveBackground");
        upscaleTool.Should().NotBeNull();
        upscaleTool.Name.Should().Be("PicsartUpscale");
        textToImageTool.Should().NotBeNull();
        textToImageTool.Name.Should().Be("PicsartTextToImage");
        listEffectsTool.Should().NotBeNull();
        listEffectsTool.Name.Should().Be("PicsartListEffects");
        getBalanceTool.Should().NotBeNull();
        getBalanceTool.Name.Should().Be("PicsartGetBalance");
    }
}
