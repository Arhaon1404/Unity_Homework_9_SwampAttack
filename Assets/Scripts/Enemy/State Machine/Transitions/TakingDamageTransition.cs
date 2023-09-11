using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakingDamageTransition : Transition
{
    private int _enemyHealth;
    private int _damageThreshold;

    protected override void OnEnable()
    {
        base.OnEnable();
        _enemyHealth = GetComponent<Knight>().Health;
        _damageThreshold = _enemyHealth - 1;
    }

    public void Update()
    {
        if (_enemyHealth == _damageThreshold)
        {
            NeedTransit = true;
        }
    }

    public void HealthInfoUpdate()
    {
        _enemyHealth = GetComponent<Knight>().Health;
    }
}
