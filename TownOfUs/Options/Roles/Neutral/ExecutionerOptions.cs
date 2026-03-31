using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using TownOfUs.Roles.Neutral;

namespace TownOfUs.Options.Roles.Neutral;

public sealed class ExecutionerOptions : AbstractOptionGroup<ExecutionerRole>
{
    public override string GroupName => TouLocale.Get("TouRoleExecutioner", "Executioner");

    [ModdedEnumOption("TouOptionExecutionerBecomesTargetDeath", typeof(BecomeOptions), ["CrewmateKeyword", "TouRoleAmnesiac", "TouRoleSurvivor", "TouRoleMercenary", "TouRoleJester"])]
    public BecomeOptions OnTargetDeath { get; set; } = BecomeOptions.Jester;

    [ModdedToggleOption("エクセキューショナーはボタン使用可能")]
    public bool CanButton { get; set; } = true;

    [ModdedEnumOption("エクセキューショナー勝利時の挙動", typeof(ExeWinOptions), ["ゲーム終了", "退出して苦悶させる", "何もしない"])]
    public ExeWinOptions ExeWin { get; set; } = ExeWinOptions.Torments;
}

public enum ExeWinOptions
{
    EndsGame,
    Torments,
    Nothing
}