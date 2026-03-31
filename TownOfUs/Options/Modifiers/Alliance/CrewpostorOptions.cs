using MiraAPI.GameOptions;
using MiraAPI.GameOptions.OptionTypes;
using TownOfUs.Modifiers.Game.Alliance;
using UnityEngine;

namespace TownOfUs.Options.Modifiers.Alliance;

public sealed class CrewpostorOptions : AbstractOptionGroup<CrewpostorModifier>
{
    public override Func<bool> GroupVisible => () => OptionGroupSingleton<RoleOptions>.Instance.IsClassicRoleAssignment;
    public override string GroupName => TouLocale.Get("TouModifierCrewpostor", "Crewpostor");
    public override uint GroupPriority => 10;
    public override Color GroupColor => Palette.ImpostorRoleHeaderRed;

    public ModdedToggleOption CrewpostorReplacesImpostor { get; set; } = new("クルーポスターが本物のインポスターと入れ替わる", true);

    public ModdedToggleOption CanAlwaysSabotage { get; set; } = new("クルーポスターは常にサボタージュ可能", false);

    public ModdedToggleOption CrewpostorVision { get; set; } = new("クルーポスターはインポスター視界を持つ", true);

    public ModdedToggleOption ShowsAsImpostor { get; set; } = new("クルーポスターはトレイターのように表示される", false);
}