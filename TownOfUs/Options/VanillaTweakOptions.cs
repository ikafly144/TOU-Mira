using MiraAPI.GameOptions;
using MiraAPI.GameOptions.OptionTypes;

namespace TownOfUs.Options;

public sealed class VanillaTweakOptions : AbstractOptionGroup
{
    public override string GroupName => "バニラの調整";
    public override uint GroupPriority => 1;

    /*[ModdedToggleOption("視界外の名前を隠す")]
    public bool HideNamesOutOfSight { get; set; } = true;*/

    public ModdedToggleOption TickCooldownsInMinigame { get; set; } = new("Continue Cooldown In Tasks and Panels", true);

    public ModdedToggleOption ParallelMedbay { get; set; } = new("スキャンを並列で実行可能", true);

    public ModdedToggleOption MedscanWalk { get; set; } = new("スキャン場所まで歩く", true);

    public ModdedEnumOption SkipButtonDisable { get; set; } = new("スキップボタンを無効化", (int)SkipState.No,
        typeof(SkipState), ["しない", "緊急ボタン時のみ", "常に"]);

    public ModdedToggleOption HideVentAnimationNotInVision { get; set; } =
        new("視界外のベントアニメーションを隠す", true);

    public ModdedEnumOption ShowPetsMode { get; set; } = new("Pet Visibility", (int)PetVisiblity.AlwaysVisible,
        typeof(PetVisiblity), ["Client Side", "When Alive", "Always Visible"]);

    public ModdedEnumOption HidePetsOnBodyRemove { get; set; } = new("Pet Removed on Body Clean", (int)PetHidden.DuringRound,
        typeof(PetHidden), ["Never", "During Round", "Always"])
    {
        Visible = () => (PetVisiblity)OptionGroupSingleton<VanillaTweakOptions>.Instance.ShowPetsMode.Value is not PetVisiblity.WhenAlive
    };

    public bool CanPauseCooldown => !TickCooldownsInMinigame.Value &&
                                 (Minigame.Instance && Minigame.Instance is not IngameWikiMinigame);

    public PetHidden PetVisibilityUponDeath => ((PetVisiblity)ShowPetsMode.Value is PetVisiblity.WhenAlive)
        ? PetHidden.Never
        : (PetHidden)HidePetsOnBodyRemove.Value;
}

public enum SkipState
{
    No,
    Emergency,
    Always
}

public enum PetVisiblity
{
    ClientSide,
    WhenAlive,
    AlwaysVisible
}

public enum PetHidden
{
    Never,
    DuringRound,
    Remove
}