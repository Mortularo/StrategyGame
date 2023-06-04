using Abstractions.Commands.CommandInterfaces;
using UnityEngine;
using UserControlSystem;
using Zenject;

public class UiModelInstaller : MonoInstaller
{
    [SerializeField] private AssetsContext _legacyContext;
    [SerializeField] private AttackableValue _attackableValue;
    [SerializeField] private Vector3Value _vector3Value;
    [SerializeField] private SelectableValue _selectableValue;

    public override void InstallBindings()
    {
        Container.Bind<AssetsContext>().FromInstance(_legacyContext);

        Container.Bind<CommandCreatorBase<IProduceCommand>>()
        .To<ProduceUnitCommandCommandCreator>().AsTransient();
        Container.Bind<CommandCreatorBase<IAttackCommand>>()
        .To<AttackCommandCommandCreator>().AsTransient();
        Container.Bind<CommandCreatorBase<IMoveCommand>>()
        .To<MoveCommandCommandCreator>().AsTransient();
        Container.Bind<CommandCreatorBase<IPatrolCommand>>()
        .To<PatrolCommandCommandCreator>().AsTransient();
        Container.Bind<CommandCreatorBase<IStopCommand>>()
        .To<StopCommandCommandCreator>().AsTransient();
        Container.Bind<CommandButtonsModel>().AsTransient();

        Container.Bind<AttackableValue>().FromInstance(_attackableValue);
        Container.Bind<Vector3Value>().FromInstance(_vector3Value);
        Container.Bind<SelectableValue>().FromInstance(_selectableValue);
    }
}

