using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsMultiSelectItem : CdsComponentBase
{
    /// <summary>
    /// The property to hide when item is filtered from input
    /// </summary>
    [Parameter]
    public string? Filtered { get; set; }

    /// <summary>
    /// The `name` attribute for the `&lt;input&gt;` for selection.
    /// </summary>
    [Parameter]
    public string? SelectionName { get; set; }

    /// <summary>
    /// `true` if this dropdown item should be disabled.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Disabled { get; set; }

    /// <summary>
    /// Dropdown size.
    /// <para><b>DefaultValue : "md"</b></para>
    /// </summary>
    [Parameter]
    public DROPDOWN_SIZE Size { get; set; } = DROPDOWN_SIZE.MD;

    /// <summary>
    /// The `value` attribute that is set to the parent `&lt;cds-dropdown&gt;` when this dropdown item is selected.
    /// </summary>
    [Parameter]
    public string? Value { get; set; }

    /// <summary>
    /// <para><b>DefaultValue : "styles"</b></para>
    /// </summary>
    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-multi-select-item")
            .SetAttributes(1, AdditionalAttributes)
            .SetAttribute(2, "id", Id)
            .SetAttributeNotNull(3, "title", Title)
            .SetAttributeNotNull(4, "tabindex", TabIndex)
            .SetAttributeNotNull(5, "role", Role)
            .SetAttributeNotNull(6, "aria-label", AriaLabel)
            .SetAttributeNotNull(7, "filtered", Filtered)
            .SetAttributeNotNull(8, "selection-name", SelectionName)
            .SetAttributeNotNull(9, "disabled", Disabled)
            .SetAttribute(10, "size", Size)
            .SetAttributeNotNull(11, "value", Value)
            .SetAttributeNotNull(12, "styles", Styles)
            .SetReferenceCapture(13, CaptureReference)
            .SetContent(14, ChildContent)
            .CloseElement();
    }
}

