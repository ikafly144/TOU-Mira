using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Utilities;

namespace TownOfUs.Options;

public sealed class AssassinOptions : AbstractOptionGroup
{
    public override string GroupName => "アサシン設定";
    public override uint GroupPriority => 7;
    public override Func<bool> GroupVisible => () => OptionGroupSingleton<RoleOptions>.Instance.IsClassicRoleAssignment;

    [ModdedNumberOption("インポスターのアサシンの数", 0, 4, 1, MiraNumberSuffixes.None, "0")]
    public float NumberOfImpostorAssassins { get; set; } = 1;

    public ModdedNumberOption ImpAssassinChance { get; } =
        new("インポスターのアサシンの出現率", 100f, 0, 100f, 10f, MiraNumberSuffixes.Percent)
        {
            Visible = () => OptionGroupSingleton<AssassinOptions>.Instance.NumberOfImpostorAssassins > 0
        };

    [ModdedNumberOption("ニュートラルのアサシンの数", 0, 5, 1, MiraNumberSuffixes.None, "0")]
    public float NumberOfNeutralAssassins { get; set; } = 1;

    public ModdedNumberOption NeutAssassinChance { get; } =
        new("ニュートラルのアサシンの出現率", 100f, 0, 100f, 10f, MiraNumberSuffixes.Percent)
        {
            Visible = () => OptionGroupSingleton<AssassinOptions>.Instance.NumberOfNeutralAssassins > 0
        };

    public ModdedToggleOption AmneTurnImpAssassin { get; } = new($"アムネジアックがインポスターになった際にアビリティを付与", true);

    public ModdedToggleOption AmneTurnNeutAssassin { get; } =
        new($"アムネジアックがニュートラルキラーになった際にアビリティを付与", true);

    [ModdedToggleOption("トレイターにアビリティを付与")]
    public bool TraitorCanAssassin { get; set; } = true;

    [ModdedNumberOption("アサシンのキル回数", 1, 15, 1, MiraNumberSuffixes.None, "0")]
    public float AssassinKills { get; set; } = 5;

    [ModdedToggleOption("1回の会議で複数回キル可能")]
    public bool AssassinMultiKill { get; set; } = true;

    [ModdedToggleOption("バニラの特殊役職を推測可能")]
    public bool GuessVanillaRoles { get; set; } = true;

    [ModdedToggleOption("「クルーメイト」を推測可能")]
    public bool AssassinCrewmateGuess { get; set; } = false;

    [ModdedToggleOption("クルー調査役職を推測可能")]
    public bool AssassinGuessInvest { get; set; } = false;

    [ModdedToggleOption("ニュートラル良性役職を推測可能")]
    public bool AssassinGuessNeutralBenign { get; set; } = true;

    [ModdedToggleOption("ニュートラル悪性役職を推測可能")]
    public bool AssassinGuessNeutralEvil { get; set; } = true;

    [ModdedToggleOption("ニュートラルキラー役職を推測可能")]
    public bool AssassinGuessNeutralKilling { get; set; } = true;

    [ModdedToggleOption("ニュートラル異端役職を推測可能")]
    public bool AssassinGuessNeutralOutlier { get; set; } = true;

    [ModdedToggleOption("インポスター役職を推測可能")]
    public bool AssassinGuessImpostors { get; set; } = true;

    [ModdedToggleOption("クルーメイトモディファイアを推測可能")]
    public bool AssassinGuessCrewModifiers { get; set; } = true;

    public ModdedToggleOption AssassinGuessUtilityModifiers { get; } =
        new("クルーユーティリティモディファイアを推測可能", false)
        {
            Visible = () => OptionGroupSingleton<AssassinOptions>.Instance.AssassinGuessCrewModifiers
        };

    [ModdedToggleOption("同盟モディファイアを推測可能")]
    public bool AssassinGuessAlliances { get; set; } = true;
}