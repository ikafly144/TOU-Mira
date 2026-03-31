using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Utilities;

namespace TownOfUs.Options;

public sealed class GeneralOptions : AbstractOptionGroup
{
    public override string GroupName => "一般設定";
    public override uint GroupPriority => 1;

    // Legacy Compatibility, this allows mods like ChaosTokens to still use this value as normal.
    
#pragma warning disable S2325 // Make a static property.
    
#pragma warning disable CA1822 // Member does not access instance data and can be marked as static
    public bool TheDeadKnow => OptionGroupSingleton<PostmortemOptions>.Instance.TheDeadKnow.Value;
    public float TempSaveCdReset => OptionGroupSingleton<GameMechanicOptions>.Instance.TempSaveCdReset;
    
#pragma warning restore CA1822 // Member does not access instance data and can be marked as static
    
#pragma warning restore S2325 // Make a static property.

    [ModdedEnumOption("ロール紹介で表示するモディファイアの種類", typeof(ModReveal))]
    public ModReveal ModifierReveal { get; set; } = ModReveal.Universal;

    [ModdedToggleOption("ロール公開時に陣営モディファイアを表示")]
    public bool TeamModifierReveal { get; set; } = true;

    [ModdedToggleOption("インポスター同士が互いを知らない")]
    public bool FFAImpostorMode { get; set; } = false;

    public ModdedToggleOption ImpsKnowRoles { get; set; } = new("インポスター同士が互いの役職を知る", true)
    {
        Visible = () => !OptionGroupSingleton<GeneralOptions>.Instance.FFAImpostorMode
    };

    public ModdedToggleOption ImpostorChat { get; set; } = new("インポスター専用の会議チャットを使用", true)
    {
        Visible = () => !OptionGroupSingleton<GeneralOptions>.Instance.FFAImpostorMode
    };

    [ModdedToggleOption("ヴァンパイア専用の会議チャットを使用")]
    public bool VampireChat { get; set; } = true;

    [ModdedNumberOption("初期ボタンクールダウン", 10f, 30f, 2.5f, MiraNumberSuffixes.Seconds, "0.#")]
    public float GameStartCd { get; set; } = 10f;

    [ModdedEnumOption("初期クールダウンの適用対象", typeof(StartCooldownType),
        ["すべてのボタン", "特定のクールダウンのみ", "なし"])]
    public StartCooldownType StartCooldownMode { get; set; } = StartCooldownType.SpecificCooldowns;

    public ModdedNumberOption StartCooldownMin { get; set; } = new("適用対象の最小クールダウン", 5f, 0f, 60f,
        2.5f, MiraNumberSuffixes.Seconds, "0.#")
    {
        Visible = () =>
            OptionGroupSingleton<GeneralOptions>.Instance.StartCooldownMode is StartCooldownType.SpecificCooldowns
    };

    public ModdedNumberOption StartCooldownMax { get; set; } = new("適用対象の最大クールダウン", 60f, 0f, 60f,
        2.5f, MiraNumberSuffixes.Seconds, "0.#")
    {
        Visible = () =>
            OptionGroupSingleton<GeneralOptions>.Instance.StartCooldownMode is StartCooldownType.SpecificCooldowns
    };

    [ModdedNumberOption("会議での死亡後に加算される投票時間", 0f, 15f, 1f, MiraNumberSuffixes.Seconds, "0.#")]
    public float AddedMeetingDeathTimer { get; set; } = 5f;

    [ModdedToggleOption("次回のゲームで初手死亡保護シールドを付与")]
    public bool FirstDeathShield { get; set; } = true;

    [ModdedToggleOption("第1ラウンドの犠牲者を表示")]
    public bool RoundOneVictims { get; set; } = true;

    [ModdedToggleOption("強力なクルーがゲームを続行")]
    public bool CrewKillersContinue { get; set; } = true;
}

public enum StartCooldownType
{
    AllButtons,
    SpecificCooldowns,
    NoButtons
}

public enum ModReveal
{
    Alliance,
    Universal,
    Neither
}