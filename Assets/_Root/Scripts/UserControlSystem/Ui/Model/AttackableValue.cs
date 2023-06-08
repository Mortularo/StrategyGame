using System;
using System.Threading.Tasks;
using System.Threading;
using UnityEngine;

    [CreateAssetMenu(fileName = nameof(AttackableValue), menuName = "Strategy Game/"
    + nameof(AttackableValue), order = 0)]
    public class AttackableValue : ScriptableObjectValueBase<IGetDamage>
    {
    }
