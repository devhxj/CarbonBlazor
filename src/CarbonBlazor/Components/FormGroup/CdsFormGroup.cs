using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;

public class FormGroupContext
{
    public string LabelTitleSlot = "label-title";

    public string LebelDescriptionSlot = "lebel-description";
}

public class CdsFormGroup : CdsComponentBase<FormGroupContext>
{
    /// <summary>
    /// Specify whether the Form Group is invalid
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Invalid { get; set; }

    /// <summary>
    /// Provide id for the fieldset &lt;legend&gt; which corresponds to the fieldset
    /// `aria-labelledby`
    /// </summary>
    [Parameter]
    public string? LegendId { get; set; }

    /// <summary>
    /// Provide the text to be rendered inside of the fieldset &lt;legend&gt;
    /// </summary>
    [Parameter]
    public string? LegendText { get; set; }

    /// <summary>
    /// Specify whether the message should be displayed in the Form Group
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Message { get; set; }

    /// <summary>
    /// Provide the text for the message in the Form Group
    /// </summary>
    [Parameter]
    public string? MessageText { get; set; }

    /// <summary>
    /// <para><b>DefaultValue : "styles"</b></para>
    /// </summary>
    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-form-group")
            .SetAttributes(1, AdditionalAttributes)
            .SetAttribute(2, "id", Id)
            .SetAttributeNotNull(3, "title", Title)
            .SetAttributeNotNull(4, "tabindex", TabIndex)
            .SetAttributeNotNull(5, "role", Role)
            .SetAttributeNotNull(6, "aria-label", AriaLabel)
            .SetAttributeNotNull(7, "invalid", Invalid)
            .SetAttributeNotNull(8, "legend-id", LegendId)
            .SetAttributeNotNull(9, "legend-text", LegendText)
            .SetAttributeNotNull(10, "message", Message)
            .SetAttributeNotNull(11, "message-text", MessageText)
            .SetAttributeNotNull(12, "styles", Styles)
            .SetReferenceCapture(13, CaptureReference)
            .SetContent(14, ChildContent, new())
            .CloseElement();
    }
}

