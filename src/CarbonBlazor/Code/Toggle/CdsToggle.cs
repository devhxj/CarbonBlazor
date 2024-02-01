using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsToggle : BaseComponent
{
    /// <summary>
    /// The text for the checked state.
    /// </summary>
    [Parameter]
    public string? LabelA { get; set; }

    /// <summary>
    /// Read only boolean.
    /// </summary>
    [Parameter]
    public bool ReadOnly { get; set; }

    /// <summary>
    /// Toggle size.
    /// </summary>
    [Parameter]
    public TOGGLE_SIZE? Size { get; set; }

    /// <summary>
    /// The text for the unchecked state.
    /// </summary>
    [Parameter]
    public string? LabelB { get; set; }

    /// <summary>
    /// Specify whether the underlying input should be checked
    /// </summary>
    [Parameter]
    public bool Checked { get; set; }

    /// <summary>
    /// Specify if checkbox is being used in a data table
    /// </summary>
    [Parameter]
    public bool DataTable { get; set; }

    /// <summary>
    /// Specify whether the Checkbox should be disabled
    /// </summary>
    [Parameter]
    public bool Disabled { get; set; }

    /// <summary>
    /// Provide text for the form group for additional help
    /// </summary>
    [Parameter]
    public string? HelperText { get; set; }

    /// <summary>
    /// Specify whether the checkbox should be present in the DOM,
    /// but invisible and uninteractable. Used for data-table purposes.
    /// </summary>
    [Parameter]
    public bool HideCheckbox { get; set; }

    /// <summary>
    /// Hide label text.
    /// </summary>
    [Parameter]
    public bool HideLabel { get; set; }

    /// <summary>
    /// Specify whether the Checkbox is in an indeterminate state
    /// </summary>
    [Parameter]
    public bool Indeterminate { get; set; }

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
    /// </summary>
    [Parameter]
    public bool Readonly { get; set; }

    /// <summary>
    /// Specify whether the Checkbox is currently invalid
    /// </summary>
    [Parameter]
    public bool Invalid { get; set; }

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
    /// </summary>
    [Parameter]
    public bool Warn { get; set; }

    /// <summary>
    /// Provide the text that is displayed when the Checkbox is in a warn state
    /// </summary>
    [Parameter]
    public bool WarnText { get; set; }

    [Parameter]
    public ShadowRootOptions ShadowRootOptions { get; set; } = new ShadowRootOptions() {DelegatesFocus = true};

    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-toggle")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttribute(5, "label-a", LabelA)
            .SetAttribute(6, "read-only", ReadOnly)
            .SetAttribute(7, "size", Size)
            .SetAttribute(8, "label-b", LabelB)
            .SetAttribute(9, "checked", Checked)
            .SetAttribute(10, "data-table", DataTable)
            .SetAttribute(11, "disabled", Disabled)
            .SetAttributeNotNull(12, "helper-text", HelperText)
            .SetAttribute(13, "hide-checkbox", HideCheckbox)
            .SetAttribute(14, "hideLabel", HideLabel)
            .SetAttribute(15, "indeterminate", Indeterminate)
            .SetAttribute(16, "label-text", LabelText)
            .SetAttributeNotNull(17, "name", Name)
            .SetAttribute(18, "readonly", Readonly)
            .SetAttribute(19, "invalid", Invalid)
            .SetAttributeNotNull(20, "invalid-text", InvalidText)
            .SetAttributeNotNull(21, "value", Value)
            .SetAttribute(22, "warn", Warn)
            .SetAttribute(23, "warn-text", WarnText)
            .SetAttributeNotNull(24, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(25, "styles", Styles)
            .SetAttributes(26, AdditionalAttributes)
            .SetContent(27, ChildContent)
            .CloseElement();
    }
}

