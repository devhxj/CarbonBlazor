using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsHeaderMenuButton : BaseComponent
{
    /// <summary>
    /// `true` if the button should represent its active state.
    /// </summary>
    [Parameter]
    public bool Active { get; set; }

    /// <summary>
    /// The `aria-label` attribute for the button in its active state.
    /// </summary>
    [Parameter]
    public string ButtonLabelActive { get; set; } = "Close navigation menu";

    /// <summary>
    /// The `aria-label` attribute for the button in its inactive state.
    /// </summary>
    [Parameter]
    public string ButtonLabelInactive { get; set; } = "Open navigation menu";

    /// <summary>
    /// Collapse mode of the side nav.
    /// </summary>
    [Parameter]
    public SIDE_NAV_COLLAPSE_MODE CollapseMode { get; set; } = SIDE_NAV_COLLAPSE_MODE.RESPONSIVE;

    /// <summary>
    /// `true` if the button should be disabled.
    /// </summary>
    [Parameter]
    public bool Disabled { get; set; }

    /// <summary>
    /// If `true` will style the side nav to sit below the header
    /// </summary>
    [Parameter]
    public bool IsNotChildOfHeader { get; set; }

    [Parameter]
    public ShadowRootOptions ShadowRootOptions { get; set; } = new ShadowRootOptions() {DelegatesFocus = true};

    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-header-menu-button")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttribute(5, "active", Active)
            .SetAttribute(6, "button-label-active", ButtonLabelActive)
            .SetAttribute(7, "button-label-inactive", ButtonLabelInactive)
            .SetAttribute(8, "collapse-mode", CollapseMode)
            .SetAttribute(9, "disabled", Disabled)
            .SetAttribute(10, "is-not-child-of-header", IsNotChildOfHeader)
            .SetAttributeNotNull(11, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(12, "styles", Styles)
            .SetAttributes(13, AdditionalAttributes)
            .SetContent(14, ChildContent)
            .CloseElement();
    }
}

