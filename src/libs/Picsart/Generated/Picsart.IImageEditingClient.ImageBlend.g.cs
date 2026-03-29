#nullable enable

namespace Picsart
{
    public partial interface IImageEditingClient
    {
        /// <summary>
        /// Blending<br/>
        /// Whether you're adding a custom watermark, layering in a texture,  or composing multi-image layouts for eCommerce or social media,  Blend service turns simple images into sophisticated visuals with just one call.<br/>
        /// This endpoint lets you seamlessly combine a base image with another visual layer -  like an overlay, mask, or logo - while giving you full control over how the two interact.  Think of it as your virtual creative layer engine: the same power you'd expect from a professional design tool,  now embedded into your workflow or platform.<br/>
        /// No need for manual edits or complex graphic design tools.  With the blend API, your app or service can automate visually rich output that's both fast and fully customizable.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Picsart.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageBlendResponse> ImageBlendAsync(

            global::Picsart.AllOf<global::Picsart.ImageImageParameters, global::Picsart.ImageOverlayParameters> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Blending<br/>
        /// Whether you're adding a custom watermark, layering in a texture,  or composing multi-image layouts for eCommerce or social media,  Blend service turns simple images into sophisticated visuals with just one call.<br/>
        /// This endpoint lets you seamlessly combine a base image with another visual layer -  like an overlay, mask, or logo - while giving you full control over how the two interact.  Think of it as your virtual creative layer engine: the same power you'd expect from a professional design tool,  now embedded into your workflow or platform.<br/>
        /// No need for manual edits or complex graphic design tools.  With the blend API, your app or service can automate visually rich output that's both fast and fully customizable.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Picsart.ImageBlendResponse> ImageBlendAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}