using MiraAPI.GameOptions;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Utilities;
using TownOfUs.Modifiers.Game.Alliance;
using UnityEngine;

namespace TownOfUs.Options.Modifiers.Alliance;

public sealed class EgotistOptions : AbstractOptionGroup<EgotistModifier>
{
    public override Func<bool> GroupVisible => () => OptionGroupSingleton<RoleOptions>.Instance.IsClassicRoleAssignment;
    public override string GroupName => TouLocale.Get("TouModifierEgotist", "Egotist");
    public override uint GroupPriority => 11;
    public override Color GroupColor => TownOfUsColors.Egotist;

    public ModdedToggleOption EgotistMustSurvive { get; set; } = new("エゴティストは勝利のために生存が必須", false);

    public ModdedToggleOption EgotistSpeedsUp { get; set; } = new("エゴティストがゲームを高速化する", true);

    public ModdedNumberOption RoundsToApplyEffects { get; set; } = new("速度/クールダウン変更に必要なラウンド数", 1f, 1f, 5f, 1f,
        MiraNumberSuffixes.None)
    {
        Visible = () => OptionGroupSingleton<EgotistOptions>.Instance.EgotistSpeedsUp
    };

    public ModdedNumberOption SpeedMultiplier { get; set; } = new("速度の加算量", 0.1f, 0f, 1.5f, 0.05f,
        MiraNumberSuffixes.Multiplier, "0.000")
    {
        Visible = () => OptionGroupSingleton<EgotistOptions>.Instance.EgotistSpeedsUp
    };

    public ModdedNumberOption CooldowmOffset { get; set; } = new("クールダウンの短縮量", 1.5f, 0f, 5f, 0.1f,
        MiraNumberSuffixes.Seconds, "0.00")
    {
        Visible = () => OptionGroupSingleton<EgotistOptions>.Instance.EgotistSpeedsUp
    };
}