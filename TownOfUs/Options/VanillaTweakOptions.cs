using MiraAPI.GameOptions;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Utilities;

namespace TownOfUs.Options;

public sealed class VanillaTweakOptions : AbstractOptionGroup
{
    public override string GroupName => "バニラの調整";
    public override uint GroupPriority => 1;

    /*[ModdedToggleOption("視界外の名前を隠す")]
    public bool HideNamesOutOfSight { get; set; } = true;*/

    public ModdedNumberOption PlayerCountWhenVentsDisable { get; set; } = new("ベントが無効化される生存人数",
        2f, 1f, 15f, 1f, MiraNumberSuffixes.None, "0.#");

    public ModdedToggleOption TickCooldownsInMinigame { get; set; } = new("タスクやパネル操作中もクールダウンを進める", true);

    public ModdedToggleOption ParallelMedbay { get; set; } = new("スキャンを並列で実行可能", true);

    public ModdedToggleOption MedscanWalk { get; set; } = new("スキャン場所まで歩く", true);

    public ModdedEnumOption SkipButtonDisable { get; set; } = new("スキップボタンを無効化", (int)SkipState.No,
        typeof(SkipState), ["しない", "緊急ボタン時のみ", "常に"]);

    public ModdedToggleOption HideVentAnimationNotInVision { get; set; } =
        new("視界外のベントアニメーションを隠す", true);

    public bool CanPauseCooldown => !TickCooldownsInMinigame.Value &&
                                 (Minigame.Instance && Minigame.Instance is not IngameWikiMinigame);
}

public enum SkipState
{
    No,
    Emergency,
    Always
}