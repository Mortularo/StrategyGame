using UnityEngine;
using UserControlSystem;
using Abstractions.Commands;
using Abstractions.Commands.CommandInterfaces;
using System.Collections.Generic;
using System;

public class CommandButtonsPresenter : MonoBehaviour
{
    [SerializeField] private SelectableValue _selectable;
    [SerializeField] private CommandButtonsView _view;
    [SerializeField] private AssetsContext _context;
    private ISelectable _currentSelectable;

    private void Start()
    {
        _selectable.OnSelected += onSelected;
        onSelected(_selectable.CurentValue);
        _view.OnClick += onButtonClick;
    }
    private void onSelected(ISelectable selectable)
    {
        if (_currentSelectable == selectable)
        {
            return;
        }
        _currentSelectable = selectable;
        _view.Clear();
        if (selectable != null)
        {
            var commandExecutors = new List<ICommandExecutor>();
            commandExecutors.AddRange((selectable as
            Component).GetComponentsInParent<ICommandExecutor>());
            _view.MakeLayout(commandExecutors);
        }
    }
    private void onButtonClick(ICommandExecutor commandExecutor)
    {
        var unitProducer = commandExecutor as
        CommandExecutorBase<IProduceCommand>;
        if (unitProducer != null)
        {
            unitProducer.ExecuteSpecificCommand(_context.Inject(new ProduceUnitCommand()));
            return;
        }
        
        var unitAttacker = commandExecutor as CommandExecutorBase<IAttackCommand>;
        if (unitAttacker != null)
        {
            unitAttacker.ExecuteSpecificCommand(_context.Inject(new AttackCommand()));
            return;
        }

        var unitPatroller = commandExecutor as CommandExecutorBase<IPatrolCommand>;
        if (unitPatroller != null)
        {
            unitPatroller.ExecuteSpecificCommand(_context.Inject(new PatrolCommand()));
            return;
        }

        var unitMover = commandExecutor as CommandExecutorBase<IMoveCommand>;
        if (unitMover != null)
        {
            unitMover.ExecuteSpecificCommand(_context.Inject(new MoveCommand()));
            return;
        }

        var unitStoper = commandExecutor as CommandExecutorBase<IStopCommand>;
        if (unitStoper != null)
        {
            unitStoper.ExecuteSpecificCommand(_context.Inject(new StopCommand()));
            return;
        }

        throw new ApplicationException($"{nameof(CommandButtonsPresenter)}." +
            $"{nameof(onButtonClick)}:" +
            $"Unknown type of commands executor: { commandExecutor.GetType().FullName }!");
    }

}
