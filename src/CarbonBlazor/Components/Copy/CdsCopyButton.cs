using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsCopyButton : BaseComponent
{
    /// <summary>
    /// Specify an optional className to be added to your Button
    /// </summary>
    [Parameter]
    public string? ButtonClassName { get; set; }

    /// <summary>
    /// `true` if the button should be disabled.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Disabled { get; set; }

    /// <summary>
    /// Specify the string that is displayed when the button is clicked and the content is copi
    /// <para><b>DefaultValue : "Copied!"</b></para>
    /// </summary>
    [Parameter]
    public string? Feedback { get; set; }

    /// <summary>
    /// The number in milliseconds to determine how long the tooltip should remain.
    /// <para><b>DefaultValue : 2000</b></para>
    /// </summary>
    [Parameter]
    public int? FeedbackTimeout { get; set; }

    /// <summary>
    /// <para><b>DefaultValue : "styles"</b></para>
    /// </summary>
    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-copy-button")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "tabindex", TabIndex)
            .SetAttributeNotNull(4, "role", Role)
            .SetAttributeNotNull(5, "aria-label", AriaLabel)
            .SetAttributeNotNull(6, "button-class-name", ButtonClassName)
            .SetAttributeNotNull(7, "disabled", Disabled)
            .SetAttributeNotNull(8, "feedback", Feedback)
            .SetAttributeNotNull(9, "feedback-timeout", FeedbackTimeout)
            .SetAttributeNotNull(10, "styles", Styles)
            .SetAttributes(11, AdditionalAttributes)
            .SetContent(12, ChildContent)
            .CloseElement();
    }
}

