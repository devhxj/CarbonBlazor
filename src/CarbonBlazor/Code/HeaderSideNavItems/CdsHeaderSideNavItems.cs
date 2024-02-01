using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsHeaderSideNavItems : BaseComponent
{
    /// <summary>
    /// Optionally specify if container will have a bottom divider to differentiate
    /// between original sidenav items and header menu items. False by default.
    /// </summary>
    [Parameter]
    public bool HasDivider { get; set; }

    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-header-side-nav-items")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttribute(5, "has-divider", HasDivider)
            .SetAttributeNotNull(6, "styles", Styles)
            .SetAttributes(7, AdditionalAttributes)
            .SetContent(8, ChildContent)
            .CloseElement();
    }
}

