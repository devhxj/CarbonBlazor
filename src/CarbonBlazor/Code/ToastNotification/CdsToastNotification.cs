using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsToastNotification : BaseComponent
{
    /// <summary>
    /// Specify the caption
    /// </summary>
    [Parameter]
    public string? Caption { get; set; }

    /// <summary>
    /// `true` to hide the close button.
    /// </summary>
    [Parameter]
    public bool HideCloseButton { get; set; }

    /// <summary>
    /// Provide a description for "status" icon that can be read by screen readers
    /// </summary>
    [Parameter]
    public string? StatusIconDescription { get; set; }

    /// <summary>
    /// Notification kind.
    /// </summary>
    [Parameter]
    public NOTIFICATION_KIND Kind { get; set; } = NOTIFICATION_KIND.SUCCESS;

    /// <summary>
    /// Low contrast mode
    /// </summary>
    [Parameter]
    public bool LowContrast { get; set; }

    /// <summary>
    /// `true` if the notification should be open.
    /// </summary>
    [Parameter]
    public bool Open { get; set; } = true;

    /// <summary>
    /// Specify an optional duration the notification should be closed in
    /// </summary>
    [Parameter]
    public int? Timeout { get; set; }

    /// <summary>
    /// The subtitle.
    /// </summary>
    [Parameter]
    public string? Subtitle { get; set; }

    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-toast-notification")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttribute(5, "caption", Caption)
            .SetAttribute(6, "hide-close-button", HideCloseButton)
            .SetAttributeNotNull(7, "status-icon-description", StatusIconDescription)
            .SetAttribute(8, "kind", Kind)
            .SetAttribute(9, "low-contrast", LowContrast)
            .SetAttribute(10, "open", Open)
            .SetAttributeNotNull(11, "timeout", Timeout)
            .SetAttribute(12, "subtitle", Subtitle)
            .SetAttributeNotNull(13, "styles", Styles)
            .SetAttributes(14, AdditionalAttributes)
            .SetContent(15, ChildContent)
            .CloseElement();
    }
}

