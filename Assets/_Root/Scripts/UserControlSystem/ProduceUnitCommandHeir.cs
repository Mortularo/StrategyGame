using UnityEngine;

public class ProduceUnitCommandHeir : ProduceUnitCommand
{
    [InjectAsset("Chomper")] private GameObject _unitPrefab;
    public GameObject UnitHeirPrefab => _unitPrefab;
}
