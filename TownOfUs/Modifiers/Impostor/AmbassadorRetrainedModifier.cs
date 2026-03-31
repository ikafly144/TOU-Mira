using AmongUs.GameOptions;
using MiraAPI.Modifiers;

namespace TownOfUs.Modifiers.Impostor;

public sealed class AmbassadorRetrainedModifier(ushort role) : BaseModifier
{
    public override string ModifierName => "再訓練済み";
    public override bool HideOnUi => true;
    public RoleBehaviour PreviousRole => RoleManager.Instance.GetRole((RoleTypes)role);
}