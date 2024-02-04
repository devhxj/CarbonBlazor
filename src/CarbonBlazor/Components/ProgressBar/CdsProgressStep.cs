using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;

public class ProgressStepContext
{
    /// <summary>
    /// The secondary progress label.
    /// </summary>
    public string SecondaryLabelTextSlot = "secondary-label-text";
}

public class CdsProgressStep : CdsComponentBase<ProgressStepContext>
{
    /// <summary>
    /// `true` if the progress step should be disabled.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Disabled { get; set; }

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
    /// <para><b>DefaultValue : "incomplete"</b></para>
    /// </summary>
    [Parameter]
    public PROGRESS_STEP_STAT State { get; set; } = PROGRESS_STEP_STAT.INCOMPLETE;

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
            .OpenElementAnd(0, "cds-progress-step")
            .SetAttributes(1, AdditionalAttributes)
            .SetAttribute(2, "id", Id)
            .SetAttributeNotNull(3, "title", Title)
            .SetAttributeNotNull(4, "tabindex", TabIndex)
            .SetAttributeNotNull(5, "role", Role)
            .SetAttributeNotNull(6, "aria-label", AriaLabel)
            .SetAttributeNotNull(7, "disabled", Disabled)
            .SetAttributeNotNull(8, "icon-label", IconLabel)
            .SetAttributeNotNull(9, "description", Description)
            .SetAttributeNotNull(10, "label-text", LabelText)
            .SetAttributeNotNull(11, "label", Label)
            .SetAttributeNotNull(12, "secondary-label-text", SecondaryLabelText)
            .SetAttributeNotNull(13, "secondary-label", SecondaryLabel)
            .SetAttribute(14, "state", State)
            .SetAttributeNotNull(15, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(16, "styles", Styles)
            .SetReferenceCapture(17, CaptureReference)
            .SetContent(18, ChildContent, new())
            .CloseElement();
    }
}

