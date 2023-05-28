using UnityEngine;

namespace Abstractions.Commands.CommandInterfaces
{
    public interface IProduceCommand
    {
        GameObject UnitPrefab { get; }
    }
}