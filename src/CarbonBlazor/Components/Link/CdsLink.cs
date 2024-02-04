using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsLink : CdsComponentBase
{
    /// <summary>
    /// `true` if the link should be disabled.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Disabled { get; set; }

    /// <summary>
    /// The default file name.
    /// </summary>
    [Parameter]
    public string? Download { get; set; }

    /// <summary>
    /// Link `href`.
    /// </summary>
    [Parameter]
    public string? Href { get; set; }

    /// <summary>
    /// The language of what `href` points to.
    /// </summary>
    [Parameter]
    public string? Hreflang { get; set; }

    /// <summary>
    /// `true` if the link should be inline.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Inline { get; set; }

    /// <summary>
    /// The a11y role for `&lt;a&gt;`.
    /// </summary>
    [Parameter]
    public string? LinkRole { get; set; }

    /// <summary>
    /// URLs to ping.
    /// </summary>
    [Parameter]
    public string? Ping { get; set; }

    /// <summary>
    /// The link type.
    /// </summary>
    [Parameter]
    public string? Rel { get; set; }

    /// <summary>
    /// Link size.
    /// <para><b>DefaultValue : "REGULAR"</b></para>
    /// </summary>
    [Parameter]
    public string? Size { get; set; }

    /// <summary>
    /// The link target.
    /// </summary>
    [Parameter]
    public string? Target { get; set; }

    /// <summary>
    /// MIME type of the `target`.
    /// </summary>
    [Parameter]
    public string? Type { get; set; }

    /// <summary>
    /// `true` if the link has been visited.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Visited { get; set; }

    /// <summary>
    /// <para><b>DefaultValue : {"delegatesFocus":true}</b></para>
    /// </summary>
    [Parameter]
    public ShadowRootOptions? ShadowRootOptions { get; set; }

    /// <summary>
    /// <para><b>DefaultValue : "styles"</b></para>
    /// </summary>
    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-link")
            .SetAttributes(1, AdditionalAttributes)
            .SetAttribute(2, "id", Id)
            .SetAttributeNotNull(3, "title", Title)
            .SetAttributeNotNull(4, "tabindex", TabIndex)
            .SetAttributeNotNull(5, "role", Role)
            .SetAttributeNotNull(6, "aria-label", AriaLabel)
            .SetAttributeNotNull(7, "disabled", Disabled)
            .SetAttributeNotNull(8, "download", Download)
            .SetAttributeNotNull(9, "href", Href)
            .SetAttributeNotNull(10, "hreflang", Hreflang)
            .SetAttributeNotNull(11, "inline", Inline)
            .SetAttributeNotNull(12, "link-role", LinkRole)
            .SetAttributeNotNull(13, "ping", Ping)
            .SetAttributeNotNull(14, "rel", Rel)
            .SetAttributeNotNull(15, "size", Size)
            .SetAttributeNotNull(16, "target", Target)
            .SetAttributeNotNull(17, "type", Type)
            .SetAttributeNotNull(18, "visited", Visited)
            .SetAttributeNotNull(19, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(20, "styles", Styles)
            .SetReferenceCapture(21, CaptureReference)
            .SetContent(22, ChildContent)
            .CloseElement();
    }
}

