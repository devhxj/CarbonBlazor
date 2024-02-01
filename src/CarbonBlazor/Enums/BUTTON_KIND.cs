using System.ComponentModel;

namespace CarbonBlazor;

public enum BUTTON_KIND
{
    [Description("primary")]
    PRIMARY,

    [Description("secondary")]
    SECONDARY,

    [Description("tertiary")]
    TERTIARY,

    [Description("ghost")]
    GHOST,

    [Description("danger")]
    DANGER,

    [Description("danger-primary")]
    DANGER_PRIMARY,

    [Description("danger-tertiary")]
    DANGER_TERTIARY,

    [Description("danger-ghost")]
    DANGER_GHOST,
}

