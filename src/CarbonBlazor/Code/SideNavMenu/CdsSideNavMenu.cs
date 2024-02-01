using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsSideNavMenu : BaseComponent
{
    /// <summary>
    /// `true` if the menu has active menu item.
    /// </summary>
    [Parameter]
    public bool Active { get; set; }

    /// <summary>
    /// `true` if the menu should be open.
    /// </summary>
    [Parameter]
    public bool Expanded { get; set; }

    /// <summary>
    /// Specify if this is a large variation of the side nav menu
    /// </summary>
    [Parameter]
    public bool Large { get; set; }

    /// <summary>
    /// `true` if the menu should be forced collapsed upon side nav's expanded state.
    /// </summary>
    [Parameter]
    public bool ForceCollapsed { get; set; }

    /// <summary>
    /// The attribute name of the menu items, that is set if this menu has an icon.
    /// </summary>
    [Parameter]
    public string AttribItemHasIcon { get; set; } = "parent-has-icon";

    [Parameter]
    public ShadowRootOptions ShadowRootOptions { get; set; } = new ShadowRootOptions() {DelegatesFocus = true};

    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-side-nav-menu")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttribute(5, "active", Active)
            .SetAttribute(6, "expanded", Expanded)
            .SetAttribute(7, "large", Large)
            .SetAttribute(8, "force-collapsed", ForceCollapsed)
            .SetAttribute(9, "", AttribItemHasIcon)
            .SetAttributeNotNull(10, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(11, "styles", Styles)
            .SetAttributes(12, AdditionalAttributes)
            .SetContent(13, ChildContent)
            .CloseElement();
    }
}

