using MiraAPI.Modifiers;

namespace TownOfUs.Modifiers.Neutral;

public sealed class InquisitorInquiredModifier : BaseModifier
{
    public override string ModifierName => "調査済み";
    public override bool HideOnUi => true;
}