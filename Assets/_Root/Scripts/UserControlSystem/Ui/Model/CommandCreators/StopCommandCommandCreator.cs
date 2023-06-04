using System;
using Abstractions.Commands.CommandInterfaces;
using Zenject;

public class StopCommandCommandCreator : CommandCreatorBase<IStopCommand>
{
    [Inject] private AssetsContext _context;
    protected override void
    classSpecificCommandCreation(Action<IStopCommand> stopCallback)
    {
        stopCallback?.Invoke(_context.Inject(new StopCommand()));
    }
}
