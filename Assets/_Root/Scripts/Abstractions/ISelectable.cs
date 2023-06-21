using UnityEngine;
<<<<<<< Updated upstream
public interface ISelectable
{
    float Health { get; }
    float MaxHealth { get; }
    Sprite Icon { get; }
=======
public interface ISelectable : IHealthHolder, IIconHolder
{
    Transform PivotPoint { get; }
>>>>>>> Stashed changes
}
