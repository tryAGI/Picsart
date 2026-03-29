# CLAUDE.md -- Picsart SDK

## Overview

Auto-generated C# SDK for [Picsart](https://picsart.io/) -- AI-powered image and video editing, background removal, enhancement, effects, GenAI image/video generation, and variable data content APIs.
Merged from 4 separate OpenAPI specs (Image Tools, Video Tools, GenAI, Variable Data).

## Build & Test

```bash
dotnet build Picsart.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Bearer token auth (converted to `X-Picsart-API-Key` header via PrepareRequest hook):

```csharp
var client = new PicsartClient(apiKey); // PICSART_API_KEY env var
```

## Key Files

- `src/libs/Picsart/openapi.yaml` -- Merged OpenAPI spec from 4 Picsart sub-APIs
- `src/libs/Picsart/generate.sh` -- Runs autosdk with `--security-scheme ApiKey:Header:X-Picsart-API-Key`
- `src/libs/Picsart/Generated/` -- **Never edit** -- auto-generated code
- `src/libs/Picsart/Extensions/PicsartClient.Auth.cs` -- PrepareRequest hook: `Bearer -> X-Picsart-API-Key` + multi-host routing
- `src/libs/Picsart/Extensions/PicsartClient.Tools.cs` -- MEAI AIFunction tools
- `src/tests/IntegrationTests/Tests.cs` -- Test helper with API key auth
- `src/tests/IntegrationTests/Examples/` -- Example tests (also generate docs)
- `specs/` -- Original individual OpenAPI specs + merge script

## Multi-Host Routing

Picsart has 4 separate API hosts. The merged spec uses path prefixes, and the `PrepareRequest` hook routes requests:

| Path Prefix | Target Host | Description |
|-------------|-------------|-------------|
| `/image/*` | `https://api.picsart.io/tools/1.0/*` | Image Tools API |
| `/video/*` | `https://video-api.picsart.io/v1/*` | Video Tools API |
| `/genai/*` | `https://genai-api.picsart.io/v1/*` | GenAI API |
| `/vd/*` | `https://vd-api.picsart.io/v1/*` | Variable Data API |

## Spec Notes

- OpenAPI specs merged from 4 sources using `specs/merge_specs.py`
- Spec fixes applied: integer `enum` on `upscale_factor` removed (caused `int.x2` errors), `VideoUploadParameters.file` made optional
- Auth: `--security-scheme ApiKey:Header:X-Picsart-API-Key` + PrepareRequest hook for Bearer -> X-Picsart-API-Key conversion

## MEAI Integration

AIFunction tools for use with any `IChatClient`:

- `AsRemoveBackgroundTool()` -- Remove background from an image URL
- `AsUpscaleTool()` -- Upscale/enhance an image
- `AsTextToImageTool()` -- Generate image from text prompt (GenAI)
- `AsListEffectsTool()` -- List available image effects
- `AsGetBalanceTool()` -- Check credits balance

## Sub-Clients

The `PicsartClient` exposes organized sub-clients:

**Image Tools:**
- `ImageRemoveBackground` -- Background removal
- `ImagePhotoEnhancement` -- Upscale, ultra upscale, face enhancement
- `ImageEffects` -- Effects, masks, adjustments, blur, color/style transfer
- `ImageEditing` -- Edit, smart crop, zoom, blend
- `ImageClassification` -- Tags, describe, car classify, extract colors, segmentation
- `ImageConversion` -- Vectorizer, design import
- `ImageContentGeneration` -- Pattern generator
- `ImageSurfacemap` -- Surface mapping
- `ImageWatermark` -- Add watermark
- `ImageUtilities` -- Upload, balance

**Video Tools:**
- `VideoEdit` -- Trim, crop, concat, fit
- `VideoEffects` -- Adjust, apply effects
- `VideoRemoveBackground` -- Video background removal
- `VideoVideoEnhancement` -- FPS upscale
- `VideoMetadata` -- Metadata, thumbnails
- `VideoAudio` -- Audio adjust, extract
- `VideoTranscriptions` -- Audio transcription
- `VideoAds` -- CTV encoding
- `VideoWatermark` -- Add watermark
- `VideoUtilities` -- Upload, balance, get results

**GenAI:**
- `GenAIText2Image` -- Text-to-image, sticker, logo
- `GenAIText2VideoImage2Video` -- Text/image-to-video
- `GenAIText2Text` -- Chat completions
- `GenAIText2Audio` -- Text-to-speech, text-to-sound
- `GenAIInpaintingImage2Image` -- Inpaint, outpaint, remove object, replace background, expand, bleed
- `GenAIUtilities` -- Balance

**Variable Data:**
- `VdReplay` -- Export replay
- `VdVariableDataContent` -- Describe, export variable data content
- `VdUtilities` -- Balance
