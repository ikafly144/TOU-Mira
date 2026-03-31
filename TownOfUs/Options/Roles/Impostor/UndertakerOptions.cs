using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Utilities;
using TownOfUs.Roles.Impostor;

namespace TownOfUs.Options.Roles.Impostor;

public sealed class UndertakerOptions : AbstractOptionGroup<UndertakerRole>
{
    public override string GroupName => TouLocale.Get("TouRoleUndertaker", "Undertaker");

    [ModdedNumberOption("運搬のクールダウン", 5f, 120f, 2.5f, MiraNumberSuffixes.Seconds)]
    public float DragCooldown { get; set; } = 25f;

    [ModdedNumberOption("運搬時の移動速度", 0.25f, 1f, 0.05f, MiraNumberSuffixes.Multiplier, "0.00")]
    public float DragSpeedMultiplier { get; set; } = 0.75f;

    [ModdedToggleOption("運搬速度が死体の大きさに影響される")]
    public bool AffectedSpeed { get; set; } = true;

    [ModdedToggleOption("アンダーテイカーはベント可能")]
    public bool CanVent { get; set; } = true;

    public ModdedToggleOption CanVentWithBody { get; } = new("死体を運んだままベント可能", false)
    {
        Visible = () => OptionGroupSingleton<UndertakerOptions>.Instance.CanVent
    };

    [ModdedToggleOption("仲間と一緒にキル可能")]
    public bool UndertakerKill { get; set; } = true;
}