using MiraAPI.Modifiers;

namespace TownOfUs.Modifiers.Neutral;

public sealed class VampireBittenModifier : BaseModifier
{
    public override string ModifierName => "噛まれ済み";
    public override bool HideOnUi => true;
}