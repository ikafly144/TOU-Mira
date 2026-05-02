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

    [ModdedNumberOption("会議での死亡後に加算される投票時間", 0f, 15f, 1f, MiraNumberSuffixes.Seconds, "0.#")]
    public float AddedMeetingDeathTimer { get; set; } = 5f;

    [ModdedToggleOption("First Death Shield Next Game")]
    public bool FirstDeathShield { get; set; } = true;

    [ModdedToggleOption("Indicate Round One Victims")]
    public bool RoundOneVictims { get; set; } = true;

    [ModdedToggleOption("Powerful Crew Continue The Game")]
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