using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Counter : MonoBehaviour
{
    public int Value = 3, MinValue = 0;

    public float WaitTime = 1f;

    public UnityEvent OnCountEvent, OnEndEvent;

    public void StartCounter()
    {
        StartCoroutine(RunCounter());
    }
    // Start is called before the first frame update
    private IEnumerator RunCounter()
    {
        var waitObject = new WaitForSeconds(WaitTime);
        while (Value>MinValue)
        {
            yield return waitObject;
            print(Value);
            Value--;
        }

        yield return waitObject;
        OnEndEvent.Invoke();
    }
}
