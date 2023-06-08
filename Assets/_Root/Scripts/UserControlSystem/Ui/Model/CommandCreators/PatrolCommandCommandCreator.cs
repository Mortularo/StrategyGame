using Abstractions.Commands.CommandInterfaces;
using UnityEngine;
using UserControlSystem;
using Zenject;
public class PatrolCommandCommandCreator :
    CancellableCommandCreatorBase<IPatrolCommand, Vector3>
{
    [Inject] private SelectableValue _selectable;
    protected override IPatrolCommand createCommand(Vector3 argument) => new
    PatrolCommand(_selectable.CurrentValue.CurrentPosition.position, argument);
}