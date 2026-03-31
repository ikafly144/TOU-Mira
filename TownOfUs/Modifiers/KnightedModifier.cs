using MiraAPI.GameOptions;
using MiraAPI.Modifiers;
using MiraAPI.Utilities.Assets;
using TownOfUs.Options.Roles.Crewmate;
using UnityEngine;

namespace TownOfUs.Modifiers;

public sealed class KnightedModifier : BaseModifier
{
    public override string ModifierName => "ナイト";
    public override bool HideOnUi => false;
    public override LoadableAsset<Sprite>? ModifierIcon => TouRoleIcons.Monarch;
    public override bool Unique => false;

    public override string GetDescription()
    {
        return $"モナークによってナイトに任命されました。投票権を {(int)OptionGroupSingleton<MonarchOptions>.Instance.VotesPerKnight} 票獲得しました。";
    }

}