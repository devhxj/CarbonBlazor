using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
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

public class CdsInlineNotification : CdsComponentBase<InlineNotificationContext>, IDisposable
{
    EditContext? _previousEditContext;
    readonly EventHandler<ValidationStateChangedEventArgs> _validationStateChangedHandler;

    [Parameter]
    public object? Model { get; set; }

    [CascadingParameter]
    private EditContext? CurrentEditContext { get; set; }

    public CdsInlineNotification() : base()
    {
        _validationStateChangedHandler = delegate
        {
            StateHasChanged();
        };
    }

    protected override void OnParametersSet()
    {
        if (CurrentEditContext is not null && CurrentEditContext != _previousEditContext)
        {
            DetachValidationStateChangedListener();
            CurrentEditContext.OnValidationStateChanged += _validationStateChangedHandler;
            _previousEditContext = CurrentEditContext;
        }
    }

    void IDisposable.Dispose()
    {
        DetachValidationStateChangedListener();
    }

    private void DetachValidationStateChangedListener()
    {
        if (_previousEditContext != null)
        {
            _previousEditContext.OnValidationStateChanged -= _validationStateChangedHandler;
        }
    }

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
    public NOTIFICATION_KIND? Kind { get; set; }

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
        var kind = Kind;
        var subtitle = Subtitle;
        var open = Open;
        if (CurrentEditContext is not null)
        {
            var messages = Model is null
                ? CurrentEditContext.GetValidationMessages()
                : CurrentEditContext.GetValidationMessages(new FieldIdentifier(Model, string.Empty));

            open = messages.Any();
            if (open == true)
            {
                subtitle ??= string.Join(" ", messages);
                kind ??= NOTIFICATION_KIND.ERROR;
            }
        }

        builder
            .OpenElementAnd(0, "cds-inline-notification")
            .SetAttributes(1, AdditionalAttributes)
            .SetAttribute(2, "id", Id)
            .SetAttributeNotNull(3, "title", Title)
            .SetAttributeNotNull(4, "tabindex", TabIndex)
            .SetAttributeNotNull(5, "role", Role)
            .SetAttributeNotNull(6, "aria-label", AriaLabel)
            .SetAttributeNotNull(7, "hide-close-button", HideCloseButton)
            .SetAttributeNotNull(8, "status-icon-description", StatusIconDescription)
            .SetAttribute(9, "kind", kind)
            .SetAttributeNotNull(10, "low-contrast", LowContrast)
            .SetAttributeNotNull(11, "open", open)
            .SetAttributeNotNull(12, "timeout", Timeout)
            .SetAttributeNotNull(13, "subtitle", subtitle)
            .SetAttributeNotNull(14, "styles", Styles)
            .SetReferenceCapture(15, CaptureReference)
            .SetContent(16, ChildContent, new())
            .CloseElement();
    }
}

