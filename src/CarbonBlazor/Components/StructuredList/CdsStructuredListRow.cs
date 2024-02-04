using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsStructuredListRow : CdsComponentBase
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
            .SetAttributes(1, AdditionalAttributes)
            .SetAttribute(2, "id", Id)
            .SetAttributeNotNull(3, "title", Title)
            .SetAttributeNotNull(4, "tabindex", TabIndex)
            .SetAttributeNotNull(5, "role", Role)
            .SetAttributeNotNull(6, "aria-label", AriaLabel)
            .SetAttributeNotNull(7, "selected", Selected)
            .SetAttributeNotNull(8, "selection-name", SelectionName)
            .SetAttributeNotNull(9, "selection-value", SelectionValue)
            .SetAttributeNotNull(10, "selection-icon-title", SelectionIconTitle)
            .SetAttributeNotNull(11, "styles", Styles)
            .SetReferenceCapture(12, CaptureReference)
            .SetContent(13, ChildContent)
            .CloseElement();
    }
}

