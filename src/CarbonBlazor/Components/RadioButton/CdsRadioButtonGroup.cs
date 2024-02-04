using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsRadioButtonGroup : CdsComponentBase
{
    /// <summary>
    /// The `value` attribute for the `&lt;input&gt;` for selection.
    /// </summary>
    [Parameter]
    public string? DefaultSelected { get; set; }

    /// <summary>
    /// `true` if the radio button group should be disabled.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Disabled { get; set; }

    /// <summary>
    /// The label position.
    /// <para><b>DefaultValue : "right"</b></para>
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
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Warn { get; set; }

    /// <summary>
    /// Provide the text that is displayed when the control is in warning state
    /// </summary>
    [Parameter]
    public string? WarnText { get; set; }

    /// <summary>
    /// Specify if the currently value is invalid.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Invalid { get; set; }

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
    /// <para><b>DefaultValue : "horizontal"</b></para>
    /// </summary>
    [Parameter]
    public RADIO_BUTTON_ORIENTATION Orientation { get; set; } = RADIO_BUTTON_ORIENTATION.HORIZONTAL;

    /// <summary>
    /// Controls the readonly state of the radio button group.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? ReadOnly { get; set; }

    /// <summary>
    /// The `value` attribute for the `&lt;input&gt;` for selection.
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
            .OpenElementAnd(0, "cds-radio-button-group")
            .SetAttributes(1, AdditionalAttributes)
            .SetAttribute(2, "id", Id)
            .SetAttributeNotNull(3, "title", Title)
            .SetAttributeNotNull(4, "tabindex", TabIndex)
            .SetAttributeNotNull(5, "role", Role)
            .SetAttributeNotNull(6, "aria-label", AriaLabel)
            .SetAttributeNotNull(7, "defaultSelected", DefaultSelected)
            .SetAttributeNotNull(8, "disabled", Disabled)
            .SetAttribute(9, "label-position", LabelPosition)
            .SetAttributeNotNull(10, "legend-text", LegendText)
            .SetAttributeNotNull(11, "helper-text", HelperText)
            .SetAttributeNotNull(12, "warn", Warn)
            .SetAttributeNotNull(13, "warn-text", WarnText)
            .SetAttributeNotNull(14, "invalid", Invalid)
            .SetAttributeNotNull(15, "invalid-text", InvalidText)
            .SetAttributeNotNull(16, "name", Name)
            .SetAttribute(17, "orientation", Orientation)
            .SetAttributeNotNull(18, "readOnly", ReadOnly)
            .SetAttributeNotNull(19, "value", Value)
            .SetAttributeNotNull(20, "styles", Styles)
            .SetReferenceCapture(21, CaptureReference)
            .SetContent(22, ChildContent)
            .CloseElement();
    }
}

