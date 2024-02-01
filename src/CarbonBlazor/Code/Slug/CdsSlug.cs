using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsSlug : BaseComponent
{
    [Parameter]
    public string Slot { get; set; } = "slug";

    /// <summary>
    /// Specify the correct translation of the AI text
    /// </summary>
    [Parameter]
    public string AiText { get; set; } = "AI";

    /// <summary>
    /// Specify additional text to be rendered next to the AI label in the inline variant
    /// </summary>
    [Parameter]
    public string? AiTextLabel { get; set; }

    /// <summary>
    /// Specify the type of dot that should be rendered in front of the inline variant: (default, hollow)
    /// </summary>
    [Parameter]
    public SLUG_DOT_TYPE? DotType { get; set; }

    /// <summary>
    /// Specify the type of Slug, from the following list of types: (default, hollow, inline)
    /// </summary>
    [Parameter]
    public SLUG_KIND? Kind { get; set; }

    /// <summary>
    /// Specify whether the revert button should be visible
    /// </summary>
    [Parameter]
    public bool RevertActive { get; set; }

    /// <summary>
    /// Specify whether the revert button should be visible
    /// </summary>
    [Parameter]
    public string RevertLabel { get; set; } = "Revert to AI input";

    /// <summary>
    /// Slug size should be mini, 2xs, xs, sm, md, lg, xl.
    /// </summary>
    [Parameter]
    public SLUG_SIZE Size { get; set; } = SLUG_SIZE.XS;

    /// <summary>
    /// Specify the text that will be provided to the aria-label of the `Slug` button
    /// </summary>
    [Parameter]
    public string SlugLabel { get; set; } = "Show information";

    [Parameter]
    public string? PreviousValue { get; set; }

    /// <summary>
    /// How the tooltip is aligned to the trigger button.
    /// </summary>
    [Parameter]
    public POPOVER_ALIGNMENT Alignment { get; set; } = POPOVER_ALIGNMENT.TOP;

    [Parameter]
    public bool Open { get; set; }

    [Parameter]
    public ShadowRootOptions ShadowRootOptions { get; set; } = new ShadowRootOptions() {DelegatesFocus = true};

    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-slug")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttribute(5, "slot", Slot)
            .SetAttribute(6, "ai-text", AiText)
            .SetAttribute(7, "ai-text-label", AiTextLabel)
            .SetAttribute(8, "dot-type", DotType)
            .SetAttribute(9, "kind", Kind)
            .SetAttribute(10, "revert-active", RevertActive)
            .SetAttribute(11, "revert-label", RevertLabel)
            .SetAttribute(12, "size", Size)
            .SetAttribute(13, "slug-label", SlugLabel)
            .SetAttributeNotNull(14, "previousValue", PreviousValue)
            .SetAttribute(15, "alignment", Alignment)
            .SetAttribute(16, "open", Open)
            .SetAttributeNotNull(17, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(18, "styles", Styles)
            .SetAttributes(19, AdditionalAttributes)
            .SetContent(20, ChildContent)
            .CloseElement();
    }
}

