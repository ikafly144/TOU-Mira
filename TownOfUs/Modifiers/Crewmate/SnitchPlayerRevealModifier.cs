namespace TownOfUs.Modifiers.Crewmate;

public sealed class SnitchPlayerRevealModifier(RoleBehaviour role)
    : BaseRevealModifier
{
    public override string ModifierName => "公開されたスニッチ";

    public override ChangeRoleResult ChangeRoleResult { get; set; } = ChangeRoleResult.Nothing;

    public override RoleBehaviour? ShownRole { get; set; } = role;
    public override bool RevealRole { get; set; } = true;
}