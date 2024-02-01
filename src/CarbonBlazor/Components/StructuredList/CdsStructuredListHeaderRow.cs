using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsStructuredListHeaderRow : BaseComponent
{
    /// <summary>
    /// The `name` attribute for the `&lt;input&gt;` for selection.
    /// If present, this structured list header row will show its selectable version of the UI.
    /// </summary>
    [Parameter]
    public string? SelectionName { get; set; }

    /// <summary>
    /// <para><b>DefaultValue : "styles"</b></para>
    /// </summary>
    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-structured-list-header-row")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "tabindex", TabIndex)
            .SetAttributeNotNull(4, "role", Role)
            .SetAttributeNotNull(5, "aria-label", AriaLabel)
            .SetAttributeNotNull(6, "selection-name", SelectionName)
            .SetAttributeNotNull(7, "styles", Styles)
            .SetAttributes(8, AdditionalAttributes)
            .SetContent(9, ChildContent)
            .CloseElement();
    }
}

