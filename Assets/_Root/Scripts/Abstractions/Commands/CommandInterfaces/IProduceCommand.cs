using UnityEngine;

namespace Abstractions.Commands.CommandInterfaces
{
    public interface IProduceCommand : ICommand
    {
        GameObject UnitPrefab { get; }
    }
}