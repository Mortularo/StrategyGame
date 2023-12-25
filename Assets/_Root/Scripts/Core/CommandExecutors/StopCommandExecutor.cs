<<<<<<< Updated upstream
using Abstractions.Commands.CommandInterfaces;
using UnityEngine;

public class StopCommandExecutor : CommandExecutorBase<IStopCommand>
{
    public override void ExecuteSpecificCommand(IStopCommand command)
    {
        Debug.Log($"{name} stops!");
    }
}
=======
using System.Threading;
using System.Threading.Tasks;

public class StopCommandExecutor : CommandExecutorBase<IStopCommand>
{
    public CancellationTokenSource CancellationTokenSource { get; set; }

    public override async Task ExecuteSpecificCommand(IStopCommand command)
    {
        CancellationTokenSource?.Cancel();
    }
}
>>>>>>> Stashed changes
