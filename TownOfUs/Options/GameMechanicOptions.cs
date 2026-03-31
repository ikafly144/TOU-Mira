using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Utilities;

namespace TownOfUs.Options;

public sealed class GameMechanicOptions : AbstractOptionGroup
{
    public override string GroupName => "ゲームメカニクス";
    public override uint GroupPriority => 1;

    /*[ModdedToggleOption("視界外の名前を隠す")]
    public bool HideNamesOutOfSight { get; set; } = true;*/

    public ModdedToggleOption GhostwalkerFixSabos { get; set; } = new("ゴーストウォーカーはサボタージュを修理可能", false);

    public ModdedEnumOption ShowPetsMode { get; set; } = new("ペットの可視性", (int)PetVisiblity.AlwaysVisible,
        typeof(PetVisiblity), ["クライアントサイド", "生存時のみ", "常に表示"]);

    public ModdedToggleOption HidePetsOnBodyRemove { get; set; } = new("ジャニター/シェフの清掃時にペットを削除", true)
    {
        Visible = () => (PetVisiblity)OptionGroupSingleton<GameMechanicOptions>.Instance.ShowPetsMode.Value is PetVisiblity.AlwaysVisible
    };

    [ModdedNumberOption("一時保存クールダウンのリセット", 0f, 15f, 0.5f, MiraNumberSuffixes.Seconds, "0.#")]
    public float TempSaveCdReset { get; set; } = 5f;
}

public enum PetVisiblity
{
    ClientSide,
    WhenAlive,
    AlwaysVisible
}