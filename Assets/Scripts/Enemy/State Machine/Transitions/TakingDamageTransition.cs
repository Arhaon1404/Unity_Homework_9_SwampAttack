using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakingDamageTransition : Transition
{
    private Enemy _enemy;
    private int _damageThreshold;

    public void Start()
    {
        _damageThreshold = 1;
    }

    public void Update()
    {
        if(_enemy.health == (_enemy.health - _damageThreshold))
        {
            NeedTransit = true;
        }
    }
}
