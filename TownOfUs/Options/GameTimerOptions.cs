using AmongUs.GameOptions;
using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;
using MiraAPI.GameOptions.OptionTypes;
using MiraAPI.Utilities;

namespace TownOfUs.Options;

public sealed class GameTimerOptions : AbstractOptionGroup
{
    public override Func<bool> GroupVisible => () =>
        !(GameOptionsManager.Instance.CurrentGameOptions.GameMode is GameModes.HideNSeek
            or GameModes.SeekFools);
    public override string GroupName => "ゲーム終了タイマー";
    public override uint GroupPriority => 3;

    [ModdedToggleOption("ゲームタイマー")] 
    public bool GameTimerEnabled { get; set; } = false;

    public ModdedNumberOption PauseInMeetings { get; } =
        new("会議中にタイマーを停止", 5f, 1f, 10f, 1f, MiraNumberSuffixes.None, "0")
        {
            Visible = () => OptionGroupSingleton<GameTimerOptions>.Instance.GameTimerEnabled
        };

    public ModdedEnumOption TimerEndOption { get; } =
        new("タイマー終了時の挙動", 1, typeof(GameTimerType), ["インポスターの勝利", "引き分け"])
        {
            Visible = () => OptionGroupSingleton<GameTimerOptions>.Instance.GameTimerEnabled
        };

    public ModdedNumberOption GameTimeLimit { get; } =
        new("ゲーム時間制限", 15f, 1f, 30f, 0.5f, MiraNumberSuffixes.None, "0.0m")
        {
            Visible = () => OptionGroupSingleton<GameTimerOptions>.Instance.GameTimerEnabled
        };
}

public enum GameTimerType
{
    Impostors,
    GameDraw
}

public enum PauseInMeetingsType
{
    Below5Minutes,
    Below10Minutes,
    Always
}