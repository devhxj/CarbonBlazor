using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsSlug : BaseComponent
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
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "tabindex", TabIndex)
            .SetAttributeNotNull(4, "role", Role)
            .SetAttributeNotNull(5, "aria-label", AriaLabel)
            .SetAttributeNotNull(6, "slot", Slot)
            .SetAttributeNotNull(7, "ai-text", AiText)
            .SetAttributeNotNull(8, "ai-text-label", AiTextLabel)
            .SetAttributeNotNull(9, "dot-type", DotType)
            .SetAttributeNotNull(10, "kind", Kind)
            .SetAttributeNotNull(11, "revert-active", RevertActive)
            .SetAttributeNotNull(12, "revert-label", RevertLabel)
            .SetAttribute(13, "size", Size)
            .SetAttributeNotNull(14, "slug-label", SlugLabel)
            .SetAttributeNotNull(15, "previousValue", PreviousValue)
            .SetAttribute(16, "alignment", Alignment)
            .SetAttributeNotNull(17, "open", Open)
            .SetAttributeNotNull(18, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(19, "styles", Styles)
            .SetAttributes(20, AdditionalAttributes)
            .SetContent(21, ChildContent)
            .CloseElement();
    }
}

