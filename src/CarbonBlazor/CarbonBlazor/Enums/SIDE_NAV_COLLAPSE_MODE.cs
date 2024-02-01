using System.ComponentModel;

namespace CarbonBlazor;

public enum SIDE_NAV_COLLAPSE_MODE
{
    [Description("fixed")]
    FIXED,

    [Description("rail")]
    RAIL,

    [Description("responsive")]
    RESPONSIVE,
}

public enum SIDE_NAV_USAGE_MODE
{
    [Description("")]
    REGULAR,

    [Description("header-nav")]
    HEADER_NAV,
}

