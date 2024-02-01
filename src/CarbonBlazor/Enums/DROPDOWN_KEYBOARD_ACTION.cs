using System.ComponentModel;

namespace CarbonBlazor;

public enum DROPDOWN_KEYBOARD_ACTION
{
    [Description("none")]
    NONE,

    [Description("closing")]
    CLOSING,

    [Description("navigating")]
    NAVIGATING,

    [Description("triggering")]
    TRIGGERING,
}

