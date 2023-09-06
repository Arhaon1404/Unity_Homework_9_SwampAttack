using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class DefenceState : State
{
    public float ElapsedTime { get; private set; }

    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
        ElapsedTime = 0;
    }

    private void OnEnable()
    {
        _animator.Play("Idle");
    }

    private void OnDisable()
    {
        _animator.StopPlayback();
    }

    private void Update()
    {
        ElapsedTime += Time.deltaTime;
    }

    public void DamageBlock()
    {
        _animator.Play("Defence");
        ElapsedTime = 0;
    }
}
