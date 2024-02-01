using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsContentSwitcher : BaseComponent
{
    /// <summary>
    /// The value of the selected item.
    /// </summary>
    [Parameter]
    public string? Value { get; set; }

    /// <summary>
    /// Content switcher size.
    /// </summary>
    [Parameter]
    public CONTENT_SWITCHER_SIZE? Size { get; set; }

    /// <summary>
    /// Icon only.
    /// </summary>
    [Parameter]
    public bool IconOnly { get; set; }

    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-content-switcher")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttribute(5, "value", Value)
            .SetAttribute(6, "size", Size)
            .SetAttribute(7, "icon", IconOnly)
            .SetAttributeNotNull(8, "styles", Styles)
            .SetAttributes(9, AdditionalAttributes)
            .SetContent(10, ChildContent)
            .CloseElement();
    }
}

