using Abstractions.Commands.CommandInterfaces;
using UnityEngine;
using Utils;

public class ProduceUnitCommand : IProduceCommand
{
    [InjectAsset("Chomper")] private GameObject _unitPrefab;
    public GameObject UnitPrefab => _unitPrefab;
}
