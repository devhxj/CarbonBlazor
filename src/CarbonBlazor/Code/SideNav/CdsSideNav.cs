using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsSideNav : BaseComponent
{
    /// <summary>
    /// Collapse mode of the side nav.
    /// </summary>
    [Parameter]
    public SIDE_NAV_COLLAPSE_MODE CollapseMode { get; set; } = SIDE_NAV_COLLAPSE_MODE.RESPONSIVE;

    /// <summary>
    /// `true` to expand the side nav.
    /// </summary>
    [Parameter]
    public bool Expanded { get; set; }

    /// <summary>
    /// If `true` will style the side nav to sit below the header
    /// </summary>
    [Parameter]
    public bool IsNotChildOfHeader { get; set; }

    /// <summary>
    /// Specify if the side-nav will be persistent above the lg breakpoint
    /// </summary>
    [Parameter]
    public bool IsNotPersistent { get; set; }

    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-side-nav")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttribute(5, "collapse-mode", CollapseMode)
            .SetAttribute(6, "expanded", Expanded)
            .SetAttribute(7, "is-not-child-of-header", IsNotChildOfHeader)
            .SetAttribute(8, "is-not-persistent", IsNotPersistent)
            .SetAttributeNotNull(9, "styles", Styles)
            .SetAttributes(10, AdditionalAttributes)
            .SetContent(11, ChildContent)
            .CloseElement();
    }
}

