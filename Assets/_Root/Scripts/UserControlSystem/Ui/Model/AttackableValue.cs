using System;
using UnityEngine;

    [CreateAssetMenu(fileName = nameof(AttackableValue), menuName = "Strategy Game/"
    + nameof(AttackableValue), order = 0)]
    public class AttackableValue : ScriptableObject
    {
        public IGetDamage CurrentValue { get; private set; }
        public Action<IGetDamage> OnSelected;
        public Action<IGetDamage> OnNewValue;

        public void SetValue(IGetDamage value)
        {
            CurrentValue = value;
            OnSelected?.Invoke(value);
        }
    }
