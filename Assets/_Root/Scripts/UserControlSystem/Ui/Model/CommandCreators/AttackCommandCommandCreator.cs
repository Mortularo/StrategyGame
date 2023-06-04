using System;
using Abstractions.Commands.CommandInterfaces;
using UserControlSystem;
using Zenject;

public class AttackCommandCommandCreator : CommandCreatorBase<IAttackCommand>
{
    [Inject] private AssetsContext _context;
    private Action<IAttackCommand> _creationCallback;
    [Inject]
    private void Init(AttackableValue groundClicks)
    {
        groundClicks.OnNewValue += onNewValue;
    }
    private void onNewValue(IGetDamage target)
    {
        _creationCallback?.Invoke(_context.Inject(new AttackCommand(target)));
        _creationCallback = null;
    }
    protected override void classSpecificCommandCreation(Action<IAttackCommand>
    creationCallback)
    {
        _creationCallback = creationCallback;
    }
    public override void ProcessCancel()
    {
        base.ProcessCancel();
        _creationCallback = null;
    }
}
