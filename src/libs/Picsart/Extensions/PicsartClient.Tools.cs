using Microsoft.Extensions.AI;

namespace Picsart;

/// <summary>
/// Extensions for using PicsartClient as MEAI AIFunction tools with any IChatClient.
/// </summary>
public static class PicsartToolExtensions
{
    /// <summary>
    /// Creates an <see cref="AIFunction"/> that removes the background from an image URL
    /// using Picsart's AI-powered background removal service.
    /// </summary>
    /// <param name="client">The Picsart client.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsRemoveBackgroundTool(
        this PicsartClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string imageUrl, CancellationToken cancellationToken) =>
            {
                var request = new AllOf<ImageImageParameters, ImageRemoveBackgroundParameters>
                {
                    Value1 = new ImageImageParameters
                    {
                        ImageUrl = imageUrl,
                    },
                    Value2 = new ImageRemoveBackgroundParameters(),
                };

                var result = await client.ImageRemoveBackground.ImageRemoveBackgroundAsync(
                    request: request,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return $"Background removed. Status: {result.Status}. Result URL: {result.Data?.Url}";
            },
            name: "PicsartRemoveBackground",
            description: "Removes the background from an image given its URL using Picsart AI. Returns the URL of the processed image.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that upscales/enhances an image URL
    /// using Picsart's AI-powered upscaling service.
    /// </summary>
    /// <param name="client">The Picsart client.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsUpscaleTool(
        this PicsartClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string imageUrl, int? upscaleFactor, CancellationToken cancellationToken) =>
            {
                var request = new AllOf<ImageImageParameters, ImageUpscaleParameters>
                {
                    Value1 = new ImageImageParameters
                    {
                        ImageUrl = imageUrl,
                    },
                    Value2 = new ImageUpscaleParameters
                    {
                        UpscaleFactor = upscaleFactor ?? 2,
                    },
                };

                var result = await client.ImagePhotoEnhancement.ImageUpscaleAsync(
                    request: request,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return $"Image upscaled. Status: {result.Status}. Result URL: {result.Data?.Url}";
            },
            name: "PicsartUpscale",
            description: "Upscales an image to increase its resolution using Picsart AI. Accepts an image URL and an optional upscale factor (2, 4, 6, or 8; default 2). Returns the URL of the upscaled image.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that generates an image from a text prompt
    /// using Picsart's GenAI text-to-image service.
    /// </summary>
    /// <param name="client">The Picsart client.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsTextToImageTool(
        this PicsartClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string prompt, int? width, int? height, CancellationToken cancellationToken) =>
            {
                var request = new AllOf<GenAIText2ImageParameters, GenAIText2ImageModels>
                {
                    Value1 = new GenAIText2ImageParameters
                    {
                        Prompt = prompt,
                        Width = width ?? 1024,
                        Height = height ?? 1024,
                        Count = 1,
                    },
                    Value2 = new GenAIText2ImageModels(),
                };

                var result = await client.GenAIText2Image.GenaiText2imageAsync(
                    request: request,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return $"Image generation started. Status: {result.Status}. Inference ID: {result.InferenceId}. Use the inference ID to check the result.";
            },
            name: "PicsartTextToImage",
            description: "Generates an image from a text prompt using Picsart GenAI. Accepts a prompt and optional width/height (default 1024x1024). Returns an inference ID to poll for the result (async generation).");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists available image effects,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Picsart client.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsListEffectsTool(
        this PicsartClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var result = await client.ImageEffects.ImageListEffectNamesAsync(
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                var effectNames = result.Data?
                    .Where(e => e.Name != null)
                    .Select(e => e.Name!) ?? [];

                return $"Available effects: {string.Join(", ", effectNames)}";
            },
            name: "PicsartListEffects",
            description: "Lists all available image effects supported by Picsart. Returns effect names that can be used with the image effects API.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that checks the credits balance
    /// for the Picsart API account.
    /// </summary>
    /// <param name="client">The Picsart client.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsGetBalanceTool(
        this PicsartClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var result = await client.ImageUtilities.ImageCreditsBalanceAsync(
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return $"Credits balance: {result.Credits}";
            },
            name: "PicsartGetBalance",
            description: "Checks the remaining credits balance for the Picsart API account.");
    }
}
