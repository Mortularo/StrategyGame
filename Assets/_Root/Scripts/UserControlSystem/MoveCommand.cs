using UnityEngine;
using Abstractions.Commands.CommandInterfaces;

public class MoveCommand : IMoveCommand
{
    public Vector3 Target { get; }
    public MoveCommand(Vector3 target)
    {
        Target = target;
    }
}