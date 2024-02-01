using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsRadioButton : BaseComponent
{
    /// <summary>
    /// `true` if this radio button should be checked.
    /// </summary>
    [Parameter]
    public bool Checked { get; set; }

    /// <summary>
    /// `true` if the radio button is used in a data table
    /// </summary>
    [Parameter]
    public bool DataTable { get; set; }

    /// <summary>
    /// `true` if the radio button item should be disabled.
    /// </summary>
    [Parameter]
    public bool DisabledItem { get; set; }

    /// <summary>
    /// `true` if the radio button group should be disabled.
    /// </summary>
    [Parameter]
    public bool Disabled { get; set; }

    /// <summary>
    /// `true` if the label should be hidden.
    /// </summary>
    [Parameter]
    public bool HideLabel { get; set; }

    /// <summary>
    /// Specify if the currently value is invalid.
    /// </summary>
    [Parameter]
    public bool Invalid { get; set; }

    /// <summary>
    /// The label position.
    /// </summary>
    [Parameter]
    public RADIO_BUTTON_LABEL_POSITION LabelPosition { get; set; } = RADIO_BUTTON_LABEL_POSITION.RIGHT;

    /// <summary>
    /// The label text.
    /// </summary>
    [Parameter]
    public string? LabelText { get; set; }

    /// <summary>
    /// The `name` attribute for the `&lt;input&gt;` for selection.
    /// </summary>
    [Parameter]
    public string? Name { get; set; }

    /// <summary>
    /// The orientation to lay out radio buttons.
    /// </summary>
    [Parameter]
    public RADIO_BUTTON_ORIENTATION Orientation { get; set; } = RADIO_BUTTON_ORIENTATION.HORIZONTAL;

    /// <summary>
    /// `true` if the radio button group should be disabled.
    /// </summary>
    [Parameter]
    public bool ReadOnly { get; set; }

    /// <summary>
    /// The `value` attribute for the `&lt;input&gt;` for selection.
    /// </summary>
    [Parameter]
    public string? Value { get; set; }

    [Parameter]
    public ShadowRootOptions ShadowRootOptions { get; set; } = new ShadowRootOptions() {DelegatesFocus = true};

    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-radio-button")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttribute(5, "checked", Checked)
            .SetAttribute(6, "data-table", DataTable)
            .SetAttribute(7, "disabledItem", DisabledItem)
            .SetAttribute(8, "disabled", Disabled)
            .SetAttribute(9, "hide-label", HideLabel)
            .SetAttribute(10, "invalid", Invalid)
            .SetAttribute(11, "label-position", LabelPosition)
            .SetAttribute(12, "label-text", LabelText)
            .SetAttributeNotNull(13, "name", Name)
            .SetAttribute(14, "orientation", Orientation)
            .SetAttribute(15, "readOnly", ReadOnly)
            .SetAttributeNotNull(16, "value", Value)
            .SetAttributeNotNull(17, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(18, "styles", Styles)
            .SetAttributes(19, AdditionalAttributes)
            .SetContent(20, ChildContent)
            .CloseElement();
    }
}

