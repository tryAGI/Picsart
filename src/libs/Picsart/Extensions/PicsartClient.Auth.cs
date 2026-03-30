#nullable enable

namespace Picsart;

public partial class PicsartClient
{
#pragma warning disable CA1822 // Mark members as static
    partial void PrepareRequest(
        global::System.Net.Http.HttpClient client,
        global::System.Net.Http.HttpRequestMessage request)
    {
        // Route requests to the correct Picsart sub-API host based on path prefix.
        // The merged spec uses:
        //   /image/* -> https://api.picsart.io/tools/1.0/*
        //   /video/* -> https://video-api.picsart.io/v1/*
        //   /genai/* -> https://genai-api.picsart.io/v1/*
        //   /vd/*    -> https://vd-api.picsart.io/v1/*
        if (request.RequestUri is { } uri)
        {
            var path = uri.PathAndQuery;

            if (path.StartsWith("/image/", global::System.StringComparison.OrdinalIgnoreCase))
            {
                var newPath = "/tools/1.0" + path["/image".Length..];
                request.RequestUri = new global::System.Uri(
                    $"https://api.picsart.io{newPath}");
            }
            else if (path.StartsWith("/video/", global::System.StringComparison.OrdinalIgnoreCase))
            {
                var newPath = "/v1" + path["/video".Length..];
                request.RequestUri = new global::System.Uri(
                    $"https://video-api.picsart.io{newPath}");
            }
            else if (path.StartsWith("/genai/", global::System.StringComparison.OrdinalIgnoreCase))
            {
                var newPath = "/v1" + path["/genai".Length..];
                request.RequestUri = new global::System.Uri(
                    $"https://genai-api.picsart.io{newPath}");
            }
            else if (path.StartsWith("/vd/", global::System.StringComparison.OrdinalIgnoreCase))
            {
                var newPath = "/v1" + path["/vd".Length..];
                request.RequestUri = new global::System.Uri(
                    $"https://vd-api.picsart.io{newPath}");
            }
        }
    }
#pragma warning restore CA1822 // Mark members as static
}
