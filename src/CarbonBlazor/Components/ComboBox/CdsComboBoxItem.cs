using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsComboBoxItem : BaseComponent
{
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
            .OpenElementAnd(0, "cds-combo-box-item")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "tabindex", TabIndex)
            .SetAttributeNotNull(4, "role", Role)
            .SetAttributeNotNull(5, "aria-label", AriaLabel)
            .SetAttributeNotNull(6, "disabled", Disabled)
            .SetAttribute(7, "size", Size)
            .SetAttributeNotNull(8, "value", Value)
            .SetAttributeNotNull(9, "styles", Styles)
            .SetAttributes(10, AdditionalAttributes)
            .SetContent(11, ChildContent)
            .CloseElement();
    }
}

