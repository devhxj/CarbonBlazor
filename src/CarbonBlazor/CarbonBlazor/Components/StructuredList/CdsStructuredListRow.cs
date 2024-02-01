using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsStructuredListRow : BaseComponent
{
    /// <summary>
    /// `true` if this structured list row should be selectable and selected.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Selected { get; set; }

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

    /// <summary>
    /// <para><b>DefaultValue : "styles"</b></para>
    /// </summary>
    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-structured-list-row")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "tabindex", TabIndex)
            .SetAttributeNotNull(4, "role", Role)
            .SetAttributeNotNull(5, "aria-label", AriaLabel)
            .SetAttributeNotNull(6, "selected", Selected)
            .SetAttributeNotNull(7, "selection-name", SelectionName)
            .SetAttributeNotNull(8, "selection-value", SelectionValue)
            .SetAttributeNotNull(9, "selection-icon-title", SelectionIconTitle)
            .SetAttributeNotNull(10, "styles", Styles)
            .SetAttributes(11, AdditionalAttributes)
            .SetContent(12, ChildContent)
            .CloseElement();
    }
}

