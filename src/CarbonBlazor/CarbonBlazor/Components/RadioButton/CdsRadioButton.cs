using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsRadioButton : BaseComponent
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
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "tabindex", TabIndex)
            .SetAttributeNotNull(4, "role", Role)
            .SetAttributeNotNull(5, "aria-label", AriaLabel)
            .SetAttributeNotNull(6, "checked", Checked)
            .SetAttributeNotNull(7, "data-table", DataTable)
            .SetAttributeNotNull(8, "disabledItem", DisabledItem)
            .SetAttributeNotNull(9, "disabled", Disabled)
            .SetAttributeNotNull(10, "hide-label", HideLabel)
            .SetAttributeNotNull(11, "invalid", Invalid)
            .SetAttribute(12, "label-position", LabelPosition)
            .SetAttributeNotNull(13, "label-text", LabelText)
            .SetAttributeNotNull(14, "name", Name)
            .SetAttribute(15, "orientation", Orientation)
            .SetAttributeNotNull(16, "readOnly", ReadOnly)
            .SetAttributeNotNull(17, "value", Value)
            .SetAttributeNotNull(18, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(19, "styles", Styles)
            .SetAttributes(20, AdditionalAttributes)
            .SetContent(21, ChildContent)
            .CloseElement();
    }
}

