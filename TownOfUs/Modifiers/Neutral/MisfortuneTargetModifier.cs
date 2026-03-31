using MiraAPI.Modifiers;

namespace TownOfUs.Modifiers.Neutral;

public sealed class MisfortuneTargetModifier : BaseModifier
{
    public override string ModifierName => "不運 (驚かす/苦悶/呪いの対象)";
    public override bool HideOnUi => true;
}