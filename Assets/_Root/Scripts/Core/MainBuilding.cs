using Abstractions.Commands;
using Abstractions.Commands.CommandInterfaces;
using UnityEngine;

<<<<<<< Updated upstream
public class MainBuilding : MonoBehaviour, IUnitProducing, ISelectable
=======
public class MainBuilding : CommandExecutorBase<IProduceCommand>, ISelectable, IGetDamage
>>>>>>> Stashed changes
{
    [SerializeField] private Transform _unitsParent;

    [SerializeField] private float _maxHealth = 1000;
    [SerializeField] private Sprite _icon;

    private float _health = 1000;

    public float Health => _health;
    public float MaxHealth => _maxHealth;
    public Sprite Icon => _icon;

<<<<<<< Updated upstream
    public void ProduceUnit()
    {
        Instantiate(_unitPrefab, new Vector3(Random.Range(-10, 10), 0, 
            Random.Range(-10, 10)), Quaternion.identity, _unitsParent);
    }
=======
    public Transform CurrentPosition => _currentPositiion;

    public override void ExecuteSpecificCommand(IProduceCommand command) =>
        Instantiate(command.UnitPrefab, new Vector3(Random.Range(-10, 10), 0,
        Random.Range(-10, 10)), Quaternion.identity, _unitsParent);

>>>>>>> Stashed changes
}
