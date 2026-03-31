using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Utilities;
using UnityEngine;

namespace TownOfUs.Options.Modifiers;

public sealed class ImpostorModifierOptions : AbstractOptionGroup
{
    public override string GroupName => "インポスターモディファイア";
    public override Func<bool> GroupVisible => () => OptionGroupSingleton<RoleOptions>.Instance.IsClassicRoleAssignment;
    public override Color GroupColor => Palette.ImpostorRoleHeaderRed;
    public override bool ShowInModifiersMenu => true;
    public override uint GroupPriority => 3;

    [ModdedNumberOption("サーカムヴェントの数", 0, 5)]
    public float CircumventAmount { get; set; } = 0;

    public ModdedNumberOption CircumventChance { get; } =
        new("サーカムヴェントの出現率", 50f, 0, 100f, 10f, MiraNumberSuffixes.Percent)
        {
            Visible = () => OptionGroupSingleton<ImpostorModifierOptions>.Instance.CircumventAmount > 0
        };

    [ModdedNumberOption("デッドリークォータの数", 0, 5)]
    public float DeadlyQuotaAmount { get; set; } = 0;

    public ModdedNumberOption DeadlyQuotaChance { get; } =
        new("デッドリークォータの出現率", 50f, 0, 100f, 10f, MiraNumberSuffixes.Percent)
        {
            Visible = () => OptionGroupSingleton<ImpostorModifierOptions>.Instance.DeadlyQuotaAmount > 0
        };

    [ModdedNumberOption("ディスパーサーの数", 0, 5)]
    public float DisperserAmount { get; set; } = 0;

    public ModdedNumberOption DisperserChance { get; } =
        new("ディスパーサーの出現率", 50f, 0, 100f, 10f, MiraNumberSuffixes.Percent)
        {
            Visible = () => OptionGroupSingleton<ImpostorModifierOptions>.Instance.DisperserAmount > 0
        };

    [ModdedNumberOption("ダブルショットの数", 0, 5)]
    public float DoubleShotAmount { get; set; } = 0;

    public ModdedNumberOption DoubleShotChance { get; } =
        new("ダブルショットの出現率", 50f, 0, 100f, 10f, MiraNumberSuffixes.Percent)
        {
            Visible = () => OptionGroupSingleton<ImpostorModifierOptions>.Instance.DoubleShotAmount > 0
        };

    [ModdedNumberOption("サボタージュマスターの数", 0, 5)]
    public float SaboteurAmount { get; set; } = 0;

    public ModdedNumberOption SaboteurChance { get; } =
        new("サボタージュマスターの出現率", 50f, 0, 100f, 10f, MiraNumberSuffixes.Percent)
        {
            Visible = () => OptionGroupSingleton<ImpostorModifierOptions>.Instance.SaboteurAmount > 0
        };

    [ModdedNumberOption("テレパスの数", 0, 5)]
    public float TelepathAmount { get; set; } = 0;

    public ModdedNumberOption TelepathChance { get; } =
        new("テレパスの出現率", 50f, 0, 100f, 10f, MiraNumberSuffixes.Percent)
        {
            Visible = () => OptionGroupSingleton<ImpostorModifierOptions>.Instance.TelepathAmount > 0
        };

    [ModdedNumberOption("アンダードッグの数", 0, 5)]
    public float UnderdogAmount { get; set; } = 0;

    public ModdedNumberOption UnderdogChance { get; } =
        new("アンダードッグの出現率", 50f, 0, 100f, 10f, MiraNumberSuffixes.Percent)
        {
            Visible = () => OptionGroupSingleton<ImpostorModifierOptions>.Instance.UnderdogAmount > 0
        };
}