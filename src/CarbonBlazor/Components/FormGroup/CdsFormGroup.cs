using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;

public class FormGroupContext
{
    public string LabelTitleSlot = "label-title";

    public string LebelDescriptionSlot = "lebel-description";
}

public class CdsFormGroup : BaseComponent<FormGroupContext>
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
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "tabindex", TabIndex)
            .SetAttributeNotNull(4, "role", Role)
            .SetAttributeNotNull(5, "aria-label", AriaLabel)
            .SetAttributeNotNull(6, "invalid", Invalid)
            .SetAttributeNotNull(7, "legend-id", LegendId)
            .SetAttributeNotNull(8, "legend-text", LegendText)
            .SetAttributeNotNull(9, "message", Message)
            .SetAttributeNotNull(10, "message-text", MessageText)
            .SetAttributeNotNull(11, "styles", Styles)
            .SetAttributes(12, AdditionalAttributes)
            .SetContent(13, ChildContent, new())
            .CloseElement();
    }
}

