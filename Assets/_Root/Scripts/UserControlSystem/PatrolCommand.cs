using Abstractions.Commands.CommandInterfaces;
using UnityEngine;

public class PatrolCommand : IPatrolCommand
{
    private Vector3 position;
    private Vector3 groundClick;

    public PatrolCommand(Vector3 position, Vector3 groundClick)
    {
        this.position = position;
        this.groundClick = groundClick;
    }

    public Vector3 From => position;
    public Vector3 To => groundClick;
}