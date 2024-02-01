using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsSideNavLink : BaseComponent
{
    /// <summary>
    /// `true` if the menu item should be active.
    /// </summary>
    [Parameter]
    public bool Active { get; set; }

    /// <summary>
    /// Link `href`.
    /// </summary>
    [Parameter]
    public string? Href { get; set; }

    /// <summary>
    /// The link type.
    /// </summary>
    [Parameter]
    public string? Rel { get; set; }

    /// <summary>
    /// The link target.
    /// </summary>
    [Parameter]
    public string? Target { get; set; }

    /// <summary>
    /// Specify if this is a large variation of the side nav link
    /// </summary>
    [Parameter]
    public bool Large { get; set; }

    [Parameter]
    public ShadowRootOptions ShadowRootOptions { get; set; } = new ShadowRootOptions() {DelegatesFocus = true};

    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-side-nav-link")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttribute(5, "active", Active)
            .SetAttribute(6, "href", Href)
            .SetAttributeNotNull(7, "rel", Rel)
            .SetAttributeNotNull(8, "target", Target)
            .SetAttribute(9, "large", Large)
            .SetAttributeNotNull(10, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(11, "styles", Styles)
            .SetAttributes(12, AdditionalAttributes)
            .SetContent(13, ChildContent)
            .CloseElement();
    }
}

