using UnityEngine;
public interface ISelectable : IHealthUsing
{
    Sprite Icon { get; }
    Transform CurrentPosition { get; }
}
