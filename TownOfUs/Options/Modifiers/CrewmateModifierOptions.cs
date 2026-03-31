using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Utilities;
using UnityEngine;

namespace TownOfUs.Options.Modifiers;

public sealed class CrewmateModifierOptions : AbstractOptionGroup
{
    public override string GroupName => "クルーメイトモディファイア";
    public override Func<bool> GroupVisible => () => OptionGroupSingleton<RoleOptions>.Instance.IsClassicRoleAssignment;
    public override Color GroupColor => Palette.CrewmateRoleHeaderBlue;
    public override bool ShowInModifiersMenu => true;
    public override uint GroupPriority => 2;

    [ModdedNumberOption("アフターマスの数", 0, 5)]
    public float AftermathAmount { get; set; } = 0;

    public ModdedNumberOption AftermathChance { get; } =
        new("アフターマスの出現率", 50f, 0, 100f, 10f, MiraNumberSuffixes.Percent)
        {
            Visible = () => OptionGroupSingleton<CrewmateModifierOptions>.Instance.AftermathAmount > 0
        };

    [ModdedNumberOption("ベイトの数", 0, 5)]
    public float BaitAmount { get; set; } = 0;

    public ModdedNumberOption BaitChance { get; } = new("ベイトの出現率", 50f, 0, 100f, 10f, MiraNumberSuffixes.Percent)
    {
        Visible = () => OptionGroupSingleton<CrewmateModifierOptions>.Instance.BaitAmount > 0
    };

    [ModdedNumberOption("セレブリティの数", 0, 1)]
    public float CelebrityAmount { get; set; } = 0;

    public ModdedNumberOption CelebrityChance { get; } =
        new("セレブリティの出現率", 50f, 0, 100f, 10f, MiraNumberSuffixes.Percent)
        {
            Visible = () => OptionGroupSingleton<CrewmateModifierOptions>.Instance.CelebrityAmount > 0
        };

    [ModdedNumberOption("ディジーズドの数", 0, 5)]
    public float DiseasedAmount { get; set; } = 0;

    public ModdedNumberOption DiseasedChance { get; } =
        new("ディジーズドの出現率", 50f, 0, 100f, 10f, MiraNumberSuffixes.Percent)
        {
            Visible = () => OptionGroupSingleton<CrewmateModifierOptions>.Instance.DiseasedAmount > 0
        };

    [ModdedNumberOption("フロスティの数", 0, 5)]
    public float FrostyAmount { get; set; } = 0;

    public ModdedNumberOption FrostyChance { get; } =
        new("フロスティの出現率", 50f, 0, 100f, 10f, MiraNumberSuffixes.Percent)
        {
            Visible = () => OptionGroupSingleton<CrewmateModifierOptions>.Instance.FrostyAmount > 0
        };

    [ModdedNumberOption("インベスティゲーターの数", 0, 5)]
    public float InvestigatorAmount { get; set; } = 0;

    public ModdedNumberOption InvestigatorChance { get; } =
        new("インベスティゲーターの出現率", 50f, 0, 100f, 10f, MiraNumberSuffixes.Percent)
        {
            Visible = () => OptionGroupSingleton<CrewmateModifierOptions>.Instance.InvestigatorAmount > 0
        };

    [ModdedNumberOption("マルチタスカーの数", 0, 5)]
    public float MultitaskerAmount { get; set; } = 0;

    public ModdedNumberOption MultitaskerChance { get; } =
        new("マルチタスカーの出現率", 50f, 0, 100f, 10f, MiraNumberSuffixes.Percent)
        {
            Visible = () => OptionGroupSingleton<CrewmateModifierOptions>.Instance.MultitaskerAmount > 0
        };

    [ModdedNumberOption("ノイズメーカーの数", 0, 5)]
    public float NoisemakerAmount { get; set; } = 0;

    public ModdedNumberOption NoisemakerChance { get; } =
        new("ノイズメーカーの出現率", 50f, 0, 100f, 10f, MiraNumberSuffixes.Percent)
        {
            Visible = () => OptionGroupSingleton<CrewmateModifierOptions>.Instance.NoisemakerAmount > 0
        };

    [ModdedNumberOption("オペレーティブの数", 0, 5)]
    public float OperativeAmount { get; set; } = 0;

    public ModdedNumberOption OperativeChance { get; } =
        new("オペレーティブの出現率", 50f, 0, 100f, 10f, MiraNumberSuffixes.Percent)
        {
            Visible = () => OptionGroupSingleton<CrewmateModifierOptions>.Instance.OperativeAmount > 0
        };

    [ModdedNumberOption("ロッティングの数", 0, 5)]
    public float RottingAmount { get; set; } = 0;

    public ModdedNumberOption RottingChance { get; } =
        new("ロッティングの出現率", 50f, 0, 100f, 10f, MiraNumberSuffixes.Percent)
        {
            Visible = () => OptionGroupSingleton<CrewmateModifierOptions>.Instance.RottingAmount > 0
        };

    [ModdedNumberOption("サイエンティストの数", 0, 5)]
    public float ScientistAmount { get; set; } = 0;

    public ModdedNumberOption ScientistChance { get; } =
        new("サイエンティストの出現率", 50f, 0, 100f, 10f, MiraNumberSuffixes.Percent)
        {
            Visible = () => OptionGroupSingleton<CrewmateModifierOptions>.Instance.ScientistAmount > 0
        };

    [ModdedNumberOption("スカウトの数", 0, 5)]
    public float ScoutAmount { get; set; } = 0;

    public ModdedNumberOption ScoutChance { get; } = new("スカウトの出現率", 50f, 0, 100f, 10f, MiraNumberSuffixes.Percent)
    {
        Visible = () => OptionGroupSingleton<CrewmateModifierOptions>.Instance.ScoutAmount > 0
    };

    [ModdedNumberOption("スパイの数", 0, 5)]
    public float SpyAmount { get; set; } = 0;

    public ModdedNumberOption SpyChance { get; } = new("スパイの出現率", 50f, 0, 100f, 10f, MiraNumberSuffixes.Percent)
    {
        Visible = () => OptionGroupSingleton<CrewmateModifierOptions>.Instance.SpyAmount > 0
    };

    [ModdedNumberOption("タスクマスターの数", 0, 5)]
    public float TaskmasterAmount { get; set; } = 0;

    public ModdedNumberOption TaskmasterChance { get; } =
        new("タスクマスターの出現率", 50f, 0, 100f, 10f, MiraNumberSuffixes.Percent)
        {
            Visible = () => OptionGroupSingleton<CrewmateModifierOptions>.Instance.TaskmasterAmount > 0
        };

    [ModdedNumberOption("トーチの数", 0, 5)]
    public float TorchAmount { get; set; } = 0;

    public ModdedNumberOption TorchChance { get; } = new("トーチの出現率", 50f, 0, 100f, 10f, MiraNumberSuffixes.Percent)
    {
        Visible = () => OptionGroupSingleton<CrewmateModifierOptions>.Instance.TorchAmount > 0
    };
}