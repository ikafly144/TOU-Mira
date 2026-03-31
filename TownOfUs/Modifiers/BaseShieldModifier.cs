using MiraAPI.Modifiers.Types;
using MiraAPI.PluginLoading;
using TownOfUs.Modules.Anims;

namespace TownOfUs.Modifiers;

[MiraIgnore]
public abstract class BaseShieldModifier : TimedModifier, IAnimated
{
    public override string ModifierName => "シールドモディファイア";
    public virtual string ShieldDescription => "守られています！";
    public override float Duration => 1f;
    public override bool AutoStart => false;

    public override bool HideOnUi =>
        !LocalSettingsTabSingleton<TownOfUsLocalRoleSettings>.Instance.ShowShieldHudToggle.Value;

    public virtual bool VisibleSymbol => false;
    public bool IsVisible { get; set; } = true;

    public void SetVisible()
    {
    }

    public override string GetDescription()
    {
        return !HideOnUi ? ShieldDescription : string.Empty;
    }
}