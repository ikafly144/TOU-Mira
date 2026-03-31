using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Utilities;
using TownOfUs.Roles.Impostor;

namespace TownOfUs.Options.Roles.Impostor;

public sealed class TraitorOptions : AbstractOptionGroup<TraitorRole>
{
    public override string GroupName => TouLocale.Get("TouRoleTraitor", "Traitor");

    [ModdedNumberOption("スポーンに必要な最小生存人数", 3f, 15f, 1f, MiraNumberSuffixes.None, "0")]
    public float LatestSpawn { get; set; } = 5f;

    [ModdedToggleOption("NK（第三陣営）生存時はスポーンしない")]
    public bool NeutralKillingStopsTraitor { get; set; } = false;

    [ModdedToggleOption("既存のインポスター役職を無効にする")]
    public bool RemoveExistingRoles { get; set; } = true;

    public ModdedEnumOption TraitorGuess { get; set; } = new("トレイターの推測方法", (int)CacheRoleGuess.ActiveOrCachedRole, typeof(CacheRoleGuess), ["トレイター", "新役職", "トレイターまたは新役職"]);
}