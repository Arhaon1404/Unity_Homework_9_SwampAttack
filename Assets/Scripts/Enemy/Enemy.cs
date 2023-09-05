using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int _reward;
    [SerializeField] public int health { get; private set; }
    

    private Player _target;

    public int Reward => _reward;
    public Player Target => _target;

    public event UnityAction<Enemy> Dying;

    public void Init(Player target)
    {
        _target = target;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        if(health <= 0)
        {
            Dying?.Invoke(this);
            Destroy(gameObject);
        }
    }
}