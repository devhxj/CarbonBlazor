using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsCheckbox : BaseComponent
{
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
    /// Specify whether the label should be hidden, or not
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
            .OpenElementAnd(0, "cds-checkbox")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "tabindex", TabIndex)
            .SetAttributeNotNull(4, "role", Role)
            .SetAttributeNotNull(5, "aria-label", AriaLabel)
            .SetAttributeNotNull(6, "checked", Checked)
            .SetAttributeNotNull(7, "data-table", DataTable)
            .SetAttributeNotNull(8, "disabled", Disabled)
            .SetAttributeNotNull(9, "helper-text", HelperText)
            .SetAttributeNotNull(10, "hide-checkbox", HideCheckbox)
            .SetAttributeNotNull(11, "hide-label", HideLabel)
            .SetAttributeNotNull(12, "indeterminate", Indeterminate)
            .SetAttributeNotNull(13, "label-text", LabelText)
            .SetAttributeNotNull(14, "name", Name)
            .SetAttributeNotNull(15, "readonly", Readonly)
            .SetAttributeNotNull(16, "invalid", Invalid)
            .SetAttributeNotNull(17, "invalid-text", InvalidText)
            .SetAttributeNotNull(18, "value", Value)
            .SetAttributeNotNull(19, "warn", Warn)
            .SetAttributeNotNull(20, "warn-text", WarnText)
            .SetAttributeNotNull(21, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(22, "styles", Styles)
            .SetAttributes(23, AdditionalAttributes)
            .SetContent(24, ChildContent)
            .CloseElement();
    }
}

