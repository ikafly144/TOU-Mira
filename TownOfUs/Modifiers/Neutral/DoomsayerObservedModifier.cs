using MiraAPI.Modifiers;

namespace TownOfUs.Modifiers.Neutral;

public sealed class DoomsayerObservedModifier : BaseModifier
{
    public override string ModifierName => "観察中";
    public override bool HideOnUi => true;
}