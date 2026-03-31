using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.Utilities;
using TownOfUs.Modifiers.Game.Universal;
using UnityEngine;

namespace TownOfUs.Options.Modifiers.Universal;

public sealed class ButtonBarryOptions : AbstractOptionGroup<ButtonBarryModifier>
{
    public override Func<bool> GroupVisible => () => OptionGroupSingleton<RoleOptions>.Instance.IsClassicRoleAssignment;
    public override string GroupName => TouLocale.Get("TouModifierButtonBarry", "Button Barry");
    public override uint GroupPriority => 30;
    public override Color GroupColor => TownOfUsColors.ButtonBarry;

    [ModdedNumberOption("ボタンのクールダウン", 2.5f, 60f, 2.5f, MiraNumberSuffixes.Seconds)]
    public float Cooldown { get; set; } = 30f;

    [ModdedNumberOption("最大使用回数", 1f, 3f, 1f, MiraNumberSuffixes.None, "0")]
    public float MaxNumButtons { get; set; } = 1f;

    [ModdedToggleOption("サボタージュを無視する")]
    public bool IgnoreSabo { get; set; } = true;

    [ModdedToggleOption("第1ラウンドでの使用を許可")]
    public bool FirstRoundUse { get; set; } = false;
}