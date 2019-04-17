using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;
using System.Xml;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class HealthPotion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
            Destroy(gameObject);
    }

}
