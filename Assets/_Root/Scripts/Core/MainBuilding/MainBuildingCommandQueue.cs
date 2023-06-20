using UnityEngine;
using Zenject;
public class MainBuildingCommandQueue : MonoBehaviour, ICommandsQueue
{
    [Inject]
    CommandExecutorBase<IProduceUnitCommand> _produceUnitCommandExecutor;
    CommandExecutorBase<ISetRallyPointCommand> _setRallyPointCommandExecutor;
    public void Clear() { }
    public async void EnqueueCommand(object command)
    {
        await _produceUnitCommandExecutor.TryExecuteCommand(command);
        await _setRallyPointCommandExecutor.TryExecuteCommand(command);
    }
}