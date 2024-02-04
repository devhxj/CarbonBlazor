using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsToggletip : CdsComponentBase
{
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
            .OpenElementAnd(0, "cds-toggletip")
            .SetAttributes(1, AdditionalAttributes)
            .SetAttribute(2, "id", Id)
            .SetAttributeNotNull(3, "title", Title)
            .SetAttributeNotNull(4, "tabindex", TabIndex)
            .SetAttributeNotNull(5, "role", Role)
            .SetAttributeNotNull(6, "aria-label", AriaLabel)
            .SetAttribute(7, "alignment", Alignment)
            .SetAttributeNotNull(8, "open", Open)
            .SetAttributeNotNull(9, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(10, "styles", Styles)
            .SetReferenceCapture(11, CaptureReference)
            .SetContent(12, ChildContent)
            .CloseElement();
    }
}

