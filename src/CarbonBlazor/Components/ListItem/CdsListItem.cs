using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;

public class ListItemContext
{
    /// <summary>
    /// The nested child list.
    /// </summary>
    public string NestedSlot = "nested";
}

public class CdsListItem : CdsComponentBase<ListItemContext>
{
    /// <summary>
    /// `true` if this list item is a child of a nested list.
    /// `&lt;cds-ordered-list&gt;` or `&lt;cds-unordered-list&gt;` automatically sets this property.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Nested { get; set; }

    /// <summary>
    /// <para><b>DefaultValue : "styles"</b></para>
    /// </summary>
    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-list-item")
            .SetAttributes(1, AdditionalAttributes)
            .SetAttribute(2, "id", Id)
            .SetAttributeNotNull(3, "title", Title)
            .SetAttributeNotNull(4, "tabindex", TabIndex)
            .SetAttributeNotNull(5, "role", Role)
            .SetAttributeNotNull(6, "aria-label", AriaLabel)
            .SetAttributeNotNull(7, "nested", Nested)
            .SetAttributeNotNull(8, "styles", Styles)
            .SetReferenceCapture(9, CaptureReference)
            .SetContent(10, ChildContent, new())
            .CloseElement();
    }
}

