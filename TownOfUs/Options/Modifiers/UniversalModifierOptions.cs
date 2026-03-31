using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Utilities;

namespace TownOfUs.Options.Modifiers;

public sealed class UniversalModifierOptions : AbstractOptionGroup
{
    public override string GroupName => "ユニバーサルモディファイア";
    public override Func<bool> GroupVisible => () => OptionGroupSingleton<RoleOptions>.Instance.IsClassicRoleAssignment;
    public override bool ShowInModifiersMenu => true;
    public override uint GroupPriority => 1;

    [ModdedNumberOption("ボタン・バリーの数", 0, 1)]
    public float ButtonBarryAmount { get; set; } = 0;

    public ModdedNumberOption ButtonBarryChance { get; } =
        new("ボタン・バリーの出現率", 50f, 0, 100f, 10f, MiraNumberSuffixes.Percent)
        {
            Visible = () => OptionGroupSingleton<UniversalModifierOptions>.Instance.ButtonBarryAmount > 0
        };

    [ModdedNumberOption("フラッシュの数", 0, 5)]
    public float FlashAmount { get; set; } = 0;

    public ModdedNumberOption FlashChance { get; } = new("フラッシュの出現率", 50f, 0, 100f, 10f, MiraNumberSuffixes.Percent)
    {
        Visible = () => OptionGroupSingleton<UniversalModifierOptions>.Instance.FlashAmount > 0
    };

    [ModdedNumberOption("ジャイアントの数", 0, 5)]
    public float GiantAmount { get; set; } = 0;

    public ModdedNumberOption GiantChance { get; } = new("ジャイアントの出現率", 50f, 0, 100f, 10f, MiraNumberSuffixes.Percent)
    {
        Visible = () => OptionGroupSingleton<UniversalModifierOptions>.Instance.GiantAmount > 0
    };

    [ModdedNumberOption("不動の数", 0, 5)]
    public float ImmovableAmount { get; set; } = 0;

    public ModdedNumberOption ImmovableChance { get; } =
        new("不動の出現率", 50f, 0, 100f, 10f, MiraNumberSuffixes.Percent)
        {
            Visible = () => OptionGroupSingleton<UniversalModifierOptions>.Instance.ImmovableAmount > 0
        };

    [ModdedNumberOption("ミニの数", 0, 5)]
    public float MiniAmount { get; set; } = 0;

    public ModdedNumberOption MiniChance { get; } = new("ミニの出現率", 50f, 0, 100f, 10f, MiraNumberSuffixes.Percent)
    {
        Visible = () => OptionGroupSingleton<UniversalModifierOptions>.Instance.MiniAmount > 0
    };

    [ModdedNumberOption("レーダーの数", 0, 5)]
    public float RadarAmount { get; set; } = 0;

    public ModdedNumberOption RadarChance { get; } = new("レーダーの出現率", 50f, 0, 100f, 10f, MiraNumberSuffixes.Percent)
    {
        Visible = () => OptionGroupSingleton<UniversalModifierOptions>.Instance.RadarAmount > 0
    };

    [ModdedNumberOption("サテライトの数", 0, 5)]
    public float SatelliteAmount { get; set; } = 0;

    public ModdedNumberOption SatelliteChance { get; } =
        new("サテライトの出現率", 50f, 0, 100f, 10f, MiraNumberSuffixes.Percent)
        {
            Visible = () => OptionGroupSingleton<UniversalModifierOptions>.Instance.SatelliteAmount > 0
        };

    [ModdedNumberOption("シャイの数", 0, 5)]
    public float ShyAmount { get; set; } = 0;

    public ModdedNumberOption ShyChance { get; } = new("シャイの出現率", 50f, 0, 100f, 10f, MiraNumberSuffixes.Percent)
    {
        Visible = () => OptionGroupSingleton<UniversalModifierOptions>.Instance.ShyAmount > 0
    };

    [ModdedNumberOption("シックスセンスの数", 0, 5)]
    public float SixthSenseAmount { get; set; } = 0;

    public ModdedNumberOption SixthSenseChance { get; } =
        new("シックスセンスの出現率", 50f, 0, 100f, 10f, MiraNumberSuffixes.Percent)
        {
            Visible = () => OptionGroupSingleton<UniversalModifierOptions>.Instance.SixthSenseAmount > 0
        };

    [ModdedNumberOption("スルースの数", 0, 5)]
    public float SleuthAmount { get; set; } = 0;

    public ModdedNumberOption SleuthChance { get; } =
        new("スルースの出現率", 50f, 0, 100f, 10f, MiraNumberSuffixes.Percent)
        {
            Visible = () => OptionGroupSingleton<UniversalModifierOptions>.Instance.SleuthAmount > 0
        };

    [ModdedNumberOption("タイブレーカーの数", 0, 1)]
    public float TiebreakerAmount { get; set; } = 0;

    public ModdedNumberOption TiebreakerChance { get; } =
        new("タイブレーカーの出現率", 50f, 0, 100f, 10f, MiraNumberSuffixes.Percent)
        {
            Visible = () => OptionGroupSingleton<UniversalModifierOptions>.Instance.TiebreakerAmount > 0
        };
}