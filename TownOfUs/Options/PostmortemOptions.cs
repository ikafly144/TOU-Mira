using MiraAPI.GameOptions;
using MiraAPI.GameOptions.OptionTypes;

namespace TownOfUs.Options;

public sealed class PostmortemOptions : AbstractOptionGroup
{
    public override string GroupName => "死後設定";
    public override uint GroupPriority => 2;

    public ModdedToggleOption TheDeadKnow { get; set; } = new("死者がプレイヤーを識別可能", true);

    public ModdedToggleOption DeadSeeVotes { get; set; } = new("死者が投票結果を確認可能", true);

    public ModdedEnumOption DeadSeePrivateChat { get; set; } = new("死者がプライベートチャットを確認可能", (int)GhostModeGlobal.DisabledUponDeath, typeof(GhostModeGlobal),
        ["無効", "死亡時に無効化", "会議中のみ", "常に"]);

    public ModdedEnumOption DeadCanHaunt { get; set; } = new("取り憑き（追従）モード", (int)GhostModeInGame.DisabledUponDeath, typeof(GhostModeInGame),
        ["無効", "死亡時に無効化", "常に"]);

    public ModdedToggleOption HideChatButton { get; set; } = new("死亡時に一時的にチャットボタンを隠す", true);

}

public enum GhostModeInGame
{
    Disabled,
    DisabledUponDeath,
    Always,
}

public enum GhostModeGlobal
{
    Disabled,
    DisabledUponDeath,
    InMeetings,
    Always,
}