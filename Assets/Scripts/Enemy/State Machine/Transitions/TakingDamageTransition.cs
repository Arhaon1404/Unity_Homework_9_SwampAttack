using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakingDamageTransition : Transition
{
    private int _enemyHealth;
    private int _damageThreshold;

    public void Start()
    {
        _enemyHealth = GetComponent<Knight>().Health;
        _damageThreshold = _enemyHealth - 1;
    }

    public void Update()
    {
        _enemyHealth = GetComponent<Knight>().Health;

        if (_enemyHealth == _damageThreshold)
        {
            Debug.Log("OK");
            NeedTransit = true;
        }
    }
}
