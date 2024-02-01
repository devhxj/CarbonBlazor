using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsHeaderMenu : BaseComponent
{
    /// <summary>
    /// `true` if the menu should be expanded.
    /// </summary>
    [Parameter]
    public bool Expanded { get; set; }

    /// <summary>
    /// Applies selected styles to the item if a user sets this to true and `aria-current !== 'page'`.
    /// </summary>
    [Parameter]
    public bool IsActive { get; set; }

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

    [Parameter]
    public ShadowRootOptions ShadowRootOptions { get; set; } = new ShadowRootOptions() {DelegatesFocus = true};

    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-header-menu")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttribute(5, "expanded", Expanded)
            .SetAttribute(6, "is-active", IsActive)
            .SetAttribute(7, "trigger-content", TriggerContent)
            .SetAttributeNotNull(8, "menu-label", MenuLabel)
            .SetAttributeNotNull(9, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(10, "styles", Styles)
            .SetAttributes(11, AdditionalAttributes)
            .SetContent(12, ChildContent)
            .CloseElement();
    }
}

