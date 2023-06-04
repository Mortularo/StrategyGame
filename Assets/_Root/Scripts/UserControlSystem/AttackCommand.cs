using Abstractions.Commands.CommandInterfaces;

public class AttackCommand : IAttackCommand
{
    public IGetDamage Target { get; }
    public AttackCommand(IGetDamage target)
    {
        Target = target;
    }
}