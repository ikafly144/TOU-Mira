using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;

namespace TownOfUs.Options;

public sealed class TaskTrackingOptions : AbstractOptionGroup
{
    public override Func<bool> GroupVisible => () => OptionGroupSingleton<RoleOptions>.Instance.IsClassicRoleAssignment;
    public override string GroupName => "タスク追跡";
    public override uint GroupPriority => 4;

    [ModdedToggleOption("ラウンド中にタスクを表示")]
    public bool ShowTaskRound { get; set; } = true;

    [ModdedToggleOption("会議中にタスクを表示")]
    public bool ShowTaskInMeetings { get; set; } = true;

    [ModdedToggleOption("死亡時にタスクを表示")]
    public bool ShowTaskDead { get; set; } = true;
}