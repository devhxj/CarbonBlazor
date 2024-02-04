using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsModal : CdsComponentBase
{
    /// <summary>
    /// Specify whether the Modal is displaying an alert, error or warning.
    /// Should go hand in hand with the danger prop.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Alert { get; set; }

    /// <summary>
    /// The additional CSS class names for the container &lt;div&gt; of the element.
    /// </summary>
    [Parameter]
    public string? ContainerClass { get; set; }

    /// <summary>
    /// Specify whether or not the Modal content should have any inner padding.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? FullWidth { get; set; }

    /// <summary>
    /// Specify whether the modal contains scrolling content
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? HasScrollingContent { get; set; }

    /// <summary>
    /// `true` if the modal should be open.
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? Open { get; set; }

    /// <summary>
    /// Modal size.
    /// <para><b>DefaultValue : "md"</b></para>
    /// </summary>
    [Parameter]
    public MODAL_SIZE Size { get; set; } = MODAL_SIZE.MD;

    /// <summary>
    /// Prevent closing on click outside of modal
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? PreventCloseOnClickOutside { get; set; }

    /// <summary>
    /// Prevent the modal from closing after clicking the close button
    /// <para><b>DefaultValue : false</b></para>
    /// </summary>
    [Parameter]
    public bool? PreventClose { get; set; }

    /// <summary>
    /// <para><b>DefaultValue : "styles"</b></para>
    /// </summary>
    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-modal")
            .SetAttributes(1, AdditionalAttributes)
            .SetAttribute(2, "id", Id)
            .SetAttributeNotNull(3, "title", Title)
            .SetAttributeNotNull(4, "tabindex", TabIndex)
            .SetAttributeNotNull(5, "role", Role)
            .SetAttributeNotNull(6, "aria-label", AriaLabel)
            .SetAttribute(7, "hidden")
            .SetAttributeNotNull(8, "alert", Alert)
            .SetAttributeNotNull(9, "container-class", ContainerClass)
            .SetAttributeNotNull(10, "full-width", FullWidth)
            .SetAttributeNotNull(11, "has-scrolling-content", HasScrollingContent)
            .SetAttributeNotNull(12, "open", Open)
            .SetAttribute(13, "size", Size)
            .SetAttributeNotNull(14, "prevent-close-on-click-outside", PreventCloseOnClickOutside)
            .SetAttributeNotNull(15, "prevent-close", PreventClose)
            .SetAttributeNotNull(16, "styles", Styles)
            .SetReferenceCapture(17, CaptureReference)
            .SetContent(18, ChildContent)
            .CloseElement();
    }
}

