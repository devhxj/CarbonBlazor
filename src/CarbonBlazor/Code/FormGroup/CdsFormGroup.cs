using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsFormGroup : BaseComponent
{
    /// <summary>
    /// Specify whether the Form Group is invalid
    /// </summary>
    [Parameter]
    public bool Invalid { get; set; }

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
    /// </summary>
    [Parameter]
    public bool Message { get; set; }

    /// <summary>
    /// Provide the text for the message in the Form Group
    /// </summary>
    [Parameter]
    public string? MessageText { get; set; }

    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-form-group")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttribute(5, "invalid", Invalid)
            .SetAttributeNotNull(6, "legend-id", LegendId)
            .SetAttributeNotNull(7, "legend-text", LegendText)
            .SetAttribute(8, "message", Message)
            .SetAttributeNotNull(9, "message-text", MessageText)
            .SetAttributeNotNull(10, "styles", Styles)
            .SetAttributes(11, AdditionalAttributes)
            .SetContent(12, ChildContent)
            .CloseElement();
    }
}

