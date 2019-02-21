using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoEvents : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Start");
    }

    private void OnEnable()
    {
        print("Enabled");
    }

    private void OnMouseDown()
    {
        print("MouseDown");
    }

    
    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.W))
           {
           print("W key pressed");
           
           } 
    }
}
