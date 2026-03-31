using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.Utilities;
using TownOfUs.Modifiers.Game.Crewmate;
using UnityEngine;

namespace TownOfUs.Options.Modifiers.Crewmate;

public sealed class ScientistOptions : AbstractOptionGroup<ScientistModifier>
{
    public override Func<bool> GroupVisible => () => OptionGroupSingleton<RoleOptions>.Instance.IsClassicRoleAssignment;
    public override string GroupName => TouLocale.Get("TouModifierScientist", "Scientist");
    public override uint GroupPriority => 26;
    public override Color GroupColor => TownOfUsColors.Scientist;

    [ModdedToggleOption("バイタル使用中に移動可能")]
    public bool MoveWithMenu { get; set; } = true;

    [ModdedNumberOption("初期チャージ", 0f, 30f, 2.5f, MiraNumberSuffixes.Seconds)]
    public float StartingCharge { get; set; } = 20f;

    [ModdedNumberOption("各ラウンドごとのチャージ量", 0f, 30f, 2.5f, MiraNumberSuffixes.Seconds)]
    public float RoundCharge { get; set; } = 15f;

    [ModdedNumberOption("タスク完了ごとのチャージ量", 0f, 30f, 2.5f, MiraNumberSuffixes.Seconds)]
    public float TaskCharge { get; set; } = 10f;

    [ModdedNumberOption("バイタル表示のクールダウン", 0f, 30f, 5f, MiraNumberSuffixes.Seconds)]
    public float DisplayCooldown { get; set; } = 15f;

    [ModdedNumberOption("バイタル表示の最大時間", 0f, 30f, 5f, MiraNumberSuffixes.Seconds, zeroInfinity: true)]
    public float DisplayDuration { get; set; } = 15f;
}