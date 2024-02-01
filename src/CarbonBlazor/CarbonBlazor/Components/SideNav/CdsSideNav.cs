using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsSideNav : BaseComponent
{
    /// <summary>
    /// Collapse mode of the side nav.
    /// <para><b>DefaultValue : "responsive"</b></para>
    /// </summary>
    [Parameter]
    public SIDE_NAV_COLLAPSE_MODE CollapseMode { get; set; } = SIDE_NAV_COLLAPSE_MODE.RESPONSIVE;

    /// <summary>
    /// `true` to expand the side nav.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Expanded { get; set; }

    /// <summary>
    /// If `true` will style the side nav to sit below the header
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? IsNotChildOfHeader { get; set; }

    /// <summary>
    /// Specify if the side-nav will be persistent above the lg breakpoint
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? IsNotPersistent { get; set; }

    /// <summary>
    /// <para><b>DefaultValue : "styles"</b></para>
    /// </summary>
    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-side-nav")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "tabindex", TabIndex)
            .SetAttributeNotNull(4, "role", Role)
            .SetAttributeNotNull(5, "aria-label", AriaLabel)
            .SetAttribute(6, "collapse-mode", CollapseMode)
            .SetAttributeNotNull(7, "expanded", Expanded)
            .SetAttributeNotNull(8, "is-not-child-of-header", IsNotChildOfHeader)
            .SetAttributeNotNull(9, "is-not-persistent", IsNotPersistent)
            .SetAttributeNotNull(10, "styles", Styles)
            .SetAttributes(11, AdditionalAttributes)
            .SetContent(12, ChildContent)
            .CloseElement();
    }
}

