using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MonoEventsTwo : MonoBehaviour
{
    public UnityEvent StartEvent, EnableEvent, MouseDownEvent, UpdateEvent;
    //You can also write these out individually.
    
    void Start()
    {
        StartEvent.Invoke();
    }

    private void OnEnable()
    {
        
    }

    private void OnMouseDown()
    {
       MouseDownEvent.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
