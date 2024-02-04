using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsHeaderMenuButton : CdsComponentBase
{
    /// <summary>
    /// `true` if the button should represent its active state.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Active { get; set; }

    /// <summary>
    /// The `aria-label` attribute for the button in its active state.
    /// <para><b>DefaultValue : "Close navigation menu"</b></para>
    /// </summary>
    [Parameter]
    public string? ButtonLabelActive { get; set; }

    /// <summary>
    /// The `aria-label` attribute for the button in its inactive state.
    /// <para><b>DefaultValue : "Open navigation menu"</b></para>
    /// </summary>
    [Parameter]
    public string? ButtonLabelInactive { get; set; }

    /// <summary>
    /// Collapse mode of the side nav.
    /// <para><b>DefaultValue : "responsive"</b></para>
    /// </summary>
    [Parameter]
    public SIDE_NAV_COLLAPSE_MODE CollapseMode { get; set; } = SIDE_NAV_COLLAPSE_MODE.RESPONSIVE;

    /// <summary>
    /// `true` if the button should be disabled.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Disabled { get; set; }

    /// <summary>
    /// If `true` will style the side nav to sit below the header
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? IsNotChildOfHeader { get; set; }

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
            .OpenElementAnd(0, "cds-header-menu-button")
            .SetAttributes(1, AdditionalAttributes)
            .SetAttribute(2, "id", Id)
            .SetAttributeNotNull(3, "title", Title)
            .SetAttributeNotNull(4, "tabindex", TabIndex)
            .SetAttributeNotNull(5, "role", Role)
            .SetAttributeNotNull(6, "aria-label", AriaLabel)
            .SetAttributeNotNull(7, "active", Active)
            .SetAttributeNotNull(8, "button-label-active", ButtonLabelActive)
            .SetAttributeNotNull(9, "button-label-inactive", ButtonLabelInactive)
            .SetAttribute(10, "collapse-mode", CollapseMode)
            .SetAttributeNotNull(11, "disabled", Disabled)
            .SetAttributeNotNull(12, "is-not-child-of-header", IsNotChildOfHeader)
            .SetAttributeNotNull(13, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(14, "styles", Styles)
            .SetReferenceCapture(15, CaptureReference)
            .SetContent(16, ChildContent)
            .CloseElement();
    }
}

