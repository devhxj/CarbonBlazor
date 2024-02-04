using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsSideNav : CdsComponentBase
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
            .SetAttributes(1, AdditionalAttributes)
            .SetAttribute(2, "id", Id)
            .SetAttributeNotNull(3, "title", Title)
            .SetAttributeNotNull(4, "tabindex", TabIndex)
            .SetAttributeNotNull(5, "role", Role)
            .SetAttributeNotNull(6, "aria-label", AriaLabel)
            .SetAttribute(7, "collapse-mode", CollapseMode)
            .SetAttributeNotNull(8, "expanded", Expanded)
            .SetAttributeNotNull(9, "is-not-child-of-header", IsNotChildOfHeader)
            .SetAttributeNotNull(10, "is-not-persistent", IsNotPersistent)
            .SetAttributeNotNull(11, "styles", Styles)
            .SetReferenceCapture(12, CaptureReference)
            .SetContent(13, ChildContent)
            .CloseElement();
    }
}

