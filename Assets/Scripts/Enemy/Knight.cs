using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Knight : Enemy
{
    public bool IsDamaged { get; private set; }

    [SerializeField] private UnityEvent _onDamaged;
    [SerializeField] private UnityEvent _isBlocked;

    public void Start()
    {
        IsDamaged = false;
    }

    public override void TakeDamage(int damage)
    {
        if (IsDamaged == false)
        {
            base.TakeDamage(damage);
            IsDamaged = true;
            _onDamaged.Invoke();
        }
        else
        { 
            _isBlocked.Invoke();
        }
    }

    public void StateChange()
    {
        IsDamaged = false;
    }
}
