using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WaitingTransition : Transition
{
    [SerializeField] private float _waitingTime;
    private float _elapsedTime;

    [SerializeField] private UnityEvent _timePassed;

    protected override void OnEnable()
    {
        base.OnEnable();
        _elapsedTime = 0;
    }

    private void Update()
    {
        if (_elapsedTime >= _waitingTime)
        {
            _timePassed.Invoke();
            NeedTransit = true;
        }

        _elapsedTime += Time.deltaTime;
    }

    public void ResetElapsedTime()
    {
        _elapsedTime = 0;
    }
}
