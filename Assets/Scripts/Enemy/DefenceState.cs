using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Animator))]
public class DefenceState : State
{
    private Animator _animator;

    private float _lastBlockTime;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        _animator.Play("Idle");
    }

    private void OnDisable()
    {
        _animator.Play("Run");
    }

    private void Update() 
    {
        if (_lastBlockTime <= 0)
        {
            _animator.Play("Idle");
        }

        _lastBlockTime -= Time.deltaTime;
    }

    public void DamageBlock()
    {
        _lastBlockTime = 0.20f;
        _animator.Play("Defence");
    }
}
