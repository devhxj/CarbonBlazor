using System.ComponentModel;

namespace CarbonBlazor;

public enum PROGRESS_STEP_STAT
{
    [Description("complete")]
    COMPLETE,

    [Description("current")]
    CURRENT,

    [Description("incomplete")]
    INCOMPLETE,

    [Description("invalid")]
    INVALID,
}

