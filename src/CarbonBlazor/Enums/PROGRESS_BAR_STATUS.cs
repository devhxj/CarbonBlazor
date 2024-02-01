using System.ComponentModel;

namespace CarbonBlazor;

public enum PROGRESS_BAR_STATUS
{
    [Description("active")]
    ACTIVE,

    [Description("finished")]
    FINISHED,

    [Description("error")]
    ERROR,
}

