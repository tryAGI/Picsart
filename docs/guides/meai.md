# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The Picsart SDK provides `AIFunction` tool wrappers compatible with [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai). These tools can be used with any `IChatClient` to give AI models access to Picsart's image editing, background removal, upscaling, text-to-image generation, and effects capabilities.

## Installation

```bash
dotnet add package Picsart
```

## Available Tools

| Method | Tool Name | Description |
|--------|-----------|-------------|
| `AsRemoveBackgroundTool()` | `PicsartRemoveBackground` | Removes the background from an image given its URL |
| `AsUpscaleTool()` | `PicsartUpscale` | Upscales an image to increase its resolution (2x, 4x, 6x, or 8x) |
| `AsTextToImageTool()` | `PicsartTextToImage` | Generates an image from a text prompt using GenAI |
| `AsListEffectsTool()` | `PicsartListEffects` | Lists all available image effects |
| `AsGetBalanceTool()` | `PicsartGetBalance` | Checks the remaining credits balance |

## Usage

```csharp
using Picsart;
using Microsoft.Extensions.AI;

var picsartClient = new PicsartClient(
    apiKey: Environment.GetEnvironmentVariable("PICSART_API_KEY")!);

var options = new ChatOptions
{
    Tools =
    [
        picsartClient.AsRemoveBackgroundTool(),
        picsartClient.AsUpscaleTool(),
        picsartClient.AsTextToImageTool(),
        picsartClient.AsListEffectsTool(),
        picsartClient.AsGetBalanceTool(),
    ],
};

IChatClient chatClient = /* your chat client */;

var messages = new List<ChatMessage>
{
    new(ChatRole.User, "Remove the background from this image: https://example.com/photo.jpg"),
};

while (true)
{
    var response = await chatClient.GetResponseAsync(messages, options);
    messages.AddRange(response.ToChatMessages());

    if (response.FinishReason == ChatFinishReason.ToolCalls)
    {
        var results = await response.CallToolsAsync(options);
        messages.AddRange(results);
        continue;
    }

    Console.WriteLine(response.Text);
    break;
}
```
