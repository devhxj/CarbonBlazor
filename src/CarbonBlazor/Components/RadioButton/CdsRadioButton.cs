using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsRadioButton : CdsComponentBase
{
    /// <summary>
    /// `true` if this radio button should be checked.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Checked { get; set; }

    /// <summary>
    /// `true` if the radio button is used in a data table
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? DataTable { get; set; }

    /// <summary>
    /// `true` if the radio button item should be disabled.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? DisabledItem { get; set; }

    /// <summary>
    /// `true` if the radio button group should be disabled.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Disabled { get; set; }

    /// <summary>
    /// `true` if the label should be hidden.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? HideLabel { get; set; }

    /// <summary>
    /// Specify if the currently value is invalid.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Invalid { get; set; }

    /// <summary>
    /// The label position.
    /// <para><b>DefaultValue : "right"</b></para>
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
    /// <para><b>DefaultValue : "horizontal"</b></para>
    /// </summary>
    [Parameter]
    public RADIO_BUTTON_ORIENTATION Orientation { get; set; } = RADIO_BUTTON_ORIENTATION.HORIZONTAL;

    /// <summary>
    /// `true` if the radio button group should be disabled.
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
    /// <para><b>DefaultValue : {"delegatesFocus":true}</b></para>
    /// </summary>
    [Parameter]
    public ShadowRootOptions? ShadowRootOptions { get; set; }

    /// <summary>
    /// <para><b>DefaultValue : "styles"</b></para>
    /// </summary>
    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-radio-button")
            .SetAttributes(1, AdditionalAttributes)
            .SetAttribute(2, "id", Id)
            .SetAttributeNotNull(3, "title", Title)
            .SetAttributeNotNull(4, "tabindex", TabIndex)
            .SetAttributeNotNull(5, "role", Role)
            .SetAttributeNotNull(6, "aria-label", AriaLabel)
            .SetAttributeNotNull(7, "checked", Checked)
            .SetAttributeNotNull(8, "data-table", DataTable)
            .SetAttributeNotNull(9, "disabledItem", DisabledItem)
            .SetAttributeNotNull(10, "disabled", Disabled)
            .SetAttributeNotNull(11, "hide-label", HideLabel)
            .SetAttributeNotNull(12, "invalid", Invalid)
            .SetAttribute(13, "label-position", LabelPosition)
            .SetAttributeNotNull(14, "label-text", LabelText)
            .SetAttributeNotNull(15, "name", Name)
            .SetAttribute(16, "orientation", Orientation)
            .SetAttributeNotNull(17, "readOnly", ReadOnly)
            .SetAttributeNotNull(18, "value", Value)
            .SetAttributeNotNull(19, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(20, "styles", Styles)
            .SetReferenceCapture(21, CaptureReference)
            .SetContent(22, ChildContent)
            .CloseElement();
    }
}

