using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : Enemy
{
    private DefenceState _defenceState;
    public bool IsDamaged { get; private set; }

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
        }
        else 
        {
            
        }
    }
}
