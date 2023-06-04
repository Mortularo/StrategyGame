using System;
using Zenject;
using Abstractions.Commands.CommandInterfaces;
public class ProduceUnitCommandCommandCreator : CommandCreatorBase<IProduceCommand>
{
    [Inject] private AssetsContext _context;
    protected override void
    classSpecificCommandCreation(Action<IProduceCommand> creationCallback)
    {
        creationCallback?.Invoke(_context.Inject(new ProduceUnitCommandHeir()));
    }
}

