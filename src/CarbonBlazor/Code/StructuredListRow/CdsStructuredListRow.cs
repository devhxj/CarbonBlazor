using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsStructuredListRow : BaseComponent
{
    /// <summary>
    /// `true` if this structured list row should be selectable and selected.
    /// </summary>
    [Parameter]
    public bool Selected { get; set; }

    /// <summary>
    /// The `name` attribute for the `&lt;input&gt;` for selection.
    /// If present, this structured list row will be a selectable one.
    /// </summary>
    [Parameter]
    public string? SelectionName { get; set; }

    /// <summary>
    /// The `value` attribute for the `&lt;input&gt;` for selection.
    /// </summary>
    [Parameter]
    public string? SelectionValue { get; set; }

    /// <summary>
    /// The content to put into the `&lt;title&gt;` attribute of the selection icon.
    /// </summary>
    [Parameter]
    public string? SelectionIconTitle { get; set; }

    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-structured-list-row")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttribute(5, "selected", Selected)
            .SetAttribute(6, "selection-name", SelectionName)
            .SetAttribute(7, "selection-value", SelectionValue)
            .SetAttribute(8, "selection-icon-title", SelectionIconTitle)
            .SetAttributeNotNull(9, "styles", Styles)
            .SetAttributes(10, AdditionalAttributes)
            .SetContent(11, ChildContent)
            .CloseElement();
    }
}

