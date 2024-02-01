using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsModal : BaseComponent
{
    /// <summary>
    /// Specify whether the Modal is displaying an alert, error or warning.
    /// Should go hand in hand with the danger prop.
    /// </summary>
    [Parameter]
    public bool Alert { get; set; }

    /// <summary>
    /// The additional CSS class names for the container &lt;div&gt; of the element.
    /// </summary>
    [Parameter]
    public string? ContainerClass { get; set; }

    /// <summary>
    /// Specify whether or not the Modal content should have any inner padding.
    /// </summary>
    [Parameter]
    public bool FullWidth { get; set; }

    /// <summary>
    /// Specify whether the modal contains scrolling content
    /// </summary>
    [Parameter]
    public bool HasScrollingContent { get; set; }

    /// <summary>
    /// `true` if the modal should be open.
    /// </summary>
    [Parameter]
    public bool Open { get; set; }

    /// <summary>
    /// Modal size.
    /// </summary>
    [Parameter]
    public MODAL_SIZE Size { get; set; } = MODAL_SIZE.MD;

    /// <summary>
    /// Prevent closing on click outside of modal
    /// </summary>
    [Parameter]
    public bool PreventCloseOnClickOutside { get; set; }

    /// <summary>
    /// Prevent the modal from closing after clicking the close button
    /// </summary>
    [Parameter]
    public bool PreventClose { get; set; }

    [Parameter]
    public string? Styles { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder
            .OpenElementAnd(0, "cds-modal")
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "role", Role)
            .SetAttributeNotNull(4, "aria-label", AriaLabel)
            .SetAttribute(5, "alert", Alert)
            .SetAttribute(6, "container-class", ContainerClass)
            .SetAttribute(7, "full-width", FullWidth)
            .SetAttribute(8, "has-scrolling-content", HasScrollingContent)
            .SetAttribute(9, "open", Open)
            .SetAttribute(10, "size", Size)
            .SetAttribute(11, "prevent-close-on-click-outside", PreventCloseOnClickOutside)
            .SetAttribute(12, "prevent-close", PreventClose)
            .SetAttributeNotNull(13, "styles", Styles)
            .SetAttributes(14, AdditionalAttributes)
            .SetContent(15, ChildContent)
            .CloseElement();
    }
}

