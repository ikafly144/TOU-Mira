using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using TownOfUs.Modifiers.Game.Impostor;
using UnityEngine;

namespace TownOfUs.Options.Modifiers.Impostor;

public sealed class DeadlyQuotaOptions : AbstractOptionGroup<DeadlyQuotaModifier>
{
    public override string GroupName => "デッドリークォータ";
    public override Color GroupColor => Palette.ImpostorRoleHeaderRed;
    public override uint GroupPriority => 40;

    [ModdedNumberOption("キルノルマの最小数", 1f, 5f, 1f)]
    public float KillQuotaMin { get; set; } = 2f;

    [ModdedNumberOption("キルノルマの最大数", 1f, 5f, 1f)]
    public float KillQuotaMax { get; set; } = 4f;

    [ModdedToggleOption("会議でのキルをノルマに加算")]
    public bool MeetingKillsCountTowardsQuota { get; set; } = true;

    [ModdedToggleOption("ノルマ達成まで一時的なシールドを付与")]
    public bool QuotaShield { get; set; } = false;

    [ModdedToggleOption("死亡時にノルマを解除")]
    public bool RemoveQuotaUponDeath { get; set; } = true;

    /// <summary>
    /// Picks the quota using Min/Max or falls back to Max if invalid
    /// </summary>
    public int GenerateKillQuota()
    {
        var min = Mathf.FloorToInt(KillQuotaMin);
        var max = Mathf.FloorToInt(KillQuotaMax);

        if (min > max)
            return max;

        if (min == max)
            return max;

        return UnityEngine.Random.Range(min, max + 1);
    }
}