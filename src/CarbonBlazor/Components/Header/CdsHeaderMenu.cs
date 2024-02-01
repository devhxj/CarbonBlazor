using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsHeaderMenu : BaseComponent
{
    /// <summary>
    /// `true` if the menu should be expanded.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Expanded { get; set; }

    /// <summary>
    /// Applies selected styles to the item if a user sets this to true and `aria-current !== 'page'`.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? IsActive { get; set; }

    /// <summary>
    /// The content of the trigger button.
    /// </summary>
    [Parameter]
    public string? TriggerContent { get; set; }

    /// <summary>
    /// The `aria-label` attribute for the menu UI.
    /// </summary>
    [Parameter]
    public string? MenuLabel { get; set; }

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
            .OpenElementAnd(0, "cds-header-menu")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "tabindex", TabIndex)
            .SetAttributeNotNull(4, "role", Role)
            .SetAttributeNotNull(5, "aria-label", AriaLabel)
            .SetAttributeNotNull(6, "expanded", Expanded)
            .SetAttributeNotNull(7, "is-active", IsActive)
            .SetAttributeNotNull(8, "trigger-content", TriggerContent)
            .SetAttributeNotNull(9, "menu-label", MenuLabel)
            .SetAttributeNotNull(10, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(11, "styles", Styles)
            .SetAttributes(12, AdditionalAttributes)
            .SetContent(13, ChildContent)
            .CloseElement();
    }
}

