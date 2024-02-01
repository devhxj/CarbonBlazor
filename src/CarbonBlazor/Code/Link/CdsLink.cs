using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsLink : BaseComponent
{
    /// <summary>
    /// `true` if the link should be disabled.
    /// </summary>
    [Parameter]
    public bool Disabled { get; set; }

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
    /// </summary>
    [Parameter]
    public bool Inline { get; set; }

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
    /// </summary>
    [Parameter]
    public string Size { get; set; } = "REGULAR";

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
    /// </summary>
    [Parameter]
    public bool Visited { get; set; }

    [Parameter]
    public ShadowRootOptions ShadowRootOptions { get; set; } = new ShadowRootOptions() {DelegatesFocus = true};

    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-link")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttribute(5, "disabled", Disabled)
            .SetAttributeNotNull(6, "download", Download)
            .SetAttributeNotNull(7, "href", Href)
            .SetAttributeNotNull(8, "hreflang", Hreflang)
            .SetAttribute(9, "inline", Inline)
            .SetAttributeNotNull(10, "link-role", LinkRole)
            .SetAttributeNotNull(11, "ping", Ping)
            .SetAttributeNotNull(12, "rel", Rel)
            .SetAttribute(13, "size", Size)
            .SetAttributeNotNull(14, "target", Target)
            .SetAttributeNotNull(15, "type", Type)
            .SetAttribute(16, "visited", Visited)
            .SetAttributeNotNull(17, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(18, "styles", Styles)
            .SetAttributes(19, AdditionalAttributes)
            .SetContent(20, ChildContent)
            .CloseElement();
    }
}

