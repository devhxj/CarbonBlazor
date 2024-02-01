using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;

public class SideNavMenuContext
{
    /// <summary>
    /// The icon.
    /// </summary>
    public string TitleIconSlot = "title-icon";
}

public class CdsSideNavMenu : BaseComponent<SideNavMenuContext>
{
    /// <summary>
    /// `true` if the menu has active menu item.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Active { get; set; }

    /// <summary>
    /// `true` if the menu should be open.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Expanded { get; set; }

    /// <summary>
    /// Specify if this is a large variation of the side nav menu
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Large { get; set; }

    /// <summary>
    /// `true` if the menu should be forced collapsed upon side nav's expanded state.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? ForceCollapsed { get; set; }

    /// <summary>
    /// The attribute name of the menu items, that is set if this menu has an icon.
    /// <para><b>DefaultValue : "parent-has-icon"</b></para>
    /// </summary>
    [Parameter]
    public string? AttribItemHasIcon { get; set; }

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
            .OpenElementAnd(0, "cds-side-nav-menu")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "tabindex", TabIndex)
            .SetAttributeNotNull(4, "role", Role)
            .SetAttributeNotNull(5, "aria-label", AriaLabel)
            .SetAttributeNotNull(6, "active", Active)
            .SetAttributeNotNull(7, "expanded", Expanded)
            .SetAttributeNotNull(8, "large", Large)
            .SetAttributeNotNull(9, "force-collapsed", ForceCollapsed)
            .SetAttributeNotNull(10, "attribitemhasicon", AttribItemHasIcon)
            .SetAttributeNotNull(11, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(12, "styles", Styles)
            .SetAttributes(13, AdditionalAttributes)
            .SetContent(14, ChildContent, new())
            .CloseElement();
    }
}

