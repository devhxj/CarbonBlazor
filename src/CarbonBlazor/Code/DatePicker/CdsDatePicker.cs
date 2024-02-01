using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsDatePicker : BaseComponent
{
    /// <summary>
    /// The Flatpickr instance.
    /// <para><b>Type : Instance | null</b></para>
    /// </summary>
    [Parameter]
    public ElementRef? Calendar { get; set; }

    /// <summary>
    /// flatpickr prop passthrough. Allows the user to enter a date directly into the input field
    /// </summary>
    [Parameter]
    public bool AllowInput { get; set; } = true;

    /// <summary>
    /// flatpickr prop passthrough. Controls whether the calendar dropdown closes upon selection.
    /// </summary>
    [Parameter]
    public bool CloseOnSelect { get; set; } = true;

    /// <summary>
    /// The date format to let Flatpickr use.
    /// </summary>
    [Parameter]
    public string? DateFormat { get; set; }

    /// <summary>
    /// Controls the disabled state of the input
    /// </summary>
    [Parameter]
    public bool Disabled { get; set; }

    /// <summary>
    /// The localization data.
    /// </summary>
    [Parameter]
    public CultureInfo? Locale { get; set; }

    /// <summary>
    /// The date range that a user can pick in calendar dropdown.
    /// </summary>
    [Parameter]
    public string? EnabledRange { get; set; }

    /// <summary>
    /// The minimum date that a user can start picking from.
    /// </summary>
    [Parameter]
    public string? MinDate { get; set; }

    /// <summary>
    /// The maximum date that a user can start picking from.
    /// </summary>
    [Parameter]
    public string? MaxDate { get; set; }

    /// <summary>
    /// Name for the input in the `FormData`
    /// </summary>
    [Parameter]
    public string? Name { get; set; }

    /// <summary>
    /// `true` if the date picker should be open.
    /// </summary>
    [Parameter]
    public bool Open { get; set; }

    /// <summary>
    /// Specify if the component should be read-only
    /// </summary>
    [Parameter]
    public bool Readonly { get; set; }

    /// <summary>
    /// The date(s) in ISO8601 format (date portion only), for range mode, '/' is used for separate start/end dates.
    /// </summary>
    [Parameter]
    public string? Value { get; set; }

    /// <summary>
    /// The CSS class applied to the "today" highlight if there are any dates selected.
    /// </summary>
    [Parameter]
    public string ClassNoBorder { get; set; } = "no-border";

    /// <summary>
    /// The default date format.
    /// </summary>
    [Parameter]
    public string DefaultDateFormat { get; set; } = "m/d/Y";

    /// <summary>
    /// The default localization data.
    /// </summary>
    [Parameter]
    public CultureInfo DefaultLocale { get; set; } = CultureInfo.CurrentCulture;

    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-date-picker")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttributeNotNull(5, "calendar", Calendar)
            .SetAttribute(6, "allow-input", AllowInput)
            .SetAttribute(7, "close-on-select", CloseOnSelect)
            .SetAttributeNotNull(8, "date-format", DateFormat)
            .SetAttribute(9, "disabled", Disabled)
            .SetAttributeNotNull(10, "locale", Locale)
            .SetAttributeNotNull(11, "enabled-range", EnabledRange)
            .SetAttributeNotNull(12, "min-date", MinDate)
            .SetAttributeNotNull(13, "max-date", MaxDate)
            .SetAttribute(14, "name", Name)
            .SetAttribute(15, "open", Open)
            .SetAttribute(16, "readonly", Readonly)
            .SetAttributeNotNull(17, "value", Value)
            .SetAttribute(18, "", ClassNoBorder)
            .SetAttribute(19, "", DefaultDateFormat)
            .SetAttribute(20, "", DefaultLocale)
            .SetAttributeNotNull(21, "styles", Styles)
            .SetAttributes(22, AdditionalAttributes)
            .SetContent(23, ChildContent)
            .CloseElement();
    }
}

