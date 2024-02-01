using System.Globalization;
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
    /// <para><b>DefaultValue : true</b></para>
    /// </summary>
    [Parameter]
    public bool? AllowInput { get; set; }

    /// <summary>
    /// flatpickr prop passthrough. Controls whether the calendar dropdown closes upon selection.
    /// <para><b>DefaultValue : true</b></para>
    /// </summary>
    [Parameter]
    public bool? CloseOnSelect { get; set; }

    /// <summary>
    /// The date format to let Flatpickr use.
    /// </summary>
    [Parameter]
    public string? DateFormat { get; set; }

    /// <summary>
    /// Controls the disabled state of the input
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Disabled { get; set; }

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
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Open { get; set; }

    /// <summary>
    /// Specify if the component should be read-only
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Readonly { get; set; }

    /// <summary>
    /// The date(s) in ISO8601 format (date portion only), for range mode, '/' is used for separate start/end dates.
    /// </summary>
    [Parameter]
    public string? Value { get; set; }

    /// <summary>
    /// The CSS class applied to the "today" highlight if there are any dates selected.
    /// <para><b>DefaultValue : "no-border"</b></para>
    /// </summary>
    [Parameter]
    public string? ClassNoBorder { get; set; }

    /// <summary>
    /// The default date format.
    /// <para><b>DefaultValue : "m/d/Y"</b></para>
    /// </summary>
    [Parameter]
    public string? DefaultDateFormat { get; set; }

    /// <summary>
    /// The default localization data.
    /// <para><b>DefaultValue : "default"</b></para>
    /// </summary>
    [Parameter]
    public CultureInfo? DefaultLocale { get; set; } = CultureInfo.CurrentCulture;

    /// <summary>
    /// <para><b>DefaultValue : "styles"</b></para>
    /// </summary>
    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-date-picker")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "tabindex", TabIndex)
            .SetAttributeNotNull(4, "role", Role)
            .SetAttributeNotNull(5, "aria-label", AriaLabel)
            .SetAttributeNotNull(6, "calendar", Calendar)
            .SetAttributeNotNull(7, "allow-input", AllowInput)
            .SetAttributeNotNull(8, "close-on-select", CloseOnSelect)
            .SetAttributeNotNull(9, "date-format", DateFormat)
            .SetAttributeNotNull(10, "disabled", Disabled)
            .SetAttributeNotNull(11, "locale", Locale)
            .SetAttributeNotNull(12, "enabled-range", EnabledRange)
            .SetAttributeNotNull(13, "min-date", MinDate)
            .SetAttributeNotNull(14, "max-date", MaxDate)
            .SetAttributeNotNull(15, "name", Name)
            .SetAttributeNotNull(16, "open", Open)
            .SetAttributeNotNull(17, "readonly", Readonly)
            .SetAttributeNotNull(18, "value", Value)
            .SetAttributeNotNull(19, "classnoborder", ClassNoBorder)
            .SetAttributeNotNull(20, "defaultdateformat", DefaultDateFormat)
            .SetAttribute(21, "", DefaultLocale)
            .SetAttributeNotNull(22, "styles", Styles)
            .SetAttributes(23, AdditionalAttributes)
            .SetContent(24, ChildContent)
            .CloseElement();
    }
}

