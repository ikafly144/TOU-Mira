using MiraAPI.Modifiers.Types;
using MiraAPI.PluginLoading;

namespace TownOfUs.Modifiers;

// This modifier is used to prevent transports with anyone who has this
[MiraIgnore]
public abstract class NoTransportModifier : TimedModifier
{
    public override string ModifierName => "転送不能モディファイア";

    public override float Duration => 1f;
    public override bool AutoStart => false;
    public override bool HideOnUi => true;
    public virtual bool VisibleToOthers { get; set; }

    public override string GetDescription()
    {
        return "転送することができません！";
    }

    public override void OnDeath(DeathReason reason)
    {
        base.OnDeath(reason);

        ModifierComponent!.RemoveModifier(this);
    }
}