<<<<<<< Updated upstream
namespace Abstractions.Commands.CommandInterfaces
{
    public interface IMoveCommand
    {
    }
=======
using UnityEngine;
public interface IMoveCommand : ICommand
{
    public Vector3 Target { get; }
>>>>>>> Stashed changes
}