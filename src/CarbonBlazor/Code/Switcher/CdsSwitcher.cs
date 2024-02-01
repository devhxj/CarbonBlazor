using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsSwitcher : BaseComponent
{
    /// <summary>
    /// Prop for accessibility labelled by on the underlying menu
    /// </summary>
    [Parameter]
    public string? AriaLabelledBy { get; set; }

    [Parameter]
    public ShadowRootOptions ShadowRootOptions { get; set; } = new ShadowRootOptions() {DelegatesFocus = true};

    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-switcher")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttributeNotNull(5, "aria-labelledby", AriaLabelledBy)
            .SetAttributeNotNull(6, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(7, "styles", Styles)
            .SetAttributes(8, AdditionalAttributes)
            .SetContent(9, ChildContent)
            .CloseElement();
    }
}

