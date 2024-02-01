using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsRadioButtonGroup : BaseComponent
{
    /// <summary>
    /// The `value` attribute for the `&lt;input&gt;` for selection.
    /// </summary>
    [Parameter]
    public string? DefaultSelected { get; set; }

    /// <summary>
    /// `true` if the radio button group should be disabled.
    /// </summary>
    [Parameter]
    public bool Disabled { get; set; }

    /// <summary>
    /// The label position.
    /// </summary>
    [Parameter]
    public RADIO_BUTTON_LABEL_POSITION LabelPosition { get; set; } = RADIO_BUTTON_LABEL_POSITION.RIGHT;

    /// <summary>
    /// The label position.
    /// </summary>
    [Parameter]
    public string? LegendText { get; set; }

    /// <summary>
    /// The helper text.
    /// </summary>
    [Parameter]
    public string? HelperText { get; set; }

    /// <summary>
    /// Specify whether the control is currently in warning state
    /// </summary>
    [Parameter]
    public bool Warn { get; set; }

    /// <summary>
    /// Provide the text that is displayed when the control is in warning state
    /// </summary>
    [Parameter]
    public string? WarnText { get; set; }

    /// <summary>
    /// Specify if the currently value is invalid.
    /// </summary>
    [Parameter]
    public bool Invalid { get; set; }

    /// <summary>
    /// Message which is displayed if the value is invalid.
    /// </summary>
    [Parameter]
    public string? InvalidText { get; set; }

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
    /// Controls the readonly state of the radio button group.
    /// </summary>
    [Parameter]
    public bool ReadOnly { get; set; }

    /// <summary>
    /// The `value` attribute for the `&lt;input&gt;` for selection.
    /// </summary>
    [Parameter]
    public string? Value { get; set; }

    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-radio-button-group")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttributeNotNull(5, "defaultSelected", DefaultSelected)
            .SetAttribute(6, "disabled", Disabled)
            .SetAttribute(7, "label-position", LabelPosition)
            .SetAttribute(8, "legend-text", LegendText)
            .SetAttributeNotNull(9, "helper-text", HelperText)
            .SetAttribute(10, "warn", Warn)
            .SetAttribute(11, "warn-text", WarnText)
            .SetAttribute(12, "invalid", Invalid)
            .SetAttribute(13, "invalid-text", InvalidText)
            .SetAttributeNotNull(14, "name", Name)
            .SetAttribute(15, "orientation", Orientation)
            .SetAttribute(16, "readOnly", ReadOnly)
            .SetAttributeNotNull(17, "value", Value)
            .SetAttributeNotNull(18, "styles", Styles)
            .SetAttributes(19, AdditionalAttributes)
            .SetContent(20, ChildContent)
            .CloseElement();
    }
}

