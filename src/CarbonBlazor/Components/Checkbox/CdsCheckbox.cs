using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System.Diagnostics.CodeAnalysis;

namespace CarbonBlazor;
public class CdsCheckbox : CdsInputBase<bool>
{
    ///// <summary>
    ///// Specify whether the underlying input should be checked
    ///// <para><b>DefaultValue : false</b></para>
    ///// </summary>
    //[Parameter]
    //public bool? Checked { get; set; }

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
    /// The data value.
    /// </summary>
    [Parameter]
    public string? Data { get; set; }

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

    [Parameter]
    public RenderFragment? ChildContent { get; set; }

    void SetValue(bool value) => base.CurrentValue = value;

    bool? IsValid()
    {
        if (Invalid.HasValue)
            return Invalid.Value;

        if (!EditContext.IsValid(FieldIdentifier))
            return true;

        return null;
    }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-checkbox")
            .SetAttributes(1, AdditionalAttributes)
            .SetAttribute(2, "id", Id)
            .SetAttributeNotNull(3, "title", Title)
            .SetAttributeNotNull(4, "tabindex", TabIndex)
            .SetAttributeNotNull(5, "role", Role)
            .SetAttributeNotNull(6, "aria-label", AriaLabel)
            .SetAttributeNotNull(7, "checked", BindConverter.FormatValue(base.CurrentValue))
            .SetAttributeNotNull(8, "data-table", DataTable)
            .SetAttributeNotNull(9, "disabled", Disabled)
            .SetAttributeNotNull(10, "helper-text", HelperText)
            .SetAttributeNotNull(11, "hide-checkbox", HideCheckbox)
            .SetAttributeNotNull(12, "hide-label", HideLabel)
            .SetAttributeNotNull(13, "indeterminate", Indeterminate)
            .SetAttributeNotNull(14, "label-text", LabelText)
            .SetAttributeNotNull(15, "name", base.NameAttributeValue)
            .SetAttributeNotNull(16, "readonly", Readonly)
            .SetAttributeNotNull(17, "invalid", IsValid())
            .SetAttributeNotNull(18, "invalid-text", InvalidText)
            .SetAttributeNotNull(19, "warn", Warn)
            .SetAttributeNotNull(20, "warn-text", WarnText)
            .SetAttributeNotNull(21, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(22, "styles", Styles)
            .SetAttributeNotNull(23, "class", base.CssClass)
            .SetAttributeNotNull(24, "value", Data)
            .SetAttribute(25, "onchange", EventCallback.Factory.CreateBinder<bool>(this, SetValue, base.CurrentValue))
            .SetUpdatesAttributeNameAnd("checked")
            .SetReferenceCapture(26, CaptureReference)
            .SetContent(27, ChildContent)
            .CloseElement();
    }

    protected override bool TryParseValueFromString(string? value, [MaybeNullWhen(false)] out bool result, [NotNullWhen(false)] out string? validationErrorMessage)
    {
        throw new NotSupportedException("This component does not parse string inputs. Bind to the 'CurrentValue' property, not 'CurrentValueAsString'.");
    }
}

