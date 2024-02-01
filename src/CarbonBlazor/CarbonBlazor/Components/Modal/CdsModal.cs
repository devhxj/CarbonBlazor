using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CarbonBlazor;
public class CdsModal : BaseComponent
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
            .SetAttribute(1, "id", Id)
            .SetAttributeNotNull(2, "title", Title)
            .SetAttributeNotNull(3, "tabindex", TabIndex)
            .SetAttributeNotNull(4, "role", Role)
            .SetAttributeNotNull(5, "aria-label", AriaLabel)
            .SetAttribute(6, "hidden")
            .SetAttributeNotNull(7, "alert", Alert)
            .SetAttributeNotNull(8, "container-class", ContainerClass)
            .SetAttributeNotNull(9, "full-width", FullWidth)
            .SetAttributeNotNull(10, "has-scrolling-content", HasScrollingContent)
            .SetAttributeNotNull(11, "open", Open)
            .SetAttribute(12, "size", Size)
            .SetAttributeNotNull(13, "prevent-close-on-click-outside", PreventCloseOnClickOutside)
            .SetAttributeNotNull(14, "prevent-close", PreventClose)
            .SetAttributeNotNull(15, "styles", Styles)
            .SetAttributes(16, AdditionalAttributes)
            .SetContent(17, ChildContent)
            .CloseElement();
    }
}

