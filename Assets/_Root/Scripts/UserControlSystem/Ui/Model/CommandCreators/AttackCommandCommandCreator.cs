using Abstractions.Commands.CommandInterfaces;

public class AttackCommandCommandCreator :
    CancellableCommandCreatorBase<IAttackCommand, IGetDamage>
{
    protected override IAttackCommand createCommand(IGetDamage argument) => new
    AttackCommand(argument);
}

