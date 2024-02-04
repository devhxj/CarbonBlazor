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

public class CdsSideNavMenu : CdsComponentBase<SideNavMenuContext>
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
            .SetAttributes(1, AdditionalAttributes)
            .SetAttribute(2, "id", Id)
            .SetAttributeNotNull(3, "title", Title)
            .SetAttributeNotNull(4, "tabindex", TabIndex)
            .SetAttributeNotNull(5, "role", Role)
            .SetAttributeNotNull(6, "aria-label", AriaLabel)
            .SetAttributeNotNull(7, "active", Active)
            .SetAttributeNotNull(8, "expanded", Expanded)
            .SetAttributeNotNull(9, "large", Large)
            .SetAttributeNotNull(10, "force-collapsed", ForceCollapsed)
            .SetAttributeNotNull(11, "attribitemhasicon", AttribItemHasIcon)
            .SetAttributeNotNull(12, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(13, "styles", Styles)
            .SetReferenceCapture(14, CaptureReference)
            .SetContent(15, ChildContent, new())
            .CloseElement();
    }
}

