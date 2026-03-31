using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.Utilities;
using TownOfUs.Modifiers.Game.Alliance;
using UnityEngine;

namespace TownOfUs.Options.Modifiers.Alliance;

public sealed class LoversOptions : AbstractOptionGroup<LoverModifier>
{
    public override Func<bool> GroupVisible => () => OptionGroupSingleton<RoleOptions>.Instance.IsClassicRoleAssignment;
    public override string GroupName => TouLocale.Get("TouModifierLovers", "Lovers");
    public override uint GroupPriority => 12;
    public override Color GroupColor => TownOfUsColors.Lover;

    [ModdedToggleOption("両方の恋人が同時に死亡・蘇生する")]
    public bool BothLoversDie { get; set; } = true;

    [ModdedNumberOption("別のキラーと恋に落ちる確率", 0, 100, 10f, MiraNumberSuffixes.Percent)]
    public float LovingImpPercent { get; set; } = 20;

    [ModdedToggleOption("ニュートラル役職も恋人になれる")]
    public bool NeutralLovers { get; set; } = true;

    [ModdedToggleOption("恋人は同じ陣営の仲間をキルできる")]
    public bool LoverKillTeammates { get; set; } = false;

    [ModdedToggleOption("恋人同士でキルし合える")]
    public bool LoversKillEachOther { get; set; } = true;
}