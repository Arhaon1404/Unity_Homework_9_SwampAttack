using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitingTransition : Transition
{
    [SerializeField] private int _waitingTime;

    private DefenceState _defenceState;

    private void Update()
    {
        if (_defenceState.ElapsedTime <= _waitingTime)
        { 
            NeedTransit = true;
        }
    }
}
