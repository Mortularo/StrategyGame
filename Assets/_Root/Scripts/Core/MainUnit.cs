using System.Collections;
using System.Collections.Generic;
using Abstractions.Commands;
using UnityEngine;

public class MainUnit : MonoBehaviour, ISelectable, IGetDamage
{
    [SerializeField] private Transform _currentPosition;
    [SerializeField] private float _maxHealth = 100;
    [SerializeField] private Sprite _icon;

    private float _health = 100;
    public float Health => _health;
    public float MaxHealth => _maxHealth;
    public Sprite Icon => _icon;
    public Transform CurrentPosition => _currentPosition;
}
