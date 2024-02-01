using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;

public class ActionableNotificationContext
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

public class CdsActionableNotification : BaseComponent<ActionableNotificationContext>
{
    /// <summary>
    /// Inline notification type.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Inline { get; set; }

    /// <summary>
    /// Pass in the action button label that will be rendered within the ActionableNotification.
    /// </summary>
    [Parameter]
    public string? ActionButtonLabel { get; set; }

    /// <summary>
    /// Specify if pressing the escape key should close notifications
    /// <para><b>DefaultValue : true</b></para>
    /// </summary>
    [Parameter]
    public bool? CloseOnEscape { get; set; }

    /// <summary>
    /// Specify if focus should be moved to the component when the notification contains actions
    /// <para><b>DefaultValue : true</b></para>
    /// </summary>
    [Parameter]
    public bool? HasFocus { get; set; }

    /// <summary>
    /// The caption.
    /// </summary>
    [Parameter]
    public string? Caption { get; set; }

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
            .OpenElementAnd(0, "cds-actionable-notification")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "tabindex", TabIndex)
            .SetAttributeNotNull(4, "role", Role)
            .SetAttributeNotNull(5, "aria-label", AriaLabel)
            .SetAttributeNotNull(6, "inline", Inline)
            .SetAttributeNotNull(7, "action-button-label", ActionButtonLabel)
            .SetAttributeNotNull(8, "close-on-escape", CloseOnEscape)
            .SetAttributeNotNull(9, "has-focus", HasFocus)
            .SetAttributeNotNull(10, "caption", Caption)
            .SetAttributeNotNull(11, "hide-close-button", HideCloseButton)
            .SetAttributeNotNull(12, "status-icon-description", StatusIconDescription)
            .SetAttribute(13, "kind", Kind)
            .SetAttributeNotNull(14, "low-contrast", LowContrast)
            .SetAttributeNotNull(15, "open", Open)
            .SetAttributeNotNull(16, "timeout", Timeout)
            .SetAttributeNotNull(17, "subtitle", Subtitle)
            .SetAttributeNotNull(18, "styles", Styles)
            .SetAttributes(19, AdditionalAttributes)
            .SetContent(20, ChildContent, new())
            .CloseElement();
    }
}

