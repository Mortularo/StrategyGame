<<<<<<< Updated upstream
namespace Abstractions.Commands.CommandInterfaces
{
    public interface IPatrolCommand
    {
    }
=======
using UnityEngine;
public interface IPatrolCommand : ICommand
{
    public Vector3 From { get; }
    public Vector3 To { get; }
>>>>>>> Stashed changes
}