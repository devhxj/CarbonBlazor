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
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "tabindex", TabIndex)
            .SetAttributeNotNull(4, "role", Role)
            .SetAttributeNotNull(5, "aria-label", AriaLabel)
            .SetAttributeNotNull(6, "defaultSelected", DefaultSelected)
            .SetAttributeNotNull(7, "disabled", Disabled)
            .SetAttribute(8, "label-position", LabelPosition)
            .SetAttributeNotNull(9, "legend-text", LegendText)
            .SetAttributeNotNull(10, "helper-text", HelperText)
            .SetAttributeNotNull(11, "warn", Warn)
            .SetAttributeNotNull(12, "warn-text", WarnText)
            .SetAttributeNotNull(13, "invalid", Invalid)
            .SetAttributeNotNull(14, "invalid-text", InvalidText)
            .SetAttributeNotNull(15, "name", Name)
            .SetAttribute(16, "orientation", Orientation)
            .SetAttributeNotNull(17, "readOnly", ReadOnly)
            .SetAttributeNotNull(18, "value", Value)
            .SetAttributeNotNull(19, "styles", Styles)
            .SetAttributes(20, AdditionalAttributes)
            .SetContent(21, ChildContent)
            .CloseElement();
    }
}

