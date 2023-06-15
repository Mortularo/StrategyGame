using UnityEngine;
<<<<<<< Updated upstream

public class MainBuilding : MonoBehaviour, IUnitProducing, ISelectable
{
    [SerializeField] private GameObject _unitPrefab;
    [SerializeField] private Transform _unitsParent;

    [SerializeField] private float _maxHealth = 1000;
    [SerializeField] private Sprite _icon;

    private float _health = 1000;

=======
public class MainBuilding : CommandExecutorBase<IProduceUnitCommand>, ISelectable, IAttackable
{
>>>>>>> Stashed changes
    public float Health => _health;
    public float MaxHealth => _maxHealth;
    public Sprite Icon => _icon;
    public Transform PivotPoint => _pivotPoint;

<<<<<<< Updated upstream
    public void ProduceUnit()
    {
        Instantiate(_unitPrefab, new Vector3(Random.Range(-10, 10), 0, 
            Random.Range(-10, 10)), Quaternion.identity, _unitsParent);
=======
    [SerializeField] private Transform _unitsParent;
    [SerializeField] private float _maxHealth = 1000;
    [SerializeField] private Sprite _icon;
    [SerializeField] private Transform _pivotPoint;
    private float _health = 1000;

    public override void ExecuteSpecificCommand(IProduceUnitCommand command)
    {
        Instantiate(command.UnitPrefab, new Vector3(Random.Range(-10, 10), 0,
        Random.Range(-10, 10)), Quaternion.identity, _unitsParent);
>>>>>>> Stashed changes
    }
}

