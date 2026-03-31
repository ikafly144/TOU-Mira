using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.Utilities;
using UnityEngine;

namespace TownOfUs.Options.Modifiers;

public sealed class AllianceModifierOptions : AbstractOptionGroup
{
    public override string GroupName => "同盟モディファイア";
    public override Func<bool> GroupVisible => () => OptionGroupSingleton<RoleOptions>.Instance.IsClassicRoleAssignment;
    public override Color GroupColor => Color.white;
    public override bool ShowInModifiersMenu => true;
    public override uint GroupPriority => 0;

    [ModdedNumberOption("クルーポスターの出現率", 0, 100, 10f, MiraNumberSuffixes.Percent)]
    public float CrewpostorChance { get; set; } = 0;

    [ModdedNumberOption("エゴティストの出現率", 0, 100f, 10f, MiraNumberSuffixes.Percent)]
    public float EgotistChance { get; set; } = 0;

    [ModdedNumberOption("恋人の出現率", 0, 100, 10f, MiraNumberSuffixes.Percent)]
    public float LoversChance { get; set; } = 0;
}