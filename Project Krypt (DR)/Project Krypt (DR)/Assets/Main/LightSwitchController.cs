using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using UnityEngine.Events;


public class LightSwitchController : MonoBehaviour
{
    public UnityEvent Event;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnMouseDown()
    {
        Event.Invoke();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
