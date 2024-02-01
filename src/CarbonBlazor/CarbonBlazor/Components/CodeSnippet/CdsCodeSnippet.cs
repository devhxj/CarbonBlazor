using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsCodeSnippet : BaseComponent
{
    /// <summary>
    /// Optional text to copy. If not specified, the `children` node's `innerText`
    /// will be used as the copy value.
    /// </summary>
    [Parameter]
    public string? CopyText { get; set; }

    /// <summary>
    /// `true` if the button should be disabled.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Disabled { get; set; }

    /// <summary>
    /// Specify the string displayed when the snippet is copied
    /// <para><b>DefaultValue : "Copied!"</b></para>
    /// </summary>
    [Parameter]
    public string? Feedback { get; set; }

    /// <summary>
    /// Specify the time it takes for the feedback message to timeout
    /// <para><b>DefaultValue : 2000</b></para>
    /// </summary>
    [Parameter]
    public int? FeedbackTimeout { get; set; }

    /// <summary>
    /// Specify whether or not a copy button should be used/rendered.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? HideCopyButton { get; set; }

    /// <summary>
    /// Specify the maximum number of rows to be shown when in collapsed view
    /// <para><b>DefaultValue : 15</b></para>
    /// </summary>
    [Parameter]
    public int? MaxCollapsedNumberOfRows { get; set; }

    /// <summary>
    /// Specify the maximum number of rows to be shown when in expanded view
    /// <para><b>DefaultValue : 0</b></para>
    /// </summary>
    [Parameter]
    public int? MaxExpandedNumberOfRows { get; set; }

    /// <summary>
    /// Specify the minimum number of rows to be shown when in collapsed view
    /// <para><b>DefaultValue : 3</b></para>
    /// </summary>
    [Parameter]
    public int? MinCollapsedNumberOfRows { get; set; }

    /// <summary>
    /// Specify the minimum number of rows to be shown when in expanded view
    /// <para><b>DefaultValue : 16</b></para>
    /// </summary>
    [Parameter]
    public int? MinExpandedNumberOfRows { get; set; }

    /// <summary>
    /// Specify a string that is displayed when the Code Snippet has been
    /// interacted with to show less lines
    /// <para><b>DefaultValue : "Show less"</b></para>
    /// </summary>
    [Parameter]
    public string? ShowLessText { get; set; }

    /// <summary>
    /// Specify a string that is displayed when the Code Snippet text is more
    /// than 15 lines
    /// <para><b>DefaultValue : "Show more"</b></para>
    /// </summary>
    [Parameter]
    public string? ShowMoreText { get; set; }

    /// <summary>
    /// Tooltip content for the copy button.
    /// <para><b>DefaultValue : "Copy to clipboard"</b></para>
    /// </summary>
    [Parameter]
    public string? TooltipContent { get; set; }

    /// <summary>
    /// `true` if the button should be disabled.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? WrapText { get; set; }

    /// <summary>
    /// The type of code snippet.
    /// <para><b>DefaultValue : "single"</b></para>
    /// </summary>
    [Parameter]
    public CODE_SNIPPET_TYPE Type { get; set; } = CODE_SNIPPET_TYPE.SINGLE;

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
            .OpenElementAnd(0, "cds-code-snippet")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "tabindex", TabIndex)
            .SetAttributeNotNull(4, "role", Role)
            .SetAttributeNotNull(5, "aria-label", AriaLabel)
            .SetAttributeNotNull(6, "copy-text", CopyText)
            .SetAttributeNotNull(7, "disabled", Disabled)
            .SetAttributeNotNull(8, "feedback", Feedback)
            .SetAttributeNotNull(9, "feedback-timeout", FeedbackTimeout)
            .SetAttributeNotNull(10, "hide-copy-button", HideCopyButton)
            .SetAttributeNotNull(11, "maxCollapsedNumberOfRows", MaxCollapsedNumberOfRows)
            .SetAttributeNotNull(12, "maxExpandedNumberOfRows", MaxExpandedNumberOfRows)
            .SetAttributeNotNull(13, "minCollapsedNumberOfRows", MinCollapsedNumberOfRows)
            .SetAttributeNotNull(14, "minExpandedNumberOfRows", MinExpandedNumberOfRows)
            .SetAttributeNotNull(15, "show-less-text", ShowLessText)
            .SetAttributeNotNull(16, "show-more-text", ShowMoreText)
            .SetAttributeNotNull(17, "tooltip-content", TooltipContent)
            .SetAttributeNotNull(18, "wrap-text", WrapText)
            .SetAttribute(19, "type", Type)
            .SetAttributeNotNull(20, "shadowRootOptions", ShadowRootOptions)
            .SetAttributeNotNull(21, "styles", Styles)
            .SetAttributes(22, AdditionalAttributes)
            .SetContent(23, ChildContent)
            .CloseElement();
    }
}

