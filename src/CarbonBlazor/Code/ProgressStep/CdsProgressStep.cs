using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsProgressStep : BaseComponent
{
    /// <summary>
    /// `true` if the progress step should be disabled.
    /// </summary>
    [Parameter]
    public bool Disabled { get; set; }

    /// <summary>
    /// The a11y text for the icon.
    /// </summary>
    [Parameter]
    public string? IconLabel { get; set; }

    [Parameter]
    public string? Description { get; set; }

    /// <summary>
    /// The primary progress label.
    /// </summary>
    [Parameter]
    public string? LabelText { get; set; }

    [Parameter]
    public string? Label { get; set; }

    /// <summary>
    /// The secondary progress label.
    /// </summary>
    [Parameter]
    public string? SecondaryLabelText { get; set; }

    [Parameter]
    public string? SecondaryLabel { get; set; }

    /// <summary>
    /// The progress state.
    /// </summary>
    [Parameter]
    public PROGRESS_STEP_STAT State { get; set; } = PROGRESS_STEP_STAT.INCOMPLETE;

    [Parameter]
    public ShadowRootOptions ShadowRootOptions { get; set; } = new ShadowRootOptions() {DelegatesFocus = true};

    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-progress-step")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttribute(5, "disabled", Disabled)
            .SetAttributeNotNull(6, "icon-label", IconLabel)
            .SetAttributeNotNull(7, "description", Description)
            .SetAttributeNotNull(8, "label-text", LabelText)
            .SetAttributeNotNull(9, "label", Label)
            .SetAttributeNotNull(10, "secondary-label-text", SecondaryLabelText)
            .SetAttributeNotNull(11, "secondary-label", SecondaryLabel)
            .SetAttribute(12, "state", State)
            .SetAttributeNotNull(13, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(14, "styles", Styles)
            .SetAttributes(15, AdditionalAttributes)
            .SetContent(16, ChildContent)
            .CloseElement();
    }
}

