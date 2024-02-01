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
    /// </summary>
    [Parameter]
    public bool Disabled { get; set; }

    /// <summary>
    /// Specify the string that is displayed when the button is clicked and the content is copi
    /// </summary>
    [Parameter]
    public string Feedback { get; set; } = "Copied!";

    /// <summary>
    /// The number in milliseconds to determine how long the tooltip should remain.
    /// </summary>
    [Parameter]
    public int FeedbackTimeout { get; set; } = 2000;

    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-copy-button")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttributeNotNull(5, "button-class-name", ButtonClassName)
            .SetAttribute(6, "disabled", Disabled)
            .SetAttribute(7, "feedback", Feedback)
            .SetAttribute(8, "feedback-timeout", FeedbackTimeout)
            .SetAttributeNotNull(9, "styles", Styles)
            .SetAttributes(10, AdditionalAttributes)
            .SetContent(11, ChildContent)
            .CloseElement();
    }
}

