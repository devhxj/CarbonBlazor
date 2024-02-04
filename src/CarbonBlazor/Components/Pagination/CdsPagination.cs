using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;

public class PaginationContext
{
    /// <summary>
    /// Where to put in the `&lt;page-sizes-select&gt;`.
    /// </summary>
    public string PageSizesSelectSlot = "page-sizes-select";
}

public class CdsPagination : CdsComponentBase<PaginationContext>
{
    /// <summary>
    /// The assistive text for the button to go to previous page.
    /// <para><b>DefaultValue : "Previous page"</b></para>
    /// </summary>
    [Parameter]
    public string? BackwardText { get; set; }

    /// <summary>
    /// The current page
    /// <para><b>DefaultValue : 1</b></para>
    /// </summary>
    [Parameter]
    public int? Page { get; set; }

    /// <summary>
    /// The formatter for the assistive text for screen readers to announce.
    /// Should be changed upon the locale the UI is rendered with.
    /// <para><b>Type : ({ count }: { count: any; }) => string</b></para>
    /// <para><b>DefaultValue : "({ count }) =>\n    `Page number, of ${count} page${count <= 1 ? '' : 's'}`"</b></para>
    /// </summary>
    [Parameter]
    public string? FormatLabelText { get; set; }

    /// <summary>
    /// The formatter, used with determinate the total pages. Should be changed upon the locale the UI is rendered with.
    /// <para><b>Type : ({ start, end, count }: { start: any; end: any; count: any; }) => string</b></para>
    /// <para><b>DefaultValue : "({ start, end, count }) =>\n    `${start}–${end} of ${count} item${count <= 1 ? '' : 's'}`"</b></para>
    /// </summary>
    [Parameter]
    public string? FormatStatusWithDeterminateTotal { get; set; }

    /// <summary>
    /// The formatter, used with indeterminate the total pages. Should be changed upon the locale the UI is rendered with.
    /// <para><b>Type : ({ start, end, count }: { start: any; end: any; count: any; }) => string</b></para>
    /// <para><b>DefaultValue : "({ start, end, count }) =>\n    end == null\n      ? `Item ${start}–`\n      : `${start}–${end} item${count <= 1 ? '' : 's'}`"</b></para>
    /// </summary>
    [Parameter]
    public string? FormatStatusWithIndeterminateTotal { get; set; }

    /// <summary>
    /// The formatter for the text next to the select box. Should be changed upon the locale the UI is rendered with.
    /// <para><b>Type : ({ count }: { count: any; }) => string</b></para>
    /// <para><b>DefaultValue : "({ count }) =>\n    this.pagesUnknown || !this.totalItems\n      ? `page`\n      : `of ${count} page${count <= 1 ? '' : 's'}`"</b></para>
    /// </summary>
    [Parameter]
    public string? FormatSupplementalText { get; set; }

    /// <summary>
    /// `true` to explicitly state that user is at the last page.
    /// </summary>
    [Parameter]
    public bool? IsLastPage { get; set; }

    /// <summary>
    /// The translatable text indicating the number of items per page.
    /// <para><b>DefaultValue : "Items per page:"</b></para>
    /// </summary>
    [Parameter]
    public string? ItemsPerPageText { get; set; }

    /// <summary>
    /// `true` if the pagination UI should be disabled.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Disabled { get; set; }

    /// <summary>
    /// The assistive text for the button to go to next page.
    /// <para><b>DefaultValue : "Next page"</b></para>
    /// </summary>
    [Parameter]
    public string? ForwardText { get; set; }

    /// <summary>
    /// true if the select box to change the page should be disabled.
    /// </summary>
    [Parameter]
    public string? PageInputDisabled { get; set; }

    /// <summary>
    /// Number of items per page.
    /// <para><b>DefaultValue : 10</b></para>
    /// </summary>
    [Parameter]
    public int? PageSize { get; set; }

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
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? PagesUnknown { get; set; }

    /// <summary>
    /// Specify the size of the Pagination.
    /// <para><b>DefaultValue : "md"</b></para>
    /// </summary>
    [Parameter]
    public PAGINATION_SIZE Size { get; set; } = PAGINATION_SIZE.MD;

    /// <summary>
    /// The row number where current page start with, index that starts with zero.
    /// <para><b>DefaultValue : 0</b></para>
    /// </summary>
    [Parameter]
    public int? Start { get; set; }

    /// <summary>
    /// The number of total items.
    /// </summary>
    [Parameter]
    public int? TotalItems { get; set; }

    /// <summary>
    /// The number of total pages.
    /// <para><b>DefaultValue : 1</b></para>
    /// </summary>
    [Parameter]
    public int? TotalPages { get; set; }

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
            .OpenElementAnd(0, "cds-pagination")
            .SetAttributes(1, AdditionalAttributes)
            .SetAttribute(2, "id", Id)
            .SetAttributeNotNull(3, "title", Title)
            .SetAttributeNotNull(4, "tabindex", TabIndex)
            .SetAttributeNotNull(5, "role", Role)
            .SetAttributeNotNull(6, "aria-label", AriaLabel)
            .SetAttributeNotNull(7, "backward-text", BackwardText)
            .SetAttributeNotNull(8, "page", Page)
            .SetAttributeNotNull(9, "formatlabeltext", FormatLabelText)
            .SetAttributeNotNull(10, "formatstatuswithdeterminatetotal", FormatStatusWithDeterminateTotal)
            .SetAttributeNotNull(11, "formatstatuswithindeterminatetotal", FormatStatusWithIndeterminateTotal)
            .SetAttributeNotNull(12, "formatsupplementaltext", FormatSupplementalText)
            .SetAttributeNotNull(13, "is-last-page", IsLastPage)
            .SetAttributeNotNull(14, "items-per-page-text", ItemsPerPageText)
            .SetAttributeNotNull(15, "disabled", Disabled)
            .SetAttributeNotNull(16, "forward-text", ForwardText)
            .SetAttributeNotNull(17, "page-input-disabled", PageInputDisabled)
            .SetAttributeNotNull(18, "page-size", PageSize)
            .SetAttributeNotNull(19, "page-size-input-disabled", PageSizeInputDisabled)
            .SetAttributeNotNull(20, "page-size-label-text", PageSizeLabelText)
            .SetAttributeNotNull(21, "pages-unknown", PagesUnknown)
            .SetAttribute(22, "size", Size)
            .SetAttributeNotNull(23, "start", Start)
            .SetAttributeNotNull(24, "total-items", TotalItems)
            .SetAttributeNotNull(25, "totalPages", TotalPages)
            .SetAttributeNotNull(26, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(27, "styles", Styles)
            .SetReferenceCapture(28, CaptureReference)
            .SetContent(29, ChildContent, new())
            .CloseElement();
    }
}

