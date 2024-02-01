using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsInlineNotification : BaseComponent
{
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
            .OpenElementAnd(0, "cds-inline-notification")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttribute(5, "hide-close-button", HideCloseButton)
            .SetAttributeNotNull(6, "status-icon-description", StatusIconDescription)
            .SetAttribute(7, "kind", Kind)
            .SetAttribute(8, "low-contrast", LowContrast)
            .SetAttribute(9, "open", Open)
            .SetAttributeNotNull(10, "timeout", Timeout)
            .SetAttribute(11, "subtitle", Subtitle)
            .SetAttributeNotNull(12, "styles", Styles)
            .SetAttributes(13, AdditionalAttributes)
            .SetContent(14, ChildContent)
            .CloseElement();
    }
}

