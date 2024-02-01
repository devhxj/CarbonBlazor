using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsSwitcherItem : BaseComponent
{
    /// <summary>
    /// Props for accessibility labelled by
    /// </summary>
    [Parameter]
    public string? AriaLabelledBy { get; set; }

    /// <summary>
    /// Link `href`.
    /// </summary>
    [Parameter]
    public string? Href { get; set; }

    /// <summary>
    /// Specify if this is a large variation of the side nav link
    /// </summary>
    [Parameter]
    public bool Selected { get; set; }

    /// <summary>
    /// Specify if this is a large variation of the side nav link
    /// </summary>
    [Parameter]
    public int TabIndex { get; set; } = 0;

    [Parameter]
    public ShadowRootOptions ShadowRootOptions { get; set; } = new ShadowRootOptions() {DelegatesFocus = true};

    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-switcher-item")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttributeNotNull(5, "aria-labelledby", AriaLabelledBy)
            .SetAttribute(6, "href", Href)
            .SetAttribute(7, "selected", Selected)
            .SetAttribute(8, "tab-index", TabIndex)
            .SetAttributeNotNull(9, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(10, "styles", Styles)
            .SetAttributes(11, AdditionalAttributes)
            .SetContent(12, ChildContent)
            .CloseElement();
    }
}

