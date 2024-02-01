using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;

public class InlineNotificationContext
{
    /// <summary>
    /// The subtitle.
    /// </summary>
    public string SubtitleSlot = "subtitle";

    /// <summary>
    /// The title.
    /// </summary>
    public string TitleSlot = "title";
}

public class CdsInlineNotification : BaseComponent<InlineNotificationContext>
{
    /// <summary>
    /// `true` to hide the close button.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? HideCloseButton { get; set; }

    /// <summary>
    /// Provide a description for "status" icon that can be read by screen readers
    /// </summary>
    [Parameter]
    public string? StatusIconDescription { get; set; }

    /// <summary>
    /// Notification kind.
    /// <para><b>DefaultValue : "success"</b></para>
    /// </summary>
    [Parameter]
    public NOTIFICATION_KIND Kind { get; set; } = NOTIFICATION_KIND.SUCCESS;

    /// <summary>
    /// Low contrast mode
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? LowContrast { get; set; }

    /// <summary>
    /// `true` if the notification should be open.
    /// <para><b>DefaultValue : true</b></para>
    /// </summary>
    [Parameter]
    public bool? Open { get; set; }

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

    /// <summary>
    /// <para><b>DefaultValue : "styles"</b></para>
    /// </summary>
    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-inline-notification")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "tabindex", TabIndex)
            .SetAttributeNotNull(4, "role", Role)
            .SetAttributeNotNull(5, "aria-label", AriaLabel)
            .SetAttributeNotNull(6, "hide-close-button", HideCloseButton)
            .SetAttributeNotNull(7, "status-icon-description", StatusIconDescription)
            .SetAttribute(8, "kind", Kind)
            .SetAttributeNotNull(9, "low-contrast", LowContrast)
            .SetAttributeNotNull(10, "open", Open)
            .SetAttributeNotNull(11, "timeout", Timeout)
            .SetAttributeNotNull(12, "subtitle", Subtitle)
            .SetAttributeNotNull(13, "styles", Styles)
            .SetAttributes(14, AdditionalAttributes)
            .SetContent(15, ChildContent, new())
            .CloseElement();
    }
}

