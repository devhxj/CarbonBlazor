using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsSideNavMenuItem : BaseComponent
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

    [Parameter]
    public ShadowRootOptions ShadowRootOptions { get; set; } = new ShadowRootOptions() {DelegatesFocus = true};

    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-side-nav-menu-item")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttribute(5, "active", Active)
            .SetAttribute(6, "href", Href)
            .SetAttributeNotNull(7, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(8, "styles", Styles)
            .SetAttributes(9, AdditionalAttributes)
            .SetContent(10, ChildContent)
            .CloseElement();
    }
}

