using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsLink : BaseComponent
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
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "tabindex", TabIndex)
            .SetAttributeNotNull(4, "role", Role)
            .SetAttributeNotNull(5, "aria-label", AriaLabel)
            .SetAttributeNotNull(6, "disabled", Disabled)
            .SetAttributeNotNull(7, "download", Download)
            .SetAttributeNotNull(8, "href", Href)
            .SetAttributeNotNull(9, "hreflang", Hreflang)
            .SetAttributeNotNull(10, "inline", Inline)
            .SetAttributeNotNull(11, "link-role", LinkRole)
            .SetAttributeNotNull(12, "ping", Ping)
            .SetAttributeNotNull(13, "rel", Rel)
            .SetAttributeNotNull(14, "size", Size)
            .SetAttributeNotNull(15, "target", Target)
            .SetAttributeNotNull(16, "type", Type)
            .SetAttributeNotNull(17, "visited", Visited)
            .SetAttributeNotNull(18, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(19, "styles", Styles)
            .SetAttributes(20, AdditionalAttributes)
            .SetContent(21, ChildContent)
            .CloseElement();
    }
}

