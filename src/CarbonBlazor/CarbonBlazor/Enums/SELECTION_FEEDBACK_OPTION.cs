using System.ComponentModel;

namespace CarbonBlazor;

public enum SELECTION_FEEDBACK_OPTION
{
    [Description("fixed")]
    FIXED,

    [Description("top")]
    TOP,

    [Description("top-after-reopen")]
    TOP_AFTER_REOPEN,
}

