<<<<<<< Updated upstream
using Abstractions.Commands.CommandInterfaces;
using UnityEngine;

public class MoveCommandExecutor : CommandExecutorBase<IMoveCommand>
{
    public override void ExecuteSpecificCommand(IMoveCommand command)
    {
        Debug.Log($"{name} patrols!");
=======
using System;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.AI;
using Task = System.Threading.Tasks.Task;

public class MoveCommandExecutor : CommandExecutorBase<IMoveCommand>
{
    [SerializeField] private UnitMovementStop _stop;
    [SerializeField] private Animator _animator;
    [SerializeField] private StopCommandExecutor _stopCommandExecutor;

    public override async Task ExecuteSpecificCommand(IMoveCommand command)
    {
        GetComponent<NavMeshAgent>().destination = command.Target;
        _animator.SetTrigger(Animator.StringToHash("Walk"));
        _stopCommandExecutor.CancellationTokenSource = new
        CancellationTokenSource();
        try
        {
            await _stop
            .WithCancellation
        (
        _stopCommandExecutor
        .CancellationTokenSource
        .Token
        );
        }
        catch
        {
            GetComponent<NavMeshAgent>().isStopped = true;
            GetComponent<NavMeshAgent>().ResetPath();
        }
        _stopCommandExecutor.CancellationTokenSource = null;
        _animator.SetTrigger(Animator.StringToHash("Idle"));
>>>>>>> Stashed changes
    }
}
