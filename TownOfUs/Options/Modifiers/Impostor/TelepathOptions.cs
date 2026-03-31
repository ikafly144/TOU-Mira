using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Utilities;
using TownOfUs.Modifiers.Game.Impostor;
using UnityEngine;

namespace TownOfUs.Options.Modifiers.Impostor;

public sealed class TelepathOptions : AbstractOptionGroup<TelepathModifier>
{
    public override Func<bool> GroupVisible => () => OptionGroupSingleton<RoleOptions>.Instance.IsClassicRoleAssignment;
    public override string GroupName => TouLocale.Get("TouModifierTelepath", "Telepath");
    public override Color GroupColor => Palette.ImpostorRoleHeaderRed;
    public override uint GroupPriority => 42;

    [ModdedToggleOption("仲間のキル場所を知る")]
    public bool KnowKillLocation { get; set; } = true;

    [ModdedToggleOption("仲間の死亡時に通知する")]
    public bool KnowDeath { get; set; } = true;

    public ModdedToggleOption KnowDeathLocation { get; } = new("仲間の死亡場所を知る", true)
    {
        Visible = () => OptionGroupSingleton<TelepathOptions>.Instance.KnowDeath
    };

    public ModdedNumberOption TelepathArrowDuration { get; } = new("死体矢印の持続時間", 2.5f, 0f, 5f, 0.5f,
        MiraNumberSuffixes.Seconds, "0.00")
    {
        Visible = () => OptionGroupSingleton<TelepathOptions>.Instance.KnowKillLocation ||
                        (OptionGroupSingleton<TelepathOptions>.Instance.KnowDeath &&
                         OptionGroupSingleton<TelepathOptions>.Instance.KnowDeathLocation)
    };

    [ModdedToggleOption("仲間の推測成功時に通知する")]
    public bool KnowCorrectGuess { get; set; } = true;

    [ModdedToggleOption("仲間の推測失敗時に通知する")]
    public bool KnowFailedGuess { get; set; } = true;
}