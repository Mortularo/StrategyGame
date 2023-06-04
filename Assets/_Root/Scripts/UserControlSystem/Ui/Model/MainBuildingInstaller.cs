using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class MainBuildingInstaller : MonoInstaller
{
    [SerializeField] private AttackableValue _value;

    public override void InstallBindings()
    {
        base.InstallBindings();

        Container.Bind<AttackableValue>().FromInstance(_value);
    }
}
