using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Switches : MonoBehaviour
{
    public UnityEvent StartingEvent, PlayingEvent, EndingEvent, DyingEvent;
    public enum States
    {
        Starting,
        Playing,
        Ending,
        Dying
    }

    public States CurrentState;
    
    void Start()
    {
        
    }

    void Update()
    {
        switch (CurrentState)
        {
            case States.Starting:
                StartingEvent.Invoke();
                break;
            case States.Playing:
                PlayingEvent.Invoke();
                break;
            case States.Ending:
                EndingEvent.Invoke();
                break;
            case States.Dying:
                DyingEvent.Invoke();
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}
