using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.Utilities;
using TownOfUs.Modifiers.Game.Universal;
using UnityEngine;

namespace TownOfUs.Options.Modifiers.Universal;

public sealed class SatelliteOptions : AbstractOptionGroup<SatelliteModifier>
{
    public override Func<bool> GroupVisible => () => OptionGroupSingleton<RoleOptions>.Instance.IsClassicRoleAssignment;
    public override string GroupName => TouLocale.Get("TouModifierSatellite", "Satellite");
    public override uint GroupPriority => 34;
    public override Color GroupColor => TownOfUsColors.Satellite;

    [ModdedNumberOption("ボタンのクールダウン", 5f, 60f, 2.5f, MiraNumberSuffixes.Seconds)]
    public float Cooldown { get; set; } = 15f;

    [ModdedNumberOption("最大使用回数", 1f, 15f, 1f, MiraNumberSuffixes.None, "0")]
    public float MaxNumCast { get; set; } = 5f;

    [ModdedToggleOption("1ラウンドにつき1回まで")]
    public bool OneUsePerRound { get; set; } = true;

    [ModdedToggleOption("第1ラウンドでの使用を許可")]
    public bool FirstRoundUse { get; set; } = true;
}