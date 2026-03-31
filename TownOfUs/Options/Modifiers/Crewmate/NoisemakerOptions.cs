using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.Utilities;
using TownOfUs.Modifiers.Game.Crewmate;
using UnityEngine;

namespace TownOfUs.Options.Modifiers.Crewmate;

public sealed class NoisemakerOptions : AbstractOptionGroup<NoisemakerModifier>
{
    public override Func<bool> GroupVisible => () => OptionGroupSingleton<RoleOptions>.Instance.IsClassicRoleAssignment;
    public override string GroupName => TouLocale.Get("TouModifierNoisemaker", "Noisemaker");
    public override uint GroupPriority => 23;
    public override Color GroupColor => TownOfUsColors.Noisemaker;

    [ModdedToggleOption("インポスターに通知する")]
    public bool ImpostorsAlerted { get; set; } = true;

    [ModdedToggleOption("ニュートラルキラーに通知する")]
    public bool NeutsAlerted { get; set; } = true;

    [ModdedToggleOption("通信サボタージュで通知を阻止する")]
    public bool CommsAffected { get; set; } = false;

    [ModdedToggleOption("死体が存在する場合のみ発動する")]
    public bool BodyCheck { get; set; } = true;

    [ModdedNumberOption("通知の持続時間", 1f, 20f, 1f, MiraNumberSuffixes.Seconds)]
    public float AlertDuration { get; set; } = 5f;
}