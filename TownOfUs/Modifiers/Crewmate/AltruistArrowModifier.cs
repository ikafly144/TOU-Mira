using UnityEngine;

namespace TownOfUs.Modifiers.Crewmate;

public sealed class AltruistArrowModifier(PlayerControl owner, Color color) : ArrowTargetModifier(owner, color, 0)
{
    public override string ModifierName => "アルトルイスト矢印";

    public override void OnDeath(DeathReason reason)
    {
        ModifierComponent?.RemoveModifier(this);
    }
}