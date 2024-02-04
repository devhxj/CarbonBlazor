using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;

public class ToggleContext
{
    /// <summary>
    /// The label text.
    /// </summary>
    public string LabelTextSlot = "label-text";

    /// <summary>
    /// The text for the checked state.
    /// </summary>
    public string CheckedTextSlot = "checked-text";

    /// <summary>
    /// The text for the unchecked state.
    /// </summary>
    public string UncheckedTextSlot = "unchecked-text";
}

public class CdsToggle : CdsComponentBase<ToggleContext>
{
    /// <summary>
    /// The text for the checked state.
    /// </summary>
    [Parameter]
    public string? LabelA { get; set; }

    /// <summary>
    /// Read only boolean.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? ReadOnly { get; set; }

    /// <summary>
    /// Toggle size.
    /// </summary>
    [Parameter]
    public TOGGLE_SIZE Size { get; set; }

    /// <summary>
    /// The text for the unchecked state.
    /// </summary>
    [Parameter]
    public string? LabelB { get; set; }

    /// <summary>
    /// Specify whether the underlying input should be checked
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Checked { get; set; }

    /// <summary>
    /// Specify if checkbox is being used in a data table
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? DataTable { get; set; }

    /// <summary>
    /// Specify whether the Checkbox should be disabled
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Disabled { get; set; }

    /// <summary>
    /// Provide text for the form group for additional help
    /// </summary>
    [Parameter]
    public string? HelperText { get; set; }

    /// <summary>
    /// Specify whether the checkbox should be present in the DOM,
    /// but invisible and uninteractable. Used for data-table purposes.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? HideCheckbox { get; set; }

    /// <summary>
    /// Hide label text.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? HideLabel { get; set; }

    /// <summary>
    /// Specify whether the Checkbox is in an indeterminate state
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Indeterminate { get; set; }

    /// <summary>
    /// Provide a label to provide a description of the Checkbox input that you are
    /// exposing to the user
    /// </summary>
    [Parameter]
    public string? LabelText { get; set; }

    /// <summary>
    /// The form name.
    /// </summary>
    [Parameter]
    public string? Name { get; set; }

    /// <summary>
    /// Specify whether the Checkbox is read-only
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Readonly { get; set; }

    /// <summary>
    /// Specify whether the Checkbox is currently invalid
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Invalid { get; set; }

    /// <summary>
    /// Provide the text that is displayed when the Checkbox is in an invalid state
    /// </summary>
    [Parameter]
    public string? InvalidText { get; set; }

    /// <summary>
    /// The value.
    /// </summary>
    [Parameter]
    public string? Value { get; set; }

    /// <summary>
    /// Specify whether the Checkbox is in a warn state
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Warn { get; set; }

    /// <summary>
    /// Provide the text that is displayed when the Checkbox is in a warn state
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? WarnText { get; set; }

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
            .OpenElementAnd(0, "cds-toggle")
            .SetAttributes(1, AdditionalAttributes)
            .SetAttribute(2, "id", Id)
            .SetAttributeNotNull(3, "title", Title)
            .SetAttributeNotNull(4, "tabindex", TabIndex)
            .SetAttributeNotNull(5, "role", Role)
            .SetAttributeNotNull(6, "aria-label", AriaLabel)
            .SetAttributeNotNull(7, "label-a", LabelA)
            .SetAttributeNotNull(8, "read-only", ReadOnly)
            .SetAttributeNotNull(9, "size", Size)
            .SetAttributeNotNull(10, "label-b", LabelB)
            .SetAttributeNotNull(11, "checked", Checked)
            .SetAttributeNotNull(12, "data-table", DataTable)
            .SetAttributeNotNull(13, "disabled", Disabled)
            .SetAttributeNotNull(14, "helper-text", HelperText)
            .SetAttributeNotNull(15, "hide-checkbox", HideCheckbox)
            .SetAttributeNotNull(16, "hideLabel", HideLabel)
            .SetAttributeNotNull(17, "indeterminate", Indeterminate)
            .SetAttributeNotNull(18, "label-text", LabelText)
            .SetAttributeNotNull(19, "name", Name)
            .SetAttributeNotNull(20, "readonly", Readonly)
            .SetAttributeNotNull(21, "invalid", Invalid)
            .SetAttributeNotNull(22, "invalid-text", InvalidText)
            .SetAttributeNotNull(23, "value", Value)
            .SetAttributeNotNull(24, "warn", Warn)
            .SetAttributeNotNull(25, "warn-text", WarnText)
            .SetAttributeNotNull(26, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(27, "styles", Styles)
            .SetReferenceCapture(28, CaptureReference)
            .SetContent(29, ChildContent, new())
            .CloseElement();
    }
}

