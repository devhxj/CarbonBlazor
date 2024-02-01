using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsPagination : BaseComponent
{
    /// <summary>
    /// The assistive text for the button to go to previous page.
    /// </summary>
    [Parameter]
    public string BackwardText { get; set; } = "Previous page";

    /// <summary>
    /// The current page
    /// </summary>
    [Parameter]
    public int Page { get; set; } = 1;

    /// <summary>
    /// The formatter for the assistive text for screen readers to announce.
    /// Should be changed upon the locale the UI is rendered with.
    /// <para><b>Type : ({ count }: { count: any; }) => string</b></para>
    /// </summary>
    [Parameter]
    public string? FormatLabelText { get; set; } = "({ count }) =>\n    `Page number, of ${count} page${count <= 1 ? '' : 's'}`";

    /// <summary>
    /// The formatter, used with determinate the total pages. Should be changed upon the locale the UI is rendered with.
    /// <para><b>Type : ({ start, end, count }: { start: any; end: any; count: any; }) => string</b></para>
    /// </summary>
    [Parameter]
    public string? FormatStatusWithDeterminateTotal { get; set; } = "({ start, end, count }) =>\n    `${start}–${end} of ${count} item${count <= 1 ? '' : 's'}`";

    /// <summary>
    /// The formatter, used with indeterminate the total pages. Should be changed upon the locale the UI is rendered with.
    /// <para><b>Type : ({ start, end, count }: { start: any; end: any; count: any; }) => string</b></para>
    /// </summary>
    [Parameter]
    public string? FormatStatusWithIndeterminateTotal { get; set; } = "({ start, end, count }) =>\n    end == null\n      ? `Item ${start}–`\n      : `${start}–${end} item${count <= 1 ? '' : 's'}`";

    /// <summary>
    /// The formatter for the text next to the select box. Should be changed upon the locale the UI is rendered with.
    /// <para><b>Type : ({ count }: { count: any; }) => string</b></para>
    /// </summary>
    [Parameter]
    public string? FormatSupplementalText { get; set; } = "({ count }) =>\n    this.pagesUnknown || !this.totalItems\n      ? `page`\n      : `of ${count} page${count <= 1 ? '' : 's'}`";

    /// <summary>
    /// `true` to explicitly state that user is at the last page.
    /// </summary>
    [Parameter]
    public bool? IsLastPage { get; set; }

    /// <summary>
    /// The translatable text indicating the number of items per page.
    /// </summary>
    [Parameter]
    public string ItemsPerPageText { get; set; } = "Items per page:";

    /// <summary>
    /// `true` if the pagination UI should be disabled.
    /// </summary>
    [Parameter]
    public bool Disabled { get; set; }

    /// <summary>
    /// The assistive text for the button to go to next page.
    /// </summary>
    [Parameter]
    public string ForwardText { get; set; } = "Next page";

    /// <summary>
    /// true if the select box to change the page should be disabled.
    /// </summary>
    [Parameter]
    public string? PageInputDisabled { get; set; }

    /// <summary>
    /// Number of items per page.
    /// </summary>
    [Parameter]
    public int PageSize { get; set; } = 10;

    /// <summary>
    /// true if the select box to change the items per page should be disabled.
    /// </summary>
    [Parameter]
    public string? PageSizeInputDisabled { get; set; }

    /// <summary>
    /// The label text for the UI to select page size.
    /// </summary>
    [Parameter]
    public string? PageSizeLabelText { get; set; }

    /// <summary>
    /// true if the total number of items is unknown.
    /// </summary>
    [Parameter]
    public bool PagesUnknown { get; set; }

    /// <summary>
    /// Specify the size of the Pagination.
    /// </summary>
    [Parameter]
    public PAGINATION_SIZE Size { get; set; } = PAGINATION_SIZE.MD;

    /// <summary>
    /// The row number where current page start with, index that starts with zero.
    /// </summary>
    [Parameter]
    public int Start { get; set; } = 0;

    /// <summary>
    /// The number of total items.
    /// </summary>
    [Parameter]
    public int? TotalItems { get; set; }

    /// <summary>
    /// The number of total pages.
    /// </summary>
    [Parameter]
    public int TotalPages { get; set; } = 1;

    [Parameter]
    public ShadowRootOptions ShadowRootOptions { get; set; } = new ShadowRootOptions() {DelegatesFocus = true};

    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-pagination")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttribute(5, "backward-text", BackwardText)
            .SetAttribute(6, "page", Page)
            .SetAttribute(7, "", FormatLabelText)
            .SetAttribute(8, "", FormatStatusWithDeterminateTotal)
            .SetAttribute(9, "", FormatStatusWithIndeterminateTotal)
            .SetAttribute(10, "", FormatSupplementalText)
            .SetAttributeNotNull(11, "is-last-page", IsLastPage)
            .SetAttribute(12, "items-per-page-text", ItemsPerPageText)
            .SetAttribute(13, "disabled", Disabled)
            .SetAttribute(14, "forward-text", ForwardText)
            .SetAttributeNotNull(15, "page-input-disabled", PageInputDisabled)
            .SetAttribute(16, "page-size", PageSize)
            .SetAttributeNotNull(17, "page-size-input-disabled", PageSizeInputDisabled)
            .SetAttributeNotNull(18, "page-size-label-text", PageSizeLabelText)
            .SetAttribute(19, "pages-unknown", PagesUnknown)
            .SetAttribute(20, "size", Size)
            .SetAttribute(21, "start", Start)
            .SetAttributeNotNull(22, "total-items", TotalItems)
            .SetAttribute(23, "totalPages", TotalPages)
            .SetAttributeNotNull(24, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(25, "styles", Styles)
            .SetAttributes(26, AdditionalAttributes)
            .SetContent(27, ChildContent)
            .CloseElement();
    }
}

