using System.ComponentModel;

namespace CarbonBlazor;

/// <summary>
/// Notification kinds.
/// </summary>
public enum NOTIFICATION_KIND
{
    [Description("success")]
    SUCCESS,

    [Description("info")]
    INFO,

    [Description("info-square")]
    INFO_SQUARE,

    [Description("warning")]
    WARNING,

    [Description("warning-alt")]
    WARNING_ALT,

    [Description("error")]
    ERROR,
}