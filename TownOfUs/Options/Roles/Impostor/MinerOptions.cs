using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Utilities;
using TownOfUs.Roles.Impostor;

namespace TownOfUs.Options.Roles.Impostor;

public sealed class MinerOptions : AbstractOptionGroup<MinerRole>
{
    public override string GroupName => TouLocale.Get("TouRoleMiner", "Miner");

    [ModdedNumberOption("1ゲームあたりの設置可能ベント数", 0f, 30f, 5f, MiraNumberSuffixes.None, "0", true)]
    public float MaxMines { get; set; } = 0f;

    [ModdedNumberOption("採掘のクールダウン", 5f, 120f, 2.5f, MiraNumberSuffixes.Seconds)]
    public float MineCooldown { get; set; } = 25f;

    [ModdedEnumOption("設置ベントの可視性", typeof(MineVisiblityOptions), ["即時", "使用後"])]
    public MineVisiblityOptions MineVisibility { get; set; } = MineVisiblityOptions.Immediate;

    public ModdedNumberOption MineDelay { get; } = new("設置の遅延", 3f, 0f, 10f, 0.5f, MiraNumberSuffixes.Seconds)
    {
        Visible = () => OptionGroupSingleton<MinerOptions>.Instance.MineVisibility is MineVisiblityOptions.Immediate
    };

    [ModdedToggleOption("仲間と一緒にキル可能")]
    public bool MinerKill { get; set; } = true;
}

public enum MineVisiblityOptions
{
    Immediate,
    AfterUse
}