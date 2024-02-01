using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsListItem : BaseComponent
{
    /// <summary>
    /// `true` if this list item is a child of a nested list.
    /// `&lt;cds-ordered-list&gt;` or `&lt;cds-unordered-list&gt;` automatically sets this property.
    /// </summary>
    [Parameter]
    public bool Nested { get; set; }

    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-list-item")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttribute(5, "nested", Nested)
            .SetAttributeNotNull(6, "styles", Styles)
            .SetAttributes(7, AdditionalAttributes)
            .SetContent(8, ChildContent)
            .CloseElement();
    }
}

