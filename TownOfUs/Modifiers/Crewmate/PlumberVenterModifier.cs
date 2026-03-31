using UnityEngine;

namespace TownOfUs.Modifiers.Crewmate;

public sealed class PlumberVenterModifier(PlayerControl owner, Color color) : ArrowTargetModifier(owner, color, 0)
{
    public override string ModifierName => "プラマー追跡矢印";
}