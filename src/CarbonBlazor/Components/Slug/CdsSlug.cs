using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsSlug : CdsComponentBase
{
    /// <summary>
    /// <para><b>DefaultValue : "slug"</b></para>
    /// </summary>
    [Parameter]
    public string? Slot { get; set; }

    /// <summary>
    /// Specify the correct translation of the AI text
    /// <para><b>DefaultValue : "AI"</b></para>
    /// </summary>
    [Parameter]
    public string? AiText { get; set; }

    /// <summary>
    /// Specify additional text to be rendered next to the AI label in the inline variant
    /// </summary>
    [Parameter]
    public string? AiTextLabel { get; set; }

    /// <summary>
    /// Specify the type of dot that should be rendered in front of the inline variant: (default, hollow)
    /// </summary>
    [Parameter]
    public SLUG_DOT_TYPE DotType { get; set; }

    /// <summary>
    /// Specify the type of Slug, from the following list of types: (default, hollow, inline)
    /// </summary>
    [Parameter]
    public SLUG_KIND Kind { get; set; }

    /// <summary>
    /// Specify whether the revert button should be visible
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? RevertActive { get; set; }

    /// <summary>
    /// Specify whether the revert button should be visible
    /// <para><b>DefaultValue : "Revert to AI input"</b></para>
    /// </summary>
    [Parameter]
    public string? RevertLabel { get; set; }

    /// <summary>
    /// Slug size should be mini, 2xs, xs, sm, md, lg, xl.
    /// <para><b>DefaultValue : "xs"</b></para>
    /// </summary>
    [Parameter]
    public SLUG_SIZE Size { get; set; } = SLUG_SIZE.XS;

    /// <summary>
    /// Specify the text that will be provided to the aria-label of the `Slug` button
    /// <para><b>DefaultValue : "Show information"</b></para>
    /// </summary>
    [Parameter]
    public string? SlugLabel { get; set; }

    [Parameter]
    public string? PreviousValue { get; set; }

    /// <summary>
    /// How the tooltip is aligned to the trigger button.
    /// <para><b>DefaultValue : "top"</b></para>
    /// </summary>
    [Parameter]
    public POPOVER_ALIGNMENT Alignment { get; set; } = POPOVER_ALIGNMENT.TOP;

    /// <summary>
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Open { get; set; }

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
            .OpenElementAnd(0, "cds-slug")
            .SetAttributes(1, AdditionalAttributes)
            .SetAttribute(2, "id", Id)
            .SetAttributeNotNull(3, "title", Title)
            .SetAttributeNotNull(4, "tabindex", TabIndex)
            .SetAttributeNotNull(5, "role", Role)
            .SetAttributeNotNull(6, "aria-label", AriaLabel)
            .SetAttributeNotNull(7, "slot", Slot)
            .SetAttributeNotNull(8, "ai-text", AiText)
            .SetAttributeNotNull(9, "ai-text-label", AiTextLabel)
            .SetAttributeNotNull(10, "dot-type", DotType)
            .SetAttributeNotNull(11, "kind", Kind)
            .SetAttributeNotNull(12, "revert-active", RevertActive)
            .SetAttributeNotNull(13, "revert-label", RevertLabel)
            .SetAttribute(14, "size", Size)
            .SetAttributeNotNull(15, "slug-label", SlugLabel)
            .SetAttributeNotNull(16, "previousValue", PreviousValue)
            .SetAttribute(17, "alignment", Alignment)
            .SetAttributeNotNull(18, "open", Open)
            .SetAttributeNotNull(19, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(20, "styles", Styles)
            .SetReferenceCapture(21, CaptureReference)
            .SetContent(22, ChildContent)
            .CloseElement();
    }
}

