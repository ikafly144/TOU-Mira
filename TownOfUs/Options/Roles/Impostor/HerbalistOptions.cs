using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Utilities;
using TownOfUs.Roles.Impostor;

namespace TownOfUs.Options.Roles.Impostor;

public sealed class HerbalistOptions : AbstractOptionGroup<HerbalistRole>
{
    public override string GroupName => TouLocale.Get("TouRoleHerbalist", "Herbalist");

    [ModdedNumberOption("ハーバリストクールダウン", 10f, 90f, 2.5f, MiraNumberSuffixes.Seconds)]
    public float HerbCooldown { get; set; } = 30f;

    public ModdedNumberOption MaxExposeUses { get; } = new("暴露の最大使用回数", 3f, 0f, 15f, 1f, "∞", "∞", MiraNumberSuffixes.None, "0");

    public ModdedNumberOption MaxConfuseUses { get; } = new("混乱の最大使用回数", 5f, 0f, 15f, 1f, "∞", "∞", MiraNumberSuffixes.None, "0");

    public ModdedNumberOption MaxProtectUses { get; } = new("保護の最大使用回数", 7f, 0f, 15f, 1f, "∞", "∞", MiraNumberSuffixes.None, "0");

    [ModdedNumberOption("混乱発生までの遅延時間", 0.5f, 5f, 0.5f, MiraNumberSuffixes.Seconds)]
    public float ConfuseDelay{ get; set; } = 3f;

    [ModdedNumberOption("混乱の持続時間", 5f, 30f, 2.5f, MiraNumberSuffixes.Seconds)]
    public float ConfuseDuration { get; set; } = 15f;

    /*
    [ModdedNumberOption("Glamour Duration", 5f, 30f, 2.5f, MiraNumberSuffixes.Seconds)]
    public float GlamourDuration { get; set; } = 15f;*/

    [ModdedNumberOption("保護の持続時間", 5f, 30f, 2.5f, MiraNumberSuffixes.Seconds)]
    public float ProtectDuration { get; set; } = 15f;

    [ModdedToggleOption("TouOptionClericProtectedSeesBarrier")]
    public bool ShowBarrier { get; set; } = false;

    [ModdedToggleOption("攻撃を受けた際にハーバリストに通知")]
    public bool AttackNotif { get; set; } = true;
}