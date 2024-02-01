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

public class CdsProgressStep : BaseComponent<ProgressStepContext>
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
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "tabindex", TabIndex)
            .SetAttributeNotNull(4, "role", Role)
            .SetAttributeNotNull(5, "aria-label", AriaLabel)
            .SetAttributeNotNull(6, "disabled", Disabled)
            .SetAttributeNotNull(7, "icon-label", IconLabel)
            .SetAttributeNotNull(8, "description", Description)
            .SetAttributeNotNull(9, "label-text", LabelText)
            .SetAttributeNotNull(10, "label", Label)
            .SetAttributeNotNull(11, "secondary-label-text", SecondaryLabelText)
            .SetAttributeNotNull(12, "secondary-label", SecondaryLabel)
            .SetAttribute(13, "state", State)
            .SetAttributeNotNull(14, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(15, "styles", Styles)
            .SetAttributes(16, AdditionalAttributes)
            .SetContent(17, ChildContent, new())
            .CloseElement();
    }
}

