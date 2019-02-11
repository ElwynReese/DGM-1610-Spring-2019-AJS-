using UnityEngine;
using UnityEngine.Events;

public class PCCEvent : MonoBehaviour
{
public UnityEvent Event;

private void OnCollisionEnter()
{
    Event.Invoke();
    Destroy(GameObject.FindWithTag("Player"));
}
}