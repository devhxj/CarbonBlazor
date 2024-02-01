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

public class CdsToggle : BaseComponent<ToggleContext>
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
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "tabindex", TabIndex)
            .SetAttributeNotNull(4, "role", Role)
            .SetAttributeNotNull(5, "aria-label", AriaLabel)
            .SetAttributeNotNull(6, "label-a", LabelA)
            .SetAttributeNotNull(7, "read-only", ReadOnly)
            .SetAttributeNotNull(8, "size", Size)
            .SetAttributeNotNull(9, "label-b", LabelB)
            .SetAttributeNotNull(10, "checked", Checked)
            .SetAttributeNotNull(11, "data-table", DataTable)
            .SetAttributeNotNull(12, "disabled", Disabled)
            .SetAttributeNotNull(13, "helper-text", HelperText)
            .SetAttributeNotNull(14, "hide-checkbox", HideCheckbox)
            .SetAttributeNotNull(15, "hideLabel", HideLabel)
            .SetAttributeNotNull(16, "indeterminate", Indeterminate)
            .SetAttributeNotNull(17, "label-text", LabelText)
            .SetAttributeNotNull(18, "name", Name)
            .SetAttributeNotNull(19, "readonly", Readonly)
            .SetAttributeNotNull(20, "invalid", Invalid)
            .SetAttributeNotNull(21, "invalid-text", InvalidText)
            .SetAttributeNotNull(22, "value", Value)
            .SetAttributeNotNull(23, "warn", Warn)
            .SetAttributeNotNull(24, "warn-text", WarnText)
            .SetAttributeNotNull(25, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(26, "styles", Styles)
            .SetAttributes(27, AdditionalAttributes)
            .SetContent(28, ChildContent, new())
            .CloseElement();
    }
}

