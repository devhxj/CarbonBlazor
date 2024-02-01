using System.ComponentModel;

namespace CarbonBlazor;

public enum INLINE_LOADING_STATE
{
    [Description("inactive")]
    INACTIVE,

    [Description("active")]
    ACTIVE,

    [Description("finished")]
    FINISHED,

    [Description("error")]
    ERROR,
}

