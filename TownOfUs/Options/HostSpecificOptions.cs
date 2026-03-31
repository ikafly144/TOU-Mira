using System.Collections;
using MiraAPI.GameOptions;
using MiraAPI.GameOptions.OptionTypes;
using Reactor.Utilities;
using TownOfUs.Modules;
using TownOfUs.Roles.Other;
using TownOfUs.Utilities;
using TownOfUs.Utilities.Appearances;
using UnityEngine;

namespace TownOfUs.Options;

public sealed class HostSpecificOptions : AbstractOptionGroup
{
    public override string GroupName => "ホスト専用設定";
    public override uint GroupPriority => 0;

    public ModdedToggleOption AntiCheatWarnings { get; set; } = new("アンチチートの警告を有効化", true, false);

    public ModdedToggleOption KickCheatMods { get; set; } = new("チートModを使用しているプレイヤーをキック", true, false);

    public ModdedToggleOption MultiplayerFreeplay { get; set; } = new("フリープレイモード", false, false);

    public ModdedEnumOption BetaLoggingLevel { get; set; } = new("詳細ログモード", (int)LoggingLevel.LogForEveryonePostGame, typeof(LoggingLevel),
        ["なし", "ホストのみ", "全員", "ゲーム終了後に全員"], false)
    {
        Visible = () => TownOfUsPlugin.IsDevBuild
    };

    public ModdedToggleOption LobbyFunMode { get; set; } = new("ロビー限定の壁抜けを許可", true, false);

    public ModdedToggleOption AllowAprilFools { get; set; } = new("エイプリルフールの演出を許可", true, false)
    {
        ChangedEvent = x =>
        {
            Debug("Toggle April Fools mode.");
            Coroutines.Start(CoSetAprilFools());
        }
    };
    public ModdedToggleOption EnableSpectators { get; set; } = new("観戦を許可", true, false)
    {
        ChangedEvent = x =>
        {
            var list = SpectatorRole.TrackedSpectators;
            foreach (var name in list)
            {
                SpectatorRole.TrackedSpectators.Remove(name);
            }
            Debug("Removed all spectators.");
        },
    };

    public ModdedToggleOption RequireSubmerged { get; set; } = new("Submergedのインストールを必須にする", true, false)
    {
        Visible = () => ModCompatibility.SubLoaded
    };

    public ModdedToggleOption RequireCrowded { get; set; } = new("Crowdedのインストールを必須にする", true, false)
    {
        Visible = () => ModCompatibility.CrowdedLoaded
    };

    public ModdedToggleOption RequireAleLudu { get; set; } = new("AleLuduModのインストールを必須にする", true, false)
    {
        Visible = () => ModCompatibility.AleLuduLoaded
    };

    public ModdedToggleOption NoGameEnd { get; set; } = new("ゲームを終了させない", false, false)
    {
        Visible = () => TownOfUsPlugin.IsDevBuild
    };

    private static IEnumerator CoSetAprilFools()
    {
        yield return new WaitForSeconds(0.05f);
        
        foreach (var player in PlayerControl.AllPlayerControls)
        {
            player.MyPhysics.SetForcedBodyType(player.BodyType);
            player.ResetAppearance();
        }
    }
}

public enum LoggingLevel
{
    NoLogging,
    LogForHost,
    LogForEveryone,
    LogForEveryonePostGame
}